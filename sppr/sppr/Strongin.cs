using System;
using System.Collections.Generic;
using System.Linq;

namespace sppr
{
    class Strongin : Method
    {
        protected double _r { get; set; }

        public Strongin(Func<double, double> curFunction, double xBegin, double xEnd, int maxSteps, double e, double r) : base(curFunction, xBegin, xEnd, maxSteps, e)
        {
            _r = r;
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

            return M > accurancy ? (_r * M) : 1.0;
        }

        protected double calculateR(KeyValuePair<double, double> left, KeyValuePair<double, double> right, double m)
        {
            var p1 = m * (right.Key - left.Key);
            var p2 = ((right.Value - left.Value) * (right.Value - left.Value)) / (m * (right.Key - left.Key));
            var p3 = 2 * (right.Value + left.Value);
            return p1 + p2 - p3;
        }

        protected double calculateNextX(KeyValuePair<double, double> left, KeyValuePair<double, double> right, double m)
        {
            return (right.Key + left.Key) / 2 - (right.Value - left.Value) / (2 * m);
        }

        protected override bool step(int stepId)
        {
            var m = calculateM();

            List<double> R = new List<double>(_points.Count);
            var e = _points.GetEnumerator();

            e.MoveNext();

            var prevPoint = e.Current;
            var left = e.Current;
            var right = e.Current;
            for (; e.MoveNext();)
            {
                var curPoint = e.Current;
                var curR = calculateR(prevPoint, curPoint, m);
                R.Add(curR);
                if (curR == R.Max())
                {
                    left = prevPoint;
                    right = curPoint;
                }
                prevPoint = curPoint;
            }
            var newX = calculateNextX(left, right, m);
            addPoint(newX);
            if (Math.Abs(left.Key - right.Key) < _e) return false;
            return true;
        }
    }
}
