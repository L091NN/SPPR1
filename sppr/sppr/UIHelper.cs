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
            double test;
            int iTest;
            if (!Double.TryParse(textBoxA.Text, out test)) return false;
            if (!Double.TryParse(textBoxB.Text, out test)) return false;
            if (!Double.TryParse(textBoxC.Text, out test)) return false;
            if (!Double.TryParse(textBoxD.Text, out test)) return false;
            if (!Double.TryParse(textBoxXBegin.Text, out test)) return false;
            if (!Double.TryParse(textBoxXEnd.Text, out test)) return false;
            if (!int.TryParse(textBoxMaxStepCount.Text, out iTest)) return false;
            if (!Double.TryParse(textBoxE.Text, out test)) return false;
            if (perspective.name != "Bruteforce")
            {
                if (!Double.TryParse(textBoxR.Text, out test)) return false;
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
