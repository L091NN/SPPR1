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
        [System.ComponentModel.Browsable(false)]
        public event System.Windows.Forms.MouseEventHandler MouseWheel;
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelHeader = new System.Windows.Forms.Panel();
            this.labelMousePosition = new System.Windows.Forms.Label();
            this.panelButtom = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
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
            this.panelGraphConrtol = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelTable = new System.Windows.Forms.Label();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.panelPostProcessing = new System.Windows.Forms.Panel();
            this.panelMinimum = new System.Windows.Forms.Panel();
            this.labelMinEnd = new System.Windows.Forms.Label();
            this.textBoxYMin = new System.Windows.Forms.TextBox();
            this.labelMinMid = new System.Windows.Forms.Label();
            this.textBoxXMin = new System.Windows.Forms.TextBox();
            this.labelMinBegin = new System.Windows.Forms.Label();
            this.panelStepCount = new System.Windows.Forms.Panel();
            this.labelMaxStepCountResult = new System.Windows.Forms.Label();
            this.labelOfStep = new System.Windows.Forms.Label();
            this.labelStepCount = new System.Windows.Forms.Label();
            this.panelDefaultZoom = new System.Windows.Forms.Panel();
            this.buttonZoomApply = new System.Windows.Forms.Button();
            this.buttonDefaultZoom = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelZoomYEnd = new System.Windows.Forms.Label();
            this.textBoxZoomYEnd = new System.Windows.Forms.TextBox();
            this.labelZoomYMid = new System.Windows.Forms.Label();
            this.textBoxZoomYBegin = new System.Windows.Forms.TextBox();
            this.labelZoomYBegin = new System.Windows.Forms.Label();
            this.panelZoomX = new System.Windows.Forms.Panel();
            this.labelZoomXEnd = new System.Windows.Forms.Label();
            this.textBoxZoomXEnd = new System.Windows.Forms.TextBox();
            this.labelZoomXMid = new System.Windows.Forms.Label();
            this.textBoxZoomXBegin = new System.Windows.Forms.TextBox();
            this.labelZoomXBegin = new System.Windows.Forms.Label();
            this.panelLinesAndPoints = new System.Windows.Forms.Panel();
            this.buttonWithLine = new System.Windows.Forms.Button();
            this.buttonWithPoints = new System.Windows.Forms.Button();
            this.panelActionButtomParam = new System.Windows.Forms.Panel();
            this.panelActionButtomE = new System.Windows.Forms.Panel();
            this.labelGuidanceE = new System.Windows.Forms.Label();
            this.textBoxE = new System.Windows.Forms.TextBox();
            this.labelE = new System.Windows.Forms.Label();
            this.panelActionButtomR = new System.Windows.Forms.Panel();
            this.labelGuidanceR = new System.Windows.Forms.Label();
            this.textBoxR = new System.Windows.Forms.TextBox();
            this.labelR = new System.Windows.Forms.Label();
            this.panelMaxSteps = new System.Windows.Forms.Panel();
            this.textBoxMaxStepCount = new System.Windows.Forms.TextBox();
            this.labelMaxStepCount = new System.Windows.Forms.Label();
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
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.panelHeader.SuspendLayout();
            this.panelButtom.SuspendLayout();
            this.panelLeft.SuspendLayout();
            this.panelRight.SuspendLayout();
            this.panelAction.SuspendLayout();
            this.panelActionHideButtom.SuspendLayout();
            this.panelActionButtom.SuspendLayout();
            this.panelGraphConrtol.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelPostProcessing.SuspendLayout();
            this.panelMinimum.SuspendLayout();
            this.panelStepCount.SuspendLayout();
            this.panelDefaultZoom.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelZoomX.SuspendLayout();
            this.panelLinesAndPoints.SuspendLayout();
            this.panelActionButtomParam.SuspendLayout();
            this.panelActionButtomE.SuspendLayout();
            this.panelActionButtomR.SuspendLayout();
            this.panelMaxSteps.SuspendLayout();
            this.panelActionButtomRegion.SuspendLayout();
            this.panelActionButtomParamFunc.SuspendLayout();
            this.panelActionRun.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(209)))), ((int)(((byte)(132)))));
            this.panelHeader.Controls.Add(this.labelMousePosition);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Margin = new System.Windows.Forms.Padding(4);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1685, 62);
            this.panelHeader.TabIndex = 4;
            // 
            // labelMousePosition
            // 
            this.labelMousePosition.AutoSize = true;
            this.labelMousePosition.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelMousePosition.Location = new System.Drawing.Point(0, 0);
            this.labelMousePosition.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMousePosition.Name = "labelMousePosition";
            this.labelMousePosition.Size = new System.Drawing.Size(19, 17);
            this.labelMousePosition.TabIndex = 0;
            this.labelMousePosition.Text = "M";
            // 
            // panelButtom
            // 
            this.panelButtom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(0)))), ((int)(((byte)(30)))));
            this.panelButtom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelButtom.Controls.Add(this.panel3);
            this.panelButtom.Controls.Add(this.panelStatus);
            this.panelButtom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelButtom.Location = new System.Drawing.Point(0, 802);
            this.panelButtom.Margin = new System.Windows.Forms.Padding(4);
            this.panelButtom.Name = "panelButtom";
            this.panelButtom.Size = new System.Drawing.Size(1685, 36);
            this.panelButtom.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(692, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(898, 276);
            this.panel3.TabIndex = 1;
            // 
            // panelStatus
            // 
            this.panelStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelStatus.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelStatus.Location = new System.Drawing.Point(0, 0);
            this.panelStatus.Margin = new System.Windows.Forms.Padding(4);
            this.panelStatus.Name = "panelStatus";
            this.panelStatus.Size = new System.Drawing.Size(0, 34);
            this.panelStatus.TabIndex = 0;
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(187)))), ((int)(((byte)(45)))));
            this.panelLeft.Controls.Add(this.buttonChangePerspectiveLeft);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 62);
            this.panelLeft.Margin = new System.Windows.Forms.Padding(4);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(93, 740);
            this.panelLeft.TabIndex = 2;
            // 
            // buttonChangePerspectiveLeft
            // 
            this.buttonChangePerspectiveLeft.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonChangePerspectiveLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonChangePerspectiveLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonChangePerspectiveLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonChangePerspectiveLeft.Location = new System.Drawing.Point(0, 0);
            this.buttonChangePerspectiveLeft.Margin = new System.Windows.Forms.Padding(4);
            this.buttonChangePerspectiveLeft.Name = "buttonChangePerspectiveLeft";
            this.buttonChangePerspectiveLeft.Size = new System.Drawing.Size(93, 740);
            this.buttonChangePerspectiveLeft.TabIndex = 0;
            this.buttonChangePerspectiveLeft.TabStop = false;
            this.buttonChangePerspectiveLeft.Text = "◀";
            this.buttonChangePerspectiveLeft.UseVisualStyleBackColor = true;
            this.buttonChangePerspectiveLeft.Click += new System.EventHandler(this.buttonChangePerspectiveLeft_Click);
            this.buttonChangePerspectiveLeft.MouseLeave += new System.EventHandler(this.buttonChangePerspectiveLeft_MouseLeave);
            this.buttonChangePerspectiveLeft.MouseMove += new System.Windows.Forms.MouseEventHandler(this.buttonChangePerspectiveLeft_MouseMove);
            // 
            // panelRight
            // 
            this.panelRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(42)))), ((int)(((byte)(108)))));
            this.panelRight.Controls.Add(this.buttonChangePerspectiveRight);
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelRight.Location = new System.Drawing.Point(1592, 62);
            this.panelRight.Margin = new System.Windows.Forms.Padding(4);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(93, 740);
            this.panelRight.TabIndex = 1;
            // 
            // buttonChangePerspectiveRight
            // 
            this.buttonChangePerspectiveRight.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonChangePerspectiveRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonChangePerspectiveRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonChangePerspectiveRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonChangePerspectiveRight.Location = new System.Drawing.Point(0, 0);
            this.buttonChangePerspectiveRight.Margin = new System.Windows.Forms.Padding(4);
            this.buttonChangePerspectiveRight.Name = "buttonChangePerspectiveRight";
            this.buttonChangePerspectiveRight.Size = new System.Drawing.Size(93, 740);
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
            this.panelAction.Location = new System.Drawing.Point(93, 62);
            this.panelAction.Margin = new System.Windows.Forms.Padding(4);
            this.panelAction.Name = "panelAction";
            this.panelAction.Size = new System.Drawing.Size(1499, 740);
            this.panelAction.TabIndex = 0;
            // 
            // labelStage
            // 
            this.labelStage.AutoSize = true;
            this.labelStage.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelStage.Font = new System.Drawing.Font("Microsoft Sans Serif", 75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelStage.ForeColor = System.Drawing.SystemColors.Control;
            this.labelStage.Location = new System.Drawing.Point(0, 425);
            this.labelStage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelStage.Name = "labelStage";
            this.labelStage.Size = new System.Drawing.Size(510, 142);
            this.labelStage.TabIndex = 5;
            this.labelStage.Text = "ERROR";
            this.labelStage.Visible = false;
            // 
            // zedGraphControlMain
            // 
            this.zedGraphControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.zedGraphControlMain.IsShowPointValues = false;
            this.zedGraphControlMain.Location = new System.Drawing.Point(0, 425);
            this.zedGraphControlMain.Margin = new System.Windows.Forms.Padding(4);
            this.zedGraphControlMain.Name = "zedGraphControlMain";
            this.zedGraphControlMain.PointValueFormat = "G";
            this.zedGraphControlMain.Size = new System.Drawing.Size(1499, 5);
            this.zedGraphControlMain.TabIndex = 4;
            this.zedGraphControlMain.Visible = false;
            this.zedGraphControlMain.MouseDown += new System.Windows.Forms.MouseEventHandler(this.zedGraphControlMain_MouseDown);
            this.zedGraphControlMain.MouseMove += new System.Windows.Forms.MouseEventHandler(this.zedGraphControlMain_MouseMove);
            this.zedGraphControlMain.MouseUp += new System.Windows.Forms.MouseEventHandler(this.zedGraphControlMain_MouseUp);
            this.zedGraphControlMain.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.zedGraphControlMain_MouseWheel);
            // 
            // panelActionHideButtom
            // 
            this.panelActionHideButtom.Controls.Add(this.buttonActionButtom);
            this.panelActionHideButtom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelActionHideButtom.Location = new System.Drawing.Point(0, 430);
            this.panelActionHideButtom.Margin = new System.Windows.Forms.Padding(4);
            this.panelActionHideButtom.Name = "panelActionHideButtom";
            this.panelActionHideButtom.Size = new System.Drawing.Size(1499, 32);
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
            this.buttonActionButtom.Margin = new System.Windows.Forms.Padding(4);
            this.buttonActionButtom.Name = "buttonActionButtom";
            this.buttonActionButtom.Size = new System.Drawing.Size(1499, 32);
            this.buttonActionButtom.TabIndex = 0;
            this.buttonActionButtom.TabStop = false;
            this.buttonActionButtom.Text = "▼";
            this.buttonActionButtom.UseVisualStyleBackColor = true;
            this.buttonActionButtom.Click += new System.EventHandler(this.buttonActionButtom_Click);
            // 
            // panelActionButtom
            // 
            this.panelActionButtom.Controls.Add(this.panelGraphConrtol);
            this.panelActionButtom.Controls.Add(this.panelActionButtomParam);
            this.panelActionButtom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelActionButtom.Location = new System.Drawing.Point(0, 462);
            this.panelActionButtom.Margin = new System.Windows.Forms.Padding(4);
            this.panelActionButtom.Name = "panelActionButtom";
            this.panelActionButtom.Size = new System.Drawing.Size(1499, 278);
            this.panelActionButtom.TabIndex = 1;
            // 
            // panelGraphConrtol
            // 
            this.panelGraphConrtol.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelGraphConrtol.Controls.Add(this.panel2);
            this.panelGraphConrtol.Controls.Add(this.tableLayoutPanel);
            this.panelGraphConrtol.Controls.Add(this.panelPostProcessing);
            this.panelGraphConrtol.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGraphConrtol.Location = new System.Drawing.Point(333, 0);
            this.panelGraphConrtol.Margin = new System.Windows.Forms.Padding(4);
            this.panelGraphConrtol.Name = "panelGraphConrtol";
            this.panelGraphConrtol.Size = new System.Drawing.Size(1166, 278);
            this.panelGraphConrtol.TabIndex = 1;
            this.panelGraphConrtol.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.labelTable);
            this.panel2.Location = new System.Drawing.Point(266, -1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(898, 36);
            this.panel2.TabIndex = 3;
            // 
            // labelTable
            // 
            this.labelTable.AutoSize = true;
            this.labelTable.Enabled = false;
            this.labelTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelTable.ForeColor = System.Drawing.SystemColors.Control;
            this.labelTable.Location = new System.Drawing.Point(428, 8);
            this.labelTable.Name = "labelTable";
            this.labelTable.Size = new System.Drawing.Size(50, 20);
            this.labelTable.TabIndex = 2;
            this.labelTable.Text = "Table";
            this.labelTable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.AutoScroll = true;
            this.tableLayoutPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.tableLayoutPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tableLayoutPanel.Location = new System.Drawing.Point(266, 72);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 3;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(892, 128);
            this.tableLayoutPanel.TabIndex = 1;
            // 
            // panelPostProcessing
            // 
            this.panelPostProcessing.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelPostProcessing.Controls.Add(this.panelMinimum);
            this.panelPostProcessing.Controls.Add(this.panelStepCount);
            this.panelPostProcessing.Controls.Add(this.panelDefaultZoom);
            this.panelPostProcessing.Controls.Add(this.panel1);
            this.panelPostProcessing.Controls.Add(this.panelZoomX);
            this.panelPostProcessing.Controls.Add(this.panelLinesAndPoints);
            this.panelPostProcessing.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelPostProcessing.Location = new System.Drawing.Point(0, 0);
            this.panelPostProcessing.Margin = new System.Windows.Forms.Padding(4);
            this.panelPostProcessing.Name = "panelPostProcessing";
            this.panelPostProcessing.Size = new System.Drawing.Size(266, 276);
            this.panelPostProcessing.TabIndex = 0;
            // 
            // panelMinimum
            // 
            this.panelMinimum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMinimum.Controls.Add(this.labelMinEnd);
            this.panelMinimum.Controls.Add(this.textBoxYMin);
            this.panelMinimum.Controls.Add(this.labelMinMid);
            this.panelMinimum.Controls.Add(this.textBoxXMin);
            this.panelMinimum.Controls.Add(this.labelMinBegin);
            this.panelMinimum.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMinimum.Location = new System.Drawing.Point(0, 178);
            this.panelMinimum.Margin = new System.Windows.Forms.Padding(4);
            this.panelMinimum.Name = "panelMinimum";
            this.panelMinimum.Size = new System.Drawing.Size(264, 36);
            this.panelMinimum.TabIndex = 5;
            // 
            // labelMinEnd
            // 
            this.labelMinEnd.AutoSize = true;
            this.labelMinEnd.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelMinEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMinEnd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelMinEnd.Location = new System.Drawing.Point(143, 0);
            this.labelMinEnd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMinEnd.Name = "labelMinEnd";
            this.labelMinEnd.Size = new System.Drawing.Size(21, 29);
            this.labelMinEnd.TabIndex = 9;
            this.labelMinEnd.Text = ")";
            // 
            // textBoxYMin
            // 
            this.textBoxYMin.BackColor = System.Drawing.SystemColors.MenuText;
            this.textBoxYMin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxYMin.Dock = System.Windows.Forms.DockStyle.Left;
            this.textBoxYMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxYMin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBoxYMin.Location = new System.Drawing.Point(124, 0);
            this.textBoxYMin.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxYMin.Name = "textBoxYMin";
            this.textBoxYMin.ReadOnly = true;
            this.textBoxYMin.Size = new System.Drawing.Size(19, 27);
            this.textBoxYMin.TabIndex = 8;
            this.textBoxYMin.Text = "2";
            this.textBoxYMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxYMin.TextChanged += new System.EventHandler(this.textBoxA_TextChanged);
            // 
            // labelMinMid
            // 
            this.labelMinMid.AutoSize = true;
            this.labelMinMid.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelMinMid.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMinMid.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelMinMid.Location = new System.Drawing.Point(105, 0);
            this.labelMinMid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMinMid.Name = "labelMinMid";
            this.labelMinMid.Size = new System.Drawing.Size(19, 29);
            this.labelMinMid.TabIndex = 7;
            this.labelMinMid.Text = ",";
            // 
            // textBoxXMin
            // 
            this.textBoxXMin.BackColor = System.Drawing.SystemColors.MenuText;
            this.textBoxXMin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxXMin.Dock = System.Windows.Forms.DockStyle.Left;
            this.textBoxXMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxXMin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBoxXMin.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textBoxXMin.Location = new System.Drawing.Point(86, 0);
            this.textBoxXMin.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxXMin.Name = "textBoxXMin";
            this.textBoxXMin.ReadOnly = true;
            this.textBoxXMin.Size = new System.Drawing.Size(19, 27);
            this.textBoxXMin.TabIndex = 6;
            this.textBoxXMin.Text = "2";
            this.textBoxXMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxXMin.TextChanged += new System.EventHandler(this.textBoxA_TextChanged);
            // 
            // labelMinBegin
            // 
            this.labelMinBegin.AutoSize = true;
            this.labelMinBegin.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelMinBegin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMinBegin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelMinBegin.Location = new System.Drawing.Point(0, 0);
            this.labelMinBegin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMinBegin.Name = "labelMinBegin";
            this.labelMinBegin.Size = new System.Drawing.Size(86, 29);
            this.labelMinBegin.TabIndex = 0;
            this.labelMinBegin.Text = "Min = (";
            // 
            // panelStepCount
            // 
            this.panelStepCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelStepCount.Controls.Add(this.labelMaxStepCountResult);
            this.panelStepCount.Controls.Add(this.labelOfStep);
            this.panelStepCount.Controls.Add(this.labelStepCount);
            this.panelStepCount.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelStepCount.Location = new System.Drawing.Point(0, 142);
            this.panelStepCount.Margin = new System.Windows.Forms.Padding(4);
            this.panelStepCount.Name = "panelStepCount";
            this.panelStepCount.Size = new System.Drawing.Size(264, 36);
            this.panelStepCount.TabIndex = 3;
            // 
            // labelMaxStepCountResult
            // 
            this.labelMaxStepCountResult.AutoSize = true;
            this.labelMaxStepCountResult.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelMaxStepCountResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMaxStepCountResult.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelMaxStepCountResult.Location = new System.Drawing.Point(175, 0);
            this.labelMaxStepCountResult.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMaxStepCountResult.Name = "labelMaxStepCountResult";
            this.labelMaxStepCountResult.Size = new System.Drawing.Size(39, 29);
            this.labelMaxStepCountResult.TabIndex = 5;
            this.labelMaxStepCountResult.Text = "10";
            // 
            // labelOfStep
            // 
            this.labelOfStep.AutoSize = true;
            this.labelOfStep.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelOfStep.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelOfStep.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelOfStep.Location = new System.Drawing.Point(39, 0);
            this.labelOfStep.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelOfStep.Name = "labelOfStep";
            this.labelOfStep.Size = new System.Drawing.Size(136, 29);
            this.labelOfStep.TabIndex = 4;
            this.labelOfStep.Text = "steps out of";
            // 
            // labelStepCount
            // 
            this.labelStepCount.AutoSize = true;
            this.labelStepCount.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelStepCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelStepCount.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelStepCount.Location = new System.Drawing.Point(0, 0);
            this.labelStepCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelStepCount.Name = "labelStepCount";
            this.labelStepCount.Size = new System.Drawing.Size(39, 29);
            this.labelStepCount.TabIndex = 3;
            this.labelStepCount.Text = "10";
            // 
            // panelDefaultZoom
            // 
            this.panelDefaultZoom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelDefaultZoom.Controls.Add(this.buttonZoomApply);
            this.panelDefaultZoom.Controls.Add(this.buttonDefaultZoom);
            this.panelDefaultZoom.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDefaultZoom.Location = new System.Drawing.Point(0, 106);
            this.panelDefaultZoom.Margin = new System.Windows.Forms.Padding(4);
            this.panelDefaultZoom.Name = "panelDefaultZoom";
            this.panelDefaultZoom.Size = new System.Drawing.Size(264, 36);
            this.panelDefaultZoom.TabIndex = 2;
            // 
            // buttonZoomApply
            // 
            this.buttonZoomApply.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonZoomApply.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonZoomApply.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonZoomApply.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonZoomApply.Location = new System.Drawing.Point(0, 0);
            this.buttonZoomApply.Margin = new System.Windows.Forms.Padding(4);
            this.buttonZoomApply.Name = "buttonZoomApply";
            this.buttonZoomApply.Size = new System.Drawing.Size(133, 34);
            this.buttonZoomApply.TabIndex = 1;
            this.buttonZoomApply.Text = "Apply";
            this.buttonZoomApply.UseVisualStyleBackColor = true;
            // 
            // buttonDefaultZoom
            // 
            this.buttonDefaultZoom.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonDefaultZoom.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonDefaultZoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDefaultZoom.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonDefaultZoom.Location = new System.Drawing.Point(129, 0);
            this.buttonDefaultZoom.Margin = new System.Windows.Forms.Padding(4);
            this.buttonDefaultZoom.Name = "buttonDefaultZoom";
            this.buttonDefaultZoom.Size = new System.Drawing.Size(133, 34);
            this.buttonDefaultZoom.TabIndex = 0;
            this.buttonDefaultZoom.Text = "Default Zoom";
            this.buttonDefaultZoom.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.labelZoomYEnd);
            this.panel1.Controls.Add(this.textBoxZoomYEnd);
            this.panel1.Controls.Add(this.labelZoomYMid);
            this.panel1.Controls.Add(this.textBoxZoomYBegin);
            this.panel1.Controls.Add(this.labelZoomYBegin);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 70);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(264, 36);
            this.panel1.TabIndex = 1;
            // 
            // labelZoomYEnd
            // 
            this.labelZoomYEnd.AutoSize = true;
            this.labelZoomYEnd.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelZoomYEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelZoomYEnd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelZoomYEnd.Location = new System.Drawing.Point(182, 0);
            this.labelZoomYEnd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelZoomYEnd.Name = "labelZoomYEnd";
            this.labelZoomYEnd.Size = new System.Drawing.Size(20, 29);
            this.labelZoomYEnd.TabIndex = 7;
            this.labelZoomYEnd.Text = "]";
            // 
            // textBoxZoomYEnd
            // 
            this.textBoxZoomYEnd.BackColor = System.Drawing.SystemColors.MenuText;
            this.textBoxZoomYEnd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxZoomYEnd.Dock = System.Windows.Forms.DockStyle.Left;
            this.textBoxZoomYEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxZoomYEnd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBoxZoomYEnd.Location = new System.Drawing.Point(163, 0);
            this.textBoxZoomYEnd.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxZoomYEnd.Name = "textBoxZoomYEnd";
            this.textBoxZoomYEnd.Size = new System.Drawing.Size(19, 27);
            this.textBoxZoomYEnd.TabIndex = 10;
            this.textBoxZoomYEnd.Text = "2";
            this.textBoxZoomYEnd.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxZoomYEnd.TextChanged += new System.EventHandler(this.textBoxA_TextChanged);
            // 
            // labelZoomYMid
            // 
            this.labelZoomYMid.AutoSize = true;
            this.labelZoomYMid.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelZoomYMid.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelZoomYMid.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelZoomYMid.Location = new System.Drawing.Point(144, 0);
            this.labelZoomYMid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelZoomYMid.Name = "labelZoomYMid";
            this.labelZoomYMid.Size = new System.Drawing.Size(19, 29);
            this.labelZoomYMid.TabIndex = 8;
            this.labelZoomYMid.Text = ",";
            // 
            // textBoxZoomYBegin
            // 
            this.textBoxZoomYBegin.BackColor = System.Drawing.SystemColors.MenuText;
            this.textBoxZoomYBegin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxZoomYBegin.Dock = System.Windows.Forms.DockStyle.Left;
            this.textBoxZoomYBegin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxZoomYBegin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBoxZoomYBegin.Location = new System.Drawing.Point(125, 0);
            this.textBoxZoomYBegin.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxZoomYBegin.Name = "textBoxZoomYBegin";
            this.textBoxZoomYBegin.Size = new System.Drawing.Size(19, 27);
            this.textBoxZoomYBegin.TabIndex = 9;
            this.textBoxZoomYBegin.Text = "2";
            this.textBoxZoomYBegin.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxZoomYBegin.TextChanged += new System.EventHandler(this.textBoxA_TextChanged);
            // 
            // labelZoomYBegin
            // 
            this.labelZoomYBegin.AutoSize = true;
            this.labelZoomYBegin.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelZoomYBegin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelZoomYBegin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelZoomYBegin.Location = new System.Drawing.Point(0, 0);
            this.labelZoomYBegin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelZoomYBegin.Name = "labelZoomYBegin";
            this.labelZoomYBegin.Size = new System.Drawing.Size(125, 29);
            this.labelZoomYBegin.TabIndex = 5;
            this.labelZoomYBegin.Text = "Zoom y ∈ [";
            // 
            // panelZoomX
            // 
            this.panelZoomX.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelZoomX.Controls.Add(this.labelZoomXEnd);
            this.panelZoomX.Controls.Add(this.textBoxZoomXEnd);
            this.panelZoomX.Controls.Add(this.labelZoomXMid);
            this.panelZoomX.Controls.Add(this.textBoxZoomXBegin);
            this.panelZoomX.Controls.Add(this.labelZoomXBegin);
            this.panelZoomX.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelZoomX.Location = new System.Drawing.Point(0, 34);
            this.panelZoomX.Margin = new System.Windows.Forms.Padding(4);
            this.panelZoomX.Name = "panelZoomX";
            this.panelZoomX.Size = new System.Drawing.Size(264, 36);
            this.panelZoomX.TabIndex = 0;
            // 
            // labelZoomXEnd
            // 
            this.labelZoomXEnd.AutoSize = true;
            this.labelZoomXEnd.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelZoomXEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelZoomXEnd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelZoomXEnd.Location = new System.Drawing.Point(182, 0);
            this.labelZoomXEnd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelZoomXEnd.Name = "labelZoomXEnd";
            this.labelZoomXEnd.Size = new System.Drawing.Size(20, 29);
            this.labelZoomXEnd.TabIndex = 7;
            this.labelZoomXEnd.Text = "]";
            // 
            // textBoxZoomXEnd
            // 
            this.textBoxZoomXEnd.BackColor = System.Drawing.SystemColors.MenuText;
            this.textBoxZoomXEnd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxZoomXEnd.Dock = System.Windows.Forms.DockStyle.Left;
            this.textBoxZoomXEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxZoomXEnd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBoxZoomXEnd.Location = new System.Drawing.Point(163, 0);
            this.textBoxZoomXEnd.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxZoomXEnd.Name = "textBoxZoomXEnd";
            this.textBoxZoomXEnd.Size = new System.Drawing.Size(19, 27);
            this.textBoxZoomXEnd.TabIndex = 10;
            this.textBoxZoomXEnd.Text = "2";
            this.textBoxZoomXEnd.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxZoomXEnd.TextChanged += new System.EventHandler(this.textBoxA_TextChanged);
            // 
            // labelZoomXMid
            // 
            this.labelZoomXMid.AutoSize = true;
            this.labelZoomXMid.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelZoomXMid.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelZoomXMid.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelZoomXMid.Location = new System.Drawing.Point(144, 0);
            this.labelZoomXMid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelZoomXMid.Name = "labelZoomXMid";
            this.labelZoomXMid.Size = new System.Drawing.Size(19, 29);
            this.labelZoomXMid.TabIndex = 8;
            this.labelZoomXMid.Text = ",";
            // 
            // textBoxZoomXBegin
            // 
            this.textBoxZoomXBegin.BackColor = System.Drawing.SystemColors.MenuText;
            this.textBoxZoomXBegin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxZoomXBegin.Dock = System.Windows.Forms.DockStyle.Left;
            this.textBoxZoomXBegin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxZoomXBegin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBoxZoomXBegin.Location = new System.Drawing.Point(125, 0);
            this.textBoxZoomXBegin.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxZoomXBegin.Name = "textBoxZoomXBegin";
            this.textBoxZoomXBegin.Size = new System.Drawing.Size(19, 27);
            this.textBoxZoomXBegin.TabIndex = 9;
            this.textBoxZoomXBegin.Text = "2";
            this.textBoxZoomXBegin.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxZoomXBegin.TextChanged += new System.EventHandler(this.textBoxA_TextChanged);
            // 
            // labelZoomXBegin
            // 
            this.labelZoomXBegin.AutoSize = true;
            this.labelZoomXBegin.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelZoomXBegin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelZoomXBegin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelZoomXBegin.Location = new System.Drawing.Point(0, 0);
            this.labelZoomXBegin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelZoomXBegin.Name = "labelZoomXBegin";
            this.labelZoomXBegin.Size = new System.Drawing.Size(125, 29);
            this.labelZoomXBegin.TabIndex = 5;
            this.labelZoomXBegin.Text = "Zoom x ∈ [";
            // 
            // panelLinesAndPoints
            // 
            this.panelLinesAndPoints.Controls.Add(this.buttonWithLine);
            this.panelLinesAndPoints.Controls.Add(this.buttonWithPoints);
            this.panelLinesAndPoints.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLinesAndPoints.Location = new System.Drawing.Point(0, 0);
            this.panelLinesAndPoints.Margin = new System.Windows.Forms.Padding(4);
            this.panelLinesAndPoints.Name = "panelLinesAndPoints";
            this.panelLinesAndPoints.Size = new System.Drawing.Size(264, 34);
            this.panelLinesAndPoints.TabIndex = 4;
            // 
            // buttonWithLine
            // 
            this.buttonWithLine.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonWithLine.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonWithLine.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonWithLine.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonWithLine.Location = new System.Drawing.Point(131, 0);
            this.buttonWithLine.Margin = new System.Windows.Forms.Padding(4);
            this.buttonWithLine.Name = "buttonWithLine";
            this.buttonWithLine.Size = new System.Drawing.Size(133, 34);
            this.buttonWithLine.TabIndex = 1;
            this.buttonWithLine.Text = "Line";
            this.buttonWithLine.UseVisualStyleBackColor = true;
            this.buttonWithLine.Click += new System.EventHandler(this.buttonWithLine_Click);
            // 
            // buttonWithPoints
            // 
            this.buttonWithPoints.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonWithPoints.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonWithPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonWithPoints.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonWithPoints.Location = new System.Drawing.Point(0, 0);
            this.buttonWithPoints.Margin = new System.Windows.Forms.Padding(4);
            this.buttonWithPoints.Name = "buttonWithPoints";
            this.buttonWithPoints.Size = new System.Drawing.Size(133, 34);
            this.buttonWithPoints.TabIndex = 0;
            this.buttonWithPoints.Text = "Points";
            this.buttonWithPoints.UseVisualStyleBackColor = true;
            this.buttonWithPoints.Click += new System.EventHandler(this.buttonWithPoints_Click);
            // 
            // panelActionButtomParam
            // 
            this.panelActionButtomParam.Controls.Add(this.panelActionButtomE);
            this.panelActionButtomParam.Controls.Add(this.panelActionButtomR);
            this.panelActionButtomParam.Controls.Add(this.panelMaxSteps);
            this.panelActionButtomParam.Controls.Add(this.panelActionButtomRegion);
            this.panelActionButtomParam.Controls.Add(this.panelActionButtomParamFunc);
            this.panelActionButtomParam.Controls.Add(this.panelActionRun);
            this.panelActionButtomParam.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelActionButtomParam.Location = new System.Drawing.Point(0, 0);
            this.panelActionButtomParam.Margin = new System.Windows.Forms.Padding(4);
            this.panelActionButtomParam.Name = "panelActionButtomParam";
            this.panelActionButtomParam.Size = new System.Drawing.Size(333, 278);
            this.panelActionButtomParam.TabIndex = 0;
            // 
            // panelActionButtomE
            // 
            this.panelActionButtomE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelActionButtomE.Controls.Add(this.labelGuidanceE);
            this.panelActionButtomE.Controls.Add(this.textBoxE);
            this.panelActionButtomE.Controls.Add(this.labelE);
            this.panelActionButtomE.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelActionButtomE.Location = new System.Drawing.Point(0, 180);
            this.panelActionButtomE.Margin = new System.Windows.Forms.Padding(4);
            this.panelActionButtomE.Name = "panelActionButtomE";
            this.panelActionButtomE.Size = new System.Drawing.Size(333, 36);
            this.panelActionButtomE.TabIndex = 4;
            this.panelActionButtomE.MouseLeave += new System.EventHandler(this.panelActionButtomE_MouseLeave);
            this.panelActionButtomE.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelActionButtomE_MouseMove);
            // 
            // labelGuidanceE
            // 
            this.labelGuidanceE.AutoSize = true;
            this.labelGuidanceE.Dock = System.Windows.Forms.DockStyle.Right;
            this.labelGuidanceE.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelGuidanceE.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelGuidanceE.Location = new System.Drawing.Point(179, 0);
            this.labelGuidanceE.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelGuidanceE.Name = "labelGuidanceE";
            this.labelGuidanceE.Size = new System.Drawing.Size(152, 29);
            this.labelGuidanceE.TabIndex = 2;
            this.labelGuidanceE.Text = "Method error";
            // 
            // textBoxE
            // 
            this.textBoxE.BackColor = System.Drawing.SystemColors.MenuText;
            this.textBoxE.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxE.Dock = System.Windows.Forms.DockStyle.Left;
            this.textBoxE.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxE.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBoxE.Location = new System.Drawing.Point(53, 0);
            this.textBoxE.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxE.Name = "textBoxE";
            this.textBoxE.Size = new System.Drawing.Size(19, 27);
            this.textBoxE.TabIndex = 0;
            this.textBoxE.Text = "2";
            this.textBoxE.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxE.TextChanged += new System.EventHandler(this.textBoxA_TextChanged);
            // 
            // labelE
            // 
            this.labelE.AutoSize = true;
            this.labelE.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelE.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelE.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelE.Location = new System.Drawing.Point(0, 0);
            this.labelE.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelE.Name = "labelE";
            this.labelE.Size = new System.Drawing.Size(53, 29);
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
            this.panelActionButtomR.Location = new System.Drawing.Point(0, 144);
            this.panelActionButtomR.Margin = new System.Windows.Forms.Padding(4);
            this.panelActionButtomR.Name = "panelActionButtomR";
            this.panelActionButtomR.Size = new System.Drawing.Size(333, 36);
            this.panelActionButtomR.TabIndex = 0;
            this.panelActionButtomR.MouseLeave += new System.EventHandler(this.panelActionButtomR_MouseLeave);
            this.panelActionButtomR.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelActionButtomR_MouseMove);
            // 
            // labelGuidanceR
            // 
            this.labelGuidanceR.AutoSize = true;
            this.labelGuidanceR.Dock = System.Windows.Forms.DockStyle.Right;
            this.labelGuidanceR.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelGuidanceR.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelGuidanceR.Location = new System.Drawing.Point(93, 0);
            this.labelGuidanceR.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelGuidanceR.Name = "labelGuidanceR";
            this.labelGuidanceR.Size = new System.Drawing.Size(238, 29);
            this.labelGuidanceR.TabIndex = 2;
            this.labelGuidanceR.Text = "Parameter of method";
            // 
            // textBoxR
            // 
            this.textBoxR.BackColor = System.Drawing.SystemColors.MenuText;
            this.textBoxR.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxR.Dock = System.Windows.Forms.DockStyle.Left;
            this.textBoxR.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxR.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBoxR.Location = new System.Drawing.Point(47, 0);
            this.textBoxR.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxR.Name = "textBoxR";
            this.textBoxR.Size = new System.Drawing.Size(19, 27);
            this.textBoxR.TabIndex = 0;
            this.textBoxR.Text = "2";
            this.textBoxR.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxR.TextChanged += new System.EventHandler(this.textBoxA_TextChanged);
            // 
            // labelR
            // 
            this.labelR.AutoSize = true;
            this.labelR.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelR.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelR.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelR.Location = new System.Drawing.Point(0, 0);
            this.labelR.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelR.Name = "labelR";
            this.labelR.Size = new System.Drawing.Size(47, 29);
            this.labelR.TabIndex = 1;
            this.labelR.Text = "r = ";
            // 
            // panelMaxSteps
            // 
            this.panelMaxSteps.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMaxSteps.Controls.Add(this.textBoxMaxStepCount);
            this.panelMaxSteps.Controls.Add(this.labelMaxStepCount);
            this.panelMaxSteps.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMaxSteps.Location = new System.Drawing.Point(0, 108);
            this.panelMaxSteps.Margin = new System.Windows.Forms.Padding(4);
            this.panelMaxSteps.Name = "panelMaxSteps";
            this.panelMaxSteps.Size = new System.Drawing.Size(333, 36);
            this.panelMaxSteps.TabIndex = 6;
            // 
            // textBoxMaxStepCount
            // 
            this.textBoxMaxStepCount.BackColor = System.Drawing.SystemColors.MenuText;
            this.textBoxMaxStepCount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxMaxStepCount.Dock = System.Windows.Forms.DockStyle.Left;
            this.textBoxMaxStepCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxMaxStepCount.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBoxMaxStepCount.Location = new System.Drawing.Point(199, 0);
            this.textBoxMaxStepCount.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxMaxStepCount.Name = "textBoxMaxStepCount";
            this.textBoxMaxStepCount.Size = new System.Drawing.Size(19, 27);
            this.textBoxMaxStepCount.TabIndex = 0;
            this.textBoxMaxStepCount.Text = "200";
            this.textBoxMaxStepCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxMaxStepCount.TextChanged += new System.EventHandler(this.textBoxA_TextChanged);
            // 
            // labelMaxStepCount
            // 
            this.labelMaxStepCount.AutoSize = true;
            this.labelMaxStepCount.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelMaxStepCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMaxStepCount.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelMaxStepCount.Location = new System.Drawing.Point(0, 0);
            this.labelMaxStepCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMaxStepCount.Name = "labelMaxStepCount";
            this.labelMaxStepCount.Size = new System.Drawing.Size(199, 29);
            this.labelMaxStepCount.TabIndex = 1;
            this.labelMaxStepCount.Text = "Max step count = ";
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
            this.panelActionButtomRegion.Location = new System.Drawing.Point(0, 72);
            this.panelActionButtomRegion.Margin = new System.Windows.Forms.Padding(4);
            this.panelActionButtomRegion.Name = "panelActionButtomRegion";
            this.panelActionButtomRegion.Size = new System.Drawing.Size(333, 36);
            this.panelActionButtomRegion.TabIndex = 1;
            // 
            // labelRegionEnd
            // 
            this.labelRegionEnd.AutoSize = true;
            this.labelRegionEnd.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelRegionEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRegionEnd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelRegionEnd.Location = new System.Drawing.Point(114, 0);
            this.labelRegionEnd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRegionEnd.Name = "labelRegionEnd";
            this.labelRegionEnd.Size = new System.Drawing.Size(20, 29);
            this.labelRegionEnd.TabIndex = 0;
            this.labelRegionEnd.Text = "]";
            // 
            // textBoxXEnd
            // 
            this.textBoxXEnd.BackColor = System.Drawing.SystemColors.MenuText;
            this.textBoxXEnd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxXEnd.Dock = System.Windows.Forms.DockStyle.Left;
            this.textBoxXEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxXEnd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBoxXEnd.Location = new System.Drawing.Point(95, 0);
            this.textBoxXEnd.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxXEnd.Name = "textBoxXEnd";
            this.textBoxXEnd.Size = new System.Drawing.Size(19, 27);
            this.textBoxXEnd.TabIndex = 6;
            this.textBoxXEnd.Text = "2";
            this.textBoxXEnd.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxXEnd.TextChanged += new System.EventHandler(this.textBoxA_TextChanged);
            // 
            // labelZpt
            // 
            this.labelZpt.AutoSize = true;
            this.labelZpt.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelZpt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelZpt.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelZpt.Location = new System.Drawing.Point(76, 0);
            this.labelZpt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelZpt.Name = "labelZpt";
            this.labelZpt.Size = new System.Drawing.Size(19, 29);
            this.labelZpt.TabIndex = 2;
            this.labelZpt.Text = ",";
            // 
            // textBoxXBegin
            // 
            this.textBoxXBegin.BackColor = System.Drawing.SystemColors.MenuText;
            this.textBoxXBegin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxXBegin.Dock = System.Windows.Forms.DockStyle.Left;
            this.textBoxXBegin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxXBegin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBoxXBegin.Location = new System.Drawing.Point(57, 0);
            this.textBoxXBegin.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxXBegin.Name = "textBoxXBegin";
            this.textBoxXBegin.Size = new System.Drawing.Size(19, 27);
            this.textBoxXBegin.TabIndex = 5;
            this.textBoxXBegin.Text = "2";
            this.textBoxXBegin.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxXBegin.TextChanged += new System.EventHandler(this.textBoxA_TextChanged);
            // 
            // labelRegionBegin
            // 
            this.labelRegionBegin.AutoSize = true;
            this.labelRegionBegin.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelRegionBegin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRegionBegin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelRegionBegin.Location = new System.Drawing.Point(0, 0);
            this.labelRegionBegin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRegionBegin.Name = "labelRegionBegin";
            this.labelRegionBegin.Size = new System.Drawing.Size(57, 29);
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
            this.panelActionButtomParamFunc.Location = new System.Drawing.Point(0, 36);
            this.panelActionButtomParamFunc.Margin = new System.Windows.Forms.Padding(4);
            this.panelActionButtomParamFunc.Name = "panelActionButtomParamFunc";
            this.panelActionButtomParamFunc.Size = new System.Drawing.Size(333, 36);
            this.panelActionButtomParamFunc.TabIndex = 2;
            // 
            // labelSinEnd
            // 
            this.labelSinEnd.AutoSize = true;
            this.labelSinEnd.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelSinEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSinEnd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelSinEnd.Location = new System.Drawing.Point(309, 0);
            this.labelSinEnd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSinEnd.Name = "labelSinEnd";
            this.labelSinEnd.Size = new System.Drawing.Size(32, 29);
            this.labelSinEnd.TabIndex = 0;
            this.labelSinEnd.Text = "x)";
            // 
            // textBoxD
            // 
            this.textBoxD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.textBoxD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxD.Dock = System.Windows.Forms.DockStyle.Left;
            this.textBoxD.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxD.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBoxD.Location = new System.Drawing.Point(290, 0);
            this.textBoxD.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxD.Name = "textBoxD";
            this.textBoxD.Size = new System.Drawing.Size(19, 27);
            this.textBoxD.TabIndex = 4;
            this.textBoxD.Text = "5";
            this.textBoxD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxD.TextChanged += new System.EventHandler(this.textBoxA_TextChanged);
            // 
            // labelSinBegin
            // 
            this.labelSinBegin.AutoSize = true;
            this.labelSinBegin.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelSinBegin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSinBegin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelSinBegin.Location = new System.Drawing.Point(238, 0);
            this.labelSinBegin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSinBegin.Name = "labelSinBegin";
            this.labelSinBegin.Size = new System.Drawing.Size(52, 29);
            this.labelSinBegin.TabIndex = 2;
            this.labelSinBegin.Text = "sin(";
            // 
            // textBoxC
            // 
            this.textBoxC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.textBoxC.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxC.Dock = System.Windows.Forms.DockStyle.Left;
            this.textBoxC.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxC.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBoxC.Location = new System.Drawing.Point(219, 0);
            this.textBoxC.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxC.Name = "textBoxC";
            this.textBoxC.Size = new System.Drawing.Size(19, 27);
            this.textBoxC.TabIndex = 3;
            this.textBoxC.Text = "3";
            this.textBoxC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxC.TextChanged += new System.EventHandler(this.textBoxA_TextChanged);
            // 
            // labelCosEnd
            // 
            this.labelCosEnd.AutoSize = true;
            this.labelCosEnd.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelCosEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCosEnd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelCosEnd.Location = new System.Drawing.Point(173, 0);
            this.labelCosEnd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCosEnd.Name = "labelCosEnd";
            this.labelCosEnd.Size = new System.Drawing.Size(46, 29);
            this.labelCosEnd.TabIndex = 4;
            this.labelCosEnd.Text = "x)+";
            // 
            // textBoxB
            // 
            this.textBoxB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.textBoxB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxB.Dock = System.Windows.Forms.DockStyle.Left;
            this.textBoxB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxB.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBoxB.Location = new System.Drawing.Point(154, 0);
            this.textBoxB.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxB.Name = "textBoxB";
            this.textBoxB.Size = new System.Drawing.Size(19, 27);
            this.textBoxB.TabIndex = 2;
            this.textBoxB.Text = "3";
            this.textBoxB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxB.TextChanged += new System.EventHandler(this.textBoxA_TextChanged);
            // 
            // labelCosBegin
            // 
            this.labelCosBegin.AutoSize = true;
            this.labelCosBegin.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelCosBegin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCosBegin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelCosBegin.Location = new System.Drawing.Point(95, 0);
            this.labelCosBegin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCosBegin.Name = "labelCosBegin";
            this.labelCosBegin.Size = new System.Drawing.Size(59, 29);
            this.labelCosBegin.TabIndex = 6;
            this.labelCosBegin.Text = "cos(";
            // 
            // textBoxA
            // 
            this.textBoxA.BackColor = System.Drawing.Color.Red;
            this.textBoxA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxA.Dock = System.Windows.Forms.DockStyle.Left;
            this.textBoxA.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxA.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBoxA.Location = new System.Drawing.Point(76, 0);
            this.textBoxA.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxA.Name = "textBoxA";
            this.textBoxA.Size = new System.Drawing.Size(19, 27);
            this.textBoxA.TabIndex = 1;
            this.textBoxA.Text = "2";
            this.textBoxA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxA.TextChanged += new System.EventHandler(this.textBoxA_TextChanged);
            // 
            // labelFunc
            // 
            this.labelFunc.AutoSize = true;
            this.labelFunc.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelFunc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFunc.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelFunc.Location = new System.Drawing.Point(7, 0);
            this.labelFunc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFunc.Name = "labelFunc";
            this.labelFunc.Size = new System.Drawing.Size(69, 29);
            this.labelFunc.TabIndex = 9;
            this.labelFunc.Text = "F(x)=";
            // 
            // panelFuncBegin
            // 
            this.panelFuncBegin.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelFuncBegin.Location = new System.Drawing.Point(0, 0);
            this.panelFuncBegin.Margin = new System.Windows.Forms.Padding(4);
            this.panelFuncBegin.Name = "panelFuncBegin";
            this.panelFuncBegin.Size = new System.Drawing.Size(7, 34);
            this.panelFuncBegin.TabIndex = 8;
            // 
            // panelActionRun
            // 
            this.panelActionRun.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelActionRun.Controls.Add(this.buttonRun);
            this.panelActionRun.Controls.Add(this.labelNameMethod);
            this.panelActionRun.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelActionRun.Location = new System.Drawing.Point(0, 0);
            this.panelActionRun.Margin = new System.Windows.Forms.Padding(4);
            this.panelActionRun.Name = "panelActionRun";
            this.panelActionRun.Size = new System.Drawing.Size(333, 36);
            this.panelActionRun.TabIndex = 5;
            // 
            // buttonRun
            // 
            this.buttonRun.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonRun.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonRun.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRun.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonRun.Location = new System.Drawing.Point(151, 0);
            this.buttonRun.Margin = new System.Windows.Forms.Padding(4);
            this.buttonRun.Name = "buttonRun";
            this.buttonRun.Size = new System.Drawing.Size(180, 34);
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
            this.labelNameMethod.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNameMethod.Name = "labelNameMethod";
            this.labelNameMethod.Size = new System.Drawing.Size(151, 33);
            this.labelNameMethod.TabIndex = 0;
            this.labelNameMethod.Text = "BruteForce";
            // 
            // labelRecomendation
            // 
            this.labelRecomendation.AutoSize = true;
            this.labelRecomendation.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelRecomendation.Font = new System.Drawing.Font("Microsoft Sans Serif", 75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRecomendation.ForeColor = System.Drawing.SystemColors.Control;
            this.labelRecomendation.Location = new System.Drawing.Point(0, 283);
            this.labelRecomendation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRecomendation.Name = "labelRecomendation";
            this.labelRecomendation.Size = new System.Drawing.Size(1111, 142);
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
            this.labelNoData.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNoData.Name = "labelNoData";
            this.labelNoData.Size = new System.Drawing.Size(1033, 283);
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
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1685, 838);
            this.Controls.Add(this.panelAction);
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.panelButtom);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "Decision making system";
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelButtom.ResumeLayout(false);
            this.panelLeft.ResumeLayout(false);
            this.panelRight.ResumeLayout(false);
            this.panelAction.ResumeLayout(false);
            this.panelAction.PerformLayout();
            this.panelActionHideButtom.ResumeLayout(false);
            this.panelActionButtom.ResumeLayout(false);
            this.panelGraphConrtol.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panelPostProcessing.ResumeLayout(false);
            this.panelMinimum.ResumeLayout(false);
            this.panelMinimum.PerformLayout();
            this.panelStepCount.ResumeLayout(false);
            this.panelStepCount.PerformLayout();
            this.panelDefaultZoom.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelZoomX.ResumeLayout(false);
            this.panelZoomX.PerformLayout();
            this.panelLinesAndPoints.ResumeLayout(false);
            this.panelActionButtomParam.ResumeLayout(false);
            this.panelActionButtomE.ResumeLayout(false);
            this.panelActionButtomE.PerformLayout();
            this.panelActionButtomR.ResumeLayout(false);
            this.panelActionButtomR.PerformLayout();
            this.panelMaxSteps.ResumeLayout(false);
            this.panelMaxSteps.PerformLayout();
            this.panelActionButtomRegion.ResumeLayout(false);
            this.panelActionButtomRegion.PerformLayout();
            this.panelActionButtomParamFunc.ResumeLayout(false);
            this.panelActionButtomParamFunc.PerformLayout();
            this.panelActionRun.ResumeLayout(false);
            this.panelActionRun.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
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
        private System.Windows.Forms.Button buttonChangePerspectiveLeft;
        private System.Windows.Forms.Button buttonChangePerspectiveRight;
        private System.Windows.Forms.Panel panelStatus;
        private System.ComponentModel.BackgroundWorker TextAnimation;
        private System.ComponentModel.BackgroundWorker panelCloser;
        private System.ComponentModel.BackgroundWorker runMethod;
        private System.Windows.Forms.Label labelFunc;
        private ZedGraph.ZedGraphControl zedGraphControlMain;
        private System.Windows.Forms.Label labelStage;
        private System.Windows.Forms.Label labelMousePosition;
        private System.Windows.Forms.Panel panelMaxSteps;
        private System.Windows.Forms.TextBox textBoxMaxStepCount;
        private System.Windows.Forms.Label labelMaxStepCount;
        private System.Windows.Forms.Panel panelGraphConrtol;
        private System.Windows.Forms.Panel panelPostProcessing;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelZoomYEnd;
        private System.Windows.Forms.TextBox textBoxZoomYEnd;
        private System.Windows.Forms.Label labelZoomYMid;
        private System.Windows.Forms.TextBox textBoxZoomYBegin;
        private System.Windows.Forms.Label labelZoomYBegin;
        private System.Windows.Forms.Panel panelZoomX;
        private System.Windows.Forms.Label labelZoomXEnd;
        private System.Windows.Forms.TextBox textBoxZoomXEnd;
        private System.Windows.Forms.Label labelZoomXMid;
        private System.Windows.Forms.TextBox textBoxZoomXBegin;
        private System.Windows.Forms.Label labelZoomXBegin;
        private System.Windows.Forms.Panel panelDefaultZoom;
        private System.Windows.Forms.Button buttonDefaultZoom;
        private System.Windows.Forms.Panel panelStepCount;
        private System.Windows.Forms.Label labelOfStep;
        private System.Windows.Forms.Label labelStepCount;
        private System.Windows.Forms.Label labelMaxStepCountResult;
        private System.Windows.Forms.Panel panelLinesAndPoints;
        private System.Windows.Forms.Button buttonWithLine;
        private System.Windows.Forms.Button buttonWithPoints;
        private System.Windows.Forms.Button buttonZoomApply;
        private System.Windows.Forms.Panel panelMinimum;
        private System.Windows.Forms.Label labelMinEnd;
        private System.Windows.Forms.TextBox textBoxYMin;
        private System.Windows.Forms.Label labelMinMid;
        private System.Windows.Forms.TextBox textBoxXMin;
        private System.Windows.Forms.Label labelMinBegin;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Label labelTable;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
    }
}