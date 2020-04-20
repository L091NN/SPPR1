namespace sppr
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelDown = new System.Windows.Forms.Panel();
            this.pbSolve = new System.Windows.Forms.ProgressBar();
            this.buttonTest = new System.Windows.Forms.Button();
            this.bwStatus = new System.ComponentModel.BackgroundWorker();
            this.zedGraphControl1 = new ZedGraph.ZedGraphControl();
            this.panelHead = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelDown.SuspendLayout();
            this.panelHead.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelDown
            // 
            this.panelDown.Controls.Add(this.pbSolve);
            this.panelDown.Controls.Add(this.buttonTest);
            this.panelDown.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelDown.Location = new System.Drawing.Point(0, 1005);
            this.panelDown.Name = "panelDown";
            this.panelDown.Size = new System.Drawing.Size(1745, 20);
            this.panelDown.TabIndex = 2;
            // 
            // pbSolve
            // 
            this.pbSolve.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbSolve.Location = new System.Drawing.Point(75, 0);
            this.pbSolve.Name = "pbSolve";
            this.pbSolve.Size = new System.Drawing.Size(1670, 20);
            this.pbSolve.TabIndex = 0;
            // 
            // buttonTest
            // 
            this.buttonTest.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonTest.Location = new System.Drawing.Point(0, 0);
            this.buttonTest.Name = "buttonTest";
            this.buttonTest.Size = new System.Drawing.Size(75, 20);
            this.buttonTest.TabIndex = 1;
            this.buttonTest.Text = "Test";
            this.buttonTest.UseVisualStyleBackColor = true;
            this.buttonTest.Click += new System.EventHandler(this.buttonTest_Click);
            // 
            // bwStatus
            // 
            this.bwStatus.WorkerReportsProgress = true;
            this.bwStatus.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwStatus_DoWork);
            this.bwStatus.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bwStatus_ProgressChanged);
            this.bwStatus.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bwStatus_RunWorkerCompleted);
            // 
            // zedGraphControl1
            // 
            this.zedGraphControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.zedGraphControl1.IsShowPointValues = false;
            this.zedGraphControl1.Location = new System.Drawing.Point(0, 0);
            this.zedGraphControl1.Name = "zedGraphControl1";
            this.zedGraphControl1.PointValueFormat = "G";
            this.zedGraphControl1.Size = new System.Drawing.Size(1745, 1005);
            this.zedGraphControl1.TabIndex = 1;
            // 
            // panelHead
            // 
            this.panelHead.Controls.Add(this.label1);
            this.panelHead.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHead.Location = new System.Drawing.Point(0, 0);
            this.panelHead.Name = "panelHead";
            this.panelHead.Size = new System.Drawing.Size(1745, 100);
            this.panelHead.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1745, 1025);
            this.Controls.Add(this.panelHead);
            this.Controls.Add(this.zedGraphControl1);
            this.Controls.Add(this.panelDown);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panelDown.ResumeLayout(false);
            this.panelHead.ResumeLayout(false);
            this.panelHead.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelDown;
        private System.ComponentModel.BackgroundWorker bwStatus;
        private System.Windows.Forms.Button buttonTest;
        private System.Windows.Forms.ProgressBar pbSolve;
        private ZedGraph.ZedGraphControl zedGraphControl1;
        private System.Windows.Forms.Panel panelHead;
        private System.Windows.Forms.Label label1;
    }
}

