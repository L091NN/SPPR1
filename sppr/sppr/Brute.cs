using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sppr
{
    class Brute : Method
    {
        protected List<KeyValuePair<double, double>> _R = null;

        public Brute(Func<double, double> curFunction, double xBegin, double xEnd, int maxSteps, double e) : base(curFunction, xBegin, xEnd, maxSteps, e)
        {
            _R = new List<KeyValuePair<double, double>>();
        }

        protected double calculateR(KeyValuePair<double, double> left, KeyValuePair<double, double> right)
        {
            return right.Key - left.Key;
        }

        protected double calculateNextX(KeyValuePair<double, double> left, KeyValuePair<double, double> right)
        {
            return (right.Key + left.Key) / 2;
        }

        protected override bool step(int stepId)
        {
            double lX;

            if (_R.Count != 0)
            {
                var eR = _R.GetEnumerator();
                eR.MoveNext();

                lX = eR.Current.Value;

                _R.Remove(eR.Current);
            }
            else
            {
                lX = _xId[1];
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

            var newX = calculateNextX(left, right);
            addPoint(newX);

            var newPoint = new KeyValuePair<double, double>(newX, _points[newX]);

            var curR = calculateR(left, newPoint);
            _R.Add(new KeyValuePair<double, double>(curR, left.Key));
            curR = calculateR(newPoint, right);
            _R.Add(new KeyValuePair<double, double>(curR, newPoint.Key));
            _R = _R.OrderByDescending(R => R.Key).ThenBy(x => x.Value).ToList();

            if (Math.Abs(left.Key - right.Key) < _e) return false;

            return true;
        }
    }
}
