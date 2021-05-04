
namespace AmongUsModUpdater
{
    partial class MainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.homeButton = new System.Windows.Forms.Button();
            this.settingsButton = new System.Windows.Forms.Button();
            this.helpButton = new System.Windows.Forms.Button();
            this.panelHome = new System.Windows.Forms.Panel();
            this.buttonHomeInstall = new CustomButton.CustomButton();
            this.waitingInfoForStart = new System.Windows.Forms.Label();
            this.buttonHomeUpdate = new CustomButton.CustomButton();
            this.otherRolesBanner = new System.Windows.Forms.PictureBox();
            this.downloadProgress = new System.Windows.Forms.ProgressBar();
            this.buttonHomeStart = new CustomButton.CustomButton();
            this.panelSettings = new System.Windows.Forms.Panel();
            this.settingsButtonQuickSearch = new CustomButton.CustomButton();
            this.settingsOpenFolder = new CustomButton.CustomButton();
            this.buttonWorkerCancel = new System.Windows.Forms.Button();
            this.labelProcessedDrives = new System.Windows.Forms.Label();
            this.progressBarSearch = new System.Windows.Forms.ProgressBar();
            this.settingsButtonAutomated = new CustomButton.CustomButton();
            this.settingButtonManual = new CustomButton.CustomButton();
            this.labelSettingsHeader = new System.Windows.Forms.Label();
            this.labelSettingsBackup = new System.Windows.Forms.Label();
            this.settingsToggleBackup = new CustomToggle.CustomToggle();
            this.settingsGamePathTextBox = new CustomTextBox.CustomTextBox();
            this.labelSettingsPath = new System.Windows.Forms.Label();
            this.panelHelp = new System.Windows.Forms.Panel();
            this.labelCopyright = new System.Windows.Forms.Label();
            this.labelCopyrightHeader = new System.Windows.Forms.Label();
            this.linkLabelResourcesGit = new System.Windows.Forms.LinkLabel();
            this.labelResourcesGit = new System.Windows.Forms.Label();
            this.labelResourcesHeader = new System.Windows.Forms.Label();
            this.labelVersionHeader = new System.Windows.Forms.Label();
            this.labelVersion = new System.Windows.Forms.Label();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.panelTop = new System.Windows.Forms.Panel();
            this.newVersionButton = new CustomButton.CustomButton();
            this.buttonExit = new System.Windows.Forms.Button();
            this.panelMenuActive = new System.Windows.Forms.Panel();
            this.manualLocationFolderDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.panelHome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.otherRolesBanner)).BeginInit();
            this.panelSettings.SuspendLayout();
            this.panelHelp.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // homeButton
            // 
            this.homeButton.FlatAppearance.BorderSize = 0;
            this.homeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homeButton.ForeColor = System.Drawing.Color.White;
            this.homeButton.Location = new System.Drawing.Point(0, 60);
            this.homeButton.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(158, 75);
            this.homeButton.TabIndex = 5;
            this.homeButton.Text = "Home";
            this.homeButton.UseVisualStyleBackColor = true;
            this.homeButton.Click += new System.EventHandler(this.homeButton_Click);
            // 
            // settingsButton
            // 
            this.settingsButton.FlatAppearance.BorderSize = 0;
            this.settingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settingsButton.ForeColor = System.Drawing.Color.White;
            this.settingsButton.Location = new System.Drawing.Point(0, 135);
            this.settingsButton.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(158, 75);
            this.settingsButton.TabIndex = 6;
            this.settingsButton.Text = "Settings";
            this.settingsButton.UseVisualStyleBackColor = true;
            this.settingsButton.Click += new System.EventHandler(this.settingsButton_Click);
            // 
            // helpButton
            // 
            this.helpButton.FlatAppearance.BorderSize = 0;
            this.helpButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.helpButton.ForeColor = System.Drawing.Color.White;
            this.helpButton.Location = new System.Drawing.Point(0, 210);
            this.helpButton.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.helpButton.Name = "helpButton";
            this.helpButton.Size = new System.Drawing.Size(158, 75);
            this.helpButton.TabIndex = 7;
            this.helpButton.Text = "Help";
            this.helpButton.UseVisualStyleBackColor = true;
            this.helpButton.Click += new System.EventHandler(this.helpButton_Click);
            // 
            // panelHome
            // 
            this.panelHome.Controls.Add(this.buttonHomeInstall);
            this.panelHome.Controls.Add(this.waitingInfoForStart);
            this.panelHome.Controls.Add(this.buttonHomeUpdate);
            this.panelHome.Controls.Add(this.otherRolesBanner);
            this.panelHome.Controls.Add(this.downloadProgress);
            this.panelHome.Controls.Add(this.buttonHomeStart);
            this.panelHome.Location = new System.Drawing.Point(172, 60);
            this.panelHome.Name = "panelHome";
            this.panelHome.Size = new System.Drawing.Size(528, 372);
            this.panelHome.TabIndex = 8;
            this.panelHome.Visible = false;
            this.panelHome.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelMenu_MouseDown);
            this.panelHome.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelMenu_MouseMove);
            // 
            // buttonHomeInstall
            // 
            this.buttonHomeInstall.Active1 = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(68)))));
            this.buttonHomeInstall.Active2 = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(68)))));
            this.buttonHomeInstall.BackColor = System.Drawing.Color.Transparent;
            this.buttonHomeInstall.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonHomeInstall.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonHomeInstall.ForeColor = System.Drawing.Color.White;
            this.buttonHomeInstall.Inactive1 = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(72)))), ((int)(((byte)(33)))));
            this.buttonHomeInstall.Inactive2 = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(72)))), ((int)(((byte)(33)))));
            this.buttonHomeInstall.Location = new System.Drawing.Point(176, 102);
            this.buttonHomeInstall.Margin = new System.Windows.Forms.Padding(2);
            this.buttonHomeInstall.Name = "buttonHomeInstall";
            this.buttonHomeInstall.Radius = 10;
            this.buttonHomeInstall.Size = new System.Drawing.Size(176, 72);
            this.buttonHomeInstall.Stroke = false;
            this.buttonHomeInstall.StrokeColor = System.Drawing.Color.Gray;
            this.buttonHomeInstall.TabIndex = 9;
            this.buttonHomeInstall.Text = "Install";
            this.buttonHomeInstall.Transparency = false;
            this.buttonHomeInstall.Visible = false;
            this.buttonHomeInstall.Click += new System.EventHandler(this.buttonHomeInstall_Click);
            // 
            // waitingInfoForStart
            // 
            this.waitingInfoForStart.AutoSize = true;
            this.waitingInfoForStart.Location = new System.Drawing.Point(121, 226);
            this.waitingInfoForStart.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.waitingInfoForStart.Name = "waitingInfoForStart";
            this.waitingInfoForStart.Size = new System.Drawing.Size(276, 15);
            this.waitingInfoForStart.TabIndex = 8;
            this.waitingInfoForStart.Text = "It takes a little while to start Among Us. Please wait.";
            this.waitingInfoForStart.Visible = false;
            // 
            // buttonHomeUpdate
            // 
            this.buttonHomeUpdate.Active1 = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(68)))));
            this.buttonHomeUpdate.Active2 = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(68)))));
            this.buttonHomeUpdate.BackColor = System.Drawing.Color.Transparent;
            this.buttonHomeUpdate.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonHomeUpdate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonHomeUpdate.ForeColor = System.Drawing.Color.White;
            this.buttonHomeUpdate.Inactive1 = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(72)))), ((int)(((byte)(33)))));
            this.buttonHomeUpdate.Inactive2 = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(72)))), ((int)(((byte)(33)))));
            this.buttonHomeUpdate.Location = new System.Drawing.Point(176, 102);
            this.buttonHomeUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.buttonHomeUpdate.Name = "buttonHomeUpdate";
            this.buttonHomeUpdate.Radius = 10;
            this.buttonHomeUpdate.Size = new System.Drawing.Size(176, 72);
            this.buttonHomeUpdate.Stroke = false;
            this.buttonHomeUpdate.StrokeColor = System.Drawing.Color.Gray;
            this.buttonHomeUpdate.TabIndex = 5;
            this.buttonHomeUpdate.Text = "Update";
            this.buttonHomeUpdate.Transparency = false;
            this.buttonHomeUpdate.Visible = false;
            this.buttonHomeUpdate.Click += new System.EventHandler(this.buttoneHomeUpdate_Click);
            // 
            // otherRolesBanner
            // 
            this.otherRolesBanner.Image = ((System.Drawing.Image)(resources.GetObject("otherRolesBanner.Image")));
            this.otherRolesBanner.Location = new System.Drawing.Point(32, 0);
            this.otherRolesBanner.Margin = new System.Windows.Forms.Padding(2);
            this.otherRolesBanner.Name = "otherRolesBanner";
            this.otherRolesBanner.Size = new System.Drawing.Size(470, 77);
            this.otherRolesBanner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.otherRolesBanner.TabIndex = 7;
            this.otherRolesBanner.TabStop = false;
            this.otherRolesBanner.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelMenu_MouseDown);
            this.otherRolesBanner.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelMenu_MouseMove);
            this.otherRolesBanner.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelMenu_MouseUp);
            // 
            // downloadProgress
            // 
            this.downloadProgress.Location = new System.Drawing.Point(69, 190);
            this.downloadProgress.Margin = new System.Windows.Forms.Padding(10);
            this.downloadProgress.Name = "downloadProgress";
            this.downloadProgress.Size = new System.Drawing.Size(398, 23);
            this.downloadProgress.TabIndex = 4;
            this.downloadProgress.Visible = false;
            // 
            // buttonHomeStart
            // 
            this.buttonHomeStart.Active1 = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(68)))));
            this.buttonHomeStart.Active2 = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(68)))));
            this.buttonHomeStart.BackColor = System.Drawing.Color.Transparent;
            this.buttonHomeStart.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonHomeStart.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonHomeStart.ForeColor = System.Drawing.Color.White;
            this.buttonHomeStart.Inactive1 = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(72)))), ((int)(((byte)(33)))));
            this.buttonHomeStart.Inactive2 = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(72)))), ((int)(((byte)(33)))));
            this.buttonHomeStart.Location = new System.Drawing.Point(176, 103);
            this.buttonHomeStart.Margin = new System.Windows.Forms.Padding(2);
            this.buttonHomeStart.Name = "buttonHomeStart";
            this.buttonHomeStart.Radius = 10;
            this.buttonHomeStart.Size = new System.Drawing.Size(176, 71);
            this.buttonHomeStart.Stroke = false;
            this.buttonHomeStart.StrokeColor = System.Drawing.Color.Gray;
            this.buttonHomeStart.TabIndex = 6;
            this.buttonHomeStart.Text = "Start";
            this.buttonHomeStart.Transparency = false;
            this.buttonHomeStart.Visible = false;
            this.buttonHomeStart.Click += new System.EventHandler(this.buttonHomeStart_Click);
            // 
            // panelSettings
            // 
            this.panelSettings.Controls.Add(this.settingsButtonQuickSearch);
            this.panelSettings.Controls.Add(this.settingsOpenFolder);
            this.panelSettings.Controls.Add(this.buttonWorkerCancel);
            this.panelSettings.Controls.Add(this.labelProcessedDrives);
            this.panelSettings.Controls.Add(this.progressBarSearch);
            this.panelSettings.Controls.Add(this.settingsButtonAutomated);
            this.panelSettings.Controls.Add(this.settingButtonManual);
            this.panelSettings.Controls.Add(this.labelSettingsHeader);
            this.panelSettings.Controls.Add(this.labelSettingsBackup);
            this.panelSettings.Controls.Add(this.settingsToggleBackup);
            this.panelSettings.Controls.Add(this.settingsGamePathTextBox);
            this.panelSettings.Controls.Add(this.labelSettingsPath);
            this.panelSettings.Location = new System.Drawing.Point(172, 60);
            this.panelSettings.Name = "panelSettings";
            this.panelSettings.Size = new System.Drawing.Size(528, 372);
            this.panelSettings.TabIndex = 9;
            this.panelSettings.Visible = false;
            this.panelSettings.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelMenu_MouseDown);
            this.panelSettings.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelMenu_MouseMove);
            // 
            // settingsButtonQuickSearch
            // 
            this.settingsButtonQuickSearch.Active1 = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(68)))));
            this.settingsButtonQuickSearch.Active2 = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(68)))));
            this.settingsButtonQuickSearch.BackColor = System.Drawing.Color.Transparent;
            this.settingsButtonQuickSearch.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.settingsButtonQuickSearch.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.settingsButtonQuickSearch.ForeColor = System.Drawing.Color.White;
            this.settingsButtonQuickSearch.Inactive1 = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(72)))), ((int)(((byte)(33)))));
            this.settingsButtonQuickSearch.Inactive2 = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(72)))), ((int)(((byte)(33)))));
            this.settingsButtonQuickSearch.Location = new System.Drawing.Point(156, 109);
            this.settingsButtonQuickSearch.Margin = new System.Windows.Forms.Padding(2);
            this.settingsButtonQuickSearch.Name = "settingsButtonQuickSearch";
            this.settingsButtonQuickSearch.Radius = 10;
            this.settingsButtonQuickSearch.Size = new System.Drawing.Size(108, 29);
            this.settingsButtonQuickSearch.Stroke = false;
            this.settingsButtonQuickSearch.StrokeColor = System.Drawing.Color.Gray;
            this.settingsButtonQuickSearch.TabIndex = 13;
            this.settingsButtonQuickSearch.Text = "Quick search";
            this.settingsButtonQuickSearch.Transparency = false;
            this.settingsButtonQuickSearch.Click += new System.EventHandler(this.settingsButtonQuickSearch_Click);
            // 
            // settingsOpenFolder
            // 
            this.settingsOpenFolder.Active1 = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(68)))));
            this.settingsOpenFolder.Active2 = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(68)))));
            this.settingsOpenFolder.BackColor = System.Drawing.Color.Transparent;
            this.settingsOpenFolder.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.settingsOpenFolder.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.settingsOpenFolder.ForeColor = System.Drawing.Color.White;
            this.settingsOpenFolder.Inactive1 = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(72)))), ((int)(((byte)(33)))));
            this.settingsOpenFolder.Inactive2 = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(72)))), ((int)(((byte)(33)))));
            this.settingsOpenFolder.Location = new System.Drawing.Point(397, 109);
            this.settingsOpenFolder.Margin = new System.Windows.Forms.Padding(2);
            this.settingsOpenFolder.Name = "settingsOpenFolder";
            this.settingsOpenFolder.Radius = 10;
            this.settingsOpenFolder.Size = new System.Drawing.Size(122, 29);
            this.settingsOpenFolder.Stroke = false;
            this.settingsOpenFolder.StrokeColor = System.Drawing.Color.Gray;
            this.settingsOpenFolder.TabIndex = 12;
            this.settingsOpenFolder.Text = "Open directory";
            this.settingsOpenFolder.Transparency = false;
            this.settingsOpenFolder.Click += new System.EventHandler(this.settingsOpenFolder_Click);
            // 
            // buttonWorkerCancel
            // 
            this.buttonWorkerCancel.FlatAppearance.BorderSize = 0;
            this.buttonWorkerCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonWorkerCancel.ForeColor = System.Drawing.Color.Silver;
            this.buttonWorkerCancel.Location = new System.Drawing.Point(386, 226);
            this.buttonWorkerCancel.Margin = new System.Windows.Forms.Padding(2);
            this.buttonWorkerCancel.Name = "buttonWorkerCancel";
            this.buttonWorkerCancel.Size = new System.Drawing.Size(27, 23);
            this.buttonWorkerCancel.TabIndex = 11;
            this.buttonWorkerCancel.Text = "X";
            this.buttonWorkerCancel.UseVisualStyleBackColor = true;
            this.buttonWorkerCancel.Visible = false;
            this.buttonWorkerCancel.Click += new System.EventHandler(this.cancelAsyncButton_Click);
            // 
            // labelProcessedDrives
            // 
            this.labelProcessedDrives.AutoSize = true;
            this.labelProcessedDrives.Location = new System.Drawing.Point(32, 252);
            this.labelProcessedDrives.Name = "labelProcessedDrives";
            this.labelProcessedDrives.Size = new System.Drawing.Size(95, 15);
            this.labelProcessedDrives.TabIndex = 9;
            this.labelProcessedDrives.Text = "Processed Drives";
            this.labelProcessedDrives.Visible = false;
            // 
            // progressBarSearch
            // 
            this.progressBarSearch.Location = new System.Drawing.Point(32, 226);
            this.progressBarSearch.Name = "progressBarSearch";
            this.progressBarSearch.Size = new System.Drawing.Size(349, 23);
            this.progressBarSearch.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBarSearch.TabIndex = 8;
            this.progressBarSearch.Visible = false;
            // 
            // settingsButtonAutomated
            // 
            this.settingsButtonAutomated.Active1 = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(68)))));
            this.settingsButtonAutomated.Active2 = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(68)))));
            this.settingsButtonAutomated.BackColor = System.Drawing.Color.Transparent;
            this.settingsButtonAutomated.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.settingsButtonAutomated.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.settingsButtonAutomated.ForeColor = System.Drawing.Color.White;
            this.settingsButtonAutomated.Inactive1 = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(72)))), ((int)(((byte)(33)))));
            this.settingsButtonAutomated.Inactive2 = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(72)))), ((int)(((byte)(33)))));
            this.settingsButtonAutomated.Location = new System.Drawing.Point(276, 109);
            this.settingsButtonAutomated.Margin = new System.Windows.Forms.Padding(2);
            this.settingsButtonAutomated.Name = "settingsButtonAutomated";
            this.settingsButtonAutomated.Radius = 10;
            this.settingsButtonAutomated.Size = new System.Drawing.Size(108, 29);
            this.settingsButtonAutomated.Stroke = false;
            this.settingsButtonAutomated.StrokeColor = System.Drawing.Color.Gray;
            this.settingsButtonAutomated.TabIndex = 7;
            this.settingsButtonAutomated.Text = "Automated search";
            this.settingsButtonAutomated.Transparency = false;
            this.settingsButtonAutomated.Click += new System.EventHandler(this.settingsButtonAutomated_Click);
            // 
            // settingButtonManual
            // 
            this.settingButtonManual.Active1 = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(68)))));
            this.settingButtonManual.Active2 = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(68)))));
            this.settingButtonManual.BackColor = System.Drawing.Color.Transparent;
            this.settingButtonManual.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.settingButtonManual.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.settingButtonManual.ForeColor = System.Drawing.Color.White;
            this.settingButtonManual.Inactive1 = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(72)))), ((int)(((byte)(33)))));
            this.settingButtonManual.Inactive2 = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(72)))), ((int)(((byte)(33)))));
            this.settingButtonManual.Location = new System.Drawing.Point(35, 109);
            this.settingButtonManual.Margin = new System.Windows.Forms.Padding(2);
            this.settingButtonManual.Name = "settingButtonManual";
            this.settingButtonManual.Radius = 10;
            this.settingButtonManual.Size = new System.Drawing.Size(108, 29);
            this.settingButtonManual.Stroke = false;
            this.settingButtonManual.StrokeColor = System.Drawing.Color.Gray;
            this.settingButtonManual.TabIndex = 6;
            this.settingButtonManual.Text = "Manual search";
            this.settingButtonManual.Transparency = false;
            this.settingButtonManual.Click += new System.EventHandler(this.settingButtonManual_Click);
            // 
            // labelSettingsHeader
            // 
            this.labelSettingsHeader.AutoSize = true;
            this.labelSettingsHeader.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelSettingsHeader.Location = new System.Drawing.Point(32, 28);
            this.labelSettingsHeader.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSettingsHeader.Name = "labelSettingsHeader";
            this.labelSettingsHeader.Size = new System.Drawing.Size(178, 19);
            this.labelSettingsHeader.TabIndex = 5;
            this.labelSettingsHeader.Text = "Among Us Game Settings";
            // 
            // labelSettingsBackup
            // 
            this.labelSettingsBackup.AutoSize = true;
            this.labelSettingsBackup.Location = new System.Drawing.Point(32, 165);
            this.labelSettingsBackup.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSettingsBackup.Name = "labelSettingsBackup";
            this.labelSettingsBackup.Size = new System.Drawing.Size(212, 15);
            this.labelSettingsBackup.TabIndex = 4;
            this.labelSettingsBackup.Text = "Should a copy of the game be created?";
            // 
            // settingsToggleBackup
            // 
            this.settingsToggleBackup.BorderColor = System.Drawing.Color.LightGray;
            this.settingsToggleBackup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.settingsToggleBackup.ForeColor = System.Drawing.Color.White;
            this.settingsToggleBackup.IsOn = false;
            this.settingsToggleBackup.Location = new System.Drawing.Point(32, 190);
            this.settingsToggleBackup.Margin = new System.Windows.Forms.Padding(2);
            this.settingsToggleBackup.Name = "settingsToggleBackup";
            this.settingsToggleBackup.OffColor = System.Drawing.Color.DarkGray;
            this.settingsToggleBackup.OffText = "";
            this.settingsToggleBackup.OnColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(72)))), ((int)(((byte)(33)))));
            this.settingsToggleBackup.OnText = "";
            this.settingsToggleBackup.Size = new System.Drawing.Size(34, 19);
            this.settingsToggleBackup.TabIndex = 3;
            this.settingsToggleBackup.Text = "customToggle1";
            this.settingsToggleBackup.TextEnabled = true;
            this.settingsToggleBackup.Click += new System.EventHandler(this.settingsToggleBackup_Click);
            // 
            // settingsGamePathTextBox
            // 
            this.settingsGamePathTextBox.BackColor = System.Drawing.Color.Transparent;
            this.settingsGamePathTextBox.Br = System.Drawing.Color.White;
            this.settingsGamePathTextBox.Enabled = false;
            this.settingsGamePathTextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.settingsGamePathTextBox.ForeColor = System.Drawing.Color.DimGray;
            this.settingsGamePathTextBox.Location = new System.Drawing.Point(32, 69);
            this.settingsGamePathTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.settingsGamePathTextBox.Name = "settingsGamePathTextBox";
            this.settingsGamePathTextBox.Size = new System.Drawing.Size(487, 30);
            this.settingsGamePathTextBox.TabIndex = 2;
            this.settingsGamePathTextBox.TextChanged += new System.EventHandler(this.settingsGamePathTextBox_TextChanged);
            // 
            // labelSettingsPath
            // 
            this.labelSettingsPath.AutoSize = true;
            this.labelSettingsPath.Location = new System.Drawing.Point(32, 52);
            this.labelSettingsPath.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSettingsPath.Name = "labelSettingsPath";
            this.labelSettingsPath.Size = new System.Drawing.Size(305, 15);
            this.labelSettingsPath.TabIndex = 1;
            this.labelSettingsPath.Text = "Please specify the folder where Among Us.exe is located.";
            // 
            // panelHelp
            // 
            this.panelHelp.Controls.Add(this.labelCopyright);
            this.panelHelp.Controls.Add(this.labelCopyrightHeader);
            this.panelHelp.Controls.Add(this.linkLabelResourcesGit);
            this.panelHelp.Controls.Add(this.labelResourcesGit);
            this.panelHelp.Controls.Add(this.labelResourcesHeader);
            this.panelHelp.Controls.Add(this.labelVersionHeader);
            this.panelHelp.Controls.Add(this.labelVersion);
            this.panelHelp.Location = new System.Drawing.Point(172, 60);
            this.panelHelp.Name = "panelHelp";
            this.panelHelp.Size = new System.Drawing.Size(528, 372);
            this.panelHelp.TabIndex = 10;
            this.panelHelp.Visible = false;
            this.panelHelp.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelMenu_MouseDown);
            this.panelHelp.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelMenu_MouseMove);
            // 
            // labelCopyright
            // 
            this.labelCopyright.AutoSize = true;
            this.labelCopyright.ForeColor = System.Drawing.Color.Silver;
            this.labelCopyright.Location = new System.Drawing.Point(32, 150);
            this.labelCopyright.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCopyright.Name = "labelCopyright";
            this.labelCopyright.Size = new System.Drawing.Size(78, 15);
            this.labelCopyright.TabIndex = 6;
            this.labelCopyright.Text = "Jolle && Narua";
            // 
            // labelCopyrightHeader
            // 
            this.labelCopyrightHeader.AutoSize = true;
            this.labelCopyrightHeader.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelCopyrightHeader.Location = new System.Drawing.Point(32, 133);
            this.labelCopyrightHeader.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCopyrightHeader.Name = "labelCopyrightHeader";
            this.labelCopyrightHeader.Size = new System.Drawing.Size(76, 19);
            this.labelCopyrightHeader.TabIndex = 5;
            this.labelCopyrightHeader.Text = "Copyright";
            // 
            // linkLabelResourcesGit
            // 
            this.linkLabelResourcesGit.AutoSize = true;
            this.linkLabelResourcesGit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.linkLabelResourcesGit.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkLabelResourcesGit.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(255)))));
            this.linkLabelResourcesGit.Location = new System.Drawing.Point(84, 92);
            this.linkLabelResourcesGit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkLabelResourcesGit.Name = "linkLabelResourcesGit";
            this.linkLabelResourcesGit.Size = new System.Drawing.Size(295, 15);
            this.linkLabelResourcesGit.TabIndex = 4;
            this.linkLabelResourcesGit.TabStop = true;
            this.linkLabelResourcesGit.Text = "https://github.com/Narua2010/AmongUsModUpdater";
            this.linkLabelResourcesGit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelResourcesGit_LinkClicked);
            this.linkLabelResourcesGit.MouseEnter += new System.EventHandler(this.linkLabelResourcesGit_MouseEnter);
            this.linkLabelResourcesGit.MouseLeave += new System.EventHandler(this.linkLabelResourcesGit_MouseLeave);
            // 
            // labelResourcesGit
            // 
            this.labelResourcesGit.AutoSize = true;
            this.labelResourcesGit.ForeColor = System.Drawing.Color.Silver;
            this.labelResourcesGit.Location = new System.Drawing.Point(32, 92);
            this.labelResourcesGit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelResourcesGit.Name = "labelResourcesGit";
            this.labelResourcesGit.Size = new System.Drawing.Size(46, 15);
            this.labelResourcesGit.TabIndex = 3;
            this.labelResourcesGit.Text = "Github:";
            // 
            // labelResourcesHeader
            // 
            this.labelResourcesHeader.AutoSize = true;
            this.labelResourcesHeader.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelResourcesHeader.Location = new System.Drawing.Point(32, 75);
            this.labelResourcesHeader.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelResourcesHeader.Name = "labelResourcesHeader";
            this.labelResourcesHeader.Size = new System.Drawing.Size(76, 19);
            this.labelResourcesHeader.TabIndex = 2;
            this.labelResourcesHeader.Text = "Resources";
            // 
            // labelVersionHeader
            // 
            this.labelVersionHeader.AutoSize = true;
            this.labelVersionHeader.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelVersionHeader.Location = new System.Drawing.Point(32, 20);
            this.labelVersionHeader.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelVersionHeader.Name = "labelVersionHeader";
            this.labelVersionHeader.Size = new System.Drawing.Size(141, 19);
            this.labelVersionHeader.TabIndex = 1;
            this.labelVersionHeader.Text = "Version Information";
            // 
            // labelVersion
            // 
            this.labelVersion.AutoSize = true;
            this.labelVersion.ForeColor = System.Drawing.Color.Silver;
            this.labelVersion.Location = new System.Drawing.Point(32, 37);
            this.labelVersion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size(216, 15);
            this.labelVersion.TabIndex = 0;
            this.labelVersion.Text = "Among Us Mod Updater Version: 0.0.0.0";
            // 
            // panelMenu
            // 
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Controls.Add(this.settingsButton);
            this.panelMenu.Controls.Add(this.homeButton);
            this.panelMenu.Controls.Add(this.helpButton);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(2);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(158, 332);
            this.panelMenu.TabIndex = 9;
            this.panelMenu.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelMenu_MouseDown);
            this.panelMenu.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelMenu_MouseMove);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(72)))), ((int)(((byte)(33)))));
            this.panelLogo.Controls.Add(this.Logo);
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Margin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(158, 60);
            this.panelLogo.TabIndex = 0;
            this.panelLogo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelMenu_MouseDown);
            this.panelLogo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelMenu_MouseMove);
            // 
            // Logo
            // 
            this.Logo.Image = ((System.Drawing.Image)(resources.GetObject("Logo.Image")));
            this.Logo.Location = new System.Drawing.Point(47, 0);
            this.Logo.Margin = new System.Windows.Forms.Padding(2);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(68, 60);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Logo.TabIndex = 0;
            this.Logo.TabStop = false;
            this.Logo.Click += new System.EventHandler(this.logo_Click);
            this.Logo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelMenu_MouseDown);
            this.Logo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelMenu_MouseMove);
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.newVersionButton);
            this.panelTop.Controls.Add(this.buttonExit);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(158, 0);
            this.panelTop.Margin = new System.Windows.Forms.Padding(2);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(542, 60);
            this.panelTop.TabIndex = 10;
            this.panelTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelMenu_MouseDown);
            this.panelTop.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelMenu_MouseMove);
            // 
            // newVersionButton
            // 
            this.newVersionButton.Active1 = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(68)))));
            this.newVersionButton.Active2 = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(68)))));
            this.newVersionButton.BackColor = System.Drawing.Color.Transparent;
            this.newVersionButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.newVersionButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.newVersionButton.ForeColor = System.Drawing.Color.White;
            this.newVersionButton.Inactive1 = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(72)))), ((int)(((byte)(33)))));
            this.newVersionButton.Inactive2 = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(72)))), ((int)(((byte)(33)))));
            this.newVersionButton.Location = new System.Drawing.Point(361, 7);
            this.newVersionButton.Name = "newVersionButton";
            this.newVersionButton.Radius = 10;
            this.newVersionButton.Size = new System.Drawing.Size(144, 23);
            this.newVersionButton.Stroke = false;
            this.newVersionButton.StrokeColor = System.Drawing.Color.Gray;
            this.newVersionButton.TabIndex = 11;
            this.newVersionButton.Text = "New Updater Version";
            this.newVersionButton.Transparency = false;
            this.newVersionButton.Click += new System.EventHandler(this.newVersionButton_Click);
            this.newVersionButton.Enter += new System.EventHandler(this.newVersionButton_MouseHover);
            this.newVersionButton.Leave += new System.EventHandler(this.newVersionButton_MouseLeave);
            // 
            // buttonExit
            // 
            this.buttonExit.FlatAppearance.BorderSize = 0;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.ForeColor = System.Drawing.Color.Silver;
            this.buttonExit.Location = new System.Drawing.Point(507, 7);
            this.buttonExit.Margin = new System.Windows.Forms.Padding(2);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(28, 24);
            this.buttonExit.TabIndex = 10;
            this.buttonExit.Text = "X";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // panelMenuActive
            // 
            this.panelMenuActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(72)))), ((int)(((byte)(33)))));
            this.panelMenuActive.Location = new System.Drawing.Point(158, 60);
            this.panelMenuActive.Margin = new System.Windows.Forms.Padding(2);
            this.panelMenuActive.Name = "panelMenuActive";
            this.panelMenuActive.Size = new System.Drawing.Size(7, 75);
            this.panelMenuActive.TabIndex = 11;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(700, 332);
            this.Controls.Add(this.panelMenuActive);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panelHome);
            this.Controls.Add(this.panelHelp);
            this.Controls.Add(this.panelSettings);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Silver;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Among Us Mod Updater";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelMenu_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelMenu_MouseMove);
            this.panelHome.ResumeLayout(false);
            this.panelHome.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.otherRolesBanner)).EndInit();
            this.panelSettings.ResumeLayout(false);
            this.panelSettings.PerformLayout();
            this.panelHelp.ResumeLayout(false);
            this.panelHelp.PerformLayout();
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.panelTop.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.Button homeButton;
        public System.Windows.Forms.Button settingsButton;
        public System.Windows.Forms.Button helpButton;
        public System.Windows.Forms.Panel panelHome;
        public System.Windows.Forms.Panel panelSettings;
        public System.Windows.Forms.Panel panelHelp;
        public System.Windows.Forms.ProgressBar downloadProgress;
        public System.Windows.Forms.Panel panelMenu;
        public System.Windows.Forms.Panel panelLogo;
        public System.Windows.Forms.Panel panelTop;
        public System.Windows.Forms.PictureBox Logo;
        public System.Windows.Forms.Panel panelMenuActive;
        public System.Windows.Forms.Button buttonExit;
        public System.Windows.Forms.Label labelVersion;
        public System.Windows.Forms.Label labelVersionHeader;
        public System.Windows.Forms.LinkLabel linkLabelResourcesGit;
        public System.Windows.Forms.Label labelResourcesGit;
        public System.Windows.Forms.Label labelResourcesHeader;
        public System.Windows.Forms.Label labelCopyright;
        public System.Windows.Forms.Label labelCopyrightHeader;
        public System.Windows.Forms.Label labelSettingsPath;
        public CustomTextBox.CustomTextBox settingsGamePathTextBox;
        public CustomToggle.CustomToggle settingsToggleBackup;
        public System.Windows.Forms.Label labelSettingsBackup;
        public System.Windows.Forms.Label labelSettingsHeader;
        public CustomButton.CustomButton settingButtonManual;
        public CustomButton.CustomButton settingsButtonAutomated;
        public System.Windows.Forms.FolderBrowserDialog manualLocationFolderDialog;
        public CustomButton.CustomButton buttonHomeStart;
        public CustomButton.CustomButton buttonHomeUpdate;
        public System.Windows.Forms.PictureBox otherRolesBanner;
        public System.Windows.Forms.Label labelProcessedDrives;
        public System.Windows.Forms.ProgressBar progressBarSearch;
        public System.Windows.Forms.Button buttonWorkerCancel;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label waitingInfoForStart;
        public CustomButton.CustomButton buttonHomeInstall;
        public CustomButton.CustomButton newVersionButton;
        public CustomButton.CustomButton settingsOpenFolder;
        public CustomButton.CustomButton settingsButtonQuickSearch;
    }
}

