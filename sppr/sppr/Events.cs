using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;
using ZedGraph;

namespace sppr
{
    class MethodInfo
    {
        public Method.Report report;
        public ZedGraph.ZedGraphControl graphControl;
    }

    class curZoom
    {
        public double xMin;
        public double yMin;
        public double xMax;
        public double yMax;
    }
    class PerspectiveInfo
    {
        public string name { get; }
        public Color colorBack { get; }
        public Color colorPanel { get; }
        public Color colorText { get; }
        public Color colorPane { get; }
        public Color colorLine { get; }
        public Color colorPoint { get; }
        public Color colorMainLine { get; }
        public bool withR { get; }
        public bool withPoint { get; set; }
        public bool withLine { get; set; }
        public bool withMainLine { get; set; }
        public bool withCurLine { get; set; }
        public double mainLineX { get; set; }
        public double curLineX { get; set; }
        public double e { get; set; }
        public double r { get; set; }
        public double xLeft { get; set; }
        public double xRight { get; set; }
        public double a { get; set; }
        public double b { get; set; }
        public double c { get; set; }
        public double d { get; set; }
        public int maxStepCount { get; set; }
        public MethodInfo methodInfo { get; set; }
        public FElem funcInfo; // It need for correct work graph, TO DO
        public curZoom curZoomBorder;
        public string sortBy;
        public string sortDir;
        public int sortTop;

        public PerspectiveInfo(string _name, Color _colorBack, Color _colorPanel, Color _colorText,
        Color _colorPane, Color _colorLine, bool _withR, bool _withPoint, bool _withLine,
        double _e, double _r, double _xLeft, double _xRight, double _a, double _b, double _c, double _d, int _maxStepCount)
        {
            name = _name;
            colorBack = _colorBack;
            colorPanel = _colorPanel;
            colorText = _colorText;
            colorPane = _colorPane;
            colorLine = _colorLine;
            colorPoint = Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(209)))), ((int)(((byte)(132)))));
            colorMainLine = Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            withR = _withR;
            withPoint = _withPoint;
            withLine = _withLine;
            withMainLine = false;
            e = _e;
            r = _r;
            xLeft = _xLeft;
            xRight = _xRight;
            a = _a;
            b = _b;
            c = _c;
            d = _d;
            maxStepCount = _maxStepCount;
            methodInfo = new MethodInfo();
            methodInfo.graphControl = new ZedGraph.ZedGraphControl();
            sortBy = "y";
            sortDir = "BottomUp";
            sortTop = 15;
            changePane();
        }

        public void changePane()
        {
            var pane = methodInfo.graphControl.GraphPane;

            pane.FontSpec.FontColor = colorPane;

            pane.PaneBorder.Color = colorBack;

            pane.AxisBorder.Color = colorPane;

            pane.PaneFill.Type = FillType.Solid;
            pane.PaneFill.Color = colorBack;

            pane.AxisFill.Type = FillType.Solid;
            pane.AxisFill.Color = colorBack;

            pane.XAxis.IsZeroLine = true;
            pane.YAxis.IsZeroLine = true;
            pane.XAxis.Color = colorPane;
            pane.YAxis.Color = colorPane;

            pane.XAxis.IsShowGrid = true;
            pane.YAxis.IsShowGrid = true;
            pane.XAxis.GridColor = colorPane;
            pane.YAxis.GridColor = colorPane;

            pane.XAxis.ScaleFontSpec.FontColor = colorPane;
            pane.YAxis.ScaleFontSpec.FontColor = colorPane;

            pane.XAxis.TitleFontSpec.FontColor = colorPane;
            pane.YAxis.TitleFontSpec.FontColor = colorPane;

            pane.XAxis.IsShowGrid = false;
            pane.YAxis.IsShowGrid = false;

            pane.Title = "";
            pane.XAxis.Title = "x";
            pane.YAxis.Title = "F(x)";

            //pane.XAxis.IsShowMinorGrid = true;
        }
    }
    partial class MainForm
    {
        //Perspective perspective;
        PerspectiveInfo perspective;
        PerspectiveInfo bruteForce;
        PerspectiveInfo piacovsky;
        PerspectiveInfo strongin;
        double status;
        string stage;
        double remainder;
        PointF oldPointGraph;

        protected void initPerspectives()
        {
            bruteForce = new PerspectiveInfo("Bruteforce", style.colors["black.vs"], style.colors["red.king yna"], style.colors["white.argon"],
            style.colors["white.argon"], style.colors["red.king yna"], false, false, true, 0.001, -1, -2, 2, 2, 3, 3, 5, 100);
            piacovsky = new PerspectiveInfo("Piyavsky method", style.colors["black.vs"], style.colors["blue.king yna"], style.colors["white.argon"],
            style.colors["white.argon"], style.colors["blue.vs"], true, false, true, 0.001, 3, -2, 2, 2, 3, 3, 5, 100);
            strongin = new PerspectiveInfo("Strongin method", style.colors["black.vs"], style.colors["yellow.king yna"], style.colors["black.argon"],
            style.colors["white.argon"], style.colors["yellow.king yna"], true, false, true, 0.001, 3, -2, 2, 2, 3, 3, 5, 100);
            perspective = bruteForce;
        }

        protected void refreshActionPanel()
        {
            panelActionBottom.BackColor = perspective.colorPanel;
            buttonActionBottom.BackColor = perspective.colorPanel;
            labelErrorList.Visible = false;
            if (perspective.methodInfo.report == null)
            {
                if (zedGraphControlMain.Visible) zedGraphControlMain.Visible = false;
                showNoData();
                panelGraphConrtol.Visible = false;
                tableLayoutPanel.Visible = false;
                buttonRun.Text = "RUN";
            }
            else
            {
                buttonRun.Text = "CLEAR";
                if (zedGraphControlMain.Visible) zedGraphControlMain.Visible = false;
                if (labelNoData.Visible || labelRecomendation.Visible) hideNoData();
                zedGraphControlMain.GraphPane = perspective.methodInfo.graphControl.GraphPane;
                zedGraphControlMain.Width = zedGraphControlMain.Width - 1;
                zedGraphControlMain.Visible = true;
                resultProccessing();
                tableProcessing();
                panelGraphConrtol.Visible = true;
                tableLayoutPanel.Visible = true;
            }
            panelActionBottomParam.Visible = false;
            paramProccessing();
            panelActionBottomParam.Visible = true;
        }

        protected void showNoData()
        {
            labelNoData.Visible = true;
            labelRecomendation.Visible = true;
        }

        protected void hideNoData()
        {
            labelNoData.Visible = false;
            labelRecomendation.Visible = false;
        }

        protected void showHideActionBottomPanel()
        {
            panelActionBottom.Visible = panelActionBottom.Visible ? false : true;
            if (panelActionBottom.Visible) buttonActionBottom.Text = "▼";
            else buttonActionBottom.Text = "▲";
        }

        void paramProccessing()
        {
            // Name
            labelNameMethod.Text = perspective.name;
            labelNameMethod.ForeColor = perspective.colorText;

            buttonRun.ForeColor = perspective.colorText;

            panelActionBottomParam.Width = labelNameMethod.Width + 100 > widthOfFunc() ? labelNameMethod.Width + 100 : widthOfFunc();

            labelFunc.ForeColor = perspective.colorText;

            // a
            textBoxA.Text = perspective.a.ToString();
            textBoxA.BackColor = perspective.colorPanel;
            textBoxA.ForeColor = perspective.colorText;
            //textBoxA.Width = textBoxA.Text.Length * 10;

            // b
            textBoxB.Text = perspective.b.ToString();
            textBoxB.BackColor = perspective.colorPanel;
            textBoxB.ForeColor = perspective.colorText;

            // c
            textBoxC.Text = perspective.c.ToString();
            textBoxC.BackColor = perspective.colorPanel;
            textBoxC.ForeColor = perspective.colorText;

            // d
            textBoxD.Text = perspective.d.ToString();
            textBoxD.BackColor = perspective.colorPanel;
            textBoxD.ForeColor = perspective.colorText;

            labelCosBegin.ForeColor = perspective.colorText;
            labelCosEnd.ForeColor = perspective.colorText;
            labelSinBegin.ForeColor = perspective.colorText;
            labelSinEnd.ForeColor = perspective.colorText;

            // xLeft
            textBoxXBegin.Text = perspective.xLeft.ToString();
            textBoxXBegin.BackColor = perspective.colorPanel;
            textBoxXBegin.ForeColor = perspective.colorText;

            // xRight
            textBoxXEnd.Text = perspective.xRight.ToString();
            textBoxXEnd.BackColor = perspective.colorPanel;
            textBoxXEnd.ForeColor = perspective.colorText;

            labelRegionBegin.ForeColor = perspective.colorText;
            labelZpt.ForeColor = perspective.colorText;
            labelRegionEnd.ForeColor = perspective.colorText;

            // max step count
            textBoxMaxStepCount.Text = perspective.maxStepCount.ToString();
            textBoxMaxStepCount.BackColor = perspective.colorPanel;
            textBoxMaxStepCount.ForeColor = perspective.colorText;

            labelMaxStepCount.ForeColor = perspective.colorText;

            // e
                textBoxE.Text = perspective.e.ToString();
                textBoxE.BackColor = perspective.colorPanel;
                textBoxE.ForeColor = perspective.colorText;

                labelE.ForeColor = perspective.colorText;
                labelGuidanceE.ForeColor = perspective.colorText;

            // r
            if (perspective.withR)
            {
                panelActionBottomR.Visible = true;
                textBoxR.Text = perspective.r.ToString();
                textBoxR.BackColor = perspective.colorPanel;
                textBoxR.ForeColor = perspective.colorText;

                labelR.ForeColor = perspective.colorText;
                labelGuidanceR.ForeColor = perspective.colorText;
            }
            else
            {
                panelActionBottomR.Visible = false;
            }
        }

        void resultProccessing()
        {
            // Points and Line buttons
            buttonWithPoints.ForeColor = perspective.withPoint ? invert(perspective.colorText) : perspective.colorText;
            buttonWithPoints.BackColor = perspective.withPoint ? invert(perspective.colorPanel) : perspective.colorPanel;
            buttonWithLine.ForeColor = perspective.withLine ? invert(perspective.colorText) : perspective.colorText;
            buttonWithLine.BackColor = perspective.withLine ? invert(perspective.colorPanel) : perspective.colorPanel;

            // xZoomLeft
            textBoxZoomXBegin.Text = perspective.curZoomBorder.xMin.ToString();
            textBoxZoomXBegin.BackColor = perspective.colorPanel;
            textBoxZoomXBegin.ForeColor = perspective.colorText;

            // xZoomRight
            textBoxZoomXEnd.Text = perspective.curZoomBorder.xMax.ToString();
            textBoxZoomXEnd.BackColor = perspective.colorPanel;
            textBoxZoomXEnd.ForeColor = perspective.colorText;

            labelZoomXBegin.ForeColor = perspective.colorText;
            labelZoomXMid.ForeColor = perspective.colorText;
            labelZoomXEnd.ForeColor = perspective.colorText;

            // yZoomLeft
            textBoxZoomYBegin.Text = perspective.curZoomBorder.yMin.ToString();
            textBoxZoomYBegin.BackColor = perspective.colorPanel;
            textBoxZoomYBegin.ForeColor = perspective.colorText;

            // yZoomRight
            textBoxZoomYEnd.Text = perspective.curZoomBorder.yMax.ToString();
            textBoxZoomYEnd.BackColor = perspective.colorPanel;
            textBoxZoomYEnd.ForeColor = perspective.colorText;

            labelZoomYBegin.ForeColor = perspective.colorText;
            labelZoomYMid.ForeColor = perspective.colorText;
            labelZoomYEnd.ForeColor = perspective.colorText;

            buttonZoomApply.ForeColor = perspective.colorText;

            buttonDefaultZoom.ForeColor = perspective.colorText;

            labelStepCount.ForeColor = perspective.colorText;
            labelStepCount.Text = perspective.methodInfo.report.onStep.ToString();
            labelOfStep.ForeColor = perspective.colorText;
            labelMaxStepCountResult.ForeColor = perspective.colorText;
            labelMaxStepCountResult.Text = perspective.methodInfo.report.ofStep.ToString();

            // xMin
            textBoxXMin.Text = perspective.methodInfo.report.minimum.x.ToString();
            textBoxXMin.BackColor = perspective.colorPanel;
            textBoxXMin.ForeColor = perspective.colorText;

            // yMin
            textBoxYMin.Text = perspective.methodInfo.report.minimum.y.ToString();
            textBoxYMin.BackColor = perspective.colorPanel;
            textBoxYMin.ForeColor = perspective.colorText;

            labelMinBegin.ForeColor = perspective.colorText;
            labelMinMid.ForeColor = perspective.colorText;
            labelMinEnd.ForeColor = perspective.colorText;
        }

        void tableProcessing()
        {
            tableLayoutPanel.BackColor = perspective.colorPanel;

            labelSortedBy.ForeColor = perspective.colorText;
            labelSortingDirection.ForeColor = perspective.colorText;
            labelTopCount.ForeColor = perspective.colorText;

            buttonSortI.ForeColor = perspective.sortBy == "i" ? invert(perspective.colorText) : perspective.colorText;
            buttonSortI.BackColor = perspective.sortBy == "i" ? invert(perspective.colorPanel) : perspective.colorPanel;

            buttonSortX.ForeColor = perspective.sortBy == "x" ? invert(perspective.colorText) : perspective.colorText;
            buttonSortX.BackColor = perspective.sortBy == "x" ? invert(perspective.colorPanel) : perspective.colorPanel;

            buttonSortY.ForeColor = perspective.sortBy == "y" ? invert(perspective.colorText) : perspective.colorText;
            buttonSortY.BackColor = perspective.sortBy == "y" ? invert(perspective.colorPanel) : perspective.colorPanel;

            buttonBottomUp.ForeColor = perspective.sortDir == "BottomUp" ? invert(perspective.colorText) : perspective.colorText;
            buttonBottomUp.BackColor = perspective.sortDir == "BottomUp" ? invert(perspective.colorPanel) : perspective.colorPanel;

            buttonTopDown.ForeColor = perspective.sortDir == "TopDown" ? invert(perspective.colorText) : perspective.colorText;
            buttonTopDown.BackColor = perspective.sortDir == "TopDown" ? invert(perspective.colorPanel) : perspective.colorPanel;

            buttonTop15.ForeColor = perspective.sortTop == 15 ? invert(perspective.colorText) : perspective.colorText;
            buttonTop15.BackColor = perspective.sortTop == 15 ? invert(perspective.colorPanel) : perspective.colorPanel;

            buttonTop30.ForeColor = perspective.sortTop == 30 ? invert(perspective.colorText) : perspective.colorText;
            buttonTop30.BackColor = perspective.sortTop == 30 ? invert(perspective.colorPanel) : perspective.colorPanel;

            buttonTop45.ForeColor = perspective.sortTop == 45 ? invert(perspective.colorText) : perspective.colorText;
            buttonTop45.BackColor = perspective.sortTop == 45 ? invert(perspective.colorPanel) : perspective.colorPanel;
        }

        protected void runCurMethod()
        {
            if (!runMethod.IsBusy)
            {
                buttonRun.Text = "CANCEL";
                if (labelNoData.Visible)
                {
                    hideNoData();
                }
                panelStatus.Width = 0;
                stage = "Processing";
                labelStage.Text = stage + "...";
                labelStage.Visible = true;
                remainder = 0;
                status = 0;
                if (!panelBottomAnimation.IsBusy) panelBottomAnimation.RunWorkerAsync(new List<Color> { style.colors["red.king yna"], style.colors["yellow.king yna"], 
                style.colors["green.vs"], style.colors["blue.king yna"], style.colors["red.king yna"] });
                runMethod.RunWorkerAsync();
            }

        }

        protected void cancelCurMethod()
        {
            buttonRun.Text = "RUN";
            runMethod.CancelAsync();
        }

        protected void clearCurMethod()
        {
            buttonRun.Text = "RUN";
            double testD;
            int testI;
            if (perspective.name == "Bruteforce")
            {
                bruteForce = new PerspectiveInfo("Bruteforce", style.colors["black.vs"], style.colors["red.king yna"], style.colors["white.argon"],
                    style.colors["white.argon"], style.colors["red.king yna"], false, false, true, 0, -1, -2, 2, 2, 3, 3, 5, 100);
                perspective = bruteForce;
            }
            if (perspective.name == "Piyavsky method")
            {
                piacovsky = new PerspectiveInfo("Piyavsky method", style.colors["black.vs"], style.colors["blue.king yna"], style.colors["white.argon"],
                    style.colors["white.argon"], style.colors["blue.vs"], true, false, true, 0.001, 3, -2, 2, 2, 3, 3, 5, 100);
                perspective = piacovsky;
                if (double.TryParse(textBoxR.Text, out testD)) perspective.r = double.Parse(textBoxR.Text);
            }
            if (perspective.name == "Strongin method")
            {
                strongin = new PerspectiveInfo("Strongin method", style.colors["black.vs"], style.colors["yellow.king yna"], style.colors["black.argon"],
                    style.colors["white.argon"], style.colors["yellow.king yna"], true, false, true, 0.001, 3, -2, 2, 2, 3, 3, 5, 100);
                perspective = strongin;
                if (double.TryParse(textBoxR.Text, out testD)) perspective.r = double.Parse(textBoxR.Text);
            }

            if (double.TryParse(textBoxA.Text, out testD)) perspective.a = double.Parse(textBoxA.Text);
            if (double.TryParse(textBoxB.Text, out testD))perspective.b = double.Parse(textBoxB.Text);
            if (double.TryParse(textBoxC.Text, out testD))perspective.c = double.Parse(textBoxC.Text);
            if (double.TryParse(textBoxD.Text, out testD))perspective.d = double.Parse(textBoxD.Text);
            if (double.TryParse(textBoxE.Text, out testD)) perspective.e = double.Parse(textBoxE.Text);
            if (double.TryParse(textBoxXBegin.Text, out testD))perspective.xLeft = double.Parse(textBoxXBegin.Text);
            if (double.TryParse(textBoxXEnd.Text, out testD))perspective.xRight = double.Parse(textBoxXEnd.Text);
            if (double.TryParse(textBoxMaxStepCount.Text, out testD))perspective.maxStepCount = int.Parse(textBoxMaxStepCount.Text);

            refreshActionPanel();
        }

        private void runMethod_DoWork(object sender, DoWorkEventArgs e)
        {
            Func<double, double> func = x => Double.Parse(textBoxA.Text) * Math.Cos(Double.Parse(textBoxB.Text) * x)
                + Double.Parse(textBoxC.Text) * Math.Sin(Double.Parse(textBoxD.Text) * x);
            Method method = null;

            runMethod.ReportProgress((int)status + 10);

            var xLeft = Double.Parse(textBoxXBegin.Text);
            var xRight = Double.Parse(textBoxXEnd.Text);
            var maxSteps = int.Parse(textBoxMaxStepCount.Text);
            var _e = Double.Parse(textBoxE.Text);
            if (perspective == bruteForce) method = new Brute(func, xLeft, xRight, maxSteps, _e);
            else
            {
                var r = Double.Parse(textBoxR.Text);
                if (perspective == piacovsky) method = new Piavsky(func, xLeft, xRight, maxSteps, _e, r);
                if (perspective == strongin) method = new Strongin(func, xLeft, xRight, maxSteps, _e, r);
            }
            runMethod.ReportProgress((int)status + 10);

            var report = method.solve(runMethod);
            status = 60;

            FElem elem = new FElem();
            elem.function = func;
            elem.xLeft = xLeft;
            elem.xRight = xRight;

            if (!runMethod.CancellationPending)
            {
                GraphProcessing gp = new GraphProcessing();
                perspective.methodInfo.graphControl.GraphPane.CurveList.Clear();
                gp.drawFunction(perspective.methodInfo.graphControl,ref elem, perspective.colorLine, runMethod);
                perspective.funcInfo = elem;

                perspective.curZoomBorder = new curZoom()
                {
                    xMin = perspective.funcInfo.xMin,
                    xMax = perspective.funcInfo.xMax,
                    yMin = perspective.funcInfo.yMin,
                    yMax = perspective.funcInfo.yMax
                };

                perspective.methodInfo.report = report;
                perspective.a = Double.Parse(textBoxA.Text);
                perspective.b = Double.Parse(textBoxB.Text);
                perspective.c = Double.Parse(textBoxC.Text);
                perspective.d = Double.Parse(textBoxD.Text);
                perspective.xLeft = xLeft;
                perspective.xRight = xRight;
                perspective.maxStepCount = maxSteps;
                perspective.e = _e;
                if (perspective.withR) perspective.r = Double.Parse(textBoxR.Text);
            }
        }

        private void runMethod_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if (!runMethod.CancellationPending)
            {
                if (status > 19.99 && stage == "Processing")
                {
                    stage = "Solving";
                    labelStage.Text = stage + "...";
                    remainder = status;
                }
                if (status > 59.99 && stage == "Solving")
                {
                    stage = "Drawing";
                    labelStage.Text = stage + "...";
                    remainder = status;
                }
                var deposit = 1.0;
                if (stage == "Solving" || stage == "Drawing") deposit = 0.4;
                status = remainder + e.ProgressPercentage * deposit;
                panelStatus.Width = (int)(panelBottom.Width * status * 0.01);
                if (status > 99)
                {
                    
                }
            }
            else
            {
                panelStatus.Width = 0;
                labelStage.Visible = false;
            }
        }

        private void runMethod_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            panelStatus.Width = 0;
            panelBottomAnimation.CancelAsync();
            buttonRun.Text = "RUN";
            labelStage.Visible = false;
            if (!runMethod.CancellationPending)
            {
                buttonRun.Text = "CLEAR";
                tableLayoutPanel.Controls.Clear();

                refreshActionPanel();
                
                zedGraphControlMain.Visible = true;
                zedGraphControlMain.GraphPane = perspective.methodInfo.graphControl.GraphPane;
                var minimum = perspective.methodInfo.report.minimum;
                perspective.mainLineX = minimum.x;
                perspective.withMainLine = true;
                new GraphProcessing().drawVerticalLine(perspective, true);
                zedGraphControlMain.AxisChange();
                zedGraphControlMain.Width = zedGraphControlMain.Width - 1;

                var point = new ZedGraph.TextItem(string.Format("{0}({1}; {2})", minimum.i - 2, minimum.x, minimum.y), (float)minimum.x, (float)zedGraphControlMain.GraphPane.YAxis.Max);
                point.FontSpec.FontColor = perspective.colorLine;
                point.FontSpec.Border.Color = perspective.colorPoint;
                point.FontSpec.Fill.Color = perspective.colorBack;
                //point.FontSpec.Angle = 2;
                zedGraphControlMain.GraphPane.GraphItemList.Add(point);
                zedGraphControlMain.Refresh();
                returnTablePanel(perspective);
            }
        }

        private void moveScales(PointF oldPoint, PointF newPoint)
        {
            var pane = zedGraphControlMain.GraphPane;

            var changeX = newPoint.X - oldPoint.X;
            var changeY = newPoint.Y - oldPoint.Y;

            var newXMin = pane.XAxis.Min - changeX * 0.5;
            var newXMax = pane.XAxis.Max - changeX * 0.5;
            var newYMin = pane.YAxis.Min - changeY * 0.5;
            var newYMax = pane.YAxis.Max - changeY * 0.5;

            var rX = perspective.funcInfo.xMax - perspective.funcInfo.xMin;
            var rY = perspective.funcInfo.yMax - perspective.funcInfo.yMin;

            if (perspective.funcInfo.xMin - rX * 0.1 < newXMin && perspective.funcInfo.xMax + rX * 0.1 > newXMax)
            {
                pane.XAxis.Min = newXMin;
                pane.XAxis.Max = newXMax;
            }

            if (perspective.funcInfo.yMin - rY * 0.1 < newYMin && perspective.funcInfo.yMax + rY * 0.1 > newYMax)
            {
                pane.YAxis.Min = newYMin;
                pane.YAxis.Max = newYMax;
            }
        }

        private void zoomScales(int delta, PointF curPoint)
        {
            var pane = zedGraphControlMain.GraphPane;
            delta = delta > 1000 ? 1000 : delta;

            var rX = (pane.XAxis.Max - pane.XAxis.Min);
            var rY = (pane.YAxis.Max - pane.YAxis.Min);

            var newXMin = pane.XAxis.Min + (curPoint.X - pane.XAxis.Min) * (delta * 0.001) / rX;
            var newXMax = pane.XAxis.Max - (pane.XAxis.Max - curPoint.X) * (delta * 0.001) / rX;
            var newYMin = pane.YAxis.Min + (curPoint.Y - pane.YAxis.Min) * (delta * 0.001) / rY;
            var newYMax = pane.YAxis.Max - (pane.YAxis.Max - curPoint.Y) * (delta * 0.001) / rY;

            if (newXMax - newXMin > (perspective.funcInfo.xMax - perspective.funcInfo.xMin) * 0.01 && newYMax - newYMin > (perspective.funcInfo.yMax - perspective.funcInfo.yMin) * 0.01)
            {
                if (delta > 0 || delta < 0 && perspective.funcInfo.xMin - rX * 0.1 < newXMin) pane.XAxis.Min = newXMin;
                if (delta > 0 || delta < 0 && perspective.funcInfo.xMax + rX * 0.1 > newXMax) pane.XAxis.Max = newXMax;

                if (delta > 0 || delta < 0 && perspective.funcInfo.yMin - rY * 0.1 < newYMin) pane.YAxis.Min = newYMin;
                if (delta > 0 || delta < 0 && perspective.funcInfo.yMax + rY * 0.1 > newYMax) pane.YAxis.Max = newYMax;
            }
            else if (delta < 0)
            {
                pane.XAxis.Min = newXMin;
                pane.XAxis.Max = newXMax;

                pane.YAxis.Min = newYMin;
                pane.YAxis.Max = newYMax;
            }

            zedGraphControlMain.AxisChange();
        }

        private void returnTablePanel(PerspectiveInfo perspective)
        {
            tableLayoutPanel = new TableLayoutPanel();

            this.tableLayoutPanel.AutoScroll = true;
            this.tableLayoutPanel.BackColor = perspective.colorPanel;
            this.tableLayoutPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tableLayoutPanel.Location = new System.Drawing.Point(200, 90);
            this.tableLayoutPanel.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 1;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel.Size = new System.Drawing.Size(672, 134);
            this.tableLayoutPanel.Visible = false;

            panelTable.Controls.Clear();
            panelTable.Controls.Add(tableLayoutPanel);

            var iterations = new List<Method.Trial>(perspective.methodInfo.report.iterations);
            if (perspective.sortBy == "i" && perspective.sortDir == "BottomUp")
                iterations.Sort(delegate (Method.Trial left, Method.Trial right)
                {
                    return left.i.CompareTo(right.i);

                });

            if (perspective.sortBy == "x" && perspective.sortDir == "BottomUp")
                iterations.Sort(delegate (Method.Trial left, Method.Trial right)
                {
                    return left.x.CompareTo(right.x);

                });

            if (perspective.sortBy == "y" && perspective.sortDir == "BottomUp")
                iterations.Sort(delegate (Method.Trial left, Method.Trial right)
                {
                    return left.y.CompareTo(right.y);

                });

            if (perspective.sortBy == "i" && perspective.sortDir == "TopDown")
                iterations.Sort(delegate (Method.Trial left, Method.Trial right)
                {
                    return right.i.CompareTo(left.i);

                });

            if (perspective.sortBy == "x" && perspective.sortDir == "TopDown")
                iterations.Sort(delegate (Method.Trial left, Method.Trial right)
                {
                    return right.x.CompareTo(left.x);

                });

            if (perspective.sortBy == "y" && perspective.sortDir == "TopDown")
                iterations.Sort(delegate (Method.Trial left, Method.Trial right)
                {
                    return right.y.CompareTo(left.y);

                });

            int i = 0;

            foreach (var kv in iterations)
            {
                if (i++ >= perspective.sortTop) break;
                tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
                tableLayoutPanel.Controls.Add(new Label() { Text = string.Format("{0}\n{1}\n{2}", (kv.i - 2).ToString(), kv.x.ToString("0.00000"), kv.y.ToString("0.00000")), TextAlign = System.Drawing.ContentAlignment.MiddleCenter, Dock = DockStyle.Left, 
                    Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204))), BackColor = perspective.colorPanel, ForeColor = perspective.colorText}, i, 0);
            }

            foreach (System.Windows.Forms.Control c in this.tableLayoutPanel.Controls)
            {
                c.MouseClick += new System.Windows.Forms.MouseEventHandler(ClickOnTableLayoutPanel);
                c.MouseEnter += new EventHandler(EnterInTableLayoutPanel);
                c.MouseLeave += new EventHandler(LeaveOfTableLayoutPanel);
            }
            tableLayoutPanel.Visible = true;
        }
    }
}
