namespace sppr
{
    partial class MainForm
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
            this.panelHeader = new System.Windows.Forms.Panel();
            this.panelButtom = new System.Windows.Forms.Panel();
            this.panelStatus = new System.Windows.Forms.Panel();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.buttonChangePerspectiveLeft = new System.Windows.Forms.Button();
            this.panelRight = new System.Windows.Forms.Panel();
            this.buttonChangePerspectiveRight = new System.Windows.Forms.Button();
            this.panelAction = new System.Windows.Forms.Panel();
            this.labelStage = new System.Windows.Forms.Label();
            this.zedGraphControlMain = new ZedGraph.ZedGraphControl();
            this.panelActionHideButtom = new System.Windows.Forms.Panel();
            this.buttonActionButtom = new System.Windows.Forms.Button();
            this.panelActionButtom = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelActionButtomParam = new System.Windows.Forms.Panel();
            this.panelActionButtomE = new System.Windows.Forms.Panel();
            this.labelGuidanceE = new System.Windows.Forms.Label();
            this.textBoxE = new System.Windows.Forms.TextBox();
            this.labelE = new System.Windows.Forms.Label();
            this.panelActionButtomR = new System.Windows.Forms.Panel();
            this.labelGuidanceR = new System.Windows.Forms.Label();
            this.textBoxR = new System.Windows.Forms.TextBox();
            this.labelR = new System.Windows.Forms.Label();
            this.panelActionButtomRegion = new System.Windows.Forms.Panel();
            this.labelRegionEnd = new System.Windows.Forms.Label();
            this.textBoxXEnd = new System.Windows.Forms.TextBox();
            this.labelZpt = new System.Windows.Forms.Label();
            this.textBoxXBegin = new System.Windows.Forms.TextBox();
            this.labelRegionBegin = new System.Windows.Forms.Label();
            this.panelActionButtomParamFunc = new System.Windows.Forms.Panel();
            this.labelSinEnd = new System.Windows.Forms.Label();
            this.textBoxD = new System.Windows.Forms.TextBox();
            this.labelSinBegin = new System.Windows.Forms.Label();
            this.textBoxC = new System.Windows.Forms.TextBox();
            this.labelCosEnd = new System.Windows.Forms.Label();
            this.textBoxB = new System.Windows.Forms.TextBox();
            this.labelCosBegin = new System.Windows.Forms.Label();
            this.textBoxA = new System.Windows.Forms.TextBox();
            this.labelFunc = new System.Windows.Forms.Label();
            this.panelFuncBegin = new System.Windows.Forms.Panel();
            this.panelActionRun = new System.Windows.Forms.Panel();
            this.buttonRun = new System.Windows.Forms.Button();
            this.labelNameMethod = new System.Windows.Forms.Label();
            this.labelRecomendation = new System.Windows.Forms.Label();
            this.labelNoData = new System.Windows.Forms.Label();
            this.panelButtomAnimation = new System.ComponentModel.BackgroundWorker();
            this.panelLeftAnimation = new System.ComponentModel.BackgroundWorker();
            this.panelRightAnimation = new System.ComponentModel.BackgroundWorker();
            this.panelActionButtomAnimation = new System.ComponentModel.BackgroundWorker();
            this.panelHeaderAnimation = new System.ComponentModel.BackgroundWorker();
            this.TextAnimation = new System.ComponentModel.BackgroundWorker();
            this.panelCloser = new System.ComponentModel.BackgroundWorker();
            this.runMethod = new System.ComponentModel.BackgroundWorker();
            this.panelButtom.SuspendLayout();
            this.panelLeft.SuspendLayout();
            this.panelRight.SuspendLayout();
            this.panelAction.SuspendLayout();
            this.panelActionHideButtom.SuspendLayout();
            this.panelActionButtom.SuspendLayout();
            this.panelActionButtomParam.SuspendLayout();
            this.panelActionButtomE.SuspendLayout();
            this.panelActionButtomR.SuspendLayout();
            this.panelActionButtomRegion.SuspendLayout();
            this.panelActionButtomParamFunc.SuspendLayout();
            this.panelActionRun.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(209)))), ((int)(((byte)(132)))));
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1264, 50);
            this.panelHeader.TabIndex = 4;
            // 
            // panelButtom
            // 
            this.panelButtom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(0)))), ((int)(((byte)(30)))));
            this.panelButtom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelButtom.Controls.Add(this.panelStatus);
            this.panelButtom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelButtom.Location = new System.Drawing.Point(0, 651);
            this.panelButtom.Name = "panelButtom";
            this.panelButtom.Size = new System.Drawing.Size(1264, 30);
            this.panelButtom.TabIndex = 3;
            // 
            // panelStatus
            // 
            this.panelStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelStatus.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelStatus.Location = new System.Drawing.Point(0, 0);
            this.panelStatus.Name = "panelStatus";
            this.panelStatus.Size = new System.Drawing.Size(0, 28);
            this.panelStatus.TabIndex = 0;
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(187)))), ((int)(((byte)(45)))));
            this.panelLeft.Controls.Add(this.buttonChangePerspectiveLeft);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 50);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(70, 601);
            this.panelLeft.TabIndex = 2;
            // 
            // buttonChangePerspectiveLeft
            // 
            this.buttonChangePerspectiveLeft.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonChangePerspectiveLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonChangePerspectiveLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonChangePerspectiveLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonChangePerspectiveLeft.Location = new System.Drawing.Point(0, 0);
            this.buttonChangePerspectiveLeft.Name = "buttonChangePerspectiveLeft";
            this.buttonChangePerspectiveLeft.Size = new System.Drawing.Size(70, 601);
            this.buttonChangePerspectiveLeft.TabIndex = 0;
            this.buttonChangePerspectiveLeft.TabStop = false;
            this.buttonChangePerspectiveLeft.Text = "◀";
            this.buttonChangePerspectiveLeft.UseVisualStyleBackColor = true;
            this.buttonChangePerspectiveLeft.Click += new System.EventHandler(this.buttonChangePerspectiveLeft_Click);
            // 
            // panelRight
            // 
            this.panelRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(42)))), ((int)(((byte)(108)))));
            this.panelRight.Controls.Add(this.buttonChangePerspectiveRight);
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelRight.Location = new System.Drawing.Point(1194, 50);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(70, 601);
            this.panelRight.TabIndex = 1;
            // 
            // buttonChangePerspectiveRight
            // 
            this.buttonChangePerspectiveRight.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonChangePerspectiveRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonChangePerspectiveRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonChangePerspectiveRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonChangePerspectiveRight.Location = new System.Drawing.Point(0, 0);
            this.buttonChangePerspectiveRight.Name = "buttonChangePerspectiveRight";
            this.buttonChangePerspectiveRight.Size = new System.Drawing.Size(70, 601);
            this.buttonChangePerspectiveRight.TabIndex = 0;
            this.buttonChangePerspectiveRight.TabStop = false;
            this.buttonChangePerspectiveRight.Text = "▶";
            this.buttonChangePerspectiveRight.UseVisualStyleBackColor = true;
            this.buttonChangePerspectiveRight.Click += new System.EventHandler(this.buttonChangePerspectiveRight_Click);
            this.buttonChangePerspectiveRight.MouseLeave += new System.EventHandler(this.buttonChangePerspectiveRight_MouseLeave);
            this.buttonChangePerspectiveRight.MouseMove += new System.Windows.Forms.MouseEventHandler(this.buttonChangePerspectiveRight_MouseMove);
            // 
            // panelAction
            // 
            this.panelAction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.panelAction.Controls.Add(this.labelStage);
            this.panelAction.Controls.Add(this.zedGraphControlMain);
            this.panelAction.Controls.Add(this.panelActionHideButtom);
            this.panelAction.Controls.Add(this.panelActionButtom);
            this.panelAction.Controls.Add(this.labelRecomendation);
            this.panelAction.Controls.Add(this.labelNoData);
            this.panelAction.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAction.Location = new System.Drawing.Point(70, 50);
            this.panelAction.Name = "panelAction";
            this.panelAction.Size = new System.Drawing.Size(1124, 601);
            this.panelAction.TabIndex = 0;
            // 
            // labelStage
            // 
            this.labelStage.AutoSize = true;
            this.labelStage.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelStage.Font = new System.Drawing.Font("Microsoft Sans Serif", 75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelStage.ForeColor = System.Drawing.SystemColors.Control;
            this.labelStage.Location = new System.Drawing.Point(0, 339);
            this.labelStage.Name = "labelStage";
            this.labelStage.Size = new System.Drawing.Size(890, 113);
            this.labelStage.TabIndex = 5;
            this.labelStage.Text = "Please run method";
            this.labelStage.Visible = false;
            // 
            // zedGraphControlMain
            // 
            this.zedGraphControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.zedGraphControlMain.IsShowPointValues = false;
            this.zedGraphControlMain.Location = new System.Drawing.Point(0, 339);
            this.zedGraphControlMain.Name = "zedGraphControlMain";
            this.zedGraphControlMain.PointValueFormat = "G";
            this.zedGraphControlMain.Size = new System.Drawing.Size(1124, 36);
            this.zedGraphControlMain.TabIndex = 4;
            this.zedGraphControlMain.Visible = false;
            // 
            // panelActionHideButtom
            // 
            this.panelActionHideButtom.Controls.Add(this.buttonActionButtom);
            this.panelActionHideButtom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelActionHideButtom.Location = new System.Drawing.Point(0, 375);
            this.panelActionHideButtom.Name = "panelActionHideButtom";
            this.panelActionHideButtom.Size = new System.Drawing.Size(1124, 26);
            this.panelActionHideButtom.TabIndex = 0;
            // 
            // buttonActionButtom
            // 
            this.buttonActionButtom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonActionButtom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonActionButtom.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonActionButtom.FlatAppearance.BorderSize = 0;
            this.buttonActionButtom.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.buttonActionButtom.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.buttonActionButtom.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonActionButtom.Location = new System.Drawing.Point(0, 0);
            this.buttonActionButtom.Name = "buttonActionButtom";
            this.buttonActionButtom.Size = new System.Drawing.Size(1124, 26);
            this.buttonActionButtom.TabIndex = 0;
            this.buttonActionButtom.TabStop = false;
            this.buttonActionButtom.Text = "▼";
            this.buttonActionButtom.UseVisualStyleBackColor = true;
            this.buttonActionButtom.Click += new System.EventHandler(this.buttonActionButtom_Click);
            // 
            // panelActionButtom
            // 
            this.panelActionButtom.Controls.Add(this.label1);
            this.panelActionButtom.Controls.Add(this.panelActionButtomParam);
            this.panelActionButtom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelActionButtom.Location = new System.Drawing.Point(0, 401);
            this.panelActionButtom.Name = "panelActionButtom";
            this.panelActionButtom.Size = new System.Drawing.Size(1124, 200);
            this.panelActionButtom.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(250, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // panelActionButtomParam
            // 
            this.panelActionButtomParam.Controls.Add(this.panelActionButtomE);
            this.panelActionButtomParam.Controls.Add(this.panelActionButtomR);
            this.panelActionButtomParam.Controls.Add(this.panelActionButtomRegion);
            this.panelActionButtomParam.Controls.Add(this.panelActionButtomParamFunc);
            this.panelActionButtomParam.Controls.Add(this.panelActionRun);
            this.panelActionButtomParam.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelActionButtomParam.Location = new System.Drawing.Point(0, 0);
            this.panelActionButtomParam.Name = "panelActionButtomParam";
            this.panelActionButtomParam.Size = new System.Drawing.Size(250, 200);
            this.panelActionButtomParam.TabIndex = 0;
            // 
            // panelActionButtomE
            // 
            this.panelActionButtomE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelActionButtomE.Controls.Add(this.labelGuidanceE);
            this.panelActionButtomE.Controls.Add(this.textBoxE);
            this.panelActionButtomE.Controls.Add(this.labelE);
            this.panelActionButtomE.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelActionButtomE.Location = new System.Drawing.Point(0, 120);
            this.panelActionButtomE.Name = "panelActionButtomE";
            this.panelActionButtomE.Size = new System.Drawing.Size(250, 30);
            this.panelActionButtomE.TabIndex = 4;
            this.panelActionButtomE.MouseLeave += new System.EventHandler(this.panelActionButtomE_MouseLeave);
            this.panelActionButtomE.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelActionButtomE_MouseMove);
            // 
            // labelGuidanceE
            // 
            this.labelGuidanceE.AutoSize = true;
            this.labelGuidanceE.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelGuidanceE.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelGuidanceE.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelGuidanceE.Location = new System.Drawing.Point(45, 0);
            this.labelGuidanceE.Name = "labelGuidanceE";
            this.labelGuidanceE.Size = new System.Drawing.Size(94, 18);
            this.labelGuidanceE.TabIndex = 2;
            this.labelGuidanceE.Text = "Method error";
            // 
            // textBoxE
            // 
            this.textBoxE.BackColor = System.Drawing.SystemColors.MenuText;
            this.textBoxE.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxE.Dock = System.Windows.Forms.DockStyle.Left;
            this.textBoxE.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxE.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBoxE.Location = new System.Drawing.Point(33, 0);
            this.textBoxE.Name = "textBoxE";
            this.textBoxE.Size = new System.Drawing.Size(12, 17);
            this.textBoxE.TabIndex = 0;
            this.textBoxE.Text = "2";
            this.textBoxE.TextChanged += new System.EventHandler(this.textBoxA_TextChanged);
            // 
            // labelE
            // 
            this.labelE.AutoSize = true;
            this.labelE.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelE.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelE.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelE.Location = new System.Drawing.Point(0, 0);
            this.labelE.Name = "labelE";
            this.labelE.Size = new System.Drawing.Size(33, 18);
            this.labelE.TabIndex = 1;
            this.labelE.Text = "e = ";
            // 
            // panelActionButtomR
            // 
            this.panelActionButtomR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelActionButtomR.Controls.Add(this.labelGuidanceR);
            this.panelActionButtomR.Controls.Add(this.textBoxR);
            this.panelActionButtomR.Controls.Add(this.labelR);
            this.panelActionButtomR.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelActionButtomR.Location = new System.Drawing.Point(0, 90);
            this.panelActionButtomR.Name = "panelActionButtomR";
            this.panelActionButtomR.Size = new System.Drawing.Size(250, 30);
            this.panelActionButtomR.TabIndex = 0;
            this.panelActionButtomR.MouseLeave += new System.EventHandler(this.panelActionButtomR_MouseLeave);
            this.panelActionButtomR.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelActionButtomR_MouseMove);
            // 
            // labelGuidanceR
            // 
            this.labelGuidanceR.AutoSize = true;
            this.labelGuidanceR.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelGuidanceR.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelGuidanceR.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelGuidanceR.Location = new System.Drawing.Point(42, 0);
            this.labelGuidanceR.Name = "labelGuidanceR";
            this.labelGuidanceR.Size = new System.Drawing.Size(148, 18);
            this.labelGuidanceR.TabIndex = 2;
            this.labelGuidanceR.Text = "Parameter of method";
            // 
            // textBoxR
            // 
            this.textBoxR.BackColor = System.Drawing.SystemColors.MenuText;
            this.textBoxR.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxR.Dock = System.Windows.Forms.DockStyle.Left;
            this.textBoxR.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxR.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBoxR.Location = new System.Drawing.Point(30, 0);
            this.textBoxR.Name = "textBoxR";
            this.textBoxR.Size = new System.Drawing.Size(12, 17);
            this.textBoxR.TabIndex = 0;
            this.textBoxR.Text = "2";
            this.textBoxR.TextChanged += new System.EventHandler(this.textBoxA_TextChanged);
            // 
            // labelR
            // 
            this.labelR.AutoSize = true;
            this.labelR.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelR.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelR.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelR.Location = new System.Drawing.Point(0, 0);
            this.labelR.Name = "labelR";
            this.labelR.Size = new System.Drawing.Size(30, 18);
            this.labelR.TabIndex = 1;
            this.labelR.Text = "r = ";
            // 
            // panelActionButtomRegion
            // 
            this.panelActionButtomRegion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelActionButtomRegion.Controls.Add(this.labelRegionEnd);
            this.panelActionButtomRegion.Controls.Add(this.textBoxXEnd);
            this.panelActionButtomRegion.Controls.Add(this.labelZpt);
            this.panelActionButtomRegion.Controls.Add(this.textBoxXBegin);
            this.panelActionButtomRegion.Controls.Add(this.labelRegionBegin);
            this.panelActionButtomRegion.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelActionButtomRegion.Location = new System.Drawing.Point(0, 60);
            this.panelActionButtomRegion.Name = "panelActionButtomRegion";
            this.panelActionButtomRegion.Size = new System.Drawing.Size(250, 30);
            this.panelActionButtomRegion.TabIndex = 1;
            // 
            // labelRegionEnd
            // 
            this.labelRegionEnd.AutoSize = true;
            this.labelRegionEnd.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelRegionEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRegionEnd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelRegionEnd.Location = new System.Drawing.Point(72, 0);
            this.labelRegionEnd.Name = "labelRegionEnd";
            this.labelRegionEnd.Size = new System.Drawing.Size(12, 18);
            this.labelRegionEnd.TabIndex = 0;
            this.labelRegionEnd.Text = "]";
            // 
            // textBoxXEnd
            // 
            this.textBoxXEnd.BackColor = System.Drawing.SystemColors.MenuText;
            this.textBoxXEnd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxXEnd.Dock = System.Windows.Forms.DockStyle.Left;
            this.textBoxXEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxXEnd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBoxXEnd.Location = new System.Drawing.Point(60, 0);
            this.textBoxXEnd.Name = "textBoxXEnd";
            this.textBoxXEnd.Size = new System.Drawing.Size(12, 17);
            this.textBoxXEnd.TabIndex = 6;
            this.textBoxXEnd.Text = "2";
            this.textBoxXEnd.TextChanged += new System.EventHandler(this.textBoxA_TextChanged);
            // 
            // labelZpt
            // 
            this.labelZpt.AutoSize = true;
            this.labelZpt.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelZpt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelZpt.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelZpt.Location = new System.Drawing.Point(48, 0);
            this.labelZpt.Name = "labelZpt";
            this.labelZpt.Size = new System.Drawing.Size(12, 18);
            this.labelZpt.TabIndex = 2;
            this.labelZpt.Text = ",";
            // 
            // textBoxXBegin
            // 
            this.textBoxXBegin.BackColor = System.Drawing.SystemColors.MenuText;
            this.textBoxXBegin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxXBegin.Dock = System.Windows.Forms.DockStyle.Left;
            this.textBoxXBegin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxXBegin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBoxXBegin.Location = new System.Drawing.Point(36, 0);
            this.textBoxXBegin.Name = "textBoxXBegin";
            this.textBoxXBegin.Size = new System.Drawing.Size(12, 17);
            this.textBoxXBegin.TabIndex = 5;
            this.textBoxXBegin.Text = "2";
            this.textBoxXBegin.TextChanged += new System.EventHandler(this.textBoxA_TextChanged);
            // 
            // labelRegionBegin
            // 
            this.labelRegionBegin.AutoSize = true;
            this.labelRegionBegin.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelRegionBegin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRegionBegin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelRegionBegin.Location = new System.Drawing.Point(0, 0);
            this.labelRegionBegin.Name = "labelRegionBegin";
            this.labelRegionBegin.Size = new System.Drawing.Size(36, 18);
            this.labelRegionBegin.TabIndex = 4;
            this.labelRegionBegin.Text = "x ∈ [";
            // 
            // panelActionButtomParamFunc
            // 
            this.panelActionButtomParamFunc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelActionButtomParamFunc.Controls.Add(this.labelSinEnd);
            this.panelActionButtomParamFunc.Controls.Add(this.textBoxD);
            this.panelActionButtomParamFunc.Controls.Add(this.labelSinBegin);
            this.panelActionButtomParamFunc.Controls.Add(this.textBoxC);
            this.panelActionButtomParamFunc.Controls.Add(this.labelCosEnd);
            this.panelActionButtomParamFunc.Controls.Add(this.textBoxB);
            this.panelActionButtomParamFunc.Controls.Add(this.labelCosBegin);
            this.panelActionButtomParamFunc.Controls.Add(this.textBoxA);
            this.panelActionButtomParamFunc.Controls.Add(this.labelFunc);
            this.panelActionButtomParamFunc.Controls.Add(this.panelFuncBegin);
            this.panelActionButtomParamFunc.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelActionButtomParamFunc.Location = new System.Drawing.Point(0, 30);
            this.panelActionButtomParamFunc.Name = "panelActionButtomParamFunc";
            this.panelActionButtomParamFunc.Size = new System.Drawing.Size(250, 30);
            this.panelActionButtomParamFunc.TabIndex = 2;
            // 
            // labelSinEnd
            // 
            this.labelSinEnd.AutoSize = true;
            this.labelSinEnd.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelSinEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSinEnd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelSinEnd.Location = new System.Drawing.Point(190, 0);
            this.labelSinEnd.Name = "labelSinEnd";
            this.labelSinEnd.Size = new System.Drawing.Size(20, 18);
            this.labelSinEnd.TabIndex = 0;
            this.labelSinEnd.Text = "x)";
            // 
            // textBoxD
            // 
            this.textBoxD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.textBoxD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxD.Dock = System.Windows.Forms.DockStyle.Left;
            this.textBoxD.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxD.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBoxD.Location = new System.Drawing.Point(180, 0);
            this.textBoxD.Name = "textBoxD";
            this.textBoxD.Size = new System.Drawing.Size(10, 17);
            this.textBoxD.TabIndex = 4;
            this.textBoxD.Text = "5";
            this.textBoxD.TextChanged += new System.EventHandler(this.textBoxA_TextChanged);
            // 
            // labelSinBegin
            // 
            this.labelSinBegin.AutoSize = true;
            this.labelSinBegin.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelSinBegin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSinBegin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelSinBegin.Location = new System.Drawing.Point(148, 0);
            this.labelSinBegin.Name = "labelSinBegin";
            this.labelSinBegin.Size = new System.Drawing.Size(32, 18);
            this.labelSinBegin.TabIndex = 2;
            this.labelSinBegin.Text = "sin(";
            // 
            // textBoxC
            // 
            this.textBoxC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.textBoxC.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxC.Dock = System.Windows.Forms.DockStyle.Left;
            this.textBoxC.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxC.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBoxC.Location = new System.Drawing.Point(138, 0);
            this.textBoxC.Name = "textBoxC";
            this.textBoxC.Size = new System.Drawing.Size(10, 17);
            this.textBoxC.TabIndex = 3;
            this.textBoxC.Text = "3";
            this.textBoxC.TextChanged += new System.EventHandler(this.textBoxA_TextChanged);
            // 
            // labelCosEnd
            // 
            this.labelCosEnd.AutoSize = true;
            this.labelCosEnd.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelCosEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCosEnd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelCosEnd.Location = new System.Drawing.Point(109, 0);
            this.labelCosEnd.Name = "labelCosEnd";
            this.labelCosEnd.Size = new System.Drawing.Size(29, 18);
            this.labelCosEnd.TabIndex = 4;
            this.labelCosEnd.Text = "x)+";
            // 
            // textBoxB
            // 
            this.textBoxB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.textBoxB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxB.Dock = System.Windows.Forms.DockStyle.Left;
            this.textBoxB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxB.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBoxB.Location = new System.Drawing.Point(98, 0);
            this.textBoxB.Name = "textBoxB";
            this.textBoxB.Size = new System.Drawing.Size(11, 17);
            this.textBoxB.TabIndex = 2;
            this.textBoxB.Text = "3";
            this.textBoxB.TextChanged += new System.EventHandler(this.textBoxA_TextChanged);
            // 
            // labelCosBegin
            // 
            this.labelCosBegin.AutoSize = true;
            this.labelCosBegin.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelCosBegin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCosBegin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelCosBegin.Location = new System.Drawing.Point(60, 0);
            this.labelCosBegin.Name = "labelCosBegin";
            this.labelCosBegin.Size = new System.Drawing.Size(38, 18);
            this.labelCosBegin.TabIndex = 6;
            this.labelCosBegin.Text = "cos(";
            // 
            // textBoxA
            // 
            this.textBoxA.BackColor = System.Drawing.Color.Red;
            this.textBoxA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxA.Dock = System.Windows.Forms.DockStyle.Left;
            this.textBoxA.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxA.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBoxA.Location = new System.Drawing.Point(48, 0);
            this.textBoxA.Name = "textBoxA";
            this.textBoxA.Size = new System.Drawing.Size(12, 17);
            this.textBoxA.TabIndex = 1;
            this.textBoxA.Text = "2";
            this.textBoxA.TextChanged += new System.EventHandler(this.textBoxA_TextChanged);
            // 
            // labelFunc
            // 
            this.labelFunc.AutoSize = true;
            this.labelFunc.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelFunc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFunc.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelFunc.Location = new System.Drawing.Point(5, 0);
            this.labelFunc.Name = "labelFunc";
            this.labelFunc.Size = new System.Drawing.Size(43, 18);
            this.labelFunc.TabIndex = 9;
            this.labelFunc.Text = "F(x)=";
            // 
            // panelFuncBegin
            // 
            this.panelFuncBegin.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelFuncBegin.Location = new System.Drawing.Point(0, 0);
            this.panelFuncBegin.Name = "panelFuncBegin";
            this.panelFuncBegin.Size = new System.Drawing.Size(5, 28);
            this.panelFuncBegin.TabIndex = 8;
            // 
            // panelActionRun
            // 
            this.panelActionRun.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelActionRun.Controls.Add(this.buttonRun);
            this.panelActionRun.Controls.Add(this.labelNameMethod);
            this.panelActionRun.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelActionRun.Location = new System.Drawing.Point(0, 0);
            this.panelActionRun.Name = "panelActionRun";
            this.panelActionRun.Size = new System.Drawing.Size(250, 30);
            this.panelActionRun.TabIndex = 5;
            // 
            // buttonRun
            // 
            this.buttonRun.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonRun.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonRun.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRun.Location = new System.Drawing.Point(120, 0);
            this.buttonRun.Name = "buttonRun";
            this.buttonRun.Size = new System.Drawing.Size(128, 28);
            this.buttonRun.TabIndex = 1;
            this.buttonRun.Text = "RUN";
            this.buttonRun.UseVisualStyleBackColor = true;
            this.buttonRun.Click += new System.EventHandler(this.buttonRun_Click);
            // 
            // labelNameMethod
            // 
            this.labelNameMethod.AutoSize = true;
            this.labelNameMethod.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelNameMethod.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelNameMethod.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNameMethod.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelNameMethod.Location = new System.Drawing.Point(0, 0);
            this.labelNameMethod.Name = "labelNameMethod";
            this.labelNameMethod.Size = new System.Drawing.Size(120, 27);
            this.labelNameMethod.TabIndex = 0;
            this.labelNameMethod.Text = "BruteForce";
            // 
            // labelRecomendation
            // 
            this.labelRecomendation.AutoSize = true;
            this.labelRecomendation.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelRecomendation.Font = new System.Drawing.Font("Microsoft Sans Serif", 75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRecomendation.ForeColor = System.Drawing.SystemColors.Control;
            this.labelRecomendation.Location = new System.Drawing.Point(0, 226);
            this.labelRecomendation.Name = "labelRecomendation";
            this.labelRecomendation.Size = new System.Drawing.Size(890, 113);
            this.labelRecomendation.TabIndex = 2;
            this.labelRecomendation.Text = "Please run method";
            // 
            // labelNoData
            // 
            this.labelNoData.AutoSize = true;
            this.labelNoData.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelNoData.Font = new System.Drawing.Font("Microsoft Sans Serif", 150F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNoData.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelNoData.Location = new System.Drawing.Point(0, 0);
            this.labelNoData.Name = "labelNoData";
            this.labelNoData.Size = new System.Drawing.Size(825, 226);
            this.labelNoData.TabIndex = 3;
            this.labelNoData.Text = "No Data";
            // 
            // panelButtomAnimation
            // 
            this.panelButtomAnimation.WorkerReportsProgress = true;
            this.panelButtomAnimation.DoWork += new System.ComponentModel.DoWorkEventHandler(this.panelButtomAnimation_DoWork);
            this.panelButtomAnimation.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.panelButtomAnimation_ProgressChanged);
            // 
            // panelLeftAnimation
            // 
            this.panelLeftAnimation.WorkerReportsProgress = true;
            this.panelLeftAnimation.DoWork += new System.ComponentModel.DoWorkEventHandler(this.panelLeftAnimation_DoWork);
            this.panelLeftAnimation.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.panelLeftAnimation_ProgressChanged);
            this.panelLeftAnimation.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.panelLeftAnimation_RunWorkerCompleted);
            // 
            // panelRightAnimation
            // 
            this.panelRightAnimation.WorkerReportsProgress = true;
            this.panelRightAnimation.DoWork += new System.ComponentModel.DoWorkEventHandler(this.panelRightAnimation_DoWork);
            this.panelRightAnimation.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.panelRightAnimation_ProgressChanged);
            this.panelRightAnimation.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.panelRightAnimation_RunWorkerCompleted);
            // 
            // panelActionButtomAnimation
            // 
            this.panelActionButtomAnimation.WorkerReportsProgress = true;
            this.panelActionButtomAnimation.DoWork += new System.ComponentModel.DoWorkEventHandler(this.panelActionButtomAnimation_DoWork);
            this.panelActionButtomAnimation.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.panelActionButtomAnimation_ProgressChanged);
            this.panelActionButtomAnimation.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.panelActionButtomAnimation_RunWorkerCompleted);
            // 
            // panelHeaderAnimation
            // 
            this.panelHeaderAnimation.WorkerReportsProgress = true;
            this.panelHeaderAnimation.DoWork += new System.ComponentModel.DoWorkEventHandler(this.panelHeaderAnimation_DoWork);
            this.panelHeaderAnimation.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.panelHeaderAnimation_ProgressChanged);
            this.panelHeaderAnimation.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.panelHeaderAnimation_RunWorkerCompleted);
            // 
            // TextAnimation
            // 
            this.TextAnimation.WorkerReportsProgress = true;
            this.TextAnimation.DoWork += new System.ComponentModel.DoWorkEventHandler(this.TextAnimation_DoWork);
            this.TextAnimation.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.TextAnimation_ProgressChanged);
            this.TextAnimation.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.TextAnimation_RunWorkerCompleted);
            // 
            // panelCloser
            // 
            this.panelCloser.WorkerReportsProgress = true;
            this.panelCloser.DoWork += new System.ComponentModel.DoWorkEventHandler(this.panelCloser_DoWork);
            this.panelCloser.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.panelCloser_ProgressChanged);
            this.panelCloser.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.panelCloser_RunWorkerCompleted);
            // 
            // runMethod
            // 
            this.runMethod.WorkerReportsProgress = true;
            this.runMethod.WorkerSupportsCancellation = true;
            this.runMethod.DoWork += new System.ComponentModel.DoWorkEventHandler(this.runMethod_DoWork);
            this.runMethod.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.runMethod_ProgressChanged);
            this.runMethod.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.runMethod_RunWorkerCompleted);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.panelAction);
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.panelButtom);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "MainForm";
            this.Text = "Decision making system";
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.panelButtom.ResumeLayout(false);
            this.panelLeft.ResumeLayout(false);
            this.panelRight.ResumeLayout(false);
            this.panelAction.ResumeLayout(false);
            this.panelAction.PerformLayout();
            this.panelActionHideButtom.ResumeLayout(false);
            this.panelActionButtom.ResumeLayout(false);
            this.panelActionButtom.PerformLayout();
            this.panelActionButtomParam.ResumeLayout(false);
            this.panelActionButtomE.ResumeLayout(false);
            this.panelActionButtomE.PerformLayout();
            this.panelActionButtomR.ResumeLayout(false);
            this.panelActionButtomR.PerformLayout();
            this.panelActionButtomRegion.ResumeLayout(false);
            this.panelActionButtomRegion.PerformLayout();
            this.panelActionButtomParamFunc.ResumeLayout(false);
            this.panelActionButtomParamFunc.PerformLayout();
            this.panelActionRun.ResumeLayout(false);
            this.panelActionRun.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Panel panelButtom;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.Panel panelAction;
        private System.ComponentModel.BackgroundWorker panelButtomAnimation;
        private System.ComponentModel.BackgroundWorker panelLeftAnimation;
        private System.ComponentModel.BackgroundWorker panelRightAnimation;
        private System.ComponentModel.BackgroundWorker panelActionButtomAnimation;
        private System.ComponentModel.BackgroundWorker panelHeaderAnimation;
        private System.Windows.Forms.Label labelRecomendation;
        private System.Windows.Forms.Label labelNoData;
        private System.Windows.Forms.Panel panelActionButtom;
        private System.Windows.Forms.Panel panelActionHideButtom;
        private System.Windows.Forms.Panel panelActionButtomParam;
        private System.Windows.Forms.Label labelNameMethod;
        private System.Windows.Forms.Panel panelActionButtomParamFunc;
        private System.Windows.Forms.Label labelCosBegin;
        private System.Windows.Forms.TextBox textBoxA;
        private System.Windows.Forms.Panel panelFuncBegin;
        private System.Windows.Forms.TextBox textBoxB;
        private System.Windows.Forms.Label labelSinEnd;
        private System.Windows.Forms.TextBox textBoxD;
        private System.Windows.Forms.Label labelSinBegin;
        private System.Windows.Forms.TextBox textBoxC;
        private System.Windows.Forms.Label labelCosEnd;
        private System.Windows.Forms.Panel panelActionButtomRegion;
        private System.Windows.Forms.Label labelRegionEnd;
        private System.Windows.Forms.TextBox textBoxXEnd;
        private System.Windows.Forms.Label labelZpt;
        private System.Windows.Forms.TextBox textBoxXBegin;
        private System.Windows.Forms.Label labelRegionBegin;
        private System.Windows.Forms.Panel panelActionButtomR;
        private System.Windows.Forms.TextBox textBoxR;
        private System.Windows.Forms.Label labelR;
        private System.Windows.Forms.Panel panelActionButtomE;
        private System.Windows.Forms.TextBox textBoxE;
        private System.Windows.Forms.Label labelE;
        private System.Windows.Forms.Label labelGuidanceR;
        private System.Windows.Forms.Label labelGuidanceE;
        private System.Windows.Forms.Button buttonActionButtom;
        private System.Windows.Forms.Panel panelActionRun;
        private System.Windows.Forms.Button buttonRun;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonChangePerspectiveLeft;
        private System.Windows.Forms.Button buttonChangePerspectiveRight;
        private System.Windows.Forms.Panel panelStatus;
        private System.ComponentModel.BackgroundWorker TextAnimation;
        private System.ComponentModel.BackgroundWorker panelCloser;
        private System.ComponentModel.BackgroundWorker runMethod;
        private System.Windows.Forms.Label labelFunc;
        private ZedGraph.ZedGraphControl zedGraphControlMain;
        private System.Windows.Forms.Label labelStage;
    }
}