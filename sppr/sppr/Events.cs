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

    enum Perspective
    {
        BruteForce,
        Piacovsky,
        Strongin
    }
    class PerspectiveInfo
    {
        public string name { get; }
        public Color colorBack { get; }
        public Color colorPanel { get; }
        public Color colorText { get; }
        public Color colorPane { get; }
        public Color colorLine { get; }
        public bool withR { get; }
        public bool withPoint { get; set; }
        public bool withLine { get; set; }
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
        public FElem funcInfo { get; set; } // It need for correct work graph, TO DO

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
            withR = _withR;
            withPoint = _withPoint;
            withLine = _withLine;
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
            style.colors["white.argon"], style.colors["red.king yna"], false, false, false, 0.001, -1, -2, 2, 2, 3, 3, 5, 100);
            piacovsky = new PerspectiveInfo("Piyavsky method", style.colors["black.vs"], style.colors["blue.king yna"], style.colors["white.argon"],
            style.colors["white.argon"], style.colors["blue.vs"], true, false, false, 0.001, 3, -2, 2, 2, 3, 3, 5, 100);
            strongin = new PerspectiveInfo("Strongin method", style.colors["black.vs"], style.colors["yellow.king yna"], style.colors["black.argon"],
            style.colors["white.argon"], style.colors["yellow.king yna"], true, false, false, 0.001, 3, -2, 2, 2, 3, 3, 5, 100);
            perspective = bruteForce;
        }

        //protected Perspective getCurrentPerspective() I wanted the best, but CS0050
        //{
        //    if (perspective == Perspective.BruteForce) return bruteForce;
        //    if (perspective == Perspective.Piacovsky) return piacovsky;
        //    if (perspective == Perspective.Strongin) return strongin;
        //
        //    return null;
        //}

        protected void refreshActionPanel()
        {
            panelActionButtom.BackColor = perspective.colorPanel;
            buttonActionButtom.BackColor = perspective.colorPanel;
            if (perspective.methodInfo.report == null)
            {
                if (zedGraphControlMain.Visible) zedGraphControlMain.Visible = false;
                showNoData();
                panelGraphConrtol.Visible = false;
            }
            else
            {
                if (zedGraphControlMain.Visible) zedGraphControlMain.Visible = false;
                if (labelNoData.Visible || labelRecomendation.Visible) hideNoData();
                zedGraphControlMain.GraphPane = perspective.methodInfo.graphControl.GraphPane;
                zedGraphControlMain.Visible = true;
                resultProccessing();
                panelGraphConrtol.Visible = true;
            }
            panelActionButtomParam.Visible = false;
            paramProccessing();
            panelActionButtomParam.Visible = true;
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

        protected void showHideActionButtomPanel()
        {
            panelActionButtom.Visible = panelActionButtom.Visible ? false : true;
            if (panelActionButtom.Visible) buttonActionButtom.Text = "▼";
            else buttonActionButtom.Text = "▲";
        }

        void paramProccessing()
        {
            // Name
            labelNameMethod.Text = perspective.name;
            labelNameMethod.ForeColor = perspective.colorText;

            buttonRun.ForeColor = perspective.colorText;

            panelActionButtomParam.Width = labelNameMethod.Width + 100;

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
            textBoxMaxStepCount.Text = perspective.xRight.ToString();
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
                panelActionButtomR.Visible = true;
                textBoxR.Text = perspective.r.ToString();
                textBoxR.BackColor = perspective.colorPanel;
                textBoxR.ForeColor = perspective.colorText;

                labelR.ForeColor = perspective.colorText;
                labelGuidanceR.ForeColor = perspective.colorText;
            }
            else
            {
                panelActionButtomR.Visible = false;
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
            textBoxZoomXBegin.Text = perspective.funcInfo.xMin.ToString();
            textBoxZoomXBegin.BackColor = perspective.colorPanel;
            textBoxZoomXBegin.ForeColor = perspective.colorText;

            // xZoomRight
            textBoxZoomXEnd.Text = perspective.funcInfo.xMax.ToString();
            textBoxZoomXEnd.BackColor = perspective.colorPanel;
            textBoxZoomXEnd.ForeColor = perspective.colorText;

            labelZoomXBegin.ForeColor = perspective.colorText;
            labelZoomXMid.ForeColor = perspective.colorText;
            labelZoomXEnd.ForeColor = perspective.colorText;

            // yZoomLeft
            textBoxZoomXBegin.Text = perspective.funcInfo.yMin.ToString();
            textBoxZoomYBegin.BackColor = perspective.colorPanel;
            textBoxZoomYBegin.ForeColor = perspective.colorText;

            // yZoomRight
            textBoxZoomXEnd.Text = perspective.funcInfo.yMax.ToString();
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
            var en = perspective.methodInfo.report.minimum.GetEnumerator();
            en.MoveNext();
            textBoxXMin.Text = en.Current.Key.ToString();
            textBoxXMin.BackColor = perspective.colorPanel;
            textBoxXMin.ForeColor = perspective.colorText;

            // yMin
            textBoxYMin.Text = en.Current.Value.ToString();
            textBoxYMin.BackColor = perspective.colorPanel;
            textBoxYMin.ForeColor = perspective.colorText;

            labelMinBegin.ForeColor = perspective.colorText;
            labelMinMid.ForeColor = perspective.colorText;
            labelMinEnd.ForeColor = perspective.colorText;
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
                runMethod.RunWorkerAsync();
            }

        }

        protected void cancelCurMethod()
        {
            buttonRun.Text = "RUN";
            runMethod.CancelAsync();
        }

        private void runMethod_DoWork(object sender, DoWorkEventArgs e)
        {
            //MethodInfo methodInfo;
            Func<double, double> func = x => Double.Parse(textBoxA.Text) * Math.Cos(Double.Parse(textBoxB.Text) * x)
                + Double.Parse(textBoxC.Text) * Math.Sin(Double.Parse(textBoxD.Text) * x);
            Method method = null;
            //System.Threading.Thread.Sleep(2000);
            runMethod.ReportProgress((int)status + 10);
            //System.Threading.Thread.Sleep(2000);
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
            //System.Threading.Thread.Sleep(2000);
            var report = method.solve(runMethod);
            status = 60;
            //System.Threading.Thread.Sleep(2000);

            if (!runMethod.CancellationPending)
            {
                FElem elem = new FElem();
                elem.function = func;
                elem.xLeft = perspective.xLeft;
                elem.xRight = perspective.xRight;
                GraphProcessing gp = new GraphProcessing();
                perspective.methodInfo.graphControl.GraphPane.CurveList.Clear();
                gp.drawFunction(perspective.methodInfo.graphControl, elem, perspective.colorLine, runMethod);
            }

            if (!runMethod.CancellationPending)
            {
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
                if (stage == "Solving" || stage == "Drawing") deposit = 0.25;
                status = remainder + e.ProgressPercentage * deposit;
                panelStatus.Width = (int)(panelButtom.Width * status * 0.01);
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
            buttonRun.Text = "RUN";
            labelStage.Visible = false;
            if (!runMethod.CancellationPending)
            {
                refreshActionPanel();
                zedGraphControlMain.Visible = true;
                zedGraphControlMain.GraphPane = perspective.methodInfo.graphControl.GraphPane;
                zedGraphControlMain.AxisChange();
                zedGraphControlMain.Dock = DockStyle.Fill;
                //zedGraphControlMain.Refresh();
            }
        }

        private void moveScales(PointF oldPoint, PointF newPoint)
        {
            var pane = zedGraphControlMain.GraphPane;

            var changeX = newPoint.X - oldPoint.X;
            var changeY = newPoint.Y - oldPoint.Y;

            pane.XAxis.Min -= changeX * 0.5;
            pane.XAxis.Max -= changeX * 0.5;

            pane.YAxis.Min -= changeY * 0.5;
            pane.YAxis.Max -= changeY * 0.5;
        }

        private void zoomScales(int delta, PointF curPoint)
        {
            var pane = zedGraphControlMain.GraphPane;
            delta = delta > 1000 ? 1000 : delta;

            var rX = (pane.XAxis.Max - pane.XAxis.Min) / 4;
            var rY = (pane.YAxis.Max - pane.YAxis.Min) / 4;

            pane.XAxis.Min += (curPoint.X - pane.XAxis.Min) * (delta * 0.001) / rX;
            pane.XAxis.Max -= (pane.XAxis.Max - curPoint.X) * (delta * 0.001) / rX;

            pane.YAxis.Min += (curPoint.Y - pane.YAxis.Min) * (delta * 0.001) / rY;
            pane.YAxis.Max -= (pane.YAxis.Max - curPoint.Y) * (delta * 0.001) / rY;
            zedGraphControlMain.AxisChange();
        }
    }
}
