using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sppr
{
    public partial class MainForm
    {
        SortedSet<string> errors;
        bool pressed;
        protected string tryFillParam()
        {
            double test1;
            double test2;
            int iTest;
            bool eXLeft = true, eXRight = true, eStep = true, eError = true, eR = true; // exist
            string result = "";
            if (!Double.TryParse(textBoxA.Text, out test1)) result += "Invalid 1st function coefficient,";

            if (!Double.TryParse(textBoxB.Text, out test1)) result += "Invalid 2nd function coefficient,";

            if (!Double.TryParse(textBoxC.Text, out test1)) result += "Invalid 3rd function coefficient,";

            if (!Double.TryParse(textBoxD.Text, out test1)) result += "Invalid 4th function coefficient,";

            if (!Double.TryParse(textBoxXBegin.Text, out test1))
            {
                result += "Invalid left border x function,";
                eXLeft = false;
            }

            if (!Double.TryParse(textBoxXEnd.Text, out test2))
            {
                result += "Invalid right border x function,";
                eXRight = false;
            }

            if (eXLeft && eXRight && test1 > test2) result += "Right border x < left border x,";

            if (!int.TryParse(textBoxMaxStepCount.Text, out iTest))
            {
                result += "Invalid max step count,";
                eStep = false;
            }

            if (eStep && iTest < 1) result += "Max step count must be greater than zero,";

            if (!Double.TryParse(textBoxE.Text, out test1))
            {
                result += "Invalid error of method,";
                eError = false;
            }

            if (eError && test1 <= 0.0) result += "Error of method must be greater than zero,";

            if (perspective.name != "Bruteforce")
            {
                if (!Double.TryParse(textBoxR.Text, out test1))
                {
                    result += "Invalid parameter r,";
                    eR = false;
                }

                if (eR && test1 < 1.0) result += "Error of method must be greater than one,";
            }



            return result;
        }

        protected string tryZoom()
        {
            double test1, test2;
            bool eXLeft = true, eXRight = true, eYLeft = true, eYRight = true; // exist
            string result = "";
            if (!Double.TryParse(textBoxZoomXBegin.Text, out test1))
            {
                result += "Invalid left x zoom border,";
            }

            if (!Double.TryParse(textBoxZoomXEnd.Text, out test2))
            {
                result += "Invalid right x zoom border,";
            }

            if (eXLeft && eXRight && test1 > test2) result += "left x zoom border > right x zoom border,";

            if (!Double.TryParse(textBoxZoomYBegin.Text, out test1))
            {
                result += "Invalid left y zoom border,";
            }

            if (!Double.TryParse(textBoxZoomYEnd.Text, out test2))
            {
                result += "Invalid right y zoom border,";
            }

            if (eYLeft && eYRight && test1 > test2) result += "bottom y zoom border > top y zoom border,";

            return result;
        }

        protected int widthOfFunc()
        {
            return panelFuncBegin.Width + labelFunc.Width + textBoxA.Width + labelCosBegin.Width
                + textBoxB.Width + labelCosEnd.Width + textBoxC.Width + labelSinBegin.Width
                + textBoxD.Width + labelSinEnd.Width;
        }

        protected int heightOfParam()
        {
            var res = labelNameMethod.Height + panelActionButtomParamFunc.Height + panelActionButtomRegion.Height;
            if (perspective.name != "Bruteforce") res += labelR.Height + labelE.Height;
            return (int)(panelAction.Height * 0.2) > res ? (int)(panelAction.Height * 0.2) : res;
        }

        protected int widthOfResult()
        {
            var wZoomX = labelZoomXBegin.Width + textBoxZoomXBegin.Width + labelZoomXMid.Width + textBoxZoomXEnd.Width + labelZoomXEnd.Width;
            var wZoomY = labelZoomYBegin.Width + textBoxZoomYBegin.Width + labelZoomYMid.Width + textBoxZoomYEnd.Width + labelZoomYEnd.Width;
            var wSteps = labelStepCount.Width + labelOfStep.Width + labelMaxStepCountResult.Width;
            var wMin = labelMinBegin.Width + textBoxXMin.Width + labelMinMid.Width + textBoxYMin.Width + labelMinEnd.Width;
            int [] ar = { 200, wZoomX, wZoomY, wSteps, wMin };

            return ar.Max<int>();

        }
    }
}
