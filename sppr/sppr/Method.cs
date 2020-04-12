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
        protected float _xBegin { get; set; }
        protected float _xEnd { get; set; }
        protected int _maxSteps { get; set; }

        protected Func<float, float> _function = null;

        /// <summary>
        /// output data
        /// </summary>
        SortedList<double, double> _points = null; // (x,y) sorted by x for convenience
        float _curMin { get; set; }
        int _steps;
        protected Method (Func<float, float> curFunction, float xBegin, float xEnd, int maxSteps)
        {
            _function = curFunction;
            _xBegin = xBegin;
            _xEnd = xEnd;
            _maxSteps = maxSteps;
            _steps = 0;
        }

        void solve(BackgroundWorker worker)
        {
            for (; _steps < _maxSteps; _steps++)
            {
                worker.ReportProgress((int)((float)_steps / _maxSteps * 100));
                step();
            }
        }

        protected abstract void step();
    }
}
