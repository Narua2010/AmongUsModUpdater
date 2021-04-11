using System;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using WinForms.Logger;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.IO.Compression;
using System.Diagnostics;

namespace AmongUsModUpdater.UpdaterFunctions
{
    public class ModFunctions
    {
        private static dynamic _mainWindow;

        public static async Task<dynamic> getModData(string requestUrl)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    client.DefaultRequestHeaders.UserAgent.Add(new ProductInfoHeaderValue("product", "1"));
                    var response = await client.GetStringAsync(requestUrl);
                    dynamic result = JsonConvert.DeserializeObject(response);
                    return result;
                }
            }
            catch (Exception e)
            {
                Logger.Log(null, e);
            }
            return null;
        }
       
        public static void startGame(string gamePath, bool checkInstallation, dynamic mainWindow)
        {
            _mainWindow = mainWindow;
            if (!string.IsNullOrWhiteSpace(gamePath))
            {

                if (checkInstallation)
                {
                    var _gamePath = gamePath + "\\Among Us.exe";
                    BackgroundWorker workerStart = new BackgroundWorker();
                    workerStart.DoWork += new DoWorkEventHandler(backgroundWorkerStart_DoWork);
                    workerStart.RunWorkerCompleted += new RunWorkerCompletedEventHandler(backgroundWorkerStart_RunComplete);
                    workerStart.RunWorkerAsync(gamePath);
                    mainWindow.downloadProgress.Value = 0;
                    mainWindow.waitingInfoForStart.Visible = true;
                }
                else
                {
                    mainWindow.buttonHomeUpdate.Visible = true;
                    mainWindow.buttonHomeStart.Visible = false;
                    mainWindow.downloadProgress.Visible = true;

                    DialogResult response = MessageBoxFunctions.openMessageBoxWithResponse("It looks like the mods are not installed. Do you want to update or install them now?", "Error");

                    if (response == DialogResult.Yes)
                    {
                        mainWindow.buttonHomeInstall.PerformClick();
                    }
                }
            }
        }
        public static async Task<string> downloadNewVersion(string downloadUrl, string zipPath, dynamic mainWindow)
        {
            _mainWindow = mainWindow;
            mainWindow.downloadProgress.Value = 0;
            try
            {
                if (File.Exists(zipPath)) File.Delete(zipPath);

                using (WebClient wc = new WebClient())
                {
                    wc.DownloadProgressChanged += wc_DownloadProgressChanged;
                    await wc.DownloadFileTaskAsync(
                        new Uri(downloadUrl),
                        //Path to save
                        zipPath
                    );

                    wc.Dispose();

                    FileAttributes attributes = File.GetAttributes(zipPath);
                    File.SetAttributes(zipPath, File.GetAttributes(zipPath) | FileAttributes.Hidden);
                }

                return zipPath;
            }
            catch (Exception e)
            {
                Logger.Log(null, e);
            }
            return null;
        }
        public static void generateBackup(string gamePath)
        {
            if (File.Exists(gamePath.Replace("\\Among Us", "") + "\\AmongUsBackup" + DateTime.Now.ToString("yyyyMMdd") + ".zip")) File.Delete(gamePath.Replace("\\Among Us", "") + "\\AmongUsBackup" + DateTime.Now.ToString("yyyyMMdd") + ".zip");
            ZipFile.CreateFromDirectory(gamePath, gamePath.Replace("\\Among Us", "") + "\\AmongUsBackup" + DateTime.Now.ToString("yyyyMMdd") + ".zip");
        }
        private static void wc_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            _mainWindow.downloadProgress.Value = e.ProgressPercentage;
        }
        public static void backgroundWorkerStart_DoWork(object sender, DoWorkEventArgs ex)
        {
            Process p = new Process();
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.FileName = ex.Argument.ToString();
            p.Start();
            p.WaitForExit();
            return;
        }
        public static void backgroundWorkerStart_RunComplete(object sender, RunWorkerCompletedEventArgs ex)
        {
            _mainWindow.waitingInfoForStart.Visible = false;
        }
    }
}
