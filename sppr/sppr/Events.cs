using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace sppr
{
    class MethodInfo
    {
        public Method.Report report;
        public List<string> inputParam;
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
        public string name;
        public Color colorBack;
        public Color colorPanel;
        public Color colorText;
        public bool withE;
        public bool withR;
        public bool withPoint;
        public bool withLine;
        public double e;
        public double r;
        public double xLeft;
        public double xRight;
        public double a;
        public double b;
        public double c;
        public double d;
        public MethodInfo methodInfo; 

        public PerspectiveInfo(string _name, Color _colorBack, Color _colorPanel, Color _colorText, bool _withE, bool _withR, bool _withPoint, bool _withLine,
            double _e, double _r, double _xLeft, double _xRight, double _a, double _b, double _c, double _d)
        {
            name = _name;
            colorBack = _colorBack;
            colorPanel = _colorPanel;
            colorText = _colorText;
            withE = _withE;
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
        }
    }
    partial class MainForm
    {
        //Perspective perspective;
        PerspectiveInfo perspective;
        PerspectiveInfo bruteForce;
        PerspectiveInfo piacovsky;
        PerspectiveInfo strongin;

        protected void initPerspectives()
        {
            bruteForce = new PerspectiveInfo("Bruteforce", style.colors["black.vs"], style.colors["red.king yna"], style.colors["white.argon"],
                false, false, false, false, -1, -1, 0, 1, 1, 1, 1, 1);
            piacovsky = new PerspectiveInfo("Piyakovsky method", style.colors["black.vs"], style.colors["blue.king yna"], style.colors["white.argon"],
                true, true, false, false, 0.0001, 3, 0, 1, 1, 1, 1, 1);
            strongin = new PerspectiveInfo("Strongin method", style.colors["black.vs"], style.colors["yellow.king yna"], style.colors["black.argon"],
                true, true, false, false, 0.0001, 3, 0, 1, 1, 1, 1, 1);
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
            if (perspective.methodInfo == null)
            {
                //showNoData();
            }
            else
            {
                /// graph processing
            }


        }

        protected void showNoData()
        {
            labelNoData.Visible = true;
            labelRecomendation.Visible = true;
        }

        protected void hideNoData()
        {
            
        }

        protected void showHideActionButtomPanel()
        {
            panelActionButtom.Visible = panelActionButtom.Visible ? false : true;
            if (panelActionButtom.Visible) buttonActionButtom.Text = "▼";
            else buttonActionButtom.Text = "▲";
        }

        protected void proccessingPanelParam()
        {
            
        }
        protected void showBruteForceMethod()
        {
            
        }

        protected void hideBruteForceMethod()
        {
            
        }

        protected void showPiacovskyMethod()
        {

        }

        protected void hidePiacovskyMethod()
        {

        }

        protected void showStronginMethod()
        {

        }

        protected void hideStronginMethod()
        {

        }
        protected void createBottomActionPanel(Color backColor)
        {
            //if (panelAction.Controls.IndexOf(panelActionBottom) != -1) panelAction.Controls.Remove(panelActionBottom);
            //this.panelActionBottom = new System.Windows.Forms.Panel();
            //this.panelActionBottom.BackColor = backColor;
            //this.panelActionBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            //this.panelActionBottom.Location = new System.Drawing.Point(0, panelAction.Location.Y + panelAction.Height - panelAction.Height / 5);
            //this.panelActionBottom.Name = "panelActionBottom";
            //this.panelActionBottom.Size = new System.Drawing.Size(panelAction.Width, panelAction.Height / 5);
            //
            //panelAction.Controls.Add(panelActionBottom);
        }

    }
}
