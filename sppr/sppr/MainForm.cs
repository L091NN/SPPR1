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
            panelButtom.BackColor = style.colors["red.king yna"];
            panelButtomAnimation.RunWorkerAsync(new List<Color> { style.colors["red.king yna"], style.colors["yellow.king yna"], 
                style.colors["green.vs"], style.colors["blue.king yna"], style.colors["red.king yna"] });
        }

        private void button1_Click(object sender, EventArgs e)
        {
            checkErrorParam("");
            if (!panelRightAnimation.IsBusy && !panelActionButtomAnimation.IsBusy && !panelLeftAnimation.IsBusy && !panelHeaderAnimation.IsBusy)
            {
                panelRightAnimation.RunWorkerAsync(new List<Color> { panelRight.BackColor, panelHeader.BackColor });
                panelActionButtomAnimation.RunWorkerAsync(new List<Color> { panelActionButtom.BackColor, panelRight.BackColor });
                panelLeftAnimation.RunWorkerAsync(new List<Color> { panelLeft.BackColor, panelActionButtom.BackColor });
                panelHeaderAnimation.RunWorkerAsync(new List<Color> { panelHeader.BackColor, panelLeft.BackColor });
            }
            //refreshActionPanel();
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            labelNoData.Font = new System.Drawing.Font("Yu Gothic UI Semibold", (float)(Math.Sqrt(panelAction.Height * panelAction.Height + panelAction.Width * panelAction.Width) / 10), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            labelRecomendation.Font = new System.Drawing.Font("Yu Gothic UI Semibold", (float)(Math.Sqrt(panelAction.Height * panelAction.Height + panelAction.Width * panelAction.Width) / 20), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panelActionButtom.Size = new System.Drawing.Size(panelAction.Width, panelAction.Height / 5);
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
    }
}
