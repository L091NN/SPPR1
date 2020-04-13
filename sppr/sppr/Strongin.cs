using System;
using System.Collections.Generic;
using System.Text;

namespace sppr
{
    class Strongin : Method
    {
        protected float _e { get; set; } // allowable error
        protected float _r { get; set; } // method parameter

        public Strongin(Func<float, float> curFunction, float xBegin, float xEnd, int maxSteps, float e, float r) : base(curFunction, xBegin, xEnd, maxSteps)
        {
            _e = e;
            _r = r;
        }

        protected override void step(int stepId)
        {
        }


    }
}
