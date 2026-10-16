namespace FakeBTCMiner
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panelTop = new System.Windows.Forms.Panel();
            this.btnMenu = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnTheme = new System.Windows.Forms.Button();
            this.btnFullscreen = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.panelTabs = new System.Windows.Forms.Panel();
            this.lblTabMining = new System.Windows.Forms.Label();
            this.lblTabSend = new System.Windows.Forms.Label();
            this.lblTabReceive = new System.Windows.Forms.Label();
            this.lblTabSettings = new System.Windows.Forms.Label();
            this.lblTabAdvanced = new System.Windows.Forms.Label();
            this.panelTabIndicator = new System.Windows.Forms.Panel();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelSideStats = new System.Windows.Forms.Panel();
            this.pageMining = new System.Windows.Forms.Panel();
            this.lblBalanceCaption = new System.Windows.Forms.Label();
            this.lblBalance = new System.Windows.Forms.Label();
            this.lblHashRateCaption = new System.Windows.Forms.Label();
            this.lblHashRate = new System.Windows.Forms.Label();
            this.panelStatusDot = new System.Windows.Forms.Panel();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblSessionCaption = new System.Windows.Forms.Label();
            this.lblSession = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.btnStartStop = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnCalcProfit = new System.Windows.Forms.Button();
            this.cmbPool = new System.Windows.Forms.ComboBox();
            this.cmbProfile = new System.Windows.Forms.ComboBox();
            this.panelChart = new System.Windows.Forms.Panel();
            this.panelGpuMon = new System.Windows.Forms.Panel();
            this.lblGpuTempCap = new System.Windows.Forms.Label();
            this.lblGpuTemp = new System.Windows.Forms.Label();
            this.lblGpuFanCap = new System.Windows.Forms.Label();
            this.lblGpuFan = new System.Windows.Forms.Label();
            this.lblGpuPowerCap = new System.Windows.Forms.Label();
            this.lblGpuPower = new System.Windows.Forms.Label();
            this.txtLog = new System.Windows.Forms.RichTextBox();
            this.btnExportLogs = new System.Windows.Forms.Button();
            this.pageSend = new System.Windows.Forms.Panel();
            this.lblSendTitle = new System.Windows.Forms.Label();
            this.lblSendAddressCaption = new System.Windows.Forms.Label();
            this.txtSendAddress = new System.Windows.Forms.TextBox();
            this.lblSendAmountCaption = new System.Windows.Forms.Label();
            this.txtSendAmount = new System.Windows.Forms.TextBox();
            this.btnSendConfirm = new System.Windows.Forms.Button();
            this.lblTxHistoryCaption = new System.Windows.Forms.Label();
            this.lstTxHistory = new System.Windows.Forms.ListBox();
            this.pageReceive = new System.Windows.Forms.Panel();
            this.lblRecvTitle = new System.Windows.Forms.Label();
            this.lblRecvCaption = new System.Windows.Forms.Label();
            this.txtWallet = new System.Windows.Forms.TextBox();
            this.btnCopyReceive = new System.Windows.Forms.Button();
            this.btnNewWallet = new System.Windows.Forms.Button();
            this.btnShowQr = new System.Windows.Forms.Button();
            this.pageSettings = new System.Windows.Forms.Panel();
            this.lblSetTitle = new System.Windows.Forms.Label();
            this.lblIntensityCaption = new System.Windows.Forms.Label();
            this.trackIntensity = new System.Windows.Forms.TrackBar();
            this.lblIntensityVal = new System.Windows.Forms.Label();
            this.lblThreadsCaption = new System.Windows.Forms.Label();
            this.numThreads = new System.Windows.Forms.NumericUpDown();
            this.lblThreadsVal = new System.Windows.Forms.Label();
            this.chkAutoStop = new System.Windows.Forms.CheckBox();
            this.chkAutoRestart = new System.Windows.Forms.CheckBox();
            this.lblAutoStopTargetCaption = new System.Windows.Forms.Label();
            this.txtAutoStopTarget = new System.Windows.Forms.TextBox();
            this.btnSaveSettings = new System.Windows.Forms.Button();
            this.btnLoadSettings = new System.Windows.Forms.Button();
            this.btnToggleTheme = new System.Windows.Forms.Button();
            this.pageAdvanced = new System.Windows.Forms.Panel();
            this.lblAdvTitle = new System.Windows.Forms.Label();
            this.lblStakeCaption = new System.Windows.Forms.Label();
            this.txtStakeAmount = new System.Windows.Forms.TextBox();
            this.btnStake = new System.Windows.Forms.Button();
            this.btnUnstake = new System.Windows.Forms.Button();
            this.lblApyCaption = new System.Windows.Forms.Label();
            this.lblApyVal = new System.Windows.Forms.Label();
            this.btnReferral = new System.Windows.Forms.Button();
            this.lblNewWalletCaption = new System.Windows.Forms.Label();
            this.txtNewWalletInput = new System.Windows.Forms.TextBox();
            this.btnSetWallet = new System.Windows.Forms.Button();
            this.lblAchCaption = new System.Windows.Forms.Label();
            this.lstAchievements = new System.Windows.Forms.ListBox();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.lblConvCaption = new System.Windows.Forms.Label();
            this.lblConvBtc = new System.Windows.Forms.Label();
            this.lblConvUsd = new System.Windows.Forms.Label();
            this.lblConvRub = new System.Windows.Forms.Label();
            this.lblToast = new System.Windows.Forms.Label();
            this.panelMenuShade = new System.Windows.Forms.Panel();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.timerMine = new System.Windows.Forms.Timer(this.components);
            this.timerAnim = new System.Windows.Forms.Timer(this.components);
            this.timerStake = new System.Windows.Forms.Timer(this.components);
            this.timerBg = new System.Windows.Forms.Timer(this.components);
            this.toastTimer = new System.Windows.Forms.Timer(this.components);
            this.panelTop.SuspendLayout();
            this.panelTabs.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.pageMining.SuspendLayout();
            this.pageSend.SuspendLayout();
            this.pageReceive.SuspendLayout();
            this.pageSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackIntensity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numThreads)).BeginInit();
            this.pageAdvanced.SuspendLayout();
            this.panelBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(14)))));
            this.panelTop.Controls.Add(this.btnMenu);
            this.panelTop.Controls.Add(this.lblTitle);
            this.panelTop.Controls.Add(this.btnTheme);
            this.panelTop.Controls.Add(this.btnFullscreen);
            this.panelTop.Controls.Add(this.btnMinimize);
            this.panelTop.Controls.Add(this.btnClose);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1600, 48);
            this.panelTop.TabIndex = 0;
            this.panelTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelTop_MouseDown);
            // 
            // btnMenu
            // 
            this.btnMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenu.FlatAppearance.BorderSize = 0;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btnMenu.ForeColor = System.Drawing.Color.White;
            this.btnMenu.Location = new System.Drawing.Point(18, 8);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(42, 32);
            this.btnMenu.TabIndex = 1;
            this.btnMenu.Text = "☰";
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.BtnMenu_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(70, 14);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(130, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "₿  BTC TOOLS ";
            // 
            // btnTheme
            // 
            this.btnTheme.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTheme.FlatAppearance.BorderSize = 0;
            this.btnTheme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTheme.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnTheme.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.btnTheme.Location = new System.Drawing.Point(1400, 8);
            this.btnTheme.Name = "btnTheme";
            this.btnTheme.Size = new System.Drawing.Size(42, 32);
            this.btnTheme.TabIndex = 2;
            this.btnTheme.Text = "◐";
            this.btnTheme.UseVisualStyleBackColor = true;
            this.btnTheme.Click += new System.EventHandler(this.BtnToggleTheme_Click);
            // 
            // btnFullscreen
            // 
            this.btnFullscreen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFullscreen.FlatAppearance.BorderSize = 0;
            this.btnFullscreen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFullscreen.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnFullscreen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.btnFullscreen.Location = new System.Drawing.Point(1444, 8);
            this.btnFullscreen.Name = "btnFullscreen";
            this.btnFullscreen.Size = new System.Drawing.Size(42, 32);
            this.btnFullscreen.TabIndex = 3;
            this.btnFullscreen.Text = "⛶";
            this.btnFullscreen.UseVisualStyleBackColor = true;
            this.btnFullscreen.Click += new System.EventHandler(this.BtnFullscreen_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnMinimize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.btnMinimize.Location = new System.Drawing.Point(1488, 8);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(42, 32);
            this.btnMinimize.TabIndex = 4;
            this.btnMinimize.Text = "—";
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.BtnMinimize_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.btnClose.Location = new System.Drawing.Point(1534, 8);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(42, 32);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "✕";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // panelTabs
            // 
            this.panelTabs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(20)))));
            this.panelTabs.Controls.Add(this.lblTabMining);
            this.panelTabs.Controls.Add(this.lblTabSend);
            this.panelTabs.Controls.Add(this.lblTabReceive);
            this.panelTabs.Controls.Add(this.lblTabSettings);
            this.panelTabs.Controls.Add(this.lblTabAdvanced);
            this.panelTabs.Controls.Add(this.panelTabIndicator);
            this.panelTabs.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTabs.Location = new System.Drawing.Point(0, 48);
            this.panelTabs.Name = "panelTabs";
            this.panelTabs.Size = new System.Drawing.Size(1600, 54);
            this.panelTabs.TabIndex = 1;
            // 
            // lblTabMining
            // 
            this.lblTabMining.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblTabMining.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblTabMining.ForeColor = System.Drawing.Color.White;
            this.lblTabMining.Location = new System.Drawing.Point(24, 16);
            this.lblTabMining.Name = "lblTabMining";
            this.lblTabMining.Size = new System.Drawing.Size(100, 22);
            this.lblTabMining.TabIndex = 0;
            this.lblTabMining.Tag = "0";
            this.lblTabMining.Text = "MINING";
            this.lblTabMining.Click += new System.EventHandler(this.Tab_Click);
            // 
            // lblTabSend
            // 
            this.lblTabSend.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblTabSend.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.lblTabSend.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.lblTabSend.Location = new System.Drawing.Point(150, 16);
            this.lblTabSend.Name = "lblTabSend";
            this.lblTabSend.Size = new System.Drawing.Size(100, 22);
            this.lblTabSend.TabIndex = 1;
            this.lblTabSend.Tag = "1";
            this.lblTabSend.Text = "SEND";
            this.lblTabSend.Click += new System.EventHandler(this.Tab_Click);
            // 
            // lblTabReceive
            // 
            this.lblTabReceive.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblTabReceive.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.lblTabReceive.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.lblTabReceive.Location = new System.Drawing.Point(250, 16);
            this.lblTabReceive.Name = "lblTabReceive";
            this.lblTabReceive.Size = new System.Drawing.Size(100, 22);
            this.lblTabReceive.TabIndex = 2;
            this.lblTabReceive.Tag = "2";
            this.lblTabReceive.Text = "RECEIVE";
            this.lblTabReceive.Click += new System.EventHandler(this.Tab_Click);
            // 
            // lblTabSettings
            // 
            this.lblTabSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblTabSettings.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.lblTabSettings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.lblTabSettings.Location = new System.Drawing.Point(360, 16);
            this.lblTabSettings.Name = "lblTabSettings";
            this.lblTabSettings.Size = new System.Drawing.Size(100, 22);
            this.lblTabSettings.TabIndex = 3;
            this.lblTabSettings.Tag = "3";
            this.lblTabSettings.Text = "SETTINGS";
            this.lblTabSettings.Click += new System.EventHandler(this.Tab_Click);
            // 
            // lblTabAdvanced
            // 
            this.lblTabAdvanced.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblTabAdvanced.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.lblTabAdvanced.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.lblTabAdvanced.Location = new System.Drawing.Point(480, 16);
            this.lblTabAdvanced.Name = "lblTabAdvanced";
            this.lblTabAdvanced.Size = new System.Drawing.Size(120, 22);
            this.lblTabAdvanced.TabIndex = 4;
            this.lblTabAdvanced.Tag = "4";
            this.lblTabAdvanced.Text = "ADVANCED";
            this.lblTabAdvanced.Click += new System.EventHandler(this.Tab_Click);
            // 
            // panelTabIndicator
            // 
            this.panelTabIndicator.BackColor = System.Drawing.Color.White;
            this.panelTabIndicator.Location = new System.Drawing.Point(24, 46);
            this.panelTabIndicator.Name = "panelTabIndicator";
            this.panelTabIndicator.Size = new System.Drawing.Size(100, 2);
            this.panelTabIndicator.TabIndex = 5;
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(24)))));
            this.panelMain.Controls.Add(this.panelSideStats);
            this.panelMain.Controls.Add(this.pageMining);
            this.panelMain.Controls.Add(this.pageSend);
            this.panelMain.Controls.Add(this.pageReceive);
            this.panelMain.Controls.Add(this.pageSettings);
            this.panelMain.Controls.Add(this.pageAdvanced);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 102);
            this.panelMain.Name = "panelMain";
            this.panelMain.Padding = new System.Windows.Forms.Padding(30, 20, 30, 20);
            this.panelMain.Size = new System.Drawing.Size(1600, 762);
            this.panelMain.TabIndex = 2;
            // 
            // panelSideStats
            // 
            this.panelSideStats.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(20)))));
            this.panelSideStats.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelSideStats.Location = new System.Drawing.Point(1270, 20);
            this.panelSideStats.Name = "panelSideStats";
            this.panelSideStats.Size = new System.Drawing.Size(300, 722);
            this.panelSideStats.TabIndex = 5;
            this.panelSideStats.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelSideStats_Paint);
            // 
            // pageMining
            // 
            this.pageMining.BackColor = System.Drawing.Color.Transparent;
            this.pageMining.Controls.Add(this.lblBalanceCaption);
            this.pageMining.Controls.Add(this.lblBalance);
            this.pageMining.Controls.Add(this.lblHashRateCaption);
            this.pageMining.Controls.Add(this.lblHashRate);
            this.pageMining.Controls.Add(this.panelStatusDot);
            this.pageMining.Controls.Add(this.lblStatus);
            this.pageMining.Controls.Add(this.lblSessionCaption);
            this.pageMining.Controls.Add(this.lblSession);
            this.pageMining.Controls.Add(this.progressBar);
            this.pageMining.Controls.Add(this.btnStartStop);
            this.pageMining.Controls.Add(this.btnPause);
            this.pageMining.Controls.Add(this.btnCalcProfit);
            this.pageMining.Controls.Add(this.cmbPool);
            this.pageMining.Controls.Add(this.cmbProfile);
            this.pageMining.Controls.Add(this.panelChart);
            this.pageMining.Controls.Add(this.panelGpuMon);
            this.pageMining.Controls.Add(this.lblGpuTempCap);
            this.pageMining.Controls.Add(this.lblGpuTemp);
            this.pageMining.Controls.Add(this.lblGpuFanCap);
            this.pageMining.Controls.Add(this.lblGpuFan);
            this.pageMining.Controls.Add(this.lblGpuPowerCap);
            this.pageMining.Controls.Add(this.lblGpuPower);
            this.pageMining.Controls.Add(this.txtLog);
            this.pageMining.Controls.Add(this.btnExportLogs);
            this.pageMining.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pageMining.Location = new System.Drawing.Point(30, 20);
            this.pageMining.Name = "pageMining";
            this.pageMining.Size = new System.Drawing.Size(1540, 722);
            this.pageMining.TabIndex = 0;
            // 
            // lblBalanceCaption
            // 
            this.lblBalanceCaption.AutoSize = true;
            this.lblBalanceCaption.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblBalanceCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.lblBalanceCaption.Location = new System.Drawing.Point(0, 0);
            this.lblBalanceCaption.Name = "lblBalanceCaption";
            this.lblBalanceCaption.Size = new System.Drawing.Size(53, 13);
            this.lblBalanceCaption.TabIndex = 0;
            this.lblBalanceCaption.Text = "BALANCE";
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Font = new System.Drawing.Font("Segoe UI Semibold", 42F, System.Drawing.FontStyle.Bold);
            this.lblBalance.ForeColor = System.Drawing.Color.White;
            this.lblBalance.Location = new System.Drawing.Point(-6, 20);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(325, 74);
            this.lblBalance.TabIndex = 1;
            this.lblBalance.Text = "0.00000000";
            // 
            // lblHashRateCaption
            // 
            this.lblHashRateCaption.AutoSize = true;
            this.lblHashRateCaption.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblHashRateCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.lblHashRateCaption.Location = new System.Drawing.Point(520, 0);
            this.lblHashRateCaption.Name = "lblHashRateCaption";
            this.lblHashRateCaption.Size = new System.Drawing.Size(64, 13);
            this.lblHashRateCaption.TabIndex = 2;
            this.lblHashRateCaption.Text = "HASH RATE";
            // 
            // lblHashRate
            // 
            this.lblHashRate.AutoSize = true;
            this.lblHashRate.Font = new System.Drawing.Font("Segoe UI Semibold", 28F, System.Drawing.FontStyle.Bold);
            this.lblHashRate.ForeColor = System.Drawing.Color.White;
            this.lblHashRate.Location = new System.Drawing.Point(515, 25);
            this.lblHashRate.Name = "lblHashRate";
            this.lblHashRate.Size = new System.Drawing.Size(199, 51);
            this.lblHashRate.TabIndex = 3;
            this.lblHashRate.Text = "0.00 MH/s";
            // 
            // panelStatusDot
            // 
            this.panelStatusDot.Location = new System.Drawing.Point(0, 105);
            this.panelStatusDot.Name = "panelStatusDot";
            this.panelStatusDot.Size = new System.Drawing.Size(40, 40);
            this.panelStatusDot.TabIndex = 4;
            this.panelStatusDot.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelStatusDot_Paint);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold);
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.lblStatus.Location = new System.Drawing.Point(46, 114);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(48, 25);
            this.lblStatus.TabIndex = 5;
            this.lblStatus.Text = "IDLE";
            // 
            // lblSessionCaption
            // 
            this.lblSessionCaption.AutoSize = true;
            this.lblSessionCaption.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblSessionCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.lblSessionCaption.Location = new System.Drawing.Point(520, 110);
            this.lblSessionCaption.Name = "lblSessionCaption";
            this.lblSessionCaption.Size = new System.Drawing.Size(51, 13);
            this.lblSessionCaption.TabIndex = 6;
            this.lblSessionCaption.Text = "SESSION";
            // 
            // lblSession
            // 
            this.lblSession.AutoSize = true;
            this.lblSession.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Bold);
            this.lblSession.ForeColor = System.Drawing.Color.White;
            this.lblSession.Location = new System.Drawing.Point(600, 108);
            this.lblSession.Name = "lblSession";
            this.lblSession.Size = new System.Drawing.Size(90, 22);
            this.lblSession.TabIndex = 7;
            this.lblSession.Text = "00:00:00";
            // 
            // progressBar
            // 
            this.progressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar.Location = new System.Drawing.Point(0, 155);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(1480, 3);
            this.progressBar.TabIndex = 8;
            // 
            // btnStartStop
            // 
            this.btnStartStop.BackColor = System.Drawing.Color.White;
            this.btnStartStop.FlatAppearance.BorderSize = 0;
            this.btnStartStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStartStop.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.btnStartStop.ForeColor = System.Drawing.Color.Black;
            this.btnStartStop.Location = new System.Drawing.Point(0, 175);
            this.btnStartStop.Name = "btnStartStop";
            this.btnStartStop.Size = new System.Drawing.Size(160, 44);
            this.btnStartStop.TabIndex = 9;
            this.btnStartStop.Text = "▶  START";
            this.btnStartStop.UseVisualStyleBackColor = false;
            this.btnStartStop.Click += new System.EventHandler(this.BtnStartStop_Click);
            // 
            // btnPause
            // 
            this.btnPause.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnPause.Enabled = false;
            this.btnPause.FlatAppearance.BorderSize = 0;
            this.btnPause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPause.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.btnPause.ForeColor = System.Drawing.Color.White;
            this.btnPause.Location = new System.Drawing.Point(170, 175);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(160, 44);
            this.btnPause.TabIndex = 10;
            this.btnPause.Text = "⏸  PAUSE";
            this.btnPause.UseVisualStyleBackColor = false;
            this.btnPause.Click += new System.EventHandler(this.BtnPause_Click);
            // 
            // btnCalcProfit
            // 
            this.btnCalcProfit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnCalcProfit.FlatAppearance.BorderSize = 0;
            this.btnCalcProfit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcProfit.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.btnCalcProfit.ForeColor = System.Drawing.Color.White;
            this.btnCalcProfit.Location = new System.Drawing.Point(340, 175);
            this.btnCalcProfit.Name = "btnCalcProfit";
            this.btnCalcProfit.Size = new System.Drawing.Size(160, 44);
            this.btnCalcProfit.TabIndex = 11;
            this.btnCalcProfit.Text = "💰  PROFIT";
            this.btnCalcProfit.UseVisualStyleBackColor = false;
            this.btnCalcProfit.Click += new System.EventHandler(this.BtnCalcProfit_Click);
            // 
            // cmbPool
            // 
            this.cmbPool.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(38)))));
            this.cmbPool.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPool.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbPool.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbPool.ForeColor = System.Drawing.Color.White;
            this.cmbPool.Items.AddRange(new object[] {
            "stratum+tcp://btc.pool.fake:3333",
            "stratum+tcp://eu.pool.fake:3333",
            "stratum+tcp://us.pool.fake:3333",
            "stratum+tcp://asia.pool.fake:3333"});
            this.cmbPool.Location = new System.Drawing.Point(520, 183);
            this.cmbPool.Name = "cmbPool";
            this.cmbPool.Size = new System.Drawing.Size(280, 23);
            this.cmbPool.TabIndex = 12;
            this.cmbPool.SelectedIndexChanged += new System.EventHandler(this.CmbPool_SelectedIndexChanged);
            // 
            // cmbProfile
            // 
            this.cmbProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(38)))));
            this.cmbProfile.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbProfile.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbProfile.ForeColor = System.Drawing.Color.White;
            this.cmbProfile.Items.AddRange(new object[] {
            "Eco",
            "Normal",
            "Turbo"});
            this.cmbProfile.Location = new System.Drawing.Point(810, 183);
            this.cmbProfile.Name = "cmbProfile";
            this.cmbProfile.Size = new System.Drawing.Size(150, 23);
            this.cmbProfile.TabIndex = 13;
            this.cmbProfile.SelectedIndexChanged += new System.EventHandler(this.CmbProfile_SelectedIndexChanged);
            // 
            // panelChart
            // 
            this.panelChart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelChart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(16)))));
            this.panelChart.Location = new System.Drawing.Point(0, 240);
            this.panelChart.Name = "panelChart";
            this.panelChart.Size = new System.Drawing.Size(1480, 180);
            this.panelChart.TabIndex = 14;
            this.panelChart.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelChart_Paint);
            // 
            // panelGpuMon
            // 
            this.panelGpuMon.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelGpuMon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(16)))));
            this.panelGpuMon.Location = new System.Drawing.Point(0, 430);
            this.panelGpuMon.Name = "panelGpuMon";
            this.panelGpuMon.Size = new System.Drawing.Size(1480, 120);
            this.panelGpuMon.TabIndex = 15;
            this.panelGpuMon.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelGpuMon_Paint);
            // 
            // lblGpuTempCap
            // 
            this.lblGpuTempCap.AutoSize = true;
            this.lblGpuTempCap.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblGpuTempCap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.lblGpuTempCap.Location = new System.Drawing.Point(0, 560);
            this.lblGpuTempCap.Name = "lblGpuTempCap";
            this.lblGpuTempCap.Size = new System.Drawing.Size(35, 13);
            this.lblGpuTempCap.TabIndex = 16;
            this.lblGpuTempCap.Text = "TEMP";
            // 
            // lblGpuTemp
            // 
            this.lblGpuTemp.AutoSize = true;
            this.lblGpuTemp.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Bold);
            this.lblGpuTemp.ForeColor = System.Drawing.Color.White;
            this.lblGpuTemp.Location = new System.Drawing.Point(0, 576);
            this.lblGpuTemp.Name = "lblGpuTemp";
            this.lblGpuTemp.Size = new System.Drawing.Size(60, 22);
            this.lblGpuTemp.TabIndex = 17;
            this.lblGpuTemp.Text = "45 °C";
            // 
            // lblGpuFanCap
            // 
            this.lblGpuFanCap.AutoSize = true;
            this.lblGpuFanCap.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblGpuFanCap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.lblGpuFanCap.Location = new System.Drawing.Point(140, 560);
            this.lblGpuFanCap.Name = "lblGpuFanCap";
            this.lblGpuFanCap.Size = new System.Drawing.Size(33, 13);
            this.lblGpuFanCap.TabIndex = 18;
            this.lblGpuFanCap.Text = "FANS";
            // 
            // lblGpuFan
            // 
            this.lblGpuFan.AutoSize = true;
            this.lblGpuFan.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Bold);
            this.lblGpuFan.ForeColor = System.Drawing.Color.White;
            this.lblGpuFan.Location = new System.Drawing.Point(140, 576);
            this.lblGpuFan.Name = "lblGpuFan";
            this.lblGpuFan.Size = new System.Drawing.Size(90, 22);
            this.lblGpuFan.TabIndex = 19;
            this.lblGpuFan.Text = "1200 RPM";
            // 
            // lblGpuPowerCap
            // 
            this.lblGpuPowerCap.AutoSize = true;
            this.lblGpuPowerCap.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblGpuPowerCap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.lblGpuPowerCap.Location = new System.Drawing.Point(320, 560);
            this.lblGpuPowerCap.Name = "lblGpuPowerCap";
            this.lblGpuPowerCap.Size = new System.Drawing.Size(46, 13);
            this.lblGpuPowerCap.TabIndex = 20;
            this.lblGpuPowerCap.Text = "POWER";
            // 
            // lblGpuPower
            // 
            this.lblGpuPower.AutoSize = true;
            this.lblGpuPower.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Bold);
            this.lblGpuPower.ForeColor = System.Drawing.Color.White;
            this.lblGpuPower.Location = new System.Drawing.Point(320, 576);
            this.lblGpuPower.Name = "lblGpuPower";
            this.lblGpuPower.Size = new System.Drawing.Size(50, 22);
            this.lblGpuPower.TabIndex = 21;
            this.lblGpuPower.Text = "80 W";
            // 
            // txtLog
            // 
            this.txtLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(14)))));
            this.txtLog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLog.Font = new System.Drawing.Font("Consolas", 9F);
            this.txtLog.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.txtLog.Location = new System.Drawing.Point(0, 620);
            this.txtLog.Name = "txtLog";
            this.txtLog.ReadOnly = true;
            this.txtLog.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.txtLog.Size = new System.Drawing.Size(1480, 662);
            this.txtLog.TabIndex = 22;
            this.txtLog.Text = "";
            // 
            // btnExportLogs
            // 
            this.btnExportLogs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnExportLogs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnExportLogs.FlatAppearance.BorderSize = 0;
            this.btnExportLogs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportLogs.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnExportLogs.ForeColor = System.Drawing.Color.White;
            this.btnExportLogs.Location = new System.Drawing.Point(0, 712);
            this.btnExportLogs.Name = "btnExportLogs";
            this.btnExportLogs.Size = new System.Drawing.Size(180, 32);
            this.btnExportLogs.TabIndex = 23;
            this.btnExportLogs.Text = "⇩  EXPORT LOGS";
            this.btnExportLogs.UseVisualStyleBackColor = false;
            this.btnExportLogs.Click += new System.EventHandler(this.BtnExportLogs_Click);
            // 
            // pageSend
            // 
            this.pageSend.BackColor = System.Drawing.Color.Transparent;
            this.pageSend.Controls.Add(this.lblSendTitle);
            this.pageSend.Controls.Add(this.lblSendAddressCaption);
            this.pageSend.Controls.Add(this.txtSendAddress);
            this.pageSend.Controls.Add(this.lblSendAmountCaption);
            this.pageSend.Controls.Add(this.txtSendAmount);
            this.pageSend.Controls.Add(this.btnSendConfirm);
            this.pageSend.Controls.Add(this.lblTxHistoryCaption);
            this.pageSend.Controls.Add(this.lstTxHistory);
            this.pageSend.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pageSend.Location = new System.Drawing.Point(30, 20);
            this.pageSend.Name = "pageSend";
            this.pageSend.Size = new System.Drawing.Size(1540, 722);
            this.pageSend.TabIndex = 1;
            this.pageSend.Visible = false;
            // 
            // lblSendTitle
            // 
            this.lblSendTitle.AutoSize = true;
            this.lblSendTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 26F, System.Drawing.FontStyle.Bold);
            this.lblSendTitle.ForeColor = System.Drawing.Color.White;
            this.lblSendTitle.Location = new System.Drawing.Point(0, 0);
            this.lblSendTitle.Name = "lblSendTitle";
            this.lblSendTitle.Size = new System.Drawing.Size(169, 47);
            this.lblSendTitle.TabIndex = 0;
            this.lblSendTitle.Text = "Send BTC";
            // 
            // lblSendAddressCaption
            // 
            this.lblSendAddressCaption.AutoSize = true;
            this.lblSendAddressCaption.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblSendAddressCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.lblSendAddressCaption.Location = new System.Drawing.Point(0, 80);
            this.lblSendAddressCaption.Name = "lblSendAddressCaption";
            this.lblSendAddressCaption.Size = new System.Drawing.Size(110, 13);
            this.lblSendAddressCaption.TabIndex = 1;
            this.lblSendAddressCaption.Text = "RECIPIENT ADDRESS";
            // 
            // txtSendAddress
            // 
            this.txtSendAddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(38)))));
            this.txtSendAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSendAddress.Font = new System.Drawing.Font("Consolas", 11F);
            this.txtSendAddress.ForeColor = System.Drawing.Color.White;
            this.txtSendAddress.Location = new System.Drawing.Point(0, 100);
            this.txtSendAddress.Name = "txtSendAddress";
            this.txtSendAddress.Size = new System.Drawing.Size(600, 25);
            this.txtSendAddress.TabIndex = 2;
            // 
            // lblSendAmountCaption
            // 
            this.lblSendAmountCaption.AutoSize = true;
            this.lblSendAmountCaption.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblSendAmountCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.lblSendAmountCaption.Location = new System.Drawing.Point(0, 160);
            this.lblSendAmountCaption.Name = "lblSendAmountCaption";
            this.lblSendAmountCaption.Size = new System.Drawing.Size(82, 13);
            this.lblSendAmountCaption.TabIndex = 3;
            this.lblSendAmountCaption.Text = "AMOUNT (BTC)";
            // 
            // txtSendAmount
            // 
            this.txtSendAmount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(38)))));
            this.txtSendAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSendAmount.Font = new System.Drawing.Font("Consolas", 11F);
            this.txtSendAmount.ForeColor = System.Drawing.Color.White;
            this.txtSendAmount.Location = new System.Drawing.Point(0, 180);
            this.txtSendAmount.Name = "txtSendAmount";
            this.txtSendAmount.Size = new System.Drawing.Size(300, 25);
            this.txtSendAmount.TabIndex = 4;
            this.txtSendAmount.Text = "0.00000001";
            // 
            // btnSendConfirm
            // 
            this.btnSendConfirm.BackColor = System.Drawing.Color.White;
            this.btnSendConfirm.FlatAppearance.BorderSize = 0;
            this.btnSendConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSendConfirm.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.btnSendConfirm.ForeColor = System.Drawing.Color.Black;
            this.btnSendConfirm.Location = new System.Drawing.Point(320, 180);
            this.btnSendConfirm.Name = "btnSendConfirm";
            this.btnSendConfirm.Size = new System.Drawing.Size(280, 25);
            this.btnSendConfirm.TabIndex = 5;
            this.btnSendConfirm.Text = "↗  SEND";
            this.btnSendConfirm.UseVisualStyleBackColor = false;
            this.btnSendConfirm.Click += new System.EventHandler(this.BtnSendConfirm_Click);
            // 
            // lblTxHistoryCaption
            // 
            this.lblTxHistoryCaption.AutoSize = true;
            this.lblTxHistoryCaption.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblTxHistoryCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.lblTxHistoryCaption.Location = new System.Drawing.Point(0, 240);
            this.lblTxHistoryCaption.Name = "lblTxHistoryCaption";
            this.lblTxHistoryCaption.Size = new System.Drawing.Size(127, 13);
            this.lblTxHistoryCaption.TabIndex = 6;
            this.lblTxHistoryCaption.Text = "TRANSACTION HISTORY";
            // 
            // lstTxHistory
            // 
            this.lstTxHistory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(14)))));
            this.lstTxHistory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstTxHistory.Font = new System.Drawing.Font("Consolas", 10F);
            this.lstTxHistory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.lstTxHistory.ItemHeight = 15;
            this.lstTxHistory.Location = new System.Drawing.Point(0, 260);
            this.lstTxHistory.Name = "lstTxHistory";
            this.lstTxHistory.Size = new System.Drawing.Size(600, 390);
            this.lstTxHistory.TabIndex = 7;
            // 
            // pageReceive
            // 
            this.pageReceive.BackColor = System.Drawing.Color.Transparent;
            this.pageReceive.Controls.Add(this.lblRecvTitle);
            this.pageReceive.Controls.Add(this.lblRecvCaption);
            this.pageReceive.Controls.Add(this.txtWallet);
            this.pageReceive.Controls.Add(this.btnCopyReceive);
            this.pageReceive.Controls.Add(this.btnNewWallet);
            this.pageReceive.Controls.Add(this.btnShowQr);
            this.pageReceive.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pageReceive.Location = new System.Drawing.Point(30, 20);
            this.pageReceive.Name = "pageReceive";
            this.pageReceive.Size = new System.Drawing.Size(1540, 722);
            this.pageReceive.TabIndex = 2;
            this.pageReceive.Visible = false;
            // 
            // lblRecvTitle
            // 
            this.lblRecvTitle.AutoSize = true;
            this.lblRecvTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 26F, System.Drawing.FontStyle.Bold);
            this.lblRecvTitle.ForeColor = System.Drawing.Color.White;
            this.lblRecvTitle.Location = new System.Drawing.Point(0, 0);
            this.lblRecvTitle.Name = "lblRecvTitle";
            this.lblRecvTitle.Size = new System.Drawing.Size(211, 47);
            this.lblRecvTitle.TabIndex = 0;
            this.lblRecvTitle.Text = "Receive BTC";
            // 
            // lblRecvCaption
            // 
            this.lblRecvCaption.AutoSize = true;
            this.lblRecvCaption.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblRecvCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.lblRecvCaption.Location = new System.Drawing.Point(0, 90);
            this.lblRecvCaption.Name = "lblRecvCaption";
            this.lblRecvCaption.Size = new System.Drawing.Size(130, 13);
            this.lblRecvCaption.TabIndex = 1;
            this.lblRecvCaption.Text = "YOUR WALLET ADDRESS";
            // 
            // txtWallet
            // 
            this.txtWallet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(38)))));
            this.txtWallet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtWallet.Font = new System.Drawing.Font("Consolas", 11F);
            this.txtWallet.ForeColor = System.Drawing.Color.White;
            this.txtWallet.Location = new System.Drawing.Point(0, 110);
            this.txtWallet.Name = "txtWallet";
            this.txtWallet.ReadOnly = true;
            this.txtWallet.Size = new System.Drawing.Size(700, 25);
            this.txtWallet.TabIndex = 2;
            // 
            // btnCopyReceive
            // 
            this.btnCopyReceive.BackColor = System.Drawing.Color.White;
            this.btnCopyReceive.FlatAppearance.BorderSize = 0;
            this.btnCopyReceive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCopyReceive.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnCopyReceive.ForeColor = System.Drawing.Color.Black;
            this.btnCopyReceive.Location = new System.Drawing.Point(720, 110);
            this.btnCopyReceive.Name = "btnCopyReceive";
            this.btnCopyReceive.Size = new System.Drawing.Size(160, 25);
            this.btnCopyReceive.TabIndex = 3;
            this.btnCopyReceive.Text = "📋  COPY";
            this.btnCopyReceive.UseVisualStyleBackColor = false;
            this.btnCopyReceive.Click += new System.EventHandler(this.BtnCopyReceive_Click);
            // 
            // btnNewWallet
            // 
            this.btnNewWallet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnNewWallet.FlatAppearance.BorderSize = 0;
            this.btnNewWallet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewWallet.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnNewWallet.ForeColor = System.Drawing.Color.White;
            this.btnNewWallet.Location = new System.Drawing.Point(0, 170);
            this.btnNewWallet.Name = "btnNewWallet";
            this.btnNewWallet.Size = new System.Drawing.Size(220, 40);
            this.btnNewWallet.TabIndex = 4;
            this.btnNewWallet.Text = "🔄  NEW WALLET";
            this.btnNewWallet.UseVisualStyleBackColor = false;
            this.btnNewWallet.Click += new System.EventHandler(this.BtnNewWallet_Click);
            // 
            // btnShowQr
            // 
            this.btnShowQr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnShowQr.FlatAppearance.BorderSize = 0;
            this.btnShowQr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowQr.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnShowQr.ForeColor = System.Drawing.Color.White;
            this.btnShowQr.Location = new System.Drawing.Point(240, 170);
            this.btnShowQr.Name = "btnShowQr";
            this.btnShowQr.Size = new System.Drawing.Size(220, 40);
            this.btnShowQr.TabIndex = 5;
            this.btnShowQr.Text = "▦  SHOW QR";
            this.btnShowQr.UseVisualStyleBackColor = false;
            this.btnShowQr.Click += new System.EventHandler(this.BtnShowQr_Click);
            // 
            // pageSettings
            // 
            this.pageSettings.BackColor = System.Drawing.Color.Transparent;
            this.pageSettings.Controls.Add(this.lblSetTitle);
            this.pageSettings.Controls.Add(this.lblIntensityCaption);
            this.pageSettings.Controls.Add(this.trackIntensity);
            this.pageSettings.Controls.Add(this.lblIntensityVal);
            this.pageSettings.Controls.Add(this.lblThreadsCaption);
            this.pageSettings.Controls.Add(this.numThreads);
            this.pageSettings.Controls.Add(this.lblThreadsVal);
            this.pageSettings.Controls.Add(this.chkAutoStop);
            this.pageSettings.Controls.Add(this.chkAutoRestart);
            this.pageSettings.Controls.Add(this.lblAutoStopTargetCaption);
            this.pageSettings.Controls.Add(this.txtAutoStopTarget);
            this.pageSettings.Controls.Add(this.btnSaveSettings);
            this.pageSettings.Controls.Add(this.btnLoadSettings);
            this.pageSettings.Controls.Add(this.btnToggleTheme);
            this.pageSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pageSettings.Location = new System.Drawing.Point(30, 20);
            this.pageSettings.Name = "pageSettings";
            this.pageSettings.Size = new System.Drawing.Size(1540, 722);
            this.pageSettings.TabIndex = 3;
            this.pageSettings.Visible = false;
            // 
            // lblSetTitle
            // 
            this.lblSetTitle.AutoSize = true;
            this.lblSetTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 26F, System.Drawing.FontStyle.Bold);
            this.lblSetTitle.ForeColor = System.Drawing.Color.White;
            this.lblSetTitle.Location = new System.Drawing.Point(0, 0);
            this.lblSetTitle.Name = "lblSetTitle";
            this.lblSetTitle.Size = new System.Drawing.Size(149, 47);
            this.lblSetTitle.TabIndex = 0;
            this.lblSetTitle.Text = "Settings";
            // 
            // lblIntensityCaption
            // 
            this.lblIntensityCaption.AutoSize = true;
            this.lblIntensityCaption.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblIntensityCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.lblIntensityCaption.Location = new System.Drawing.Point(0, 80);
            this.lblIntensityCaption.Name = "lblIntensityCaption";
            this.lblIntensityCaption.Size = new System.Drawing.Size(83, 13);
            this.lblIntensityCaption.TabIndex = 1;
            this.lblIntensityCaption.Text = "INTENSITY (1-3)";
            // 
            // trackIntensity
            // 
            this.trackIntensity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(24)))));
            this.trackIntensity.Location = new System.Drawing.Point(0, 100);
            this.trackIntensity.Maximum = 3;
            this.trackIntensity.Minimum = 1;
            this.trackIntensity.Name = "trackIntensity";
            this.trackIntensity.Size = new System.Drawing.Size(500, 45);
            this.trackIntensity.TabIndex = 2;
            this.trackIntensity.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackIntensity.Value = 2;
            this.trackIntensity.Scroll += new System.EventHandler(this.TrackIntensity_Scroll);
            // 
            // lblIntensityVal
            // 
            this.lblIntensityVal.AutoSize = true;
            this.lblIntensityVal.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Bold);
            this.lblIntensityVal.ForeColor = System.Drawing.Color.White;
            this.lblIntensityVal.Location = new System.Drawing.Point(520, 108);
            this.lblIntensityVal.Name = "lblIntensityVal";
            this.lblIntensityVal.Size = new System.Drawing.Size(20, 22);
            this.lblIntensityVal.TabIndex = 3;
            this.lblIntensityVal.Text = "2";
            // 
            // lblThreadsCaption
            // 
            this.lblThreadsCaption.AutoSize = true;
            this.lblThreadsCaption.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblThreadsCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.lblThreadsCaption.Location = new System.Drawing.Point(0, 170);
            this.lblThreadsCaption.Name = "lblThreadsCaption";
            this.lblThreadsCaption.Size = new System.Drawing.Size(55, 13);
            this.lblThreadsCaption.TabIndex = 4;
            this.lblThreadsCaption.Text = "THREADS";
            // 
            // numThreads
            // 
            this.numThreads.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(38)))));
            this.numThreads.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numThreads.Font = new System.Drawing.Font("Consolas", 11F);
            this.numThreads.ForeColor = System.Drawing.Color.White;
            this.numThreads.Location = new System.Drawing.Point(0, 190);
            this.numThreads.Maximum = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.numThreads.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numThreads.Name = "numThreads";
            this.numThreads.Size = new System.Drawing.Size(120, 25);
            this.numThreads.TabIndex = 5;
            this.numThreads.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numThreads.ValueChanged += new System.EventHandler(this.NumThreads_ValueChanged);
            // 
            // lblThreadsVal
            // 
            this.lblThreadsVal.AutoSize = true;
            this.lblThreadsVal.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Bold);
            this.lblThreadsVal.ForeColor = System.Drawing.Color.White;
            this.lblThreadsVal.Location = new System.Drawing.Point(140, 190);
            this.lblThreadsVal.Name = "lblThreadsVal";
            this.lblThreadsVal.Size = new System.Drawing.Size(20, 22);
            this.lblThreadsVal.TabIndex = 6;
            this.lblThreadsVal.Text = "4";
            // 
            // chkAutoStop
            // 
            this.chkAutoStop.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.chkAutoStop.ForeColor = System.Drawing.Color.White;
            this.chkAutoStop.Location = new System.Drawing.Point(0, 250);
            this.chkAutoStop.Name = "chkAutoStop";
            this.chkAutoStop.Size = new System.Drawing.Size(300, 30);
            this.chkAutoStop.TabIndex = 7;
            this.chkAutoStop.Text = "Auto-stop at target";
            this.chkAutoStop.UseVisualStyleBackColor = true;
            this.chkAutoStop.CheckedChanged += new System.EventHandler(this.ChkAutoStop_CheckedChanged);
            // 
            // chkAutoRestart
            // 
            this.chkAutoRestart.Checked = true;
            this.chkAutoRestart.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAutoRestart.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.chkAutoRestart.ForeColor = System.Drawing.Color.White;
            this.chkAutoRestart.Location = new System.Drawing.Point(0, 280);
            this.chkAutoRestart.Name = "chkAutoRestart";
            this.chkAutoRestart.Size = new System.Drawing.Size(300, 30);
            this.chkAutoRestart.TabIndex = 8;
            this.chkAutoRestart.Text = "Auto-restart on fail";
            this.chkAutoRestart.UseVisualStyleBackColor = true;
            this.chkAutoRestart.CheckedChanged += new System.EventHandler(this.ChkAutoRestart_CheckedChanged);
            // 
            // lblAutoStopTargetCaption
            // 
            this.lblAutoStopTargetCaption.AutoSize = true;
            this.lblAutoStopTargetCaption.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblAutoStopTargetCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.lblAutoStopTargetCaption.Location = new System.Drawing.Point(0, 320);
            this.lblAutoStopTargetCaption.Name = "lblAutoStopTargetCaption";
            this.lblAutoStopTargetCaption.Size = new System.Drawing.Size(73, 13);
            this.lblAutoStopTargetCaption.TabIndex = 9;
            this.lblAutoStopTargetCaption.Text = "TARGET (BTC)";
            // 
            // txtAutoStopTarget
            // 
            this.txtAutoStopTarget.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(38)))));
            this.txtAutoStopTarget.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAutoStopTarget.Font = new System.Drawing.Font("Consolas", 11F);
            this.txtAutoStopTarget.ForeColor = System.Drawing.Color.White;
            this.txtAutoStopTarget.Location = new System.Drawing.Point(0, 340);
            this.txtAutoStopTarget.Name = "txtAutoStopTarget";
            this.txtAutoStopTarget.Size = new System.Drawing.Size(300, 25);
            this.txtAutoStopTarget.TabIndex = 10;
            this.txtAutoStopTarget.Text = "0.00001000";
            this.txtAutoStopTarget.TextChanged += new System.EventHandler(this.TxtAutoStopTarget_TextChanged);
            // 
            // btnSaveSettings
            // 
            this.btnSaveSettings.BackColor = System.Drawing.Color.White;
            this.btnSaveSettings.FlatAppearance.BorderSize = 0;
            this.btnSaveSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveSettings.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnSaveSettings.ForeColor = System.Drawing.Color.Black;
            this.btnSaveSettings.Location = new System.Drawing.Point(0, 400);
            this.btnSaveSettings.Name = "btnSaveSettings";
            this.btnSaveSettings.Size = new System.Drawing.Size(200, 40);
            this.btnSaveSettings.TabIndex = 11;
            this.btnSaveSettings.Text = "💾  SAVE";
            this.btnSaveSettings.UseVisualStyleBackColor = false;
            this.btnSaveSettings.Click += new System.EventHandler(this.BtnSaveSettings_Click);
            // 
            // btnLoadSettings
            // 
            this.btnLoadSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnLoadSettings.FlatAppearance.BorderSize = 0;
            this.btnLoadSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadSettings.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnLoadSettings.ForeColor = System.Drawing.Color.White;
            this.btnLoadSettings.Location = new System.Drawing.Point(220, 400);
            this.btnLoadSettings.Name = "btnLoadSettings";
            this.btnLoadSettings.Size = new System.Drawing.Size(200, 40);
            this.btnLoadSettings.TabIndex = 12;
            this.btnLoadSettings.Text = "📂  LOAD";
            this.btnLoadSettings.UseVisualStyleBackColor = false;
            this.btnLoadSettings.Click += new System.EventHandler(this.BtnLoadSettings_Click);
            // 
            // btnToggleTheme
            // 
            this.btnToggleTheme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnToggleTheme.FlatAppearance.BorderSize = 0;
            this.btnToggleTheme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToggleTheme.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnToggleTheme.ForeColor = System.Drawing.Color.White;
            this.btnToggleTheme.Location = new System.Drawing.Point(440, 400);
            this.btnToggleTheme.Name = "btnToggleTheme";
            this.btnToggleTheme.Size = new System.Drawing.Size(220, 40);
            this.btnToggleTheme.TabIndex = 13;
            this.btnToggleTheme.Text = "◐  THEME";
            this.btnToggleTheme.UseVisualStyleBackColor = false;
            this.btnToggleTheme.Click += new System.EventHandler(this.BtnToggleTheme_Click);
            // 
            // pageAdvanced
            // 
            this.pageAdvanced.BackColor = System.Drawing.Color.Transparent;
            this.pageAdvanced.Controls.Add(this.lblAdvTitle);
            this.pageAdvanced.Controls.Add(this.lblStakeCaption);
            this.pageAdvanced.Controls.Add(this.txtStakeAmount);
            this.pageAdvanced.Controls.Add(this.btnStake);
            this.pageAdvanced.Controls.Add(this.btnUnstake);
            this.pageAdvanced.Controls.Add(this.lblApyCaption);
            this.pageAdvanced.Controls.Add(this.lblApyVal);
            this.pageAdvanced.Controls.Add(this.btnReferral);
            this.pageAdvanced.Controls.Add(this.lblNewWalletCaption);
            this.pageAdvanced.Controls.Add(this.txtNewWalletInput);
            this.pageAdvanced.Controls.Add(this.btnSetWallet);
            this.pageAdvanced.Controls.Add(this.lblAchCaption);
            this.pageAdvanced.Controls.Add(this.lstAchievements);
            this.pageAdvanced.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pageAdvanced.Location = new System.Drawing.Point(30, 20);
            this.pageAdvanced.Name = "pageAdvanced";
            this.pageAdvanced.Size = new System.Drawing.Size(1540, 722);
            this.pageAdvanced.TabIndex = 4;
            this.pageAdvanced.Visible = false;
            // 
            // lblAdvTitle
            // 
            this.lblAdvTitle.AutoSize = true;
            this.lblAdvTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 26F, System.Drawing.FontStyle.Bold);
            this.lblAdvTitle.ForeColor = System.Drawing.Color.White;
            this.lblAdvTitle.Location = new System.Drawing.Point(0, 0);
            this.lblAdvTitle.Name = "lblAdvTitle";
            this.lblAdvTitle.Size = new System.Drawing.Size(321, 47);
            this.lblAdvTitle.TabIndex = 0;
            this.lblAdvTitle.Text = "Advanced Features";
            // 
            // lblStakeCaption
            // 
            this.lblStakeCaption.AutoSize = true;
            this.lblStakeCaption.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblStakeCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.lblStakeCaption.Location = new System.Drawing.Point(0, 80);
            this.lblStakeCaption.Name = "lblStakeCaption";
            this.lblStakeCaption.Size = new System.Drawing.Size(109, 13);
            this.lblStakeCaption.TabIndex = 1;
            this.lblStakeCaption.Text = "STAKING (simulated)";
            // 
            // txtStakeAmount
            // 
            this.txtStakeAmount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(38)))));
            this.txtStakeAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStakeAmount.Font = new System.Drawing.Font("Consolas", 11F);
            this.txtStakeAmount.ForeColor = System.Drawing.Color.White;
            this.txtStakeAmount.Location = new System.Drawing.Point(0, 100);
            this.txtStakeAmount.Name = "txtStakeAmount";
            this.txtStakeAmount.Size = new System.Drawing.Size(240, 25);
            this.txtStakeAmount.TabIndex = 2;
            this.txtStakeAmount.Text = "0.00000100";
            // 
            // btnStake
            // 
            this.btnStake.BackColor = System.Drawing.Color.White;
            this.btnStake.FlatAppearance.BorderSize = 0;
            this.btnStake.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStake.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnStake.ForeColor = System.Drawing.Color.Black;
            this.btnStake.Location = new System.Drawing.Point(260, 100);
            this.btnStake.Name = "btnStake";
            this.btnStake.Size = new System.Drawing.Size(160, 25);
            this.btnStake.TabIndex = 3;
            this.btnStake.Text = "🔒  STAKE";
            this.btnStake.UseVisualStyleBackColor = false;
            this.btnStake.Click += new System.EventHandler(this.BtnStake_Click);
            // 
            // btnUnstake
            // 
            this.btnUnstake.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnUnstake.FlatAppearance.BorderSize = 0;
            this.btnUnstake.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUnstake.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnUnstake.ForeColor = System.Drawing.Color.White;
            this.btnUnstake.Location = new System.Drawing.Point(430, 100);
            this.btnUnstake.Name = "btnUnstake";
            this.btnUnstake.Size = new System.Drawing.Size(160, 25);
            this.btnUnstake.TabIndex = 4;
            this.btnUnstake.Text = "🔓  UNSTAKE";
            this.btnUnstake.UseVisualStyleBackColor = false;
            this.btnUnstake.Click += new System.EventHandler(this.BtnUnstake_Click);
            // 
            // lblApyCaption
            // 
            this.lblApyCaption.AutoSize = true;
            this.lblApyCaption.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblApyCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.lblApyCaption.Location = new System.Drawing.Point(620, 90);
            this.lblApyCaption.Name = "lblApyCaption";
            this.lblApyCaption.Size = new System.Drawing.Size(25, 13);
            this.lblApyCaption.TabIndex = 5;
            this.lblApyCaption.Text = "APY";
            // 
            // lblApyVal
            // 
            this.lblApyVal.AutoSize = true;
            this.lblApyVal.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold);
            this.lblApyVal.ForeColor = System.Drawing.Color.White;
            this.lblApyVal.Location = new System.Drawing.Point(620, 106);
            this.lblApyVal.Name = "lblApyVal";
            this.lblApyVal.Size = new System.Drawing.Size(77, 28);
            this.lblApyVal.TabIndex = 6;
            this.lblApyVal.Text = "5.50%";
            // 
            // btnReferral
            // 
            this.btnReferral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnReferral.FlatAppearance.BorderSize = 0;
            this.btnReferral.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReferral.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnReferral.ForeColor = System.Drawing.Color.White;
            this.btnReferral.Location = new System.Drawing.Point(0, 160);
            this.btnReferral.Name = "btnReferral";
            this.btnReferral.Size = new System.Drawing.Size(280, 40);
            this.btnReferral.TabIndex = 7;
            this.btnReferral.Text = "👥  REFERRAL BONUS";
            this.btnReferral.UseVisualStyleBackColor = false;
            this.btnReferral.Click += new System.EventHandler(this.BtnReferral_Click);
            // 
            // lblNewWalletCaption
            // 
            this.lblNewWalletCaption.AutoSize = true;
            this.lblNewWalletCaption.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblNewWalletCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.lblNewWalletCaption.Location = new System.Drawing.Point(0, 220);
            this.lblNewWalletCaption.Name = "lblNewWalletCaption";
            this.lblNewWalletCaption.Size = new System.Drawing.Size(167, 13);
            this.lblNewWalletCaption.TabIndex = 8;
            this.lblNewWalletCaption.Text = "SET CUSTOM WALLET ADDRESS";
            // 
            // txtNewWalletInput
            // 
            this.txtNewWalletInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(38)))));
            this.txtNewWalletInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNewWalletInput.Font = new System.Drawing.Font("Consolas", 11F);
            this.txtNewWalletInput.ForeColor = System.Drawing.Color.White;
            this.txtNewWalletInput.Location = new System.Drawing.Point(0, 240);
            this.txtNewWalletInput.Name = "txtNewWalletInput";
            this.txtNewWalletInput.Size = new System.Drawing.Size(500, 25);
            this.txtNewWalletInput.TabIndex = 9;
            // 
            // btnSetWallet
            // 
            this.btnSetWallet.BackColor = System.Drawing.Color.White;
            this.btnSetWallet.FlatAppearance.BorderSize = 0;
            this.btnSetWallet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetWallet.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnSetWallet.ForeColor = System.Drawing.Color.Black;
            this.btnSetWallet.Location = new System.Drawing.Point(520, 240);
            this.btnSetWallet.Name = "btnSetWallet";
            this.btnSetWallet.Size = new System.Drawing.Size(200, 25);
            this.btnSetWallet.TabIndex = 10;
            this.btnSetWallet.Text = "✓  SET WALLET";
            this.btnSetWallet.UseVisualStyleBackColor = false;
            this.btnSetWallet.Click += new System.EventHandler(this.BtnSetWallet_Click);
            // 
            // lblAchCaption
            // 
            this.lblAchCaption.AutoSize = true;
            this.lblAchCaption.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblAchCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.lblAchCaption.Location = new System.Drawing.Point(0, 300);
            this.lblAchCaption.Name = "lblAchCaption";
            this.lblAchCaption.Size = new System.Drawing.Size(87, 13);
            this.lblAchCaption.TabIndex = 11;
            this.lblAchCaption.Text = "ACHIEVEMENTS";
            // 
            // lstAchievements
            // 
            this.lstAchievements.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(14)))));
            this.lstAchievements.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstAchievements.Font = new System.Drawing.Font("Consolas", 10F);
            this.lstAchievements.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.lstAchievements.ItemHeight = 15;
            this.lstAchievements.Location = new System.Drawing.Point(0, 320);
            this.lstAchievements.Name = "lstAchievements";
            this.lstAchievements.Size = new System.Drawing.Size(720, 255);
            this.lstAchievements.TabIndex = 12;
            // 
            // panelBottom
            // 
            this.panelBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(14)))));
            this.panelBottom.Controls.Add(this.lblConvCaption);
            this.panelBottom.Controls.Add(this.lblConvBtc);
            this.panelBottom.Controls.Add(this.lblConvUsd);
            this.panelBottom.Controls.Add(this.lblConvRub);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 864);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(1600, 36);
            this.panelBottom.TabIndex = 3;
            // 
            // lblConvCaption
            // 
            this.lblConvCaption.AutoSize = true;
            this.lblConvCaption.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblConvCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.lblConvCaption.Location = new System.Drawing.Point(24, 10);
            this.lblConvCaption.Name = "lblConvCaption";
            this.lblConvCaption.Size = new System.Drawing.Size(70, 13);
            this.lblConvCaption.TabIndex = 0;
            this.lblConvCaption.Text = "CONVERTER";
            // 
            // lblConvBtc
            // 
            this.lblConvBtc.AutoSize = true;
            this.lblConvBtc.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Bold);
            this.lblConvBtc.ForeColor = System.Drawing.Color.White;
            this.lblConvBtc.Location = new System.Drawing.Point(130, 8);
            this.lblConvBtc.Name = "lblConvBtc";
            this.lblConvBtc.Size = new System.Drawing.Size(120, 18);
            this.lblConvBtc.TabIndex = 1;
            this.lblConvBtc.Text = "0.00000000 BTC";
            // 
            // lblConvUsd
            // 
            this.lblConvUsd.AutoSize = true;
            this.lblConvUsd.Font = new System.Drawing.Font("Consolas", 11F);
            this.lblConvUsd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.lblConvUsd.Location = new System.Drawing.Point(320, 8);
            this.lblConvUsd.Name = "lblConvUsd";
            this.lblConvUsd.Size = new System.Drawing.Size(48, 18);
            this.lblConvUsd.TabIndex = 2;
            this.lblConvUsd.Text = "$0.00";
            // 
            // lblConvRub
            // 
            this.lblConvRub.AutoSize = true;
            this.lblConvRub.Font = new System.Drawing.Font("Consolas", 11F);
            this.lblConvRub.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.lblConvRub.Location = new System.Drawing.Point(490, 8);
            this.lblConvRub.Name = "lblConvRub";
            this.lblConvRub.Size = new System.Drawing.Size(56, 18);
            this.lblConvRub.TabIndex = 3;
            this.lblConvRub.Text = "0.00 ₽";
            // 
            // lblToast
            // 
            this.lblToast.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(44)))));
            this.lblToast.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.lblToast.ForeColor = System.Drawing.Color.White;
            this.lblToast.Location = new System.Drawing.Point(650, 700);
            this.lblToast.Name = "lblToast";
            this.lblToast.Size = new System.Drawing.Size(300, 50);
            this.lblToast.TabIndex = 6;
            this.lblToast.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblToast.Visible = false;
            // 
            // panelMenuShade
            // 
            this.panelMenuShade.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panelMenuShade.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMenuShade.Location = new System.Drawing.Point(0, 102);
            this.panelMenuShade.Name = "panelMenuShade";
            this.panelMenuShade.Size = new System.Drawing.Size(1600, 762);
            this.panelMenuShade.TabIndex = 10;
            this.panelMenuShade.Visible = false;
            this.panelMenuShade.Click += new System.EventHandler(this.PanelMenuShade_Click);
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(24)))));
            this.panelMenu.Location = new System.Drawing.Point(-320, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(320, 900);
            this.panelMenu.TabIndex = 11;
            // 
            // timerMine
            // 
            this.timerMine.Interval = 700;
            this.timerMine.Tick += new System.EventHandler(this.TimerMine_Tick);
            // 
            // timerAnim
            // 
            this.timerAnim.Interval = 16;
            this.timerAnim.Tick += new System.EventHandler(this.TimerAnim_Tick);
            // 
            // timerStake
            // 
            this.timerStake.Interval = 3000;
            this.timerStake.Tick += new System.EventHandler(this.TimerStake_Tick);
            // 
            // timerBg
            // 
            this.timerBg.Interval = 30;
            this.timerBg.Tick += new System.EventHandler(this.TimerBg_Tick);
            // 
            // toastTimer
            // 
            this.toastTimer.Interval = 2000;
            this.toastTimer.Tick += new System.EventHandler(this.ToastTimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(12)))));
            this.ClientSize = new System.Drawing.Size(1600, 900);
            this.Controls.Add(this.panelMenuShade);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.panelTabs);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.lblToast);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BTC Miner Pro";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panelTabs.ResumeLayout(false);
            this.panelMain.ResumeLayout(false);
            this.pageMining.ResumeLayout(false);
            this.pageMining.PerformLayout();
            this.pageSend.ResumeLayout(false);
            this.pageSend.PerformLayout();
            this.pageReceive.ResumeLayout(false);
            this.pageReceive.PerformLayout();
            this.pageSettings.ResumeLayout(false);
            this.pageSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackIntensity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numThreads)).EndInit();
            this.pageAdvanced.ResumeLayout(false);
            this.pageAdvanced.PerformLayout();
            this.panelBottom.ResumeLayout(false);
            this.panelBottom.PerformLayout();
            this.ResumeLayout(false);

        }

        // ============== Объявления контролов ==============
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnTheme;
        private System.Windows.Forms.Button btnFullscreen;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnClose;

        private System.Windows.Forms.Panel panelTabs;
        private System.Windows.Forms.Label lblTabMining;
        private System.Windows.Forms.Label lblTabSend;
        private System.Windows.Forms.Label lblTabReceive;
        private System.Windows.Forms.Label lblTabSettings;
        private System.Windows.Forms.Label lblTabAdvanced;
        private System.Windows.Forms.Panel panelTabIndicator;

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelSideStats;

        private System.Windows.Forms.Panel pageMining;
        private System.Windows.Forms.Label lblBalanceCaption;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Label lblHashRateCaption;
        private System.Windows.Forms.Label lblHashRate;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Panel panelStatusDot;
        private System.Windows.Forms.Label lblSessionCaption;
        private System.Windows.Forms.Label lblSession;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Button btnStartStop;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnCalcProfit;
        private System.Windows.Forms.ComboBox cmbPool;
        private System.Windows.Forms.ComboBox cmbProfile;
        private System.Windows.Forms.Panel panelChart;
        private System.Windows.Forms.Panel panelGpuMon;
        private System.Windows.Forms.Label lblGpuTempCap;
        private System.Windows.Forms.Label lblGpuTemp;
        private System.Windows.Forms.Label lblGpuFanCap;
        private System.Windows.Forms.Label lblGpuFan;
        private System.Windows.Forms.Label lblGpuPowerCap;
        private System.Windows.Forms.Label lblGpuPower;
        private System.Windows.Forms.RichTextBox txtLog;
        private System.Windows.Forms.Button btnExportLogs;

        private System.Windows.Forms.Panel pageSend;
        private System.Windows.Forms.Label lblSendTitle;
        private System.Windows.Forms.Label lblSendAddressCaption;
        private System.Windows.Forms.TextBox txtSendAddress;
        private System.Windows.Forms.Label lblSendAmountCaption;
        private System.Windows.Forms.TextBox txtSendAmount;
        private System.Windows.Forms.Button btnSendConfirm;
        private System.Windows.Forms.Label lblTxHistoryCaption;
        private System.Windows.Forms.ListBox lstTxHistory;

        private System.Windows.Forms.Panel pageReceive;
        private System.Windows.Forms.Label lblRecvTitle;
        private System.Windows.Forms.Label lblRecvCaption;
        private System.Windows.Forms.TextBox txtWallet;
        private System.Windows.Forms.Button btnCopyReceive;
        private System.Windows.Forms.Button btnNewWallet;
        private System.Windows.Forms.Button btnShowQr;

        private System.Windows.Forms.Panel pageSettings;
        private System.Windows.Forms.Label lblSetTitle;
        private System.Windows.Forms.Label lblIntensityCaption;
        private System.Windows.Forms.TrackBar trackIntensity;
        private System.Windows.Forms.Label lblIntensityVal;
        private System.Windows.Forms.Label lblThreadsCaption;
        private System.Windows.Forms.NumericUpDown numThreads;
        private System.Windows.Forms.Label lblThreadsVal;
        private System.Windows.Forms.CheckBox chkAutoStop;
        private System.Windows.Forms.CheckBox chkAutoRestart;
        private System.Windows.Forms.Label lblAutoStopTargetCaption;
        private System.Windows.Forms.TextBox txtAutoStopTarget;
        private System.Windows.Forms.Button btnSaveSettings;
        private System.Windows.Forms.Button btnLoadSettings;
        private System.Windows.Forms.Button btnToggleTheme;

        private System.Windows.Forms.Panel pageAdvanced;
        private System.Windows.Forms.Label lblAdvTitle;
        private System.Windows.Forms.Label lblStakeCaption;
        private System.Windows.Forms.TextBox txtStakeAmount;
        private System.Windows.Forms.Button btnStake;
        private System.Windows.Forms.Button btnUnstake;
        private System.Windows.Forms.Label lblApyCaption;
        private System.Windows.Forms.Label lblApyVal;
        private System.Windows.Forms.Button btnReferral;
        private System.Windows.Forms.Label lblNewWalletCaption;
        private System.Windows.Forms.TextBox txtNewWalletInput;
        private System.Windows.Forms.Button btnSetWallet;
        private System.Windows.Forms.Label lblAchCaption;
        private System.Windows.Forms.ListBox lstAchievements;

        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Label lblConvCaption;
        private System.Windows.Forms.Label lblConvBtc;
        private System.Windows.Forms.Label lblConvUsd;
        private System.Windows.Forms.Label lblConvRub;

        private System.Windows.Forms.Label lblToast;

        private System.Windows.Forms.Panel panelMenuShade;
        private System.Windows.Forms.Panel panelMenu;

        private System.Windows.Forms.Timer timerMine;
        private System.Windows.Forms.Timer timerAnim;
        private System.Windows.Forms.Timer timerStake;
        private System.Windows.Forms.Timer timerBg;
        private System.Windows.Forms.Timer toastTimer;
    }
}