using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using ZedGraph;
using System.ComponentModel;

namespace sppr
{
    public struct FElem
    {
        public Func<double, double> function;
        public double xLeft;
        public double xRight;
        public double xMin;
        public double yMin;
        public double xMax;
        public double yMax;
    }
    class GraphProcessing
    {
        
        public void drawFunction(ZedGraphControl zgControl,ref FElem elem, Color lineColor, BackgroundWorker worker)
        {
            var pane = zgControl.GraphPane;
            var w = zgControl.Width;
            var h = zgControl.Height;
            PointPairList ppList = new PointPairList();

            var step = (elem.xRight - elem.xLeft) / w;

            var yLeft = elem.function(elem.xLeft);
            var yRight = elem.function(elem.xRight);

            elem.yMin = yLeft > yRight ? yRight : yLeft;
            elem.yMax = yLeft > yRight ? yLeft : yRight;

            for (double i = elem.xLeft; i < elem.xRight; i+= step)
            {
                var progress = (int)((i - elem.xLeft) / (elem.xRight - elem.xLeft) * 100);
                worker.ReportProgress(progress);
                if (worker.CancellationPending) return;
                var curY = elem.function(i);
                if (curY < elem.yMin) elem.yMin = curY;
                if (curY > elem.yMax) elem.yMax = curY;
                ppList.Add(new PointPair(i, curY));
            }

            var curve = pane.AddCurve("", ppList, lineColor, ZedGraph.SymbolType.None);

            curve.Line.Width = 4.0f;

            var rX = elem.xRight - elem.xLeft;
            var rY = elem.yMax - elem.yMin;
            elem.xMin = elem.xLeft;
            elem.xMax = elem.xRight;

            pane.XAxis.Min = elem.xMin - rX * 0.1;
            pane.XAxis.Max = elem.xMax + rX * 0.1;
            pane.YAxis.Min = elem.yMin - rY * 0.1;
            pane.YAxis.Max = elem.yMax + rY * 0.1;

            //var line = new PointPairList();
            //line.Add(new PointPair(elem.xMin, 2 * elem.yMin - elem.yMax));
            //line.Add(new PointPair(elem.xMin, 2 * elem.yMax - elem.yMin));
            //curve = pane.AddCurve("", line, Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(239)))), ((int)(((byte)(249))))), ZedGraph.SymbolType.None);
            //curve.Line.Style = System.Drawing.Drawing2D.DashStyle.Dash;
            //curve.Line.Width = 0.01f;
            //
            //line.Clear();
            //line.Add(new PointPair(elem.xMax, 2 * elem.yMin - elem.yMax));
            //line.Add(new PointPair(elem.xMax, 2 * elem.yMax - elem.yMin));
            //curve = pane.AddCurve("", line, Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(239)))), ((int)(((byte)(249))))), ZedGraph.SymbolType.None);
            //curve.Line.Style = System.Drawing.Drawing2D.DashStyle.Dash;
            //curve.Line.Width = 0.01f;

            zgControl.AxisChange();
            zgControl.Invalidate();
        }

        public void refreshGraph(PerspectiveInfo perspective)
        {
            var pane = perspective.methodInfo.graphControl.GraphPane;
            pane.CurveList.Clear();
            var w = perspective.methodInfo.graphControl.Width;
            var h = perspective.methodInfo.graphControl.Height;
            var elem = perspective.funcInfo;
            PointPairList ppList = new PointPairList();

            var step = (elem.xMax - elem.xMin) / w;

            for (double i = elem.xMin; i <= elem.xMax; i += step)
            {
                var curY = perspective.funcInfo.function(i);
                if (curY < elem.yMin) elem.yMin = curY;
                if (curY > elem.yMax) elem.yMax = curY;
                ppList.Add(new PointPair(i, curY));
            }

            var curve = pane.AddCurve("", ppList, perspective.colorLine, ZedGraph.SymbolType.None);
            curve.Line.Width = 4.0f;

            if (perspective.withPoint)
            {
                foreach (var point in perspective.methodInfo.report.iterations)
                {
                    if (point.x >= elem.xMin && point.x <= elem.xMax)
                    {
                        var line = new PointPairList();
                        line.Add(new PointPair(point.x, 0));
                        line.Add(new PointPair(point.x, perspective.funcInfo.function(point.x)));
                        curve = pane.AddCurve("", line, perspective.colorPoint, ZedGraph.SymbolType.None);
                        curve.Line.Width = 0.5f;
                    }
                }
            }

            if (perspective.withLine && perspective.withMainLine)
            {
                drawVerticalLine(perspective, true);
            }

            perspective.methodInfo.graphControl.AxisChange();
            perspective.methodInfo.graphControl.Invalidate();
        }

        //public void drawVerticalLine(ZedGraphControl zgControl, SortedList<int, double> x, FElem elem)
        public void drawVerticalLine(PerspectiveInfo perspective, bool isMainLine)
        {
            var pane = perspective.methodInfo.graphControl.GraphPane;

            var line = new PointPairList();
            if (isMainLine)
            {
                line.Add(new PointPair(perspective.mainLineX, 2 * perspective.funcInfo.yMin - perspective.funcInfo.yMax));
                line.Add(new PointPair(perspective.mainLineX, 2 * perspective.funcInfo.yMax - perspective.funcInfo.yMin));
                var curve = pane.AddCurve("", line, perspective.colorMainLine, ZedGraph.SymbolType.None);
                curve.Line.Width = 2f;
            }
            else
            {
                line.Add(new PointPair(perspective.curLineX, 2 * perspective.funcInfo.yMin - perspective.funcInfo.yMax));
                line.Add(new PointPair(perspective.curLineX, 2 * perspective.funcInfo.yMax - perspective.funcInfo.yMin));
                var curve = pane.AddCurve("", line, perspective.colorMainLine, ZedGraph.SymbolType.None);
                curve.Line.Width = 0.5f;
            }
        }
    }
}
