using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.ComponentModel;

namespace sppr
{
    partial class MainForm
    {
        Style style;
        public int RGBtoInt(int r, int g, int b)
        {
            return 255 << 24 | (r << 16) | (g << 8) | (b << 0);
        }

        public Color invert(Color c)
        {
            return Color.FromArgb(255 - c.R, 255 - c.G, 255 - c.B);
        }

        private void changeColor(List<Color> colors, BackgroundWorker worker, int sleep = 5)
        {
            var color = colors.GetEnumerator();
            color.MoveNext();
            var curColor = color.Current;
            for (; color.MoveNext();)
            {
                while (curColor != color.Current)
                {
                    int R, G, B;
                    if (curColor.R != color.Current.R)
                    {
                        if (curColor.R > color.Current.R) R = curColor.R - 1;
                        else R = curColor.R + 1;
                    }
                    else R = curColor.R;

                    if (curColor.G != color.Current.G)
                    {
                        if (curColor.G > color.Current.G) G = curColor.G - 1;
                        else G = curColor.G + 1;
                    }
                    else G = curColor.G;

                    if (curColor.B != color.Current.B)
                    {
                        if (curColor.B > color.Current.B) B = curColor.B - 1;
                        else B = curColor.B + 1;
                    }
                    else B = curColor.B;

                    curColor = Color.FromArgb(R, G, B);

                    worker.ReportProgress(RGBtoInt(R, G, B));

                    System.Threading.Thread.Sleep(sleep);

                }
            }
        }

        private void panelMove(BackgroundWorker worker, int over, int sleep = 5)
        {
            while (panelActionBottom.Height != over)
            {
                if (over > panelActionBottom.Height) worker.ReportProgress(1);
                else worker.ReportProgress(-1);
                System.Threading.Thread.Sleep(sleep);
            }
        }

        private void panelHeaderAnimation_DoWork(object sender, DoWorkEventArgs e)
        {
            changeColor((List<Color>)e.Argument, panelHeaderAnimation, 11);
        }

        private void panelHeaderAnimation_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            panelHeader.BackColor = Color.FromArgb(e.ProgressPercentage);
        }

        private void panelHeaderAnimation_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

        }

        private void panelBottomAnimation_DoWork(object sender, DoWorkEventArgs e)
        {
            while (!panelBottomAnimation.CancellationPending)
                changeColor((List<Color>)e.Argument, panelBottomAnimation);
        }

        private void panelBottomAnimation_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            panelStatus.BackColor = Color.FromArgb(e.ProgressPercentage);
        }

        private void panelLeftAnimation_DoWork(object sender, DoWorkEventArgs e)
        {
            changeColor((List<Color>)e.Argument, panelLeftAnimation, 11);
        }

        private void panelLeftAnimation_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            panelLeft.BackColor = Color.FromArgb(e.ProgressPercentage);
        }

        private void panelLeftAnimation_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

        }

        private void panelRightAnimation_DoWork(object sender, DoWorkEventArgs e)
        {
            changeColor((List<Color>)e.Argument, panelRightAnimation, 11);
        }

        private void panelRightAnimation_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            panelRight.BackColor = Color.FromArgb(e.ProgressPercentage);
        }

        private void panelRightAnimation_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

        }

        private void panelActionBottomAnimation_DoWork(object sender, DoWorkEventArgs e)
        {
            changeColor((List<Color>)e.Argument, panelActionBottomAnimation, 11);
        }

        private void panelActionBottomAnimation_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            var color = Color.FromArgb(e.ProgressPercentage);
            panelActionBottom.BackColor = color;
            buttonActionBottom.BackColor = color;
            //textBoxA.BackColor = color;
            //textBoxB.BackColor = color;
            //textBoxC.BackColor = color;
            //textBoxD.BackColor = color;
            //textBoxXBegin.BackColor = color;
            //textBoxXEnd.BackColor = color;
            //textBoxR.BackColor = color;
            //textBoxE.BackColor = color;
        }

        private void panelActionBottomAnimation_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

        }

        private void TextAnimation_DoWork(object sender, DoWorkEventArgs e)
        {
            changeColor((List<Color>)e.Argument, TextAnimation);
        }

        private void TextAnimation_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            labelNameMethod.ForeColor = Color.FromArgb(e.ProgressPercentage);
        }

        private void TextAnimation_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

        }

        private void panelCloser_DoWork(object sender, DoWorkEventArgs e)
        {
            panelMove(panelCloser, (int)e.Argument); 
        }

        private void panelCloser_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            panelActionBottom.Height += e.ProgressPercentage;
        }

        private void panelCloser_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (panelBottom.Height == 0)
                panelActionBottom.Visible = false;
            else panelActionBottom.Visible = true;
        }

        int conStage;
        List<string> conLog;
        bool isCon;
        
        private void Conami_DoWork(object sender, DoWorkEventArgs e)
        {
            while (!Conami.CancellationPending)
            {
                System.Threading.Thread.Sleep(500);
                Conami.ReportProgress(1);
            }
        }

        private void Conami_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            List<string> scenar10 = new List<string>() { "Up&Down", "Up&Down", "Up&Down", "Up&Down", "Left", "Right", "Left", "Right", "SortX", "SortY", "Strat" };
            if (conStage == 10) buttonRun.Text = "START";
            if (conStage == 11) Conami.CancelAsync();
            foreach (var click in conLog)
            {
                conStage = click == scenar10[conStage] ? conStage + 1 : 0; 
            }
            conLog.Clear();
        }

        private void Conami_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            isCon = true;
            closeDoors();
            fallRoof();
            ButtomUp();

            captions();
            System.Windows.Forms.Application.Exit();
        }

        private void closeDoors()
        {
            panelAction.Visible = false;
            var step = this.Size.Width / 64;
            while (panelLeft.Location.X + panelLeft.Size.Width < panelRight.Location.X)
            {
                panelRight.Width += step;
                buttonChangePerspectiveLeft.Width += step;
                panelLeft.Width += step;
                buttonChangePerspectiveRight.Width += step;
                panelActionHideBottom.Height += step;
                panelLeft.Refresh();
                panelRight.Refresh();
                panelAction.Refresh();
            }

        }

        private void fallRoof()
        {
            var step = this.Size.Height / 64;
            while (panelHeader.Height < panelBottom.Location.Y)
            {
                panelHeader.Height += step;
                panelHeader.Refresh();
            }

        }

        private void ButtomUp()
        {
            panelBottom.BackColor = style.colors["black.vs"];
            var step = this.Size.Height / 64;
            while (panelBottom.Height < this.Size.Height)
            {
                panelBottom.Height += step;
                panelBottom.Refresh();
            }
            panelHeader.Visible = false;
            panelLeft.Visible = false;
            panelRight.Visible = false;
            panelBottom.Dock = System.Windows.Forms.DockStyle.Fill;
        }

        private void captions()
        {
            System.Threading.Thread.Sleep(1000);

            labelTheEnd.Location = new Point(this.Size.Width / 2, this.Size.Height / 2);
            labelTheEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 0.05f * panelBottom.Width, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            labelTheEnd.Visible = true;

            labelTheEnd.Text = "Developed by\nLugin Mikhail\n381703-3";
            labelTheEnd.Location = new Point(this.Size.Width / 2 - labelTheEnd.Width / 2, this.Size.Height / 2 - labelTheEnd.Height / 2);
            labelTheEnd.Refresh();

            System.Threading.Thread.Sleep(5000);
            labelTheEnd.Text = "";
            labelTheEnd.Refresh();

            System.Threading.Thread.Sleep(1000);
            labelTheEnd.Text = "Developed by\nTrubina Anastasia\n381606-3";
            labelTheEnd.Location = new Point(this.Size.Width / 2 - labelTheEnd.Width / 2, this.Size.Height / 2 - labelTheEnd.Height / 2);
            labelTheEnd.Refresh();

            System.Threading.Thread.Sleep(5000);
            labelTheEnd.Text = "";
            labelTheEnd.Refresh();

            System.Threading.Thread.Sleep(1000);
            labelTheEnd.Text = "Lobachevsky\nApril-May 2020";
            labelTheEnd.Location = new Point(this.Size.Width / 2 - labelTheEnd.Width / 2, this.Size.Height / 2 - labelTheEnd.Height / 2);
            labelTheEnd.Refresh();

            System.Threading.Thread.Sleep(5000);
            labelTheEnd.Text = "Thanks";
            labelTheEnd.Location = new Point(this.Size.Width / 2 - labelTheEnd.Width / 2, this.Size.Height / 2 - labelTheEnd.Height / 2);
            labelTheEnd.Refresh();

            System.Threading.Thread.Sleep(1000);
        }

    }
}
