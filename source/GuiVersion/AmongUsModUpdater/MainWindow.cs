using Newtonsoft.Json;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using WinForms.Logger;
using AmongUsModUpdater.UpdaterFunctions;
using AmongUsModUpdater.AmongUsModUpdater;
using AmongUsModUpdater.TheOtherRoles;

namespace AmongUsModUpdater
{
    public partial class MainWindow : Form
    {
        private static string projectUrl = "https://github.com/Narua2010/AmongUsModUpdater";
        private Panel[] menuPanels;
        private Button[] menuButtons;

        private string selectedMod;

        static string newVersionUrl;
        private Point lastPointTmp = new Point(0, 0);
        private Point lastPoint = new Point(0, 0);

        public ProgressBar ProgressBarSearch
        {
            get { return progressBarSearch; }
        }
        public Label LabelProcessedDrives
        {
            get { return labelProcessedDrives; }
        }
        public Button ButtonWorkerCancel
        {
            get { return buttonWorkerCancel; }
        }
        public CustomButton.CustomButton SettingsButtonAutomated
        {
            get { return settingsButtonAutomated; }
        }
        public CustomTextBox.CustomTextBox SettingsGamePathTextBox
        {
            get { return settingsGamePathTextBox; }
        }

        public MainWindow()
        {
            InitializeComponent();
            initializeMainWindow();
        }

        private async void initializeMainWindow()
        {

            Logger.Log("Init", null);

            //Demo
            selectedMod = "The Other Roles";

            menuPanels = new[] { panelHome, panelSettings, panelHelp };
            menuButtons = new[] { homeButton, settingsButton, helpButton };

            labelVersion.Text = "Among Us Mod Updater Version: " + Application.ProductVersion;
            settingsGamePathTextBox.Text = Properties.Settings.Default.GamePath;

            newVersionUrl = await AmongUsModUpdater.AmongUsModUpdater.checkVersionsUpdate(this);

            if (Properties.Settings.Default.Backup == true)
            {
                settingsToggleBackup.IsOn = true;
            }
            else
            {
                settingsToggleBackup.IsOn = false;
            }

            panelHome.Visible = true;
            TheOtherRoles.TheOtherRoles.getTheOtherRoles(this);
        }

        //Menü
        private void homeButton_Click(object sender, EventArgs e)
        {
            SystemFunctions.switchPanelVisibility(0, menuPanels, menuButtons, panelMenuActive);
        }
        private void settingsButton_Click(object sender, EventArgs e)
        {
            SystemFunctions.switchPanelVisibility(1, menuPanels, menuButtons, panelMenuActive);
        }
        private void helpButton_Click(object sender, EventArgs e)
        {
            SystemFunctions.switchPanelVisibility(2, menuPanels, menuButtons, panelMenuActive);
        }

        //Topbar
        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void newVersionButton_Click(object sender, EventArgs e)
        {
            SystemFunctions.openLinkInBrowser(newVersionUrl);
            Application.Exit();
        }
        private void newVersionButton_MouseHover(object sender, EventArgs e)
        {
            newVersionButton.BackColor = Color.FromArgb(49, 52, 61);
        }

        private void newVersionButton_MouseLeave(object sender, EventArgs e)
        {
            newVersionButton.BackColor = Color.FromArgb(41, 44, 51);
        }
        private void logo_Click(object sender, EventArgs e)
        {
            SystemFunctions.openLinkInBrowser(projectUrl);
        }

        //Change WindowPosition
        private void panelMenu_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }
        private void panelMenu_MouseDown(object sender, MouseEventArgs e)
        {
            lastPointTmp = new Point(this.Left, this.Top);
            lastPoint = new Point(e.X, e.Y);
        }

        //Mod Actions
        private void buttonHomeInstall_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(Properties.Settings.Default.GamePath))
            {
                if (Properties.Settings.Default.Backup)
                {
                    ModFunctions.generateBackup(Properties.Settings.Default.GamePath);
                }
                switch (selectedMod)
                {
                    case "The Other Roles":
                        TheOtherRoles.TheOtherRoles.installTheOtherRoles(this, Properties.Settings.Default.GamePath);
                        break;
                }
            }
            else
            {
                DialogResult response = MessageBoxFunctions.openMessageBoxWithResponse("No play path was given. Please enter it under the settings. Would you like to be redirected to the settings?", "Error");

                if (response == DialogResult.Yes)
                {
                    settingsButton.PerformClick();
                }
            }
        }
        private void buttonHomeStart_Click(object sender, EventArgs e)
        {
            switch (selectedMod)
            {
                case "The Other Roles":
                    TheOtherRoles.TheOtherRoles.startTheOtherRoles(this);
                    break;
                default:
                    ModFunctions.startGame(Properties.Settings.Default.GamePath, true, this);
                    break;
            }
        }
        private void buttoneHomeUpdate_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(Properties.Settings.Default.GamePath))
            {
                if (Properties.Settings.Default.Backup)
                {
                    ModFunctions.generateBackup(Properties.Settings.Default.GamePath);
                }
                switch (selectedMod)
                {
                    case "The Other Roles":
                        TheOtherRoles.TheOtherRoles.updateTheOtherRoles(this);
                        break;
                }
            }
            else
            {
                DialogResult response = MessageBoxFunctions.openMessageBoxWithResponse("No play path was given. Please enter it under the settings. Would you like to be redirected to the settings?", "Error");

                if (response == DialogResult.Yes)
                {
                    settingsButton.PerformClick();
                }
            }

        }
        
        //Settings Actions
        private void panelMenu_MouseUp(object sender, MouseEventArgs e)
        {
            if (new Point(this.Left, this.Top) == lastPointTmp || lastPointTmp == new Point(0, 0))
            {
                string url = "";
                switch (selectedMod)
                {
                    case "The Other Roles":
                        url = TheOtherRoles.TheOtherRoles.projectUrl;
                        break;
                }

                if (!string.IsNullOrWhiteSpace(url)) SystemFunctions.openLinkInBrowser(url);
            }
        }
        private void settingButtonManual_Click(object sender, EventArgs e)
        {
            DialogResult result = manualLocationFolderDialog.ShowDialog();

            if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(manualLocationFolderDialog.SelectedPath))
            {
                if (File.Exists(manualLocationFolderDialog.SelectedPath + "\\Among Us.exe"))
                {
                    settingsGamePathTextBox.Text = manualLocationFolderDialog.SelectedPath;
                }
                else
                {
                    string message = "The Among Us.exe could not be found in the selected folder. Please select the correct path where it is located.";
                    string caption = "Error";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    DialogResult response = MessageBox.Show(message, caption, buttons);

                    if (response == DialogResult.OK)
                    {
                        settingButtonManual.PerformClick();
                    }
                }
            }
        }
        private void settingsButtonAutomated_Click(object sender, EventArgs e)
        {
            DialogResult response = MessageBoxFunctions.openMessageBoxWithResponse("The automatic search can take longer and cause problems with slow systems. Especially if you have more than two hard drives. If you continue your system might slow down.", "Attention");

            if (response == DialogResult.Yes)
            {
                SystemFunctions.startAutomatedSearch(this);
            }
        }
        private void cancelAsyncButton_Click(System.Object sender, System.EventArgs e)
        {
            SystemFunctions.cancelAutomatedSearch();

            this.buttonWorkerCancel.Enabled = false;
        }
        private void settingsGamePathTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(settingsGamePathTextBox.Text))
            {
                Properties.Settings.Default.GamePath = settingsGamePathTextBox.Text;
                Properties.Settings.Default.Save();
            }
        }
        private void settingsToggleBackup_Click(object sender, EventArgs e)
        {
            if (settingsToggleBackup.IsOn == true)
            {
                Properties.Settings.Default.Backup = true;
            }
            else
            {
                Properties.Settings.Default.Backup = false;
            }
            Properties.Settings.Default.Save();
        }

        //Help Actions
        private void linkLabelResourcesGit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SystemFunctions.openLinkInBrowser(projectUrl);
        }
        private void linkLabelResourcesGit_MouseEnter(object sender, EventArgs e)
        {
            linkLabelResourcesGit.LinkColor = Color.Red;
        }
        private void linkLabelResourcesGit_MouseLeave(object sender, EventArgs e)
        {
            linkLabelResourcesGit.LinkColor = Color.FromArgb(0, 90, 255);
        }
    }
}