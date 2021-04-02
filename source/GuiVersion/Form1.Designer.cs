
namespace AmongUsModUpdater
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonStart = new System.Windows.Forms.Button();
            this.downloadProgress = new System.Windows.Forms.ProgressBar();
            this.homeButton = new System.Windows.Forms.Button();
            this.configButton = new System.Windows.Forms.Button();
            this.helpButton = new System.Windows.Forms.Button();
            this.panelHome = new System.Windows.Forms.Panel();
            this.panelHelp = new System.Windows.Forms.Panel();
            this.panelConfig = new System.Windows.Forms.Panel();
            this.panelHome.SuspendLayout();
            this.panelHelp.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(274, 248);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(193, 108);
            this.buttonStart.TabIndex = 1;
            this.buttonStart.Text = "Start/Update";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // downloadProgress
            // 
            this.downloadProgress.Location = new System.Drawing.Point(94, 123);
            this.downloadProgress.Margin = new System.Windows.Forms.Padding(14, 17, 14, 17);
            this.downloadProgress.Name = "downloadProgress";
            this.downloadProgress.Size = new System.Drawing.Size(569, 38);
            this.downloadProgress.TabIndex = 4;
            // 
            // homeButton
            // 
            this.homeButton.Location = new System.Drawing.Point(17, 20);
            this.homeButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(179, 125);
            this.homeButton.TabIndex = 5;
            this.homeButton.Text = "Home";
            this.homeButton.UseVisualStyleBackColor = true;
            this.homeButton.Click += new System.EventHandler(this.homeButton_Click);
            // 
            // configButton
            // 
            this.configButton.Location = new System.Drawing.Point(17, 155);
            this.configButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.configButton.Name = "configButton";
            this.configButton.Size = new System.Drawing.Size(179, 125);
            this.configButton.TabIndex = 6;
            this.configButton.Text = "Config";
            this.configButton.UseVisualStyleBackColor = true;
            this.configButton.Click += new System.EventHandler(this.configButton_Click);
            // 
            // helpButton
            // 
            this.helpButton.Location = new System.Drawing.Point(17, 290);
            this.helpButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.helpButton.Name = "helpButton";
            this.helpButton.Size = new System.Drawing.Size(179, 125);
            this.helpButton.TabIndex = 7;
            this.helpButton.Text = "Help";
            this.helpButton.UseVisualStyleBackColor = true;
            this.helpButton.Click += new System.EventHandler(this.helpButton_Click);
            // 
            // panelHome
            // 
            this.panelHome.Controls.Add(this.downloadProgress);
            this.panelHome.Controls.Add(this.buttonStart);
            this.panelHome.Location = new System.Drawing.Point(204, 20);
            this.panelHome.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelHome.Name = "panelHome";
            this.panelHome.Size = new System.Drawing.Size(784, 695);
            this.panelHome.TabIndex = 8;
            this.panelHome.Visible = false;
            // 
            // panelHelp
            // 
            this.panelHelp.Controls.Add(this.panelConfig);
            this.panelHelp.Location = new System.Drawing.Point(204, 20);
            this.panelHelp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelHelp.Name = "panelHelp";
            this.panelHelp.Size = new System.Drawing.Size(784, 695);
            this.panelHelp.TabIndex = 10;
            this.panelHelp.Visible = false;
            // 
            // panelConfig
            // 
            this.panelConfig.Location = new System.Drawing.Point(209, 20);
            this.panelConfig.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelConfig.Name = "panelConfig";
            this.panelConfig.Size = new System.Drawing.Size(784, 695);
            this.panelConfig.TabIndex = 9;
            this.panelConfig.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1006, 735);
            this.Controls.Add(this.panelHome);
            this.Controls.Add(this.panelHelp);
            this.Controls.Add(this.helpButton);
            this.Controls.Add(this.configButton);
            this.Controls.Add(this.homeButton);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Among Us Mod Updater";
            this.panelHome.ResumeLayout(false);
            this.panelHelp.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.ProgressBar downloadProgress;
        private System.Windows.Forms.Button homeButton;
        private System.Windows.Forms.Button configButton;
        private System.Windows.Forms.Button helpButton;
        private System.Windows.Forms.Panel panelHome;
        private System.Windows.Forms.Panel panelConfig;
        private System.Windows.Forms.Panel panelHelp;
    }
}

