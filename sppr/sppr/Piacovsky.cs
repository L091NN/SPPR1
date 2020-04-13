using System;
using System.Collections.Generic;
using System.Text;

namespace sppr
{
    class Piacovsky : Method
    {
        public Piacovsky(Func<float, float> curFunction, float xBegin, float xEnd, int maxSteps) : base(curFunction, xBegin, xEnd, maxSteps)
        {
        }
        protected override void step(int stepId)
        {
        }
    }
}
