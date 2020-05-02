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
            while (panelActionButtom.Height != over)
            {
                if (over > panelActionButtom.Height) worker.ReportProgress(1);
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
            //var red = (e.ProgressPercentage >> 16) & 255;
            //var green = (e.ProgressPercentage >> 8) & 255;
            //var blue = (e.ProgressPercentage >> 0) & 255;
            panelHeader.BackColor = Color.FromArgb(e.ProgressPercentage);
        }

        private void panelHeaderAnimation_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

        }

        private void panelButtomAnimation_DoWork(object sender, DoWorkEventArgs e)
        {
            while (true)
                changeColor((List<Color>)e.Argument, panelButtomAnimation);
        }

        private void panelButtomAnimation_ProgressChanged(object sender, ProgressChangedEventArgs e)
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

        private void panelActionButtomAnimation_DoWork(object sender, DoWorkEventArgs e)
        {
            changeColor((List<Color>)e.Argument, panelActionButtomAnimation, 11);
        }

        private void panelActionButtomAnimation_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            var color = Color.FromArgb(e.ProgressPercentage);
            panelActionButtom.BackColor = color;
            buttonActionButtom.BackColor = color;
            //textBoxA.BackColor = color;
            //textBoxB.BackColor = color;
            //textBoxC.BackColor = color;
            //textBoxD.BackColor = color;
            //textBoxXBegin.BackColor = color;
            //textBoxXEnd.BackColor = color;
            //textBoxR.BackColor = color;
            //textBoxE.BackColor = color;
        }

        private void panelActionButtomAnimation_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
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
            panelActionButtom.Height += e.ProgressPercentage;
        }

        private void panelCloser_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (panelButtom.Height == 0)
                panelActionButtom.Visible = false;
            else panelActionButtom.Visible = true;
        }

    }
}
