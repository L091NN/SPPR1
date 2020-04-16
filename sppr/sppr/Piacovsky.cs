using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sppr
{
    class Piacovsky : Method
    {
        public Piacovsky(Func<double, double> curFunction, double xBegin, double xEnd, int maxSteps) : base(curFunction, xBegin, xEnd, maxSteps)
        {
        }
        protected override bool step(int stepId)
        {
            return true;
        }
    }
}
