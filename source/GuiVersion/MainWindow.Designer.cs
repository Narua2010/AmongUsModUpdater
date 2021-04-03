
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
            this.otherRolesBanner = new System.Windows.Forms.PictureBox();
            this.buttonHomeStart = new CustomButton.CustomButton();
            this.buttoneHomeUpdate = new CustomButton.CustomButton();
            this.downloadProgress = new System.Windows.Forms.ProgressBar();
            this.panelSettings = new System.Windows.Forms.Panel();
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
            this.homeButton.Location = new System.Drawing.Point(0, 100);
            this.homeButton.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(225, 125);
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
            this.settingsButton.Location = new System.Drawing.Point(0, 225);
            this.settingsButton.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(225, 125);
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
            this.helpButton.Location = new System.Drawing.Point(0, 350);
            this.helpButton.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.helpButton.Name = "helpButton";
            this.helpButton.Size = new System.Drawing.Size(225, 125);
            this.helpButton.TabIndex = 7;
            this.helpButton.Text = "Help";
            this.helpButton.UseVisualStyleBackColor = true;
            this.helpButton.Click += new System.EventHandler(this.helpButton_Click);
            // 
            // panelHome
            // 
            this.panelHome.Controls.Add(this.otherRolesBanner);
            this.panelHome.Controls.Add(this.buttonHomeStart);
            this.panelHome.Controls.Add(this.buttoneHomeUpdate);
            this.panelHome.Controls.Add(this.downloadProgress);
            this.panelHome.Location = new System.Drawing.Point(245, 100);
            this.panelHome.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelHome.Name = "panelHome";
            this.panelHome.Size = new System.Drawing.Size(755, 620);
            this.panelHome.TabIndex = 8;
            this.panelHome.Visible = false;
            // 
            // otherRolesBanner
            // 
            this.otherRolesBanner.Image = ((System.Drawing.Image)(resources.GetObject("otherRolesBanner.Image")));
            this.otherRolesBanner.Location = new System.Drawing.Point(45, 0);
            this.otherRolesBanner.Name = "otherRolesBanner";
            this.otherRolesBanner.Size = new System.Drawing.Size(672, 128);
            this.otherRolesBanner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.otherRolesBanner.TabIndex = 7;
            this.otherRolesBanner.TabStop = false;
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
            this.buttonHomeStart.Location = new System.Drawing.Point(252, 171);
            this.buttonHomeStart.Name = "buttonHomeStart";
            this.buttonHomeStart.Radius = 10;
            this.buttonHomeStart.Size = new System.Drawing.Size(252, 119);
            this.buttonHomeStart.Stroke = false;
            this.buttonHomeStart.StrokeColor = System.Drawing.Color.Gray;
            this.buttonHomeStart.TabIndex = 6;
            this.buttonHomeStart.Text = "Start";
            this.buttonHomeStart.Transparency = false;
            this.buttonHomeStart.Visible = false;
            this.buttonHomeStart.Click += new System.EventHandler(this.buttonHomeStart_Click);
            // 
            // buttoneHomeUpdate
            // 
            this.buttoneHomeUpdate.Active1 = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(68)))));
            this.buttoneHomeUpdate.Active2 = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(68)))));
            this.buttoneHomeUpdate.BackColor = System.Drawing.Color.Transparent;
            this.buttoneHomeUpdate.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttoneHomeUpdate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttoneHomeUpdate.ForeColor = System.Drawing.Color.White;
            this.buttoneHomeUpdate.Inactive1 = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(72)))), ((int)(((byte)(33)))));
            this.buttoneHomeUpdate.Inactive2 = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(72)))), ((int)(((byte)(33)))));
            this.buttoneHomeUpdate.Location = new System.Drawing.Point(252, 170);
            this.buttoneHomeUpdate.Name = "buttoneHomeUpdate";
            this.buttoneHomeUpdate.Radius = 10;
            this.buttoneHomeUpdate.Size = new System.Drawing.Size(252, 120);
            this.buttoneHomeUpdate.Stroke = false;
            this.buttoneHomeUpdate.StrokeColor = System.Drawing.Color.Gray;
            this.buttoneHomeUpdate.TabIndex = 5;
            this.buttoneHomeUpdate.Text = "Update";
            this.buttoneHomeUpdate.Transparency = false;
            this.buttoneHomeUpdate.Visible = false;
            this.buttoneHomeUpdate.Click += new System.EventHandler(this.buttoneHomeUpdate_Click);
            // 
            // downloadProgress
            // 
            this.downloadProgress.Location = new System.Drawing.Point(98, 317);
            this.downloadProgress.Margin = new System.Windows.Forms.Padding(14, 17, 14, 17);
            this.downloadProgress.Name = "downloadProgress";
            this.downloadProgress.Size = new System.Drawing.Size(569, 38);
            this.downloadProgress.TabIndex = 4;
            this.downloadProgress.Visible = false;
            // 
            // panelSettings
            // 
            this.panelSettings.Controls.Add(this.settingsButtonAutomated);
            this.panelSettings.Controls.Add(this.settingButtonManual);
            this.panelSettings.Controls.Add(this.labelSettingsHeader);
            this.panelSettings.Controls.Add(this.labelSettingsBackup);
            this.panelSettings.Controls.Add(this.settingsToggleBackup);
            this.panelSettings.Controls.Add(this.settingsGamePathTextBox);
            this.panelSettings.Controls.Add(this.labelSettingsPath);
            this.panelSettings.Location = new System.Drawing.Point(245, 100);
            this.panelSettings.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelSettings.Name = "panelSettings";
            this.panelSettings.Size = new System.Drawing.Size(755, 620);
            this.panelSettings.TabIndex = 9;
            this.panelSettings.Visible = false;
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
            this.settingsButtonAutomated.Location = new System.Drawing.Point(306, 181);
            this.settingsButtonAutomated.Name = "settingsButtonAutomated";
            this.settingsButtonAutomated.Radius = 10;
            this.settingsButtonAutomated.Size = new System.Drawing.Size(198, 49);
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
            this.settingButtonManual.Location = new System.Drawing.Point(48, 181);
            this.settingButtonManual.Name = "settingButtonManual";
            this.settingButtonManual.Radius = 10;
            this.settingButtonManual.Size = new System.Drawing.Size(198, 49);
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
            this.labelSettingsHeader.Location = new System.Drawing.Point(45, 47);
            this.labelSettingsHeader.Name = "labelSettingsHeader";
            this.labelSettingsHeader.Size = new System.Drawing.Size(252, 28);
            this.labelSettingsHeader.TabIndex = 5;
            this.labelSettingsHeader.Text = "Among Us Game Settings";
            // 
            // labelSettingsBackup
            // 
            this.labelSettingsBackup.AutoSize = true;
            this.labelSettingsBackup.Location = new System.Drawing.Point(45, 275);
            this.labelSettingsBackup.Name = "labelSettingsBackup";
            this.labelSettingsBackup.Size = new System.Drawing.Size(324, 25);
            this.labelSettingsBackup.TabIndex = 4;
            this.labelSettingsBackup.Text = "Should a copy of the game be created?";
            // 
            // settingsToggleBackup
            // 
            this.settingsToggleBackup.BorderColor = System.Drawing.Color.LightGray;
            this.settingsToggleBackup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.settingsToggleBackup.ForeColor = System.Drawing.Color.White;
            this.settingsToggleBackup.IsOn = false;
            this.settingsToggleBackup.Location = new System.Drawing.Point(45, 317);
            this.settingsToggleBackup.Name = "settingsToggleBackup";
            this.settingsToggleBackup.OffColor = System.Drawing.Color.DarkGray;
            this.settingsToggleBackup.OffText = "";
            this.settingsToggleBackup.OnColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(72)))), ((int)(((byte)(33)))));
            this.settingsToggleBackup.OnText = "";
            this.settingsToggleBackup.Size = new System.Drawing.Size(58, 31);
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
            this.settingsGamePathTextBox.Location = new System.Drawing.Point(45, 115);
            this.settingsGamePathTextBox.Name = "settingsGamePathTextBox";
            this.settingsGamePathTextBox.Size = new System.Drawing.Size(459, 50);
            this.settingsGamePathTextBox.TabIndex = 2;
            this.settingsGamePathTextBox.TextChanged += new System.EventHandler(this.settingsGamePathTextBox_TextChanged);
            // 
            // labelSettingsPath
            // 
            this.labelSettingsPath.AutoSize = true;
            this.labelSettingsPath.Location = new System.Drawing.Point(45, 87);
            this.labelSettingsPath.Name = "labelSettingsPath";
            this.labelSettingsPath.Size = new System.Drawing.Size(459, 25);
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
            this.panelHelp.Location = new System.Drawing.Point(245, 100);
            this.panelHelp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelHelp.Name = "panelHelp";
            this.panelHelp.Size = new System.Drawing.Size(755, 620);
            this.panelHelp.TabIndex = 10;
            this.panelHelp.Visible = false;
            // 
            // labelCopyright
            // 
            this.labelCopyright.AutoSize = true;
            this.labelCopyright.ForeColor = System.Drawing.Color.Silver;
            this.labelCopyright.Location = new System.Drawing.Point(45, 250);
            this.labelCopyright.Name = "labelCopyright";
            this.labelCopyright.Size = new System.Drawing.Size(117, 25);
            this.labelCopyright.TabIndex = 6;
            this.labelCopyright.Text = "Jolle && Narua";
            // 
            // labelCopyrightHeader
            // 
            this.labelCopyrightHeader.AutoSize = true;
            this.labelCopyrightHeader.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelCopyrightHeader.Location = new System.Drawing.Point(45, 222);
            this.labelCopyrightHeader.Name = "labelCopyrightHeader";
            this.labelCopyrightHeader.Size = new System.Drawing.Size(105, 28);
            this.labelCopyrightHeader.TabIndex = 5;
            this.labelCopyrightHeader.Text = "Copyright";
            // 
            // linkLabelResourcesGit
            // 
            this.linkLabelResourcesGit.AutoSize = true;
            this.linkLabelResourcesGit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.linkLabelResourcesGit.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkLabelResourcesGit.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(255)))));
            this.linkLabelResourcesGit.Location = new System.Drawing.Point(120, 153);
            this.linkLabelResourcesGit.Name = "linkLabelResourcesGit";
            this.linkLabelResourcesGit.Size = new System.Drawing.Size(445, 25);
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
            this.labelResourcesGit.Location = new System.Drawing.Point(45, 153);
            this.labelResourcesGit.Name = "labelResourcesGit";
            this.labelResourcesGit.Size = new System.Drawing.Size(69, 25);
            this.labelResourcesGit.TabIndex = 3;
            this.labelResourcesGit.Text = "Github:";
            // 
            // labelResourcesHeader
            // 
            this.labelResourcesHeader.AutoSize = true;
            this.labelResourcesHeader.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelResourcesHeader.Location = new System.Drawing.Point(45, 125);
            this.labelResourcesHeader.Name = "labelResourcesHeader";
            this.labelResourcesHeader.Size = new System.Drawing.Size(107, 28);
            this.labelResourcesHeader.TabIndex = 2;
            this.labelResourcesHeader.Text = "Resources";
            // 
            // labelVersionHeader
            // 
            this.labelVersionHeader.AutoSize = true;
            this.labelVersionHeader.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelVersionHeader.Location = new System.Drawing.Point(45, 34);
            this.labelVersionHeader.Name = "labelVersionHeader";
            this.labelVersionHeader.Size = new System.Drawing.Size(201, 28);
            this.labelVersionHeader.TabIndex = 1;
            this.labelVersionHeader.Text = "Version Information";
            // 
            // labelVersion
            // 
            this.labelVersion.AutoSize = true;
            this.labelVersion.ForeColor = System.Drawing.Color.Silver;
            this.labelVersion.Location = new System.Drawing.Point(45, 62);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size(333, 25);
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
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(225, 553);
            this.panelMenu.TabIndex = 9;
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(72)))), ((int)(((byte)(33)))));
            this.panelLogo.Controls.Add(this.Logo);
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(225, 100);
            this.panelLogo.TabIndex = 0;
            // 
            // Logo
            // 
            this.Logo.Image = ((System.Drawing.Image)(resources.GetObject("Logo.Image")));
            this.Logo.Location = new System.Drawing.Point(67, 0);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(97, 100);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Logo.TabIndex = 0;
            this.Logo.TabStop = false;
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.buttonExit);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(225, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(775, 100);
            this.panelTop.TabIndex = 10;
            // 
            // buttonExit
            // 
            this.buttonExit.FlatAppearance.BorderSize = 0;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.ForeColor = System.Drawing.Color.Silver;
            this.buttonExit.Location = new System.Drawing.Point(724, 12);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(39, 39);
            this.buttonExit.TabIndex = 10;
            this.buttonExit.Text = "X";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // panelMenuActive
            // 
            this.panelMenuActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(72)))), ((int)(((byte)(33)))));
            this.panelMenuActive.Location = new System.Drawing.Point(226, 100);
            this.panelMenuActive.Name = "panelMenuActive";
            this.panelMenuActive.Size = new System.Drawing.Size(10, 125);
            this.panelMenuActive.TabIndex = 11;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1000, 553);
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
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Among Us Mod Updater";
            this.panelHome.ResumeLayout(false);
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
        private System.Windows.Forms.Button homeButton;
        private System.Windows.Forms.Button settingsButton;
        private System.Windows.Forms.Button helpButton;
        private System.Windows.Forms.Panel panelHome;
        private System.Windows.Forms.Panel panelSettings;
        private System.Windows.Forms.Panel panelHelp;
        private System.Windows.Forms.ProgressBar downloadProgress;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Panel panelMenuActive;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label labelVersion;
        private System.Windows.Forms.Label labelVersionHeader;
        private System.Windows.Forms.LinkLabel linkLabelResourcesGit;
        private System.Windows.Forms.Label labelResourcesGit;
        private System.Windows.Forms.Label labelResourcesHeader;
        private System.Windows.Forms.Label labelCopyright;
        private System.Windows.Forms.Label labelCopyrightHeader;
        private System.Windows.Forms.Label labelSettingsPath;
        private CustomTextBox.CustomTextBox settingsGamePathTextBox;
        private CustomToggle.CustomToggle settingsToggleBackup;
        private System.Windows.Forms.Label labelSettingsBackup;
        private System.Windows.Forms.Label labelSettingsHeader;
        private CustomButton.CustomButton settingButtonManual;
        private CustomButton.CustomButton settingsButtonAutomated;
        private System.Windows.Forms.FolderBrowserDialog manualLocationFolderDialog;
        private CustomButton.CustomButton buttonHomeStart;
        private CustomButton.CustomButton buttoneHomeUpdate;
        private System.Windows.Forms.PictureBox otherRolesBanner;
    }
}

