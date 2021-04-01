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

            getOtherRoles();
            
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
                downloadNewVersion();
                deleteOldFiles();
            } 
            catch (Exception e)
            {

            }
        }

        private void downloadNewVersion()
        {
            try
            {
                using (WebClient wc = new WebClient())
                {
                    wc.DownloadProgressChanged += wc_DownloadProgressChanged;
                    var pathToSave = path + "\\" + releaseName + ".zip";
                    wc.DownloadFileAsync(
                        new Uri(downloadUrl),
                        //Path to save
                        pathToSave
                    );

                    FileAttributes attributes = File.GetAttributes(pathToSave);
                    File.SetAttributes(pathToSave, File.GetAttributes(pathToSave) | FileAttributes.Hidden);
                }
            }
            catch (Exception e)
            {

            }
            
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
            if (Directory.Exists(path + "\\mono"))
            {
                
                //then delete folder
                Directory.Delete(path + "\\mono", true);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
        }

        void wc_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            downloadProgress.Value = e.ProgressPercentage;
        }
    }
}
