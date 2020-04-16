using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sppr
{
    class Brute : Method
    {
        public Brute(Func<double, double> curFunction, double xBegin, double xEnd, int maxSteps) : base(curFunction, xBegin, xEnd, maxSteps)
        {
        }
        protected override bool step(int stepId)
        {
            return true;
        }
    }
}
