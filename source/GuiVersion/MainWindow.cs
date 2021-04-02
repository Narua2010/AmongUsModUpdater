using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using Microsoft.Win32;
using System.ServiceProcess;
using System.IO;
using System.IO.Compression;
using System.Diagnostics;

namespace AmongUsModUpdater
{
    public partial class MainWindow : Form
    {
        static string request = "https://api.github.com/repos/Eisbison/TheOtherRoles/releases/latest";
        static string releaseName;
        static string downloadUrl;

        public MainWindow()
        {
            InitializeComponent();

            labelVersion.Text = "Among Us Mod Updater Version: " +Application.ProductVersion;
            settingsGamePathTextBox.Text = Properties.Settings.Default.GamePath;

            if (Properties.Settings.Default.Backup == true)
            {
                settingsToggleBackup.IsOn = true;
            }
            else
            {
                settingsToggleBackup.IsOn = false;
            }

            panelHome.Visible = true;

            getOtherRoles();
        }
        private void wc_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            downloadProgress.Value = e.ProgressPercentage;
        }
        private void homeButton_Click(object sender, EventArgs e)
        {
            panelHome.Visible = true;
            panelSettings.Visible = false;
            panelHelp.Visible = false;

            panelMenuActive.Height = homeButton.Height;
            panelMenuActive.Top = homeButton.Top;
        }
        private void settingsButton_Click(object sender, EventArgs e)
        {
            panelHome.Visible = false;
            panelSettings.Visible = true;
            panelHelp.Visible = false;

            panelMenuActive.Height = settingsButton.Height;
            panelMenuActive.Top = settingsButton.Top;
        }
        private void helpButton_Click(object sender, EventArgs e)
        {
            panelHome.Visible = false;
            panelSettings.Visible = false;
            panelHelp.Visible = true;

            panelMenuActive.Height = helpButton.Height;
            panelMenuActive.Top = helpButton.Top;
        }
        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void linkLabelResourcesGit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ProcessStartInfo psInfo = new ProcessStartInfo
            {
                FileName = "https://github.com/Narua2010/AmongUsModUpdater",
                UseShellExecute = true
            };
            Process.Start(psInfo);
        }
        private void linkLabelResourcesGit_MouseEnter(object sender, EventArgs e)
        {
            linkLabelResourcesGit.LinkColor = Color.Red;
        }
        private void linkLabelResourcesGit_MouseLeave(object sender, EventArgs e)
        {
            linkLabelResourcesGit.LinkColor = Color.FromArgb(0, 90, 255);
        }
        private void settingButtonManual_Click(object sender, EventArgs e)
        {
            DialogResult result = manualLocationFolderDialog.ShowDialog();

            if(result == DialogResult.OK && !string.IsNullOrWhiteSpace(manualLocationFolderDialog.SelectedPath))
            {
                settingsGamePathTextBox.Text = manualLocationFolderDialog.SelectedPath;
            }
        }
        private void settingsButtonAutomated_Click(object sender, EventArgs e)
        {
            string message = "The automatic search can take longer and cause problems with slow systems.";
            string caption = "Attention";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult response = MessageBox.Show(message, caption, buttons);

            if(response == DialogResult.Yes)
            {
                string result = gettingInstallationPath();
                if (!string.IsNullOrWhiteSpace(result))
                {
                    settingsGamePathTextBox.Text = result;
                }
            }
        }
        private string gettingInstallationPath()
        {
            string path = "";
            try
            {
                var options = new EnumerationOptions()
                {
                    IgnoreInaccessible = true,
                    RecurseSubdirectories = true
                };

                DriveInfo[] allDrives = DriveInfo.GetDrives();
                foreach (var drive in allDrives)
                {
                    string[] dirs = Directory.GetFiles(drive.Name, @"Among Us.exe", options);
                    if (dirs.Length > 0) path = dirs[0].Replace("\\Among Us.exe", "");
                }
            }
            catch (Exception e)
            {
            }

            return path;
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
        private void buttonHomeStart_Click(object sender, EventArgs e)
        {
            startGame();
        }
        private void startGame()
        {
            if (!string.IsNullOrWhiteSpace(Properties.Settings.Default.GamePath))
            {
                var gamePath = Properties.Settings.Default.GamePath + "\\Among Us.exe";
                Process p = new Process();
                p.StartInfo.UseShellExecute = false;
                p.StartInfo.RedirectStandardOutput = true;
                p.StartInfo.FileName = gamePath;
                p.Start();

                string output = p.StandardOutput.ReadToEnd();
                downloadProgress.Value = 0;
                p.WaitForExit();
            }
        }
        private void buttoneHomeUpdate_Click(object sender, EventArgs e)
        {
            var check = downloadNewVersion();
        }
        private async Task<bool> downloadNewVersion()
        {
            downloadProgress.Value = 0;
            var pathToSave = Properties.Settings.Default.GamePath + "\\" + releaseName + ".zip";
            try
            {
                if (File.Exists(pathToSave)) File.Delete(pathToSave);

                using (WebClient wc = new WebClient())
                {
                    wc.DownloadProgressChanged += wc_DownloadProgressChanged;
                    await wc.DownloadFileTaskAsync(
                        new Uri(downloadUrl),
                        //Path to save
                        pathToSave
                    );

                    wc.Dispose();

                    FileAttributes attributes = File.GetAttributes(pathToSave);
                    File.SetAttributes(pathToSave, File.GetAttributes(pathToSave) | FileAttributes.Hidden);
                }
            }
            catch (Exception e)
            {

            }
            finally
            {
                deleteOldFiles();

                var zipPath = Properties.Settings.Default.GamePath + "\\" + releaseName + ".zip";
                ZipFile.ExtractToDirectory(zipPath, Properties.Settings.Default.GamePath);
                buttonHomeStart.Visible = true;
                buttoneHomeUpdate.Visible = false;
                downloadProgress.Visible = false;
                startGame();
            }
            return true;
        }
        private void deleteOldFiles()
        {
            string path = Properties.Settings.Default.GamePath;
            if (Directory.Exists(path + "\\mono")) Directory.Delete(path + "\\mono", true);
            if (Directory.Exists(path + "\\BepInex")) Directory.Delete(path + "\\BepInex", true);
            if (File.Exists(path + "\\winhttp.dll")) File.Delete(path + "\\winhttp.dll");
            if (File.Exists(path + "\\steam_appid.txt")) File.Delete(path + "\\steam_appid.txt");
            if (File.Exists(path + "\\doorstop_config.ini")) File.Delete(path + "\\doorstop_config.ini");
        }
        private async void getOtherRoles()
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    client.DefaultRequestHeaders.UserAgent.Add(new ProductInfoHeaderValue("product", "1"));
                    var response = await client.GetStringAsync(request);
                    dynamic json = JsonConvert.DeserializeObject(response);
                    downloadUrl = json.assets[0].browser_download_url;
                    releaseName = json.name;
                    string newReleaseId = json.assets[0].id.ToString();

                    if (Properties.Settings.Default.OtherModsReleaseId == newReleaseId)
                    {
                        buttonHomeStart.Visible = true;
                        buttoneHomeUpdate.Visible = false;
                        downloadProgress.Visible = false;
                    }
                    else
                    {
                        buttonHomeStart.Visible = false;
                        buttoneHomeUpdate.Visible = true;
                        downloadProgress.Visible = true;
                        Properties.Settings.Default.OtherModsReleaseId = newReleaseId;
                        Properties.Settings.Default.Save();
                    }
                }
            }
            catch (Exception e)
            {

            }
        }
    }
}
