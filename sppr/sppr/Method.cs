using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using ZedGraph;

namespace sppr
{
    abstract class Method
    {
        /// <summary>
        /// input data
        /// </summary>
        /// 
        protected int _maxSteps { get; set; }

        protected Func<float, float> _function = null;

        /// <summary>
        /// output data
        /// </summary>
        protected SortedList<float, float> _points = null; // (x,y) sorted by x for convenience
        protected SortedList<int, float> _xId = null; // (id,x)

        protected List<int> _curMinId = null;
        int _steps;
        protected Method (Func<float, float> curFunction, float xBegin, float xEnd, int maxSteps)
        {
            _function = curFunction;
            _maxSteps = maxSteps;
            _steps = 1;
            _points = new SortedList<float, float>();
            _xId = new SortedList<int, float>();
            _curMinId = new List<int>();
            addPoint(xBegin);
            addPoint(xEnd);
        }

        protected void addPoint(float x)
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
            if (Math.Abs(_points[x] - _points[_xId[_curMinId[0]]]) < 1e-5)
            {
                _curMinId.Add(_xId.Count);
            }
            else if (_points[_xId[_curMinId[0]]] < _points[x])
            {
                _curMinId.Clear();
                _curMinId.Add(_xId.Count);
            }

        }

        public void solve(BackgroundWorker worker)
        {
            for (; _steps < _maxSteps; _steps++)
            {
                worker.ReportProgress((int)((float)_steps / _maxSteps * 100));
                step(_steps);
            }
        }

        protected abstract void step(int stepId);
    }
}
