using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace sppr
{
    abstract class Method
    {
        public class Report
        {
            public SortedList<double, double> minimum;
            public SortedList<int, double> iterations;
            public int onStep;
            public int ofStep;

            public Report() { }
            public Report(SortedList<double, double> _minimum, SortedList<int, double> _iterations, int _onStep, int _ofStep)
            {
                minimum = _minimum;
                iterations = _iterations;
                onStep = _onStep;
                ofStep = _ofStep;
            }
        }
        protected double accurancy = 1e-5;
        /// <summary>
        /// input data
        /// </summary>
        protected int _maxSteps { get; set; }
        protected double _e { get; set; }
        protected Func<double, double> _function = null;

        /// <summary>
        /// output data
        /// </summary>
        protected SortedList<double, double> _points = null; // (x,y) sorted by x for convenience
        protected SortedList<int, double> _xId = null; // (id,x)

        protected List<int> _curMinId = null;
        int _steps;

        protected Method(Func<double, double> curFunction, double xBegin, double xEnd, int maxSteps, double e)
        {
            _function = curFunction;
            _maxSteps = maxSteps;
            _e = e;
            _steps = 1;
            _points = new SortedList<double, double>();
            _xId = new SortedList<int, double>();
            _curMinId = new List<int>();
            addPoint(xBegin);
            addPoint(xEnd);
        }

        protected void addPoint(double x)
        {
            if (_points.Count == 0)
            {
                _points.Add(x, _function(x));
                _xId.Add(_xId.Count + 1, x);
                _curMinId.Add(1);
                return;
            }

            _points.Add(x, _function(x));
            _xId.Add(_xId.Count + 1, x);
            if (_points[_xId[_curMinId[0]]] > _points[x])
            {
                _curMinId.Clear();
                _curMinId.Add(_xId.Count);
            }

        }
        private Report getReport()
        {
            var minimum = new SortedList<double, double>();
            for (var it = _curMinId.GetEnumerator(); ;)
            {
                if (!it.MoveNext()) break;
                minimum.Add(_xId[it.Current], _points[_xId[it.Current]]);
            }

            return new Report(minimum, _xId, _steps, _maxSteps);
        }
        public Report solve(BackgroundWorker worker)
        {
            for (; _steps < _maxSteps; _steps++)
            {
                worker.ReportProgress((int)((double)_steps / _maxSteps * 100));
                if (worker.CancellationPending) return null;
                if (!step(_steps)) break;
            }

            return getReport();
        }

        protected abstract bool step(int stepId);
    }
}
