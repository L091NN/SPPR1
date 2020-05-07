using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sppr
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            style = new Style();
            labelGuidanceR.Visible = false;
            labelGuidanceE.Visible = false;
            tableLayoutPanel.Visible = false;
            initPerspectives();
            refreshActionPanel();
            //panelBottom.BackColor = style.colors["red.king yna"];
            //panelBottomAnimation.RunWorkerAsync(new List<Color> { style.colors["red.king yna"], style.colors["yellow.king yna"], 
                //style.colors["green.vs"], style.colors["blue.king yna"], style.colors["red.king yna"] });
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            labelNoData.Font = new System.Drawing.Font("Yu Gothic UI Semibold", (float)(Math.Sqrt(panelAction.Height * panelAction.Height + panelAction.Width * panelAction.Width) / 10), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            labelRecomendation.Font = new System.Drawing.Font("Yu Gothic UI Semibold", (float)(Math.Sqrt(panelAction.Height * panelAction.Height + panelAction.Width * panelAction.Width) / 20), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));

            this.panelActionBottom.Size = new System.Drawing.Size(panelAction.Width, widthOfFunc());
        }

        private void buttonActionBottom_Click(object sender, EventArgs e)
        {
            showHideActionBottomPanel();
        }

        private void panelActionBottomR_MouseMove(object sender, MouseEventArgs e)
        {
            labelGuidanceR.Visible = true;
        }

        private void panelActionBottomR_MouseLeave(object sender, EventArgs e)
        {
            labelGuidanceR.Visible = false;
        }

        private void panelActionBottomE_MouseMove(object sender, MouseEventArgs e)
        {
            labelGuidanceE.Visible = true;
        }

        private void panelActionBottomE_MouseLeave(object sender, EventArgs e)
        {
            labelGuidanceE.Visible = false;
        }

        private void buttonRun_Click(object sender, EventArgs e)
        {
            if (buttonRun.Text == "RUN")
            {
                var errorString = tryFillParam();
                if (errorString == "")
                {
                    labelErrorList.Visible = false;
                    runCurMethod(); //label1.Text = "ERROR: Incorrect input";
                }
                else
                {
                    var errors = errorString.Split(',');
                    labelErrorList.Text = "";
                    foreach (var error in errors)
                    {
                        labelErrorList.Text += error + '\n';
                    }
                    hideNoData();
                    labelErrorList.Visible = true;
                }
            }
            else if (buttonRun.Text == "CANCEL")
            {
                cancelCurMethod();
            }
            else if (buttonRun.Text == "CLEAR")
            {
                clearCurMethod();
            }
        }

        private void buttonChangePerspectiveLeft_Click(object sender, EventArgs e)
        {
            if (!panelRightAnimation.IsBusy && !panelActionBottomAnimation.IsBusy && !panelLeftAnimation.IsBusy && !panelHeaderAnimation.IsBusy && !runMethod.IsBusy)
            {
                perspective = perspective == bruteForce ? strongin : perspective == piacovsky ? bruteForce : piacovsky;
                panelRightAnimation.RunWorkerAsync(new List<Color> { panelRight.BackColor, panelActionBottom.BackColor });
                panelActionBottomAnimation.RunWorkerAsync(new List<Color> { panelActionBottom.BackColor, panelLeft.BackColor });
                panelLeftAnimation.RunWorkerAsync(new List<Color> { panelLeft.BackColor, panelRight.BackColor });
                //panelHeaderAnimation.RunWorkerAsync(new List<Color> { panelHeader.BackColor, panelRight.BackColor });
                refreshActionPanel();
                zedGraphControlMain.Refresh();
            }
        }

        private void buttonChangePerspectiveRight_Click(object sender, EventArgs e)
        {
            if (!panelRightAnimation.IsBusy && !panelActionBottomAnimation.IsBusy && !panelLeftAnimation.IsBusy && !panelHeaderAnimation.IsBusy && !runMethod.IsBusy)
            {
                perspective = perspective == bruteForce ? piacovsky : perspective == piacovsky ? strongin : bruteForce;
                panelRightAnimation.RunWorkerAsync(new List<Color> { panelRight.BackColor, panelLeft.BackColor });
                panelActionBottomAnimation.RunWorkerAsync(new List<Color> { panelActionBottom.BackColor, panelRight.BackColor });
                panelLeftAnimation.RunWorkerAsync(new List<Color> { panelLeft.BackColor, panelActionBottom.BackColor });
                //panelHeaderAnimation.RunWorkerAsync(new List<Color> { panelHeader.BackColor, panelLeft.BackColor });
                refreshActionPanel();
                zedGraphControlMain.Refresh();
            }
        }

        private void textBoxA_TextChanged(object sender, EventArgs e)
        {
            if (((TextBox)sender).Text.Length > 5)
                ((TextBox)sender).Text = ((TextBox)sender).Text.Substring(0, 6);
            ((TextBox)sender).Width = ((TextBox)sender).Text.Length * 8 + 10;
            var widthOfCurFunc = widthOfFunc();
            if (widthOfCurFunc > panelActionBottomParam.Width)
                panelActionBottomParam.Width = widthOfCurFunc;
            panelPostProcessing.Width = widthOfResult();
        }

        private void buttonChangePerspectiveRight_MouseMove(object sender, MouseEventArgs e)
        {
            if (perspective.name == "Bruteforce")
            {
                buttonChangePerspectiveRight.Text = "P\ni\ny\na\n▶\ns\nk\ny";
            }
            if (perspective.name == "Piyavsky method")
            {
                buttonChangePerspectiveRight.Text = "S\nt\nr\no\n▶\ng\ni\nn";
            }
            if (perspective.name == "Strongin method")
            {
                buttonChangePerspectiveRight.Text = "B\nr\nu\nt\ne\n▶\nf\no\nr\nc\ne\n";
            }
        }

        private void buttonChangePerspectiveRight_MouseLeave(object sender, EventArgs e)
        {
            buttonChangePerspectiveRight.Text = "▶";
        }

        private void buttonChangePerspectiveLeft_MouseMove(object sender, MouseEventArgs e)
        {
            if (perspective.name == "Bruteforce")
            {
                buttonChangePerspectiveLeft.Text = "S\nt\nr\no\n◀\ng\ni\nn\n";
            }
            if (perspective.name == "Piyavsky method")
            {
                buttonChangePerspectiveLeft.Text = "B\nr\nu\nt\ne\n◀\nf\no\nr\nc\ne\n";
            }
            if (perspective.name == "Strongin method")
            {
                buttonChangePerspectiveLeft.Text = "P\ni\ny\na\n◀\ns\nk\ny";
            }
        }

        private void buttonChangePerspectiveLeft_MouseLeave(object sender, EventArgs e)
        {
            buttonChangePerspectiveLeft.Text = "◀";
        }

        private void zedGraphControlMain_MouseWheel(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            double graphX, graphY, Y;
            zedGraphControlMain.GraphPane.ReverseTransform(new PointF(e.X, e.Y), out graphX, out graphY, out Y);
            zoomScales(e.Delta, new PointF((float)graphX, (float)graphY));
            zedGraphControlMain.Refresh();
        }

        private void zedGraphControlMain_MouseDown(object sender, MouseEventArgs e)
        {

            var pane = zedGraphControlMain.GraphPane;

            Point eventPoint = new Point(e.X, e.Y);

            labelMousePosition.Text = string.Format("({0}; {1})", eventPoint.X, eventPoint.Y);

            double graphX, graphY, Y;
            pane.ReverseTransform(new PointF(e.X, e.Y), out graphX, out graphY, out Y);
            labelMousePosition.Text += string.Format("({0:F3}; {1:F3})", graphX, graphY);

            PointF controlPoint = pane.GeneralTransform(new PointF((float)graphX,
            (float)graphY),
            ZedGraph.CoordType.AxisXYScale);

            labelMousePosition.Text += string.Format("({0}; {1})", controlPoint.X, controlPoint.Y);

            oldPointGraph = new PointF((float)graphX, (float)graphY);

            pressed = true;

        }

        private void zedGraphControlMain_MouseUp(object sender, MouseEventArgs e)
        {
            var pane = zedGraphControlMain.GraphPane;

            Point eventPoint = new Point(e.X, e.Y);

            labelMousePosition.Text = string.Format("({0}; {1})", eventPoint.X, eventPoint.Y);

            double graphX, graphY, Y;
            pane.ReverseTransform(new PointF(e.X, e.Y), out graphX, out graphY, out Y);
            labelMousePosition.Text += string.Format("({0:F3}; {1:F3})", graphX, graphY);

            PointF controlPoint = pane.GeneralTransform(new PointF((float)graphX,
            (float)graphY),
            ZedGraph.CoordType.AxisXYScale);

            labelMousePosition.Text += string.Format("({0}; {1})", controlPoint.X, controlPoint.Y);

            pressed = false;

        }

        private void zedGraphControlMain_MouseMove(object sender, MouseEventArgs e)
        {
            if (pressed)
            {
                var pane = zedGraphControlMain.GraphPane;

                Point eventPoint = new Point(e.X, e.Y);

                labelMousePosition.Text = string.Format("({0}; {1})", eventPoint.X, eventPoint.Y);

                double graphX, graphY, Y;
                pane.ReverseTransform(new PointF(e.X, e.Y), out graphX, out graphY, out Y);
                labelMousePosition.Text += string.Format("({0:F3}; {1:F3})", graphX, graphY);

                var newPoint = new PointF((float)graphX, (float)graphY);

                PointF controlPoint = pane.GeneralTransform(newPoint,
                ZedGraph.CoordType.AxisXYScale);

                labelMousePosition.Text += string.Format("({0}; {1})", controlPoint.X, controlPoint.Y);

                moveScales(oldPointGraph, newPoint);
                zedGraphControlMain.Refresh();
                oldPointGraph = newPoint;
            }
            else if (perspective.withLine)
            {
                var pane = zedGraphControlMain.GraphPane;

                Point eventPoint = new Point(e.X, e.Y);

                double x, y, z;
                pane.ReverseTransform(new PointF(e.X, e.Y), out x, out y, out z);
                var xList = new List<Method.Trial>(perspective.methodInfo.report.iterations);
                xList.Sort(delegate (Method.Trial left, Method.Trial right)
                {
                    return left.x.CompareTo(right.x);

                });
                var eX = xList.GetEnumerator();
                eX.MoveNext();
                var rXMin = eX.Current;

                for (; eX.MoveNext();)
                {
                    if (Math.Abs(eX.Current.x - x) > Math.Abs(rXMin.x - x)) break;
                    rXMin = eX.Current;
                }
                if (perspective.withCurLine) pane.CurveList.Remove(pane.CurveList.Count - 1);

                perspective.curLineX = rXMin.x;
                var gp = new GraphProcessing();
                gp.drawVerticalLine(perspective, false);
                perspective.withCurLine = true;

                zedGraphControlMain.AxisChange();

                if (!perspective.withMainLine)
                {
                    if (pane.GraphItemList.Count != 0) pane.GraphItemList.RemoveAt(0);

                    var point = new ZedGraph.TextItem(string.Format("{0}({1}; {2})", rXMin.i - 2, rXMin.x, rXMin.y), (float)rXMin.x, (float)pane.YAxis.Max);
                    point.FontSpec.FontColor = perspective.colorLine;
                    point.FontSpec.Border.Color = perspective.colorPoint;
                    point.FontSpec.Fill.Color = perspective.colorBack;
                    //point.FontSpec.Angle = 2;
                    pane.GraphItemList.Add(point);
                }

                zedGraphControlMain.Invalidate();
            }

        }

        private void buttonWithPoints_Click(object sender, EventArgs e)
        {
            perspective.withPoint = perspective.withPoint ? false : true;
            new GraphProcessing().refreshGraph(perspective);

            zedGraphControlMain.AxisChange();
            zedGraphControlMain.Invalidate();
            resultProccessing();
        }

        private void buttonWithLine_Click(object sender, EventArgs e)
        {
            perspective.withLine = perspective.withLine ? false : true;
            var pane = zedGraphControlMain.GraphPane;
            if (perspective.withCurLine)
            {
                pane.CurveList.Remove(pane.CurveList.Count - 1);
                perspective.withCurLine = false;
            }

            if (perspective.withMainLine)
            {
                pane.CurveList.Remove(pane.CurveList.Count - 1);
                perspective.withMainLine = false;
            }
            if (pane.GraphItemList.Count != 0) pane.GraphItemList.RemoveAt(0);
            zedGraphControlMain.AxisChange();
            zedGraphControlMain.Invalidate();

            resultProccessing();
        }

        private void zedGraphControlMain_DoubleClick(object sender, EventArgs e)
        {
            if (perspective.withLine)
            {
                var pane = zedGraphControlMain.GraphPane;

                if (perspective.withCurLine)
                {
                    pane.CurveList.Remove(pane.CurveList.Count - 1);
                    perspective.withCurLine = false;
                }
                var repeatMainLine = false;
                if (perspective.withMainLine)
                {
                    pane.CurveList.Remove(pane.CurveList.Count - 1);
                    repeatMainLine = perspective.mainLineX == perspective.curLineX;
                    perspective.withMainLine = false;
                }
                perspective.mainLineX = perspective.curLineX;
                if (!repeatMainLine)
                {
                    var gp = new GraphProcessing();
                    gp.drawVerticalLine(perspective, true);

                    perspective.withMainLine = true;
                }

                zedGraphControlMain.AxisChange();

                if (pane.GraphItemList.Count != 0) pane.GraphItemList.RemoveAt(0);

                Method.Trial trialOfMin = new Method.Trial();
                foreach (var pointInfo in perspective.methodInfo.report.iterations)
                {
                    if (perspective.curLineX == pointInfo.x)
                    {
                        trialOfMin = pointInfo;
                        break;
                    }
                }

                var point = new ZedGraph.TextItem(string.Format("{0}({1}; {2})", trialOfMin.i - 2, trialOfMin.x, trialOfMin.y), (float)trialOfMin.x, (float)pane.YAxis.Max);
                point.FontSpec.FontColor = perspective.colorLine;
                point.FontSpec.Border.Color = perspective.colorPoint;
                point.FontSpec.Fill.Color = perspective.colorBack;
                //point.FontSpec.Angle = 2;
                pane.GraphItemList.Add(point);

                zedGraphControlMain.Invalidate();
            }
        }

        private void zedGraphControlMain_MouseLeave(object sender, EventArgs e)
        {
            if (perspective.withCurLine)
            {
                var pane = zedGraphControlMain.GraphPane;
                pane.CurveList.Remove(pane.CurveList.Count - 1);
                perspective.withCurLine = false;

                if (pane.GraphItemList.Count != 0 && !perspective.withMainLine) pane.GraphItemList.RemoveAt(0);

                zedGraphControlMain.AxisChange();
                zedGraphControlMain.Invalidate();
            }

        }

        private void buttonDefaultZoom_Click(object sender, EventArgs e)
        {
            var pane = zedGraphControlMain.GraphPane;
            var elem = perspective.funcInfo;

            var rX = elem.xRight - elem.xLeft;
            var rY = elem.yMax - elem.yMin;

            pane.XAxis.Min = elem.xMin - rX * 0.1;
            pane.XAxis.Max = elem.xMax + rX * 0.1;
            pane.YAxis.Min = elem.yMin - rY * 0.1;
            pane.YAxis.Max = elem.yMax + rY * 0.1;

            zedGraphControlMain.AxisChange();
            zedGraphControlMain.Invalidate();
        }

        private void buttonZoomApply_Click(object sender, EventArgs e)
        {
            var errorString = tryZoom();
            if (errorString == "")
            {
                labelErrorList.Visible = false;
                perspective.curZoomBorder.xMin = double.Parse(textBoxZoomXBegin.Text);
                perspective.curZoomBorder.xMax = double.Parse(textBoxZoomXEnd.Text);
                perspective.curZoomBorder.yMin = double.Parse(textBoxZoomYBegin.Text);
                perspective.curZoomBorder.yMax = double.Parse(textBoxZoomYEnd.Text);

                //if (perspective.curZoomBorder.xMax - perspective.curZoomBorder.xMin > (perspective.funcInfo.xMax - perspective.funcInfo.xMin))
                var pane = zedGraphControlMain.GraphPane;

                pane.XAxis.Min = perspective.curZoomBorder.xMin;
                pane.XAxis.Max = perspective.curZoomBorder.xMax;
                pane.YAxis.Min = perspective.curZoomBorder.yMin;
                pane.YAxis.Max = perspective.curZoomBorder.yMax;

                zedGraphControlMain.AxisChange();
                zedGraphControlMain.Invalidate();
            }
            else
            {
                var errors = errorString.Split(',');
                labelErrorList.Text = "";
                foreach (var error in errors)
                {
                    labelErrorList.Text += error + '\n';
                }
                labelErrorList.Visible = true;
            }
        }

        private void labelErrorList_Click(object sender, EventArgs e)
        {
            labelErrorList.Visible = false;
            if (perspective.methodInfo.report == null)
            {
                showNoData();
            }
        }

        private void labelMinBegin_Click(object sender, EventArgs e)
        {
            if (perspective.withLine)
            {
                var pane = zedGraphControlMain.GraphPane;

                if (perspective.withCurLine)
                {
                    pane.CurveList.Remove(pane.CurveList.Count - 1);
                    perspective.withCurLine = false;
                }
                var repeatMainLine = false;
                if (perspective.withMainLine)
                {
                    pane.CurveList.Remove(pane.CurveList.Count - 1);
                    repeatMainLine = perspective.mainLineX == perspective.methodInfo.report.minimum.x;
                    perspective.withMainLine = false;
                }
                perspective.mainLineX = perspective.methodInfo.report.minimum.x;
                if (pane.GraphItemList.Count != 0) pane.GraphItemList.RemoveAt(0);
                if (!repeatMainLine)
                {
                    var gp = new GraphProcessing();
                    gp.drawVerticalLine(perspective, true);

                    perspective.withMainLine = true;
                }

                zedGraphControlMain.AxisChange();

                if (!repeatMainLine)
                {
                    var minimum = perspective.methodInfo.report.minimum;
                    var point = new ZedGraph.TextItem(string.Format("{0}({1}; {2})", minimum.i - 2, minimum.x, minimum.y), (float)minimum.x, (float)pane.YAxis.Max);
                    point.FontSpec.FontColor = perspective.colorLine;
                    point.FontSpec.Border.Color = perspective.colorPoint;
                    point.FontSpec.Fill.Color = perspective.colorBack;
                    //point.FontSpec.Angle = 2;
                    pane.GraphItemList.Add(point);
                }

                zedGraphControlMain.Invalidate();
            }
        }

        private void buttonSortI_Click(object sender, EventArgs e)
        {
            perspective.sortBy = "i";
            tableProcessing();
            returnTablePanel(perspective);
        }

        private void buttonSortX_Click(object sender, EventArgs e)
        {
            perspective.sortBy = "x";
            tableProcessing();
            returnTablePanel(perspective);
        }

        private void buttonSortY_Click(object sender, EventArgs e)
        {
            perspective.sortBy = "y";
            tableProcessing();
            returnTablePanel(perspective);
        }

        private void buttonBottomUp_Click(object sender, EventArgs e)
        {
            perspective.sortDir = "BottomUp";
            tableProcessing();
            returnTablePanel(perspective);
        }

        private void buttonTopDown_Click(object sender, EventArgs e)
        {
            perspective.sortDir = "TopDown";
            tableProcessing();
            returnTablePanel(perspective);
        }

        private void buttonTop5_Click(object sender, EventArgs e)
        {
            perspective.sortTop = 45;
            tableProcessing();
            returnTablePanel(perspective);
        }

        private void buttonTop10_Click(object sender, EventArgs e)
        {
            perspective.sortTop = 30;
            tableProcessing();
            returnTablePanel(perspective);
        }

        private void buttonTop15_Click(object sender, EventArgs e)
        {
            perspective.sortTop = 15;
            tableProcessing();
            returnTablePanel(perspective);
        }

        public void ClickOnTableLayoutPanel(object sender, MouseEventArgs e)
        {
            int column = tableLayoutPanel.GetColumn((Control)sender);
            var control = tableLayoutPanel.GetControlFromPosition(column, 0);
            var param = control.Text.Split('\n');

            if (perspective.withLine)
            {
                var pane = zedGraphControlMain.GraphPane;

                if (perspective.withCurLine)
                {
                    pane.CurveList.Remove(pane.CurveList.Count - 1);
                    perspective.withCurLine = false;
                }

                if (perspective.withMainLine)
                {
                    pane.CurveList.Remove(pane.CurveList.Count - 1);
                    perspective.withMainLine = false;
                }
                perspective.mainLineX = perspective.curLineX;

                var gp = new GraphProcessing();
                gp.drawVerticalLine(perspective, true);

                perspective.withMainLine = true;

                zedGraphControlMain.AxisChange();

                if (pane.GraphItemList.Count != 0) pane.GraphItemList.RemoveAt(0);

                Method.Trial trialOfMin = new Method.Trial();
                trialOfMin = perspective.methodInfo.report.iterations[int.Parse(param[0]) + 1];

                var point = new ZedGraph.TextItem(string.Format("{0}({1}; {2})", trialOfMin.i - 2, trialOfMin.x, trialOfMin.y), (float)trialOfMin.x, (float)pane.YAxis.Max);
                point.FontSpec.FontColor = perspective.colorLine;
                point.FontSpec.Border.Color = perspective.colorPoint;
                point.FontSpec.Fill.Color = perspective.colorBack;
                //point.FontSpec.Angle = 2;
                pane.GraphItemList.Add(point);

                zedGraphControlMain.Invalidate();
            }
        }

        public void EnterInTableLayoutPanel(object sender, EventArgs e)
        {
            int column = tableLayoutPanel.GetColumn((Control)sender);
            var control = tableLayoutPanel.GetControlFromPosition(column, 0);
            var param = control.Text.Split('\n');

            if (perspective.withLine)
            {
                var pane = zedGraphControlMain.GraphPane;

                var trialOfMin = perspective.methodInfo.report.iterations[int.Parse(param[0]) + 1];
                if (perspective.withCurLine)
                {
                    pane.CurveList.Remove(pane.CurveList.Count - 1);
                    perspective.withCurLine = false;
                }

                perspective.curLineX = trialOfMin.x;

                var gp = new GraphProcessing();
                gp.drawVerticalLine(perspective, false);
                perspective.withCurLine = true;

                zedGraphControlMain.AxisChange();

                if (!perspective.withMainLine)
                {
                    if (pane.GraphItemList.Count != 0) pane.GraphItemList.RemoveAt(0);

                    var point = new ZedGraph.TextItem(string.Format("{0}({1}; {2})", trialOfMin.i - 2, trialOfMin.x, trialOfMin.y), (float)trialOfMin.x, (float)pane.YAxis.Max);
                    point.FontSpec.FontColor = perspective.colorLine;
                    point.FontSpec.Border.Color = perspective.colorPoint;
                    point.FontSpec.Fill.Color = perspective.colorBack;
                    //point.FontSpec.Angle = 2;
                    pane.GraphItemList.Add(point);
                }

                zedGraphControlMain.Invalidate();
            }
        }

        public void LeaveOfTableLayoutPanel(object sender, EventArgs e)
        {
            if (perspective.withCurLine)
            {
                var pane = zedGraphControlMain.GraphPane;
                pane.CurveList.Remove(pane.CurveList.Count - 1);
                perspective.withCurLine = false;

                if (pane.GraphItemList.Count != 0 && !perspective.withMainLine) pane.GraphItemList.RemoveAt(0);

                zedGraphControlMain.AxisChange();
                zedGraphControlMain.Invalidate();
            }
        }
    }
}
