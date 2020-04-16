using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sppr
{
    class Strongin : Method
    {
        protected double _e { get; set; } // allowable error
        protected double _r { get; set; } // method parameter

        protected SortedDictionary<double, double> _R = null;

        public Strongin(Func<double, double> curFunction, double xBegin, double xEnd, int maxSteps, double e, double r) : base(curFunction, xBegin, xEnd, maxSteps)
        {
            _e = e;
            _r = r;
            _R = new SortedDictionary<double, double>();
        }

        protected override bool step(int stepId)
        {
            return processingNewPoint();
        }

        protected double calculateM()
        {
            double M = 0.0;
            var e = _points.GetEnumerator();
            e.MoveNext();
            var prevPoint = e.Current;
            for (; e.MoveNext();)
            {
                var curPoint = e.Current;
                double curM = Math.Abs((curPoint.Value - prevPoint.Value) / (curPoint.Key - prevPoint.Key));
                if (M - curM < accurancy) M = curM;
                prevPoint = curPoint;
            }

            return M > accurancy ? _r * M : 1.0;
        }

        protected double calculateR(KeyValuePair<double, double> left, KeyValuePair<double, double> right, double m)
        {
            return m * (right.Key - left.Key)
                + ((right.Value - left.Value) * (right.Value - left.Value)) / (m * (right.Key - left.Key))
                - 2 * (right.Value + left.Value);
        }

        protected double calculateNextX(KeyValuePair<double, double> left, KeyValuePair<double, double> right, double m)
        {
            return (right.Key + left.Key) / 2 - (right.Value - left.Value) / (2 * m);
        }

        protected bool processingNewPoint()
        {
            var m = calculateM();

            double lX;

            if (_R.Count != 0)
            {
                var eR = _R.GetEnumerator();
                eR.MoveNext();

                lX = eR.Current.Value; // left x

                _R.Remove(eR.Current.Key);
            }
            else
            {
                lX = _xId[1]; // left x
            }

            var eP = _points.GetEnumerator();
            do
            {
                eP.MoveNext();
            }
            while (eP.Current.Key != lX);
            var left = eP.Current;

            eP.MoveNext();
            var right = eP.Current;

            var newX = calculateNextX(left, right, m);
            addPoint(newX);

            var newPoint = new KeyValuePair<double, double>(newX, _points[newX]);

            var curR = calculateR(left, newPoint, m);
            while (_R.ContainsKey(curR)) curR += curR * 1e-10;
            _R.Add(-curR, left.Key);
            curR = calculateR(newPoint, right, m);
            while (_R.ContainsKey(curR)) curR += curR + 1e-10;
            _R.Add(-curR, newPoint.Key);

            if (Math.Abs(left.Key - newPoint.Key) < _e || Math.Abs(right.Key - newPoint.Key) < _e) return false;

            return true;
        }

    }
}
