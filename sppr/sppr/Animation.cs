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

        private void changePanelColor(List<Color> colors, BackgroundWorker worker, int sleep = 5)
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

                    worker.ReportProgress(curColor.R + curColor.G * 256 + curColor.B * 256 * 256);

                    System.Threading.Thread.Sleep(sleep);

                }
            }
        }

        private void panelHeaderAnimation_DoWork(object sender, DoWorkEventArgs e)
        {
            changePanelColor((List<Color>)e.Argument, panelHeaderAnimation, 50);
        }

        private void panelHeaderAnimation_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            int B = e.ProgressPercentage / (256 * 256);
            int G = (e.ProgressPercentage % (256 * 256)) / 256;
            int R = e.ProgressPercentage % 256;
            panelHeader.BackColor = Color.FromArgb(R, G, B);
        }

        private void panelHeaderAnimation_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

        }

        private void panelButtomAnimation_DoWork(object sender, DoWorkEventArgs e)
        {
            while (true)
            changePanelColor((List<Color>)e.Argument, panelButtomAnimation);
        }

        private void panelButtomAnimation_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            int B = e.ProgressPercentage / (256 * 256);
            int G = (e.ProgressPercentage % (256 * 256)) / 256;
            int R = e.ProgressPercentage % 256;
            panelButtom.BackColor = Color.FromArgb(R, G, B);
        }

        private void panelLeftAnimation_DoWork(object sender, DoWorkEventArgs e)
        {
            changePanelColor((List<Color>)e.Argument, panelLeftAnimation, 50);
        }

        private void panelLeftAnimation_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            int B = e.ProgressPercentage / (256 * 256);
            int G = (e.ProgressPercentage % (256 * 256)) / 256;
            int R = e.ProgressPercentage % 256;
            panelLeft.BackColor = Color.FromArgb(R, G, B);
        }

        private void panelLeftAnimation_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

        }

        private void panelRightAnimation_DoWork(object sender, DoWorkEventArgs e)
        {
            changePanelColor((List<Color>)e.Argument, panelRightAnimation, 50);
        }

        private void panelRightAnimation_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            int B = e.ProgressPercentage / (256 * 256);
            int G = (e.ProgressPercentage % (256 * 256)) / 256;
            int R = e.ProgressPercentage % 256;
            panelRight.BackColor = Color.FromArgb(R, G, B);
        }

        private void panelRightAnimation_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

        }

        private void panelActionButtomAnimation_DoWork(object sender, DoWorkEventArgs e)
        {
            changePanelColor((List<Color>)e.Argument, panelActionButtomAnimation, 50);
        }

        private void panelActionButtomAnimation_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            int B = e.ProgressPercentage / (256 * 256);
            int G = (e.ProgressPercentage % (256 * 256)) / 256;
            int R = e.ProgressPercentage % 256;
            panelActionButtom.BackColor = Color.FromArgb(R, G, B);
            buttonActionButtom.BackColor = Color.FromArgb(R, G, B);
        }

        private void panelActionButtomAnimation_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

        }

    }
}
