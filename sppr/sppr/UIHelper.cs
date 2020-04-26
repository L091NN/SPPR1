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
        protected bool tryFillParam()
        {
            if (!Double.TryParse(textBoxA.Text, out perspective.a)) return false;
            if (!Double.TryParse(textBoxB.Text, out perspective.b)) return false;
            if (!Double.TryParse(textBoxC.Text, out perspective.c)) return false;
            if (!Double.TryParse(textBoxD.Text, out perspective.d)) return false;
            if (!Double.TryParse(textBoxXBegin.Text, out perspective.xLeft)) return false;
            if (!Double.TryParse(textBoxXEnd.Text, out perspective.xRight)) return false;
            if (!int.TryParse(textBoxMaxStepCount.Text, out perspective.maxStepCount)) return false;
            if (perspective.name != "Bruteforce")
            {
                if (!Double.TryParse(textBoxA.Text, out perspective.a)) return false;
                if (!Double.TryParse(textBoxA.Text, out perspective.a)) return false;
            }

            return true;
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

    }
}
