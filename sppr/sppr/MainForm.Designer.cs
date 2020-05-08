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
            this.panelBottom = new System.Windows.Forms.Panel();
            this.panelStatus = new System.Windows.Forms.Panel();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.buttonChangePerspectiveLeft = new System.Windows.Forms.Button();
            this.panelRight = new System.Windows.Forms.Panel();
            this.buttonChangePerspectiveRight = new System.Windows.Forms.Button();
            this.panelAction = new System.Windows.Forms.Panel();
            this.labelErrorList = new System.Windows.Forms.Label();
            this.labelStage = new System.Windows.Forms.Label();
            this.zedGraphControlMain = new ZedGraph.ZedGraphControl();
            this.panelActionHideBottom = new System.Windows.Forms.Panel();
            this.buttonActionBottom = new System.Windows.Forms.Button();
            this.panelActionBottom = new System.Windows.Forms.Panel();
            this.panelGraphConrtol = new System.Windows.Forms.Panel();
            this.panelTable = new System.Windows.Forms.Panel();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.panelSortTopCount = new System.Windows.Forms.Panel();
            this.buttonTop45 = new System.Windows.Forms.Button();
            this.buttonTop30 = new System.Windows.Forms.Button();
            this.buttonTop15 = new System.Windows.Forms.Button();
            this.labelTopCount = new System.Windows.Forms.Label();
            this.panelSortGrade = new System.Windows.Forms.Panel();
            this.buttonTopDown = new System.Windows.Forms.Button();
            this.buttonBottomUp = new System.Windows.Forms.Button();
            this.labelSortingDirection = new System.Windows.Forms.Label();
            this.panelSortedBy = new System.Windows.Forms.Panel();
            this.buttonSortY = new System.Windows.Forms.Button();
            this.buttonSortX = new System.Windows.Forms.Button();
            this.buttonSortI = new System.Windows.Forms.Button();
            this.labelSortedBy = new System.Windows.Forms.Label();
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
            this.panelActionBottomParam = new System.Windows.Forms.Panel();
            this.panelActionBottomE = new System.Windows.Forms.Panel();
            this.labelGuidanceE = new System.Windows.Forms.Label();
            this.textBoxE = new System.Windows.Forms.TextBox();
            this.labelE = new System.Windows.Forms.Label();
            this.panelActionBottomR = new System.Windows.Forms.Panel();
            this.labelGuidanceR = new System.Windows.Forms.Label();
            this.textBoxR = new System.Windows.Forms.TextBox();
            this.labelR = new System.Windows.Forms.Label();
            this.panelMaxSteps = new System.Windows.Forms.Panel();
            this.textBoxMaxStepCount = new System.Windows.Forms.TextBox();
            this.labelMaxStepCount = new System.Windows.Forms.Label();
            this.panelActionBottomRegion = new System.Windows.Forms.Panel();
            this.labelRegionEnd = new System.Windows.Forms.Label();
            this.textBoxXEnd = new System.Windows.Forms.TextBox();
            this.labelZpt = new System.Windows.Forms.Label();
            this.textBoxXBegin = new System.Windows.Forms.TextBox();
            this.labelRegionBegin = new System.Windows.Forms.Label();
            this.panelActionBottomParamFunc = new System.Windows.Forms.Panel();
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
            this.panelBottomAnimation = new System.ComponentModel.BackgroundWorker();
            this.panelLeftAnimation = new System.ComponentModel.BackgroundWorker();
            this.panelRightAnimation = new System.ComponentModel.BackgroundWorker();
            this.panelActionBottomAnimation = new System.ComponentModel.BackgroundWorker();
            this.panelHeaderAnimation = new System.ComponentModel.BackgroundWorker();
            this.TextAnimation = new System.ComponentModel.BackgroundWorker();
            this.panelCloser = new System.ComponentModel.BackgroundWorker();
            this.runMethod = new System.ComponentModel.BackgroundWorker();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.Conami = new System.ComponentModel.BackgroundWorker();
            this.labelTheEnd = new System.Windows.Forms.Label();
            this.panelHeader.SuspendLayout();
            this.panelBottom.SuspendLayout();
            this.panelLeft.SuspendLayout();
            this.panelRight.SuspendLayout();
            this.panelAction.SuspendLayout();
            this.panelActionHideBottom.SuspendLayout();
            this.panelActionBottom.SuspendLayout();
            this.panelGraphConrtol.SuspendLayout();
            this.panelTable.SuspendLayout();
            this.panelSortTopCount.SuspendLayout();
            this.panelSortGrade.SuspendLayout();
            this.panelSortedBy.SuspendLayout();
            this.panelPostProcessing.SuspendLayout();
            this.panelMinimum.SuspendLayout();
            this.panelStepCount.SuspendLayout();
            this.panelDefaultZoom.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelZoomX.SuspendLayout();
            this.panelLinesAndPoints.SuspendLayout();
            this.panelActionBottomParam.SuspendLayout();
            this.panelActionBottomE.SuspendLayout();
            this.panelActionBottomR.SuspendLayout();
            this.panelMaxSteps.SuspendLayout();
            this.panelActionBottomRegion.SuspendLayout();
            this.panelActionBottomParamFunc.SuspendLayout();
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
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1264, 50);
            this.panelHeader.TabIndex = 4;
            this.panelHeader.Paint += new System.Windows.Forms.PaintEventHandler(this.panelHeader_Paint);
            // 
            // labelMousePosition
            // 
            this.labelMousePosition.AutoSize = true;
            this.labelMousePosition.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelMousePosition.Location = new System.Drawing.Point(0, 0);
            this.labelMousePosition.Name = "labelMousePosition";
            this.labelMousePosition.Size = new System.Drawing.Size(16, 13);
            this.labelMousePosition.TabIndex = 0;
            this.labelMousePosition.Text = "M";
            this.labelMousePosition.Visible = false;
            // 
            // panelBottom
            // 
            this.panelBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(0)))), ((int)(((byte)(30)))));
            this.panelBottom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBottom.Controls.Add(this.labelTheEnd);
            this.panelBottom.Controls.Add(this.panelStatus);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 651);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(1264, 30);
            this.panelBottom.TabIndex = 3;
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
            this.buttonChangePerspectiveLeft.MouseLeave += new System.EventHandler(this.buttonChangePerspectiveLeft_MouseLeave);
            this.buttonChangePerspectiveLeft.MouseMove += new System.Windows.Forms.MouseEventHandler(this.buttonChangePerspectiveLeft_MouseMove);
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
            this.panelAction.Controls.Add(this.labelErrorList);
            this.panelAction.Controls.Add(this.labelStage);
            this.panelAction.Controls.Add(this.zedGraphControlMain);
            this.panelAction.Controls.Add(this.panelActionHideBottom);
            this.panelAction.Controls.Add(this.panelActionBottom);
            this.panelAction.Controls.Add(this.labelRecomendation);
            this.panelAction.Controls.Add(this.labelNoData);
            this.panelAction.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAction.Location = new System.Drawing.Point(70, 50);
            this.panelAction.Name = "panelAction";
            this.panelAction.Size = new System.Drawing.Size(1124, 601);
            this.panelAction.TabIndex = 0;
            // 
            // labelErrorList
            // 
            this.labelErrorList.AutoSize = true;
            this.labelErrorList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelErrorList.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelErrorList.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelErrorList.Location = new System.Drawing.Point(0, 452);
            this.labelErrorList.Name = "labelErrorList";
            this.labelErrorList.Size = new System.Drawing.Size(60, 24);
            this.labelErrorList.TabIndex = 2;
            this.labelErrorList.Text = "label1";
            this.labelErrorList.Visible = false;
            this.labelErrorList.Click += new System.EventHandler(this.labelErrorList_Click);
            // 
            // labelStage
            // 
            this.labelStage.AutoSize = true;
            this.labelStage.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelStage.Font = new System.Drawing.Font("Microsoft Sans Serif", 75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelStage.ForeColor = System.Drawing.SystemColors.Control;
            this.labelStage.Location = new System.Drawing.Point(0, 339);
            this.labelStage.Name = "labelStage";
            this.labelStage.Size = new System.Drawing.Size(409, 113);
            this.labelStage.TabIndex = 5;
            this.labelStage.Text = "ERROR";
            this.labelStage.Visible = false;
            // 
            // zedGraphControlMain
            // 
            this.zedGraphControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.zedGraphControlMain.IsShowPointValues = false;
            this.zedGraphControlMain.Location = new System.Drawing.Point(0, 339);
            this.zedGraphControlMain.Name = "zedGraphControlMain";
            this.zedGraphControlMain.PointValueFormat = "G";
            this.zedGraphControlMain.Size = new System.Drawing.Size(1124, 10);
            this.zedGraphControlMain.TabIndex = 4;
            this.zedGraphControlMain.Visible = false;
            this.zedGraphControlMain.DoubleClick += new System.EventHandler(this.zedGraphControlMain_DoubleClick);
            this.zedGraphControlMain.MouseDown += new System.Windows.Forms.MouseEventHandler(this.zedGraphControlMain_MouseDown);
            this.zedGraphControlMain.MouseLeave += new System.EventHandler(this.zedGraphControlMain_MouseLeave);
            this.zedGraphControlMain.MouseMove += new System.Windows.Forms.MouseEventHandler(this.zedGraphControlMain_MouseMove);
            this.zedGraphControlMain.MouseUp += new System.Windows.Forms.MouseEventHandler(this.zedGraphControlMain_MouseUp);
            this.zedGraphControlMain.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.zedGraphControlMain_MouseWheel);
            // 
            // panelActionHideBottom
            // 
            this.panelActionHideBottom.Controls.Add(this.buttonActionBottom);
            this.panelActionHideBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelActionHideBottom.Location = new System.Drawing.Point(0, 349);
            this.panelActionHideBottom.Name = "panelActionHideBottom";
            this.panelActionHideBottom.Size = new System.Drawing.Size(1124, 26);
            this.panelActionHideBottom.TabIndex = 0;
            // 
            // buttonActionBottom
            // 
            this.buttonActionBottom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonActionBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonActionBottom.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonActionBottom.FlatAppearance.BorderSize = 0;
            this.buttonActionBottom.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.buttonActionBottom.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.buttonActionBottom.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonActionBottom.Location = new System.Drawing.Point(0, 0);
            this.buttonActionBottom.Name = "buttonActionBottom";
            this.buttonActionBottom.Size = new System.Drawing.Size(1124, 26);
            this.buttonActionBottom.TabIndex = 0;
            this.buttonActionBottom.TabStop = false;
            this.buttonActionBottom.Text = "▼";
            this.buttonActionBottom.UseVisualStyleBackColor = true;
            this.buttonActionBottom.Click += new System.EventHandler(this.buttonActionBottom_Click);
            // 
            // panelActionBottom
            // 
            this.panelActionBottom.Controls.Add(this.panelGraphConrtol);
            this.panelActionBottom.Controls.Add(this.panelActionBottomParam);
            this.panelActionBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelActionBottom.Location = new System.Drawing.Point(0, 375);
            this.panelActionBottom.Name = "panelActionBottom";
            this.panelActionBottom.Size = new System.Drawing.Size(1124, 226);
            this.panelActionBottom.TabIndex = 1;
            // 
            // panelGraphConrtol
            // 
            this.panelGraphConrtol.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelGraphConrtol.Controls.Add(this.panelTable);
            this.panelGraphConrtol.Controls.Add(this.panelSortTopCount);
            this.panelGraphConrtol.Controls.Add(this.panelSortGrade);
            this.panelGraphConrtol.Controls.Add(this.panelSortedBy);
            this.panelGraphConrtol.Controls.Add(this.panelPostProcessing);
            this.panelGraphConrtol.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGraphConrtol.Location = new System.Drawing.Point(250, 0);
            this.panelGraphConrtol.Name = "panelGraphConrtol";
            this.panelGraphConrtol.Size = new System.Drawing.Size(874, 226);
            this.panelGraphConrtol.TabIndex = 1;
            this.panelGraphConrtol.Visible = false;
            // 
            // panelTable
            // 
            this.panelTable.Controls.Add(this.tableLayoutPanel);
            this.panelTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTable.Location = new System.Drawing.Point(200, 90);
            this.panelTable.Name = "panelTable";
            this.panelTable.Size = new System.Drawing.Size(672, 134);
            this.panelTable.TabIndex = 5;
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.AutoScroll = true;
            this.tableLayoutPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.tableLayoutPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 1;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel.Size = new System.Drawing.Size(672, 134);
            this.tableLayoutPanel.TabIndex = 1;
            // 
            // panelSortTopCount
            // 
            this.panelSortTopCount.Controls.Add(this.buttonTop45);
            this.panelSortTopCount.Controls.Add(this.buttonTop30);
            this.panelSortTopCount.Controls.Add(this.buttonTop15);
            this.panelSortTopCount.Controls.Add(this.labelTopCount);
            this.panelSortTopCount.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSortTopCount.Location = new System.Drawing.Point(200, 60);
            this.panelSortTopCount.Name = "panelSortTopCount";
            this.panelSortTopCount.Size = new System.Drawing.Size(672, 30);
            this.panelSortTopCount.TabIndex = 4;
            // 
            // buttonTop45
            // 
            this.buttonTop45.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonTop45.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonTop45.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonTop45.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonTop45.Location = new System.Drawing.Point(194, 0);
            this.buttonTop45.Name = "buttonTop45";
            this.buttonTop45.Size = new System.Drawing.Size(75, 30);
            this.buttonTop45.TabIndex = 3;
            this.buttonTop45.Text = "45";
            this.buttonTop45.UseVisualStyleBackColor = true;
            this.buttonTop45.Click += new System.EventHandler(this.buttonTop45_Click);
            // 
            // buttonTop30
            // 
            this.buttonTop30.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonTop30.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonTop30.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonTop30.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonTop30.Location = new System.Drawing.Point(119, 0);
            this.buttonTop30.Name = "buttonTop30";
            this.buttonTop30.Size = new System.Drawing.Size(75, 30);
            this.buttonTop30.TabIndex = 2;
            this.buttonTop30.Text = "30";
            this.buttonTop30.UseVisualStyleBackColor = true;
            this.buttonTop30.Click += new System.EventHandler(this.buttonTop30_Click);
            // 
            // buttonTop15
            // 
            this.buttonTop15.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonTop15.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonTop15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonTop15.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonTop15.Location = new System.Drawing.Point(44, 0);
            this.buttonTop15.Name = "buttonTop15";
            this.buttonTop15.Size = new System.Drawing.Size(75, 30);
            this.buttonTop15.TabIndex = 1;
            this.buttonTop15.Text = "15";
            this.buttonTop15.UseVisualStyleBackColor = true;
            this.buttonTop15.Click += new System.EventHandler(this.buttonTop15_Click);
            // 
            // labelTopCount
            // 
            this.labelTopCount.AutoSize = true;
            this.labelTopCount.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelTopCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTopCount.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelTopCount.Location = new System.Drawing.Point(0, 0);
            this.labelTopCount.Name = "labelTopCount";
            this.labelTopCount.Size = new System.Drawing.Size(44, 24);
            this.labelTopCount.TabIndex = 0;
            this.labelTopCount.Text = "Top";
            this.labelTopCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelSortGrade
            // 
            this.panelSortGrade.Controls.Add(this.buttonTopDown);
            this.panelSortGrade.Controls.Add(this.buttonBottomUp);
            this.panelSortGrade.Controls.Add(this.labelSortingDirection);
            this.panelSortGrade.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSortGrade.Location = new System.Drawing.Point(200, 30);
            this.panelSortGrade.Name = "panelSortGrade";
            this.panelSortGrade.Size = new System.Drawing.Size(672, 30);
            this.panelSortGrade.TabIndex = 3;
            // 
            // buttonTopDown
            // 
            this.buttonTopDown.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonTopDown.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonTopDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonTopDown.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonTopDown.Location = new System.Drawing.Point(221, 0);
            this.buttonTopDown.Name = "buttonTopDown";
            this.buttonTopDown.Size = new System.Drawing.Size(75, 30);
            this.buttonTopDown.TabIndex = 2;
            this.buttonTopDown.Text = "TopDown";
            this.buttonTopDown.UseVisualStyleBackColor = true;
            this.buttonTopDown.Click += new System.EventHandler(this.buttonTopDown_Click);
            // 
            // buttonBottomUp
            // 
            this.buttonBottomUp.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonBottomUp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonBottomUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBottomUp.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonBottomUp.Location = new System.Drawing.Point(146, 0);
            this.buttonBottomUp.Name = "buttonBottomUp";
            this.buttonBottomUp.Size = new System.Drawing.Size(75, 30);
            this.buttonBottomUp.TabIndex = 1;
            this.buttonBottomUp.Text = "BottomUp";
            this.buttonBottomUp.UseVisualStyleBackColor = true;
            this.buttonBottomUp.Click += new System.EventHandler(this.buttonBottomUp_Click);
            // 
            // labelSortingDirection
            // 
            this.labelSortingDirection.AutoSize = true;
            this.labelSortingDirection.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelSortingDirection.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSortingDirection.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelSortingDirection.Location = new System.Drawing.Point(0, 0);
            this.labelSortingDirection.Name = "labelSortingDirection";
            this.labelSortingDirection.Size = new System.Drawing.Size(146, 24);
            this.labelSortingDirection.TabIndex = 0;
            this.labelSortingDirection.Text = "Sorting direction";
            this.labelSortingDirection.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelSortedBy
            // 
            this.panelSortedBy.Controls.Add(this.buttonSortY);
            this.panelSortedBy.Controls.Add(this.buttonSortX);
            this.panelSortedBy.Controls.Add(this.buttonSortI);
            this.panelSortedBy.Controls.Add(this.labelSortedBy);
            this.panelSortedBy.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSortedBy.Location = new System.Drawing.Point(200, 0);
            this.panelSortedBy.Name = "panelSortedBy";
            this.panelSortedBy.Size = new System.Drawing.Size(672, 30);
            this.panelSortedBy.TabIndex = 2;
            // 
            // buttonSortY
            // 
            this.buttonSortY.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonSortY.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSortY.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSortY.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonSortY.Location = new System.Drawing.Point(240, 0);
            this.buttonSortY.Name = "buttonSortY";
            this.buttonSortY.Size = new System.Drawing.Size(75, 30);
            this.buttonSortY.TabIndex = 3;
            this.buttonSortY.Text = "Y";
            this.buttonSortY.UseVisualStyleBackColor = true;
            this.buttonSortY.Click += new System.EventHandler(this.buttonSortY_Click);
            // 
            // buttonSortX
            // 
            this.buttonSortX.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonSortX.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSortX.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSortX.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonSortX.Location = new System.Drawing.Point(165, 0);
            this.buttonSortX.Name = "buttonSortX";
            this.buttonSortX.Size = new System.Drawing.Size(75, 30);
            this.buttonSortX.TabIndex = 2;
            this.buttonSortX.Text = "X";
            this.buttonSortX.UseVisualStyleBackColor = true;
            this.buttonSortX.Click += new System.EventHandler(this.buttonSortX_Click);
            // 
            // buttonSortI
            // 
            this.buttonSortI.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonSortI.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSortI.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSortI.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonSortI.Location = new System.Drawing.Point(90, 0);
            this.buttonSortI.Name = "buttonSortI";
            this.buttonSortI.Size = new System.Drawing.Size(75, 30);
            this.buttonSortI.TabIndex = 1;
            this.buttonSortI.Text = "iterations";
            this.buttonSortI.UseVisualStyleBackColor = true;
            this.buttonSortI.Click += new System.EventHandler(this.buttonSortI_Click);
            // 
            // labelSortedBy
            // 
            this.labelSortedBy.AutoSize = true;
            this.labelSortedBy.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelSortedBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSortedBy.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelSortedBy.Location = new System.Drawing.Point(0, 0);
            this.labelSortedBy.Name = "labelSortedBy";
            this.labelSortedBy.Size = new System.Drawing.Size(90, 24);
            this.labelSortedBy.TabIndex = 0;
            this.labelSortedBy.Text = "Sorted by";
            this.labelSortedBy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.panelPostProcessing.Name = "panelPostProcessing";
            this.panelPostProcessing.Size = new System.Drawing.Size(200, 224);
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
            this.panelMinimum.Location = new System.Drawing.Point(0, 148);
            this.panelMinimum.Name = "panelMinimum";
            this.panelMinimum.Size = new System.Drawing.Size(198, 30);
            this.panelMinimum.TabIndex = 5;
            // 
            // labelMinEnd
            // 
            this.labelMinEnd.AutoSize = true;
            this.labelMinEnd.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelMinEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMinEnd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelMinEnd.Location = new System.Drawing.Point(111, 0);
            this.labelMinEnd.Name = "labelMinEnd";
            this.labelMinEnd.Size = new System.Drawing.Size(16, 24);
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
            this.textBoxYMin.Location = new System.Drawing.Point(97, 0);
            this.textBoxYMin.Name = "textBoxYMin";
            this.textBoxYMin.ReadOnly = true;
            this.textBoxYMin.Size = new System.Drawing.Size(14, 22);
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
            this.labelMinMid.Location = new System.Drawing.Point(82, 0);
            this.labelMinMid.Name = "labelMinMid";
            this.labelMinMid.Size = new System.Drawing.Size(15, 24);
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
            this.textBoxXMin.Location = new System.Drawing.Point(68, 0);
            this.textBoxXMin.Name = "textBoxXMin";
            this.textBoxXMin.ReadOnly = true;
            this.textBoxXMin.Size = new System.Drawing.Size(14, 22);
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
            this.labelMinBegin.Name = "labelMinBegin";
            this.labelMinBegin.Size = new System.Drawing.Size(68, 24);
            this.labelMinBegin.TabIndex = 0;
            this.labelMinBegin.Text = "Min = (";
            this.labelMinBegin.Click += new System.EventHandler(this.labelMinBegin_Click);
            // 
            // panelStepCount
            // 
            this.panelStepCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelStepCount.Controls.Add(this.labelMaxStepCountResult);
            this.panelStepCount.Controls.Add(this.labelOfStep);
            this.panelStepCount.Controls.Add(this.labelStepCount);
            this.panelStepCount.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelStepCount.Location = new System.Drawing.Point(0, 118);
            this.panelStepCount.Name = "panelStepCount";
            this.panelStepCount.Size = new System.Drawing.Size(198, 30);
            this.panelStepCount.TabIndex = 3;
            // 
            // labelMaxStepCountResult
            // 
            this.labelMaxStepCountResult.AutoSize = true;
            this.labelMaxStepCountResult.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelMaxStepCountResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMaxStepCountResult.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelMaxStepCountResult.Location = new System.Drawing.Point(135, 0);
            this.labelMaxStepCountResult.Name = "labelMaxStepCountResult";
            this.labelMaxStepCountResult.Size = new System.Drawing.Size(30, 24);
            this.labelMaxStepCountResult.TabIndex = 5;
            this.labelMaxStepCountResult.Text = "10";
            // 
            // labelOfStep
            // 
            this.labelOfStep.AutoSize = true;
            this.labelOfStep.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelOfStep.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelOfStep.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelOfStep.Location = new System.Drawing.Point(30, 0);
            this.labelOfStep.Name = "labelOfStep";
            this.labelOfStep.Size = new System.Drawing.Size(105, 24);
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
            this.labelStepCount.Name = "labelStepCount";
            this.labelStepCount.Size = new System.Drawing.Size(30, 24);
            this.labelStepCount.TabIndex = 3;
            this.labelStepCount.Text = "10";
            // 
            // panelDefaultZoom
            // 
            this.panelDefaultZoom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelDefaultZoom.Controls.Add(this.buttonZoomApply);
            this.panelDefaultZoom.Controls.Add(this.buttonDefaultZoom);
            this.panelDefaultZoom.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDefaultZoom.Location = new System.Drawing.Point(0, 88);
            this.panelDefaultZoom.Name = "panelDefaultZoom";
            this.panelDefaultZoom.Size = new System.Drawing.Size(198, 30);
            this.panelDefaultZoom.TabIndex = 2;
            // 
            // buttonZoomApply
            // 
            this.buttonZoomApply.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonZoomApply.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonZoomApply.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonZoomApply.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonZoomApply.Location = new System.Drawing.Point(0, 0);
            this.buttonZoomApply.Name = "buttonZoomApply";
            this.buttonZoomApply.Size = new System.Drawing.Size(100, 28);
            this.buttonZoomApply.TabIndex = 1;
            this.buttonZoomApply.Text = "Apply";
            this.buttonZoomApply.UseVisualStyleBackColor = true;
            this.buttonZoomApply.Click += new System.EventHandler(this.buttonZoomApply_Click);
            // 
            // buttonDefaultZoom
            // 
            this.buttonDefaultZoom.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonDefaultZoom.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonDefaultZoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDefaultZoom.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonDefaultZoom.Location = new System.Drawing.Point(96, 0);
            this.buttonDefaultZoom.Name = "buttonDefaultZoom";
            this.buttonDefaultZoom.Size = new System.Drawing.Size(100, 28);
            this.buttonDefaultZoom.TabIndex = 0;
            this.buttonDefaultZoom.Text = "Default Zoom";
            this.buttonDefaultZoom.UseVisualStyleBackColor = true;
            this.buttonDefaultZoom.Click += new System.EventHandler(this.buttonDefaultZoom_Click);
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
            this.panel1.Location = new System.Drawing.Point(0, 58);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(198, 30);
            this.panel1.TabIndex = 1;
            // 
            // labelZoomYEnd
            // 
            this.labelZoomYEnd.AutoSize = true;
            this.labelZoomYEnd.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelZoomYEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelZoomYEnd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelZoomYEnd.Location = new System.Drawing.Point(143, 0);
            this.labelZoomYEnd.Name = "labelZoomYEnd";
            this.labelZoomYEnd.Size = new System.Drawing.Size(15, 24);
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
            this.textBoxZoomYEnd.Location = new System.Drawing.Point(129, 0);
            this.textBoxZoomYEnd.Name = "textBoxZoomYEnd";
            this.textBoxZoomYEnd.Size = new System.Drawing.Size(14, 22);
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
            this.labelZoomYMid.Location = new System.Drawing.Point(114, 0);
            this.labelZoomYMid.Name = "labelZoomYMid";
            this.labelZoomYMid.Size = new System.Drawing.Size(15, 24);
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
            this.textBoxZoomYBegin.Location = new System.Drawing.Point(100, 0);
            this.textBoxZoomYBegin.Name = "textBoxZoomYBegin";
            this.textBoxZoomYBegin.Size = new System.Drawing.Size(14, 22);
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
            this.labelZoomYBegin.Name = "labelZoomYBegin";
            this.labelZoomYBegin.Size = new System.Drawing.Size(100, 24);
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
            this.panelZoomX.Location = new System.Drawing.Point(0, 28);
            this.panelZoomX.Name = "panelZoomX";
            this.panelZoomX.Size = new System.Drawing.Size(198, 30);
            this.panelZoomX.TabIndex = 0;
            // 
            // labelZoomXEnd
            // 
            this.labelZoomXEnd.AutoSize = true;
            this.labelZoomXEnd.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelZoomXEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelZoomXEnd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelZoomXEnd.Location = new System.Drawing.Point(144, 0);
            this.labelZoomXEnd.Name = "labelZoomXEnd";
            this.labelZoomXEnd.Size = new System.Drawing.Size(15, 24);
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
            this.textBoxZoomXEnd.Location = new System.Drawing.Point(130, 0);
            this.textBoxZoomXEnd.Name = "textBoxZoomXEnd";
            this.textBoxZoomXEnd.Size = new System.Drawing.Size(14, 22);
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
            this.labelZoomXMid.Location = new System.Drawing.Point(115, 0);
            this.labelZoomXMid.Name = "labelZoomXMid";
            this.labelZoomXMid.Size = new System.Drawing.Size(15, 24);
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
            this.textBoxZoomXBegin.Location = new System.Drawing.Point(101, 0);
            this.textBoxZoomXBegin.Name = "textBoxZoomXBegin";
            this.textBoxZoomXBegin.Size = new System.Drawing.Size(14, 22);
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
            this.labelZoomXBegin.Name = "labelZoomXBegin";
            this.labelZoomXBegin.Size = new System.Drawing.Size(101, 24);
            this.labelZoomXBegin.TabIndex = 5;
            this.labelZoomXBegin.Text = "Zoom x ∈ [";
            // 
            // panelLinesAndPoints
            // 
            this.panelLinesAndPoints.Controls.Add(this.buttonWithLine);
            this.panelLinesAndPoints.Controls.Add(this.buttonWithPoints);
            this.panelLinesAndPoints.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLinesAndPoints.Location = new System.Drawing.Point(0, 0);
            this.panelLinesAndPoints.Name = "panelLinesAndPoints";
            this.panelLinesAndPoints.Size = new System.Drawing.Size(198, 28);
            this.panelLinesAndPoints.TabIndex = 4;
            // 
            // buttonWithLine
            // 
            this.buttonWithLine.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonWithLine.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonWithLine.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonWithLine.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonWithLine.Location = new System.Drawing.Point(98, 0);
            this.buttonWithLine.Name = "buttonWithLine";
            this.buttonWithLine.Size = new System.Drawing.Size(100, 28);
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
            this.buttonWithPoints.Name = "buttonWithPoints";
            this.buttonWithPoints.Size = new System.Drawing.Size(100, 28);
            this.buttonWithPoints.TabIndex = 0;
            this.buttonWithPoints.Text = "Points";
            this.buttonWithPoints.UseVisualStyleBackColor = true;
            this.buttonWithPoints.Click += new System.EventHandler(this.buttonWithPoints_Click);
            // 
            // panelActionBottomParam
            // 
            this.panelActionBottomParam.Controls.Add(this.panelActionBottomE);
            this.panelActionBottomParam.Controls.Add(this.panelActionBottomR);
            this.panelActionBottomParam.Controls.Add(this.panelMaxSteps);
            this.panelActionBottomParam.Controls.Add(this.panelActionBottomRegion);
            this.panelActionBottomParam.Controls.Add(this.panelActionBottomParamFunc);
            this.panelActionBottomParam.Controls.Add(this.panelActionRun);
            this.panelActionBottomParam.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelActionBottomParam.Location = new System.Drawing.Point(0, 0);
            this.panelActionBottomParam.Name = "panelActionBottomParam";
            this.panelActionBottomParam.Size = new System.Drawing.Size(250, 226);
            this.panelActionBottomParam.TabIndex = 0;
            // 
            // panelActionBottomE
            // 
            this.panelActionBottomE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelActionBottomE.Controls.Add(this.labelGuidanceE);
            this.panelActionBottomE.Controls.Add(this.textBoxE);
            this.panelActionBottomE.Controls.Add(this.labelE);
            this.panelActionBottomE.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelActionBottomE.Location = new System.Drawing.Point(0, 150);
            this.panelActionBottomE.Name = "panelActionBottomE";
            this.panelActionBottomE.Size = new System.Drawing.Size(250, 30);
            this.panelActionBottomE.TabIndex = 4;
            this.panelActionBottomE.MouseLeave += new System.EventHandler(this.panelActionBottomE_MouseLeave);
            this.panelActionBottomE.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelActionBottomE_MouseMove);
            // 
            // labelGuidanceE
            // 
            this.labelGuidanceE.AutoSize = true;
            this.labelGuidanceE.Dock = System.Windows.Forms.DockStyle.Right;
            this.labelGuidanceE.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelGuidanceE.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelGuidanceE.Location = new System.Drawing.Point(129, 0);
            this.labelGuidanceE.Name = "labelGuidanceE";
            this.labelGuidanceE.Size = new System.Drawing.Size(119, 24);
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
            this.textBoxE.Location = new System.Drawing.Point(42, 0);
            this.textBoxE.Name = "textBoxE";
            this.textBoxE.Size = new System.Drawing.Size(14, 22);
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
            this.labelE.Name = "labelE";
            this.labelE.Size = new System.Drawing.Size(42, 24);
            this.labelE.TabIndex = 1;
            this.labelE.Text = "e = ";
            // 
            // panelActionBottomR
            // 
            this.panelActionBottomR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelActionBottomR.Controls.Add(this.labelGuidanceR);
            this.panelActionBottomR.Controls.Add(this.textBoxR);
            this.panelActionBottomR.Controls.Add(this.labelR);
            this.panelActionBottomR.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelActionBottomR.Location = new System.Drawing.Point(0, 120);
            this.panelActionBottomR.Name = "panelActionBottomR";
            this.panelActionBottomR.Size = new System.Drawing.Size(250, 30);
            this.panelActionBottomR.TabIndex = 0;
            this.panelActionBottomR.MouseLeave += new System.EventHandler(this.panelActionBottomR_MouseLeave);
            this.panelActionBottomR.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelActionBottomR_MouseMove);
            // 
            // labelGuidanceR
            // 
            this.labelGuidanceR.AutoSize = true;
            this.labelGuidanceR.Dock = System.Windows.Forms.DockStyle.Right;
            this.labelGuidanceR.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelGuidanceR.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelGuidanceR.Location = new System.Drawing.Point(63, 0);
            this.labelGuidanceR.Name = "labelGuidanceR";
            this.labelGuidanceR.Size = new System.Drawing.Size(185, 24);
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
            this.textBoxR.Location = new System.Drawing.Point(37, 0);
            this.textBoxR.Name = "textBoxR";
            this.textBoxR.Size = new System.Drawing.Size(14, 22);
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
            this.labelR.Name = "labelR";
            this.labelR.Size = new System.Drawing.Size(37, 24);
            this.labelR.TabIndex = 1;
            this.labelR.Text = "r = ";
            // 
            // panelMaxSteps
            // 
            this.panelMaxSteps.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMaxSteps.Controls.Add(this.textBoxMaxStepCount);
            this.panelMaxSteps.Controls.Add(this.labelMaxStepCount);
            this.panelMaxSteps.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMaxSteps.Location = new System.Drawing.Point(0, 90);
            this.panelMaxSteps.Name = "panelMaxSteps";
            this.panelMaxSteps.Size = new System.Drawing.Size(250, 30);
            this.panelMaxSteps.TabIndex = 6;
            // 
            // textBoxMaxStepCount
            // 
            this.textBoxMaxStepCount.BackColor = System.Drawing.SystemColors.MenuText;
            this.textBoxMaxStepCount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxMaxStepCount.Dock = System.Windows.Forms.DockStyle.Left;
            this.textBoxMaxStepCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxMaxStepCount.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBoxMaxStepCount.Location = new System.Drawing.Point(159, 0);
            this.textBoxMaxStepCount.Name = "textBoxMaxStepCount";
            this.textBoxMaxStepCount.Size = new System.Drawing.Size(14, 22);
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
            this.labelMaxStepCount.Name = "labelMaxStepCount";
            this.labelMaxStepCount.Size = new System.Drawing.Size(159, 24);
            this.labelMaxStepCount.TabIndex = 1;
            this.labelMaxStepCount.Text = "Max step count = ";
            // 
            // panelActionBottomRegion
            // 
            this.panelActionBottomRegion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelActionBottomRegion.Controls.Add(this.labelRegionEnd);
            this.panelActionBottomRegion.Controls.Add(this.textBoxXEnd);
            this.panelActionBottomRegion.Controls.Add(this.labelZpt);
            this.panelActionBottomRegion.Controls.Add(this.textBoxXBegin);
            this.panelActionBottomRegion.Controls.Add(this.labelRegionBegin);
            this.panelActionBottomRegion.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelActionBottomRegion.Location = new System.Drawing.Point(0, 60);
            this.panelActionBottomRegion.Name = "panelActionBottomRegion";
            this.panelActionBottomRegion.Size = new System.Drawing.Size(250, 30);
            this.panelActionBottomRegion.TabIndex = 1;
            // 
            // labelRegionEnd
            // 
            this.labelRegionEnd.AutoSize = true;
            this.labelRegionEnd.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelRegionEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRegionEnd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelRegionEnd.Location = new System.Drawing.Point(89, 0);
            this.labelRegionEnd.Name = "labelRegionEnd";
            this.labelRegionEnd.Size = new System.Drawing.Size(15, 24);
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
            this.textBoxXEnd.Location = new System.Drawing.Point(75, 0);
            this.textBoxXEnd.Name = "textBoxXEnd";
            this.textBoxXEnd.Size = new System.Drawing.Size(14, 22);
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
            this.labelZpt.Location = new System.Drawing.Point(60, 0);
            this.labelZpt.Name = "labelZpt";
            this.labelZpt.Size = new System.Drawing.Size(15, 24);
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
            this.textBoxXBegin.Location = new System.Drawing.Point(46, 0);
            this.textBoxXBegin.Name = "textBoxXBegin";
            this.textBoxXBegin.Size = new System.Drawing.Size(14, 22);
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
            this.labelRegionBegin.Name = "labelRegionBegin";
            this.labelRegionBegin.Size = new System.Drawing.Size(46, 24);
            this.labelRegionBegin.TabIndex = 4;
            this.labelRegionBegin.Text = "x ∈ [";
            // 
            // panelActionBottomParamFunc
            // 
            this.panelActionBottomParamFunc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelActionBottomParamFunc.Controls.Add(this.labelSinEnd);
            this.panelActionBottomParamFunc.Controls.Add(this.textBoxD);
            this.panelActionBottomParamFunc.Controls.Add(this.labelSinBegin);
            this.panelActionBottomParamFunc.Controls.Add(this.textBoxC);
            this.panelActionBottomParamFunc.Controls.Add(this.labelCosEnd);
            this.panelActionBottomParamFunc.Controls.Add(this.textBoxB);
            this.panelActionBottomParamFunc.Controls.Add(this.labelCosBegin);
            this.panelActionBottomParamFunc.Controls.Add(this.textBoxA);
            this.panelActionBottomParamFunc.Controls.Add(this.labelFunc);
            this.panelActionBottomParamFunc.Controls.Add(this.panelFuncBegin);
            this.panelActionBottomParamFunc.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelActionBottomParamFunc.Location = new System.Drawing.Point(0, 30);
            this.panelActionBottomParamFunc.Name = "panelActionBottomParamFunc";
            this.panelActionBottomParamFunc.Size = new System.Drawing.Size(250, 30);
            this.panelActionBottomParamFunc.TabIndex = 2;
            // 
            // labelSinEnd
            // 
            this.labelSinEnd.AutoSize = true;
            this.labelSinEnd.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelSinEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSinEnd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelSinEnd.Location = new System.Drawing.Point(239, 0);
            this.labelSinEnd.Name = "labelSinEnd";
            this.labelSinEnd.Size = new System.Drawing.Size(26, 24);
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
            this.textBoxD.Location = new System.Drawing.Point(225, 0);
            this.textBoxD.Name = "textBoxD";
            this.textBoxD.Size = new System.Drawing.Size(14, 22);
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
            this.labelSinBegin.Location = new System.Drawing.Point(185, 0);
            this.labelSinBegin.Name = "labelSinBegin";
            this.labelSinBegin.Size = new System.Drawing.Size(40, 24);
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
            this.textBoxC.Location = new System.Drawing.Point(171, 0);
            this.textBoxC.Name = "textBoxC";
            this.textBoxC.Size = new System.Drawing.Size(14, 22);
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
            this.labelCosEnd.Location = new System.Drawing.Point(134, 0);
            this.labelCosEnd.Name = "labelCosEnd";
            this.labelCosEnd.Size = new System.Drawing.Size(37, 24);
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
            this.textBoxB.Location = new System.Drawing.Point(120, 0);
            this.textBoxB.Name = "textBoxB";
            this.textBoxB.Size = new System.Drawing.Size(14, 22);
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
            this.labelCosBegin.Location = new System.Drawing.Point(74, 0);
            this.labelCosBegin.Name = "labelCosBegin";
            this.labelCosBegin.Size = new System.Drawing.Size(46, 24);
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
            this.textBoxA.Location = new System.Drawing.Point(60, 0);
            this.textBoxA.Name = "textBoxA";
            this.textBoxA.Size = new System.Drawing.Size(14, 22);
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
            this.labelFunc.Location = new System.Drawing.Point(5, 0);
            this.labelFunc.Name = "labelFunc";
            this.labelFunc.Size = new System.Drawing.Size(55, 24);
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
            this.buttonRun.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRun.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
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
            // panelBottomAnimation
            // 
            this.panelBottomAnimation.WorkerReportsProgress = true;
            this.panelBottomAnimation.WorkerSupportsCancellation = true;
            this.panelBottomAnimation.DoWork += new System.ComponentModel.DoWorkEventHandler(this.panelBottomAnimation_DoWork);
            this.panelBottomAnimation.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.panelBottomAnimation_ProgressChanged);
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
            // panelActionBottomAnimation
            // 
            this.panelActionBottomAnimation.WorkerReportsProgress = true;
            this.panelActionBottomAnimation.DoWork += new System.ComponentModel.DoWorkEventHandler(this.panelActionBottomAnimation_DoWork);
            this.panelActionBottomAnimation.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.panelActionBottomAnimation_ProgressChanged);
            this.panelActionBottomAnimation.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.panelActionBottomAnimation_RunWorkerCompleted);
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
            // Conami
            // 
            this.Conami.WorkerReportsProgress = true;
            this.Conami.WorkerSupportsCancellation = true;
            this.Conami.DoWork += new System.ComponentModel.DoWorkEventHandler(this.Conami_DoWork);
            this.Conami.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.Conami_ProgressChanged);
            this.Conami.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.Conami_RunWorkerCompleted);
            // 
            // labelTheEnd
            // 
            this.labelTheEnd.AutoSize = true;
            this.labelTheEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTheEnd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelTheEnd.Location = new System.Drawing.Point(639, 4);
            this.labelTheEnd.Name = "labelTheEnd";
            this.labelTheEnd.Size = new System.Drawing.Size(16, 17);
            this.labelTheEnd.TabIndex = 1;
            this.labelTheEnd.Text = "1";
            this.labelTheEnd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelTheEnd.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.panelAction);
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.panelHeader);
            this.Name = "MainForm";
            this.Text = "Decision making system";
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelBottom.ResumeLayout(false);
            this.panelBottom.PerformLayout();
            this.panelLeft.ResumeLayout(false);
            this.panelRight.ResumeLayout(false);
            this.panelAction.ResumeLayout(false);
            this.panelAction.PerformLayout();
            this.panelActionHideBottom.ResumeLayout(false);
            this.panelActionBottom.ResumeLayout(false);
            this.panelGraphConrtol.ResumeLayout(false);
            this.panelTable.ResumeLayout(false);
            this.panelSortTopCount.ResumeLayout(false);
            this.panelSortTopCount.PerformLayout();
            this.panelSortGrade.ResumeLayout(false);
            this.panelSortGrade.PerformLayout();
            this.panelSortedBy.ResumeLayout(false);
            this.panelSortedBy.PerformLayout();
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
            this.panelActionBottomParam.ResumeLayout(false);
            this.panelActionBottomE.ResumeLayout(false);
            this.panelActionBottomE.PerformLayout();
            this.panelActionBottomR.ResumeLayout(false);
            this.panelActionBottomR.PerformLayout();
            this.panelMaxSteps.ResumeLayout(false);
            this.panelMaxSteps.PerformLayout();
            this.panelActionBottomRegion.ResumeLayout(false);
            this.panelActionBottomRegion.PerformLayout();
            this.panelActionBottomParamFunc.ResumeLayout(false);
            this.panelActionBottomParamFunc.PerformLayout();
            this.panelActionRun.ResumeLayout(false);
            this.panelActionRun.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.Panel panelAction;
        private System.ComponentModel.BackgroundWorker panelBottomAnimation;
        private System.ComponentModel.BackgroundWorker panelLeftAnimation;
        private System.ComponentModel.BackgroundWorker panelRightAnimation;
        private System.ComponentModel.BackgroundWorker panelActionBottomAnimation;
        private System.ComponentModel.BackgroundWorker panelHeaderAnimation;
        private System.Windows.Forms.Label labelRecomendation;
        private System.Windows.Forms.Label labelNoData;
        private System.Windows.Forms.Panel panelActionBottom;
        private System.Windows.Forms.Panel panelActionHideBottom;
        private System.Windows.Forms.Panel panelActionBottomParam;
        private System.Windows.Forms.Label labelNameMethod;
        private System.Windows.Forms.Panel panelActionBottomParamFunc;
        private System.Windows.Forms.Label labelCosBegin;
        private System.Windows.Forms.TextBox textBoxA;
        private System.Windows.Forms.Panel panelFuncBegin;
        private System.Windows.Forms.TextBox textBoxB;
        private System.Windows.Forms.Label labelSinEnd;
        private System.Windows.Forms.TextBox textBoxD;
        private System.Windows.Forms.Label labelSinBegin;
        private System.Windows.Forms.TextBox textBoxC;
        private System.Windows.Forms.Label labelCosEnd;
        private System.Windows.Forms.Panel panelActionBottomRegion;
        private System.Windows.Forms.Label labelRegionEnd;
        private System.Windows.Forms.TextBox textBoxXEnd;
        private System.Windows.Forms.Label labelZpt;
        private System.Windows.Forms.TextBox textBoxXBegin;
        private System.Windows.Forms.Label labelRegionBegin;
        private System.Windows.Forms.Panel panelActionBottomR;
        private System.Windows.Forms.TextBox textBoxR;
        private System.Windows.Forms.Label labelR;
        private System.Windows.Forms.Panel panelActionBottomE;
        private System.Windows.Forms.TextBox textBoxE;
        private System.Windows.Forms.Label labelE;
        private System.Windows.Forms.Label labelGuidanceR;
        private System.Windows.Forms.Label labelGuidanceE;
        private System.Windows.Forms.Button buttonActionBottom;
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
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Panel panelSortedBy;
        private System.Windows.Forms.Label labelSortedBy;
        private System.Windows.Forms.Label labelErrorList;
        private System.Windows.Forms.Button buttonSortY;
        private System.Windows.Forms.Button buttonSortX;
        private System.Windows.Forms.Button buttonSortI;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Panel panelSortTopCount;
        private System.Windows.Forms.Button buttonTop45;
        private System.Windows.Forms.Button buttonTop30;
        private System.Windows.Forms.Button buttonTop15;
        private System.Windows.Forms.Label labelTopCount;
        private System.Windows.Forms.Panel panelSortGrade;
        private System.Windows.Forms.Button buttonTopDown;
        private System.Windows.Forms.Button buttonBottomUp;
        private System.Windows.Forms.Label labelSortingDirection;
        private System.Windows.Forms.Panel panelTable;
        private System.ComponentModel.BackgroundWorker Conami;
        private System.Windows.Forms.Label labelTheEnd;
    }
}