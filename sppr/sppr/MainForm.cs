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
            initPerspectives();
            refreshActionPanel();
            //panelButtom.BackColor = style.colors["red.king yna"];
            //panelButtomAnimation.RunWorkerAsync(new List<Color> { style.colors["red.king yna"], style.colors["yellow.king yna"], 
                //style.colors["green.vs"], style.colors["blue.king yna"], style.colors["red.king yna"] });
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            labelNoData.Font = new System.Drawing.Font("Yu Gothic UI Semibold", (float)(Math.Sqrt(panelAction.Height * panelAction.Height + panelAction.Width * panelAction.Width) / 10), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            labelRecomendation.Font = new System.Drawing.Font("Yu Gothic UI Semibold", (float)(Math.Sqrt(panelAction.Height * panelAction.Height + panelAction.Width * panelAction.Width) / 20), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));

            this.panelActionButtom.Size = new System.Drawing.Size(panelAction.Width, widthOfFunc());
        }

        private void buttonActionButtom_Click(object sender, EventArgs e)
        {
            showHideActionButtomPanel();
        }

        private void panelActionButtomR_MouseMove(object sender, MouseEventArgs e)
        {
            labelGuidanceR.Visible = true;
        }

        private void panelActionButtomR_MouseLeave(object sender, EventArgs e)
        {
            labelGuidanceR.Visible = false;
        }

        private void panelActionButtomE_MouseMove(object sender, MouseEventArgs e)
        {
            labelGuidanceE.Visible = true;
        }

        private void panelActionButtomE_MouseLeave(object sender, EventArgs e)
        {
            labelGuidanceE.Visible = false;
        }

        private void buttonRun_Click(object sender, EventArgs e)
        {
            if (buttonRun.Text == "RUN")
            {
                if (!tryFillParam()) ; //label1.Text = "ERROR: Incorrect input";
                else
                {
                    runCurMethod();
                }
            }
            else if (buttonRun.Text == "CANCEL")
            {
                cancelCurMethod();
            }
            

            
        }

        private void buttonChangePerspectiveLeft_Click(object sender, EventArgs e)
        {
            if (!panelRightAnimation.IsBusy && !panelActionButtomAnimation.IsBusy && !panelLeftAnimation.IsBusy && !panelHeaderAnimation.IsBusy && !runMethod.IsBusy)
            {
                perspective = perspective == bruteForce ? strongin : perspective == piacovsky ? bruteForce : piacovsky;
                //panelRightAnimation.RunWorkerAsync(new List<Color> { panelRight.BackColor, panelActionButtom.BackColor });
                //panelActionButtomAnimation.RunWorkerAsync(new List<Color> { panelActionButtom.BackColor, panelLeft.BackColor });
                //panelLeftAnimation.RunWorkerAsync(new List<Color> { panelLeft.BackColor, panelRight.BackColor });
                //panelHeaderAnimation.RunWorkerAsync(new List<Color> { panelHeader.BackColor, panelRight.BackColor });
                refreshActionPanel();
            }
        }

        private void buttonChangePerspectiveRight_Click(object sender, EventArgs e)
        {
            if (!panelRightAnimation.IsBusy && !panelActionButtomAnimation.IsBusy && !panelLeftAnimation.IsBusy && !panelHeaderAnimation.IsBusy && !runMethod.IsBusy)
            {
                perspective = perspective == bruteForce ? piacovsky : perspective == piacovsky ? strongin : bruteForce;
                //panelRightAnimation.RunWorkerAsync(new List<Color> { panelRight.BackColor, panelLeft.BackColor });
                //panelActionButtomAnimation.RunWorkerAsync(new List<Color> { panelActionButtom.BackColor, panelRight.BackColor });
                //panelLeftAnimation.RunWorkerAsync(new List<Color> { panelLeft.BackColor, panelActionButtom.BackColor });
                //panelHeaderAnimation.RunWorkerAsync(new List<Color> { panelHeader.BackColor, panelLeft.BackColor });
                refreshActionPanel();
            }
        }

        private void textBoxA_TextChanged(object sender, EventArgs e)
        {
            if (((TextBox)sender).Text.Length > 5)
                ((TextBox)sender).Text = ((TextBox)sender).Text.Substring(0, 6);
            ((TextBox)sender).Width = ((TextBox)sender).Text.Length * 8 + 10;
            var widthOfCurFunc = widthOfFunc();
            if (widthOfCurFunc > panelActionButtomParam.Width)
                panelActionButtomParam.Width = widthOfCurFunc;
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

        }

        private void buttonWithPoints_Click(object sender, EventArgs e)
        {
            perspective.withPoint = perspective.withPoint ? false : true;
            resultProccessing();
        }

        private void buttonWithLine_Click(object sender, EventArgs e)
        {
            perspective.withLine = perspective.withLine ? false : true;
            resultProccessing();
        }
    }
}
