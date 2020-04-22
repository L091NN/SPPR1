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
            panelButtomAnimation.RunWorkerAsync(new List<Color> { style.colors["red.king yna"], style.colors["yellow.king yna"], 
                style.colors["green.vs"], style.colors["blue.king yna"], style.colors["red.king yna"] });
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
                if (!fillParam()) label1.Text = "ERROR: Incorrect input";
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
            if (!panelRightAnimation.IsBusy && !panelActionButtomAnimation.IsBusy && !panelLeftAnimation.IsBusy && !panelHeaderAnimation.IsBusy)
            {
                perspective = perspective == bruteForce ? strongin : perspective == piacovsky ? bruteForce : piacovsky;
                panelRightAnimation.RunWorkerAsync(new List<Color> { panelRight.BackColor, panelActionButtom.BackColor });
                panelActionButtomAnimation.RunWorkerAsync(new List<Color> { panelActionButtom.BackColor, panelLeft.BackColor });
                panelLeftAnimation.RunWorkerAsync(new List<Color> { panelLeft.BackColor, panelRight.BackColor });
                refreshActionPanel();
                //panelHeaderAnimation.RunWorkerAsync(new List<Color> { panelHeader.BackColor, panelRight.BackColor });
            }
        }

        private void buttonChangePerspectiveRight_Click(object sender, EventArgs e)
        {
            if (!panelRightAnimation.IsBusy && !panelActionButtomAnimation.IsBusy && !panelLeftAnimation.IsBusy && !panelHeaderAnimation.IsBusy)
            {
                perspective = perspective == bruteForce ? piacovsky : perspective == piacovsky ? strongin : bruteForce;
                panelRightAnimation.RunWorkerAsync(new List<Color> { panelRight.BackColor, panelLeft.BackColor });
                panelActionButtomAnimation.RunWorkerAsync(new List<Color> { panelActionButtom.BackColor, panelRight.BackColor });
                panelLeftAnimation.RunWorkerAsync(new List<Color> { panelLeft.BackColor, panelActionButtom.BackColor });
                //panelHeaderAnimation.RunWorkerAsync(new List<Color> { panelHeader.BackColor, panelLeft.BackColor });
                refreshActionPanel();
            }
        }

        private void textBoxA_TextChanged(object sender, EventArgs e)
        {
            if (((TextBox)sender).Text.Length < 6)
            ((TextBox)sender).Width = ((TextBox)sender).Text.Length * 8 + 8;
            var widthOfCurFunc = widthOfFunc();
            if (widthOfCurFunc > panelActionButtomParam.Width)
                panelActionButtomParam.Width = widthOfCurFunc;
        }

        private void buttonChangePerspectiveRight_MouseMove(object sender, MouseEventArgs e)
        {
            if (perspective.name == "Bruteforce") buttonChangePerspectiveRight.Text = "Piacovsky ▶";
            if (perspective.name == "Piyakovsky method") buttonChangePerspectiveRight.Text = "Strongin ▶";
            if (perspective.name == "Strongin method") buttonChangePerspectiveRight.Text = "Bruteforce ▶";
        }

        private void buttonChangePerspectiveRight_MouseLeave(object sender, EventArgs e)
        {
            buttonChangePerspectiveRight.Text = "▶";
        }
    }
}
