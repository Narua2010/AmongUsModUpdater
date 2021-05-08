using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;
using System.IO;
using WinForms.Logger;
using Microsoft.Win32;

namespace AmongUsModUpdater.UpdaterFunctions
{
    public class QuickSearch
    {
        private dynamic mainWindow;
        private BackgroundWorker worker;

        public QuickSearch(dynamic mainWindow)
        {
            this.mainWindow = mainWindow;
            this.mainWindow.ProgressBarSearch.Visible = true;
            this.mainWindow.LabelProcessedDrives.Visible = true;
            this.mainWindow.ButtonWorkerCancel.Visible = true;
            this.mainWindow.ButtonWorkerCancel.Enabled = true;
            this.mainWindow.SettingsButtonQuickSearch.Enabled = false;
            this.worker = new BackgroundWorker();
            worker.DoWork += new DoWorkEventHandler(this.backgroundWorker1_DoWork);
            worker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(this.backgroundWorker1_RunComplete);
            worker.ProgressChanged += new ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            worker.WorkerReportsProgress = true;
            worker.WorkerSupportsCancellation = true;
        }
        public void startAsyncWorker()
        {
            worker.RunWorkerAsync();
        }
        public void cancelAsyncWorker()
        {
            // Cancel the asynchronous operation.
            worker.CancelAsync();
        }
        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            ProgressArgument progressArgument = (ProgressArgument)e.UserState;
            this.mainWindow.LabelProcessedDrives.Text = "Searching in registry " + progressArgument.count + " of " + progressArgument.allDrivesLength;
        }
        private void backgroundWorker1_RunComplete(object sender, RunWorkerCompletedEventArgs ex)
        {
            if (ex.Cancelled)
            {
                this.mainWindow.LabelProcessedDrives.Visible = false;
                this.mainWindow.ProgressBarSearch.Visible = false;
                this.mainWindow.ButtonWorkerCancel.Visible = false;
                this.mainWindow.SettingsButtonQuickSearch.Enabled = true;
                this.mainWindow.LabelProcessedDrives.Text = "Searching in registry ...";
                worker = new BackgroundWorker();
                return;
            }
            if (ex.Result != null)
            {
                this.mainWindow.SettingsGamePathTextBox.Text = ex.Result.ToString();
                worker = new BackgroundWorker();
            }
            else
            {
                string message = "The Among Us.exe could not be found. Please search for it manually or install the game.";
                string caption = "Error";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult response = MessageBox.Show(message, caption, buttons);
                this.mainWindow.SettingsGamePathTextBox.Text = "";
                worker = new BackgroundWorker();
            }
            this.mainWindow.LabelProcessedDrives.Visible = false;
            this.mainWindow.ProgressBarSearch.Visible = false;
            this.mainWindow.ButtonWorkerCancel.Visible = false;
            this.mainWindow.SettingsButtonQuickSearch.Enabled = true;
            worker = new BackgroundWorker();
        }
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs ex)
        {
            string path = "";
            try
            {
                var options = new EnumerationOptions()
                {
                    IgnoreInaccessible = true,
                    RecurseSubdirectories = false
                };
                var installPath = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Wow6432Node\\Valve\\Steam", false).GetValue("InstallPath");
                if (installPath != null && !installPath.Equals(string.Empty))
                {
                    path = installPath + @"\steamapps\common\Among Us";
                    if(Directory.Exists(path))
                        if (Directory.GetFiles(path, @"Among Us.exe", options).Any())
                            ex.Result = path;
                }
            }
            catch (Exception e)
            {
                Logger.Log(null, e);
            }

        }
    }
}
