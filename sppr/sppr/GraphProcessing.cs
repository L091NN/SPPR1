using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using ZedGraph;

namespace sppr
{
    public struct FElem
    {
        public Func<double, double> function;
        public double xLeft;
        public double xRight;
    }
    class GraphProcessing
    {
        public void drawFunction(ZedGraphControl zgControl, FElem elem)
        {
            var pane = zgControl.GraphPane;
            var w = zgControl.Width * 100;
            var h = zgControl.Height;
            PointPairList ppList = new PointPairList();

            var step = (elem.xRight - elem.xLeft) / w;

            for (double i = elem.xLeft; i < elem.xRight; i+= step)
            {
                ppList.Add(new PointPair(i, elem.function(i)));
            }

            pane.AddCurve("", ppList, Color.FromArgb(129, 57, 206), ZedGraph.SymbolType.None);
            zgControl.AxisChange();
            zgControl.Invalidate();
        }

        public void drawVerticalLine(ZedGraphControl zgControl, SortedList<int, double> x)
        {
            var pane = zgControl.GraphPane;
            foreach (var it in x)
            {
                PointPairList ppList = new PointPairList();
                ppList.Add(new PointPair(it.Value, 1));
                ppList.Add(new PointPair(it.Value, -3));
                pane.AddCurve("", ppList, Color.FromArgb(0, 0, 0), ZedGraph.SymbolType.None);
                zgControl.AxisChange();
                zgControl.Invalidate();

            }
        }

    }
}
