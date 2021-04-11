using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;
using System.IO;
using WinForms.Logger;

namespace AmongUsModUpdater.UpdaterFunctions
{
    public class AutomatedSearch
    {
        private dynamic mainWindow;
        private BackgroundWorker worker;

        public AutomatedSearch(dynamic mainWindow)
        {
            this.mainWindow = mainWindow;
            this.mainWindow.ProgressBarSearch.Visible = true;
            this.mainWindow.LabelProcessedDrives.Visible = true;
            this.mainWindow.ButtonWorkerCancel.Visible = true;
            this.mainWindow.ButtonWorkerCancel.Enabled = true;
            this.mainWindow.SettingsButtonAutomated.Enabled = false;
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
            this.mainWindow.LabelProcessedDrives.Text = "Searching in drive " + progressArgument.count + " of " + progressArgument.allDrivesLength;
        }
        private void backgroundWorker1_RunComplete(object sender, RunWorkerCompletedEventArgs ex)
        {
            if (ex.Cancelled)
            {
                this.mainWindow.LabelProcessedDrives.Visible = false;
                this.mainWindow.ProgressBarSearch.Visible = false;
                this.mainWindow.ButtonWorkerCancel.Visible = false;
                this.mainWindow.SettingsButtonAutomated.Enabled = true;
                this.mainWindow.LabelProcessedDrives.Text = "Searching in drive ...";
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
            this.mainWindow.SettingsButtonAutomated.Enabled = true;
            worker = new BackgroundWorker();
        }
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs ex)
        {
            string path = "";
            BackgroundWorker worker = sender as BackgroundWorker;
            ProgressArgument progressArgument = new ProgressArgument();
            try
            {
                var options = new EnumerationOptions()
                {
                    IgnoreInaccessible = true,
                    RecurseSubdirectories = true
                };

                DriveInfo[] allDrives = DriveInfo.GetDrives();
                int count = 1;
                foreach (var drive in allDrives)
                {
                    if (worker.CancellationPending)
                    {
                        ex.Cancel = true;
                        return;
                    }
                    progressArgument.count = count;
                    progressArgument.allDrivesLength = allDrives.Length;
                    worker.ReportProgress(10, progressArgument);

                    string[] dirs = Directory.GetFiles(drive.Name, @"Among Us.exe", options);
                    if (dirs.Length > 0)
                    {
                        path = dirs[0].Replace("\\Among Us.exe", "");
                        ex.Result = path;
                        return;
                    }
                    count++;
                }
            }
            catch (Exception e)
            {
                Logger.Log(null, e);
            }

        }
    }
}
