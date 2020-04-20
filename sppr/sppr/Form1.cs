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
    public partial class Form1 : Form
    {
        FElem elem;
        GraphProcessing gp;
        Method.Report result;
        public Form1()
        {
            InitializeComponent();
            elem = new FElem();
            gp = new GraphProcessing();
            label1.Text = "";
        }

        private void bwStatus_DoWork(object sender, DoWorkEventArgs e)
        {
            result = ((Method)e.Argument).solve(bwStatus);
            //if (bwStatus.CancellationPending != true);
        }

        private void bwStatus_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            pbSolve.Value = e.ProgressPercentage;
        }

        private void bwStatus_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (!e.Cancelled)
            {
            }
            pbSolve.Value = 0;
            gp.drawFunction(zedGraphControl1, elem);
            gp.drawVerticalLine(zedGraphControl1, result.iterations);
            foreach (var res in result.minimum)
            {
                label1.Text += "(" + res.Key.ToString() + "," + res.Value.ToString() + ")";
            }
            label1.Text += result.onStep.ToString() + "\\" + result.ofStep.ToString(); 
        }

        private void buttonTest_Click(object sender, EventArgs e)
        {
            double ca = 1.0f;
            elem.function = x => -(2 * Math.Sin(10 * x) + Math.Cos(x * x * x));
            elem.xLeft = -3.0f;
            elem.xRight = 3.0f;
            Method strong = new Strongin(elem.function, elem.xLeft, elem.xRight, 10000, 1e-5, 5);
            bwStatus.RunWorkerAsync(strong);
        }
    }
}
