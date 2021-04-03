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
using System.Threading;

namespace AmongUsModUpdater
{
    public partial class MainWindow : Form
    {
        static string request = "https://api.github.com/repos/Eisbison/TheOtherRoles/releases/latest";
        static string releaseName;
        static string downloadUrl;
        bool configControll = false;

        public MainWindow()
        {
            InitializeComponent();

            //#if DEBUG
            //    Properties.Settings.Default.Backup = false;
            //    Properties.Settings.Default.GamePath = "";
            //    Properties.Settings.Default.OtherModsReleaseId = "";
            //    Properties.Settings.Default.Save();
            //#endif

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
                if(File.Exists(manualLocationFolderDialog.SelectedPath + "\\Among Us.exe"))
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

            if (!string.IsNullOrWhiteSpace(path))
            {
                return path;
            }
            else
            {
                string message = "The Among Us.exe could not be found. Please search for it manually or install the game.";
                string caption = "Error";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult response = MessageBox.Show(message, caption, buttons);
                return null;
            }
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
                if (checkInstallation())
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
                else
                {
                    buttoneHomeUpdate.Visible = true;
                    buttonHomeStart.Visible = false;
                    downloadProgress.Visible = true;

                    string message = "It looks like the mods are not installed. Do you want to update or install them now?";
                    string caption = "Error";
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult response = MessageBox.Show(message, caption, buttons);

                    if (response == DialogResult.Yes)
                    {
                        buttoneHomeUpdate.PerformClick();
                    }
                }
            }
        }
        private void buttoneHomeUpdate_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(Properties.Settings.Default.GamePath))
            {
                if (Properties.Settings.Default.Backup)
                {
                    if (File.Exists(Properties.Settings.Default.GamePath.Replace("\\Among Us", "") + "\\AmongUsBackup" + DateTime.Now.ToString("yyyyMMdd") + ".zip")) File.Delete(Properties.Settings.Default.GamePath.Replace("\\Among Us", "") + "\\AmongUsBackup" + DateTime.Now.ToString("yyyyMMdd") + ".zip");
                    ZipFile.CreateFromDirectory(Properties.Settings.Default.GamePath, Properties.Settings.Default.GamePath.Replace("\\Among Us", "") + "\\AmongUsBackup"+ DateTime.Now.ToString("yyyyMMdd") +".zip");
                }
                var check = downloadNewVersion();
            }
            else
            {
                string message = "No play path was given. Please enter it under the settings. Would you like to be redirected to the settings?";
                string caption = "Error";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult response = MessageBox.Show(message, caption, buttons);

                if (response == DialogResult.Yes)
                {
                    settingsButton.PerformClick();
                }
            }
            
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

                if (configControll)
                {
                    File.Copy(Properties.Settings.Default.GamePath + "\\com.comando.essentials.cfg", Properties.Settings.Default.GamePath + "\\BepInex\\config\\com.comando.essentials.cfg");
                }

                
                buttoneHomeUpdate.Visible = false;
                buttonHomeStart.Visible = true;
                downloadProgress.Visible = false;

                if (File.Exists(Properties.Settings.Default.GamePath + "\\com.comando.essentials.cfg")) File.Delete(Properties.Settings.Default.GamePath + "\\com.comando.essentials.cfg");
                if (File.Exists(Properties.Settings.Default.GamePath + "\\" + releaseName + ".zip")) File.Delete(Properties.Settings.Default.GamePath + "\\" + releaseName + ".zip");

                string message = "The mod has been successfully updated. Would you like to start the game now?";
                string caption = "Update finished";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult response = MessageBox.Show(message, caption, buttons);

                if (response == DialogResult.Yes)
                {
                    startGame();
                }
            }
            return true;
        }
        private void deleteOldFiles()
        {
            string path = Properties.Settings.Default.GamePath;
            
            if (File.Exists(path + "\\BepInex\\config\\com.comando.essentials.cfg"))
            {
                File.Copy(path + "\\BepInex\\config\\com.comando.essentials.cfg", path + "\\com.comando.essentials.cfg");
                configControll = true;
            }

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
        private bool checkInstallation()
        {
            string path = Properties.Settings.Default.GamePath;
            
            if (!Directory.Exists(path + "\\mono") || !Directory.Exists(path + "\\BepInex") || !File.Exists(path + "\\winhttp.dll") || !File.Exists(path + "\\steam_appid.txt") || !File.Exists(path + "\\doorstop_config.ini")) return false;
            
            return true;
        }
    }
}
