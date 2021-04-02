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
    public partial class Form1 : Form
    {
        static string request = "https://api.github.com/repos/Eisbison/TheOtherRoles/releases/latest";
        static int releaseId;
        static string releaseName;
        static string downloadUrl;
        static string path;

        public Form1()
        {
            InitializeComponent();
            panelHome.Visible = true;
        }

       
        private async void getOtherRoles()
        {
            try
            {
                using(HttpClient client = new HttpClient())
                {
                    client.DefaultRequestHeaders.UserAgent.Add(new ProductInfoHeaderValue("product", "1"));
                    var response = await client.GetStringAsync(request);
                    dynamic json = JsonConvert.DeserializeObject(response);
                    downloadUrl = json.assets[0].browser_download_url;
                    releaseName = json.name;
                    releaseId = json.assets[0].id;
                }

                gettingInstallationPath();

                await downloadNewVersion();
                
                
                
                
            } 
            catch (Exception e)
            {

            }
            finally
            {
                startGame();
            }
        }

        private async Task<bool> downloadNewVersion()
        {
            var pathToSave = path + "\\" + releaseName + ".zip";
            try
            {
                if(File.Exists(pathToSave)) File.Delete(pathToSave);

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

                var zipPath = path + "\\" + releaseName + ".zip";
                ZipFile.ExtractToDirectory(zipPath, path);
            }
            return true;
        }

        private void gettingInstallationPath()
        {
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
        }

        private void deleteOldFiles()
        {
            if (Directory.Exists(path + "\\mono")) Directory.Delete(path + "\\mono", true);
            if (Directory.Exists(path + "\\BepInex")) Directory.Delete(path + "\\BepInex", true);
            if (File.Exists(path + "\\winhttp.dll")) File.Delete(path + "\\winhttp.dll");
            if (File.Exists(path + "\\steam_appid.txt")) File.Delete(path + "\\steam_appid.txt");
            if (File.Exists(path + "\\doorstop_config.ini")) File.Delete(path + "\\doorstop_config.ini");
        }

        private void startGame()
        {
            var gamePath = path + "\\Among Us.exe";
            Process p = new Process();
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.FileName = gamePath;
            p.Start();

            string output = p.StandardOutput.ReadToEnd();
            p.WaitForExit();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            downloadProgress.Value = 0;
            getOtherRoles();
        }

        private async void wc_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            downloadProgress.Value = e.ProgressPercentage;
        }


        private void homeButton_Click(object sender, EventArgs e)
        {
            panelHome.Visible = true;
            panelConfig.Visible = false;
            panelHelp.Visible = false;
        }

        private void configButton_Click(object sender, EventArgs e)
        {
            panelHome.Visible = false;
            panelConfig.Visible = true;
            panelHelp.Visible = false;
        }

        private void helpButton_Click(object sender, EventArgs e)
        {
            panelHome.Visible = false;
            panelConfig.Visible = false;
            panelHelp.Visible = true;
        }
    }
}
