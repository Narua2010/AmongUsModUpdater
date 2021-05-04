using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;
using System.IO;

namespace AmongUsModUpdater.UpdaterFunctions
{
    public class SystemFunctions
    {
        private static AutomatedSearch automatedSearch;
        private static QuickSearch quickSearch;

        public static void switchPanelVisibility(int y, Panel[] menuPanels, Button[] menuButtons, Panel panelMenuActive)
        {
            for(int i = 0; i < menuPanels.Length; i++)
            {
                if(i == y)
                {
                    menuPanels[i].Visible = true;
                    panelMenuActive.Height = menuButtons[i].Height;
                    panelMenuActive.Top = menuButtons[i].Top;
                }
                else
                {
                    menuPanels[i].Visible = false;
                }
            }
        }
        public static void openLinkInBrowser(string link)
        {
            ProcessStartInfo psInfo = new ProcessStartInfo
            {
                FileName = link,
                UseShellExecute = true
            };
            Process.Start(psInfo);
        }
        public static void startAutomatedSearch(dynamic mainWindow)
        {
            automatedSearch = new AutomatedSearch(mainWindow);
            automatedSearch.startAsyncWorker();
        }
        public static void cancelAutomatedSearch()
        {
            automatedSearch.cancelAsyncWorker();
        }
        public static void startQuickSearch(dynamic mainWindow)
        {
            quickSearch = new QuickSearch(mainWindow);
            quickSearch.startAsyncWorker();
        }
        public static void cancelQuickSearch()
        {
            quickSearch.cancelAsyncWorker();
        }
        public static async Task<bool> copyFolder(string sourceFolder, string destFolder)
        {
            if (!Directory.Exists(destFolder))
                Directory.CreateDirectory(destFolder);
            string[] files = Directory.GetFiles(sourceFolder);
            foreach (string file in files)
            {
                string name = Path.GetFileName(file);
                string dest = Path.Combine(destFolder, name);
                File.Copy(file, dest);
            }
            string[] folders = Directory.GetDirectories(sourceFolder);
            foreach (string folder in folders)
            {
                if(folder != destFolder) {
                    string name = Path.GetFileName(folder);
                    string dest = Path.Combine(destFolder, name);
                    await copyFolder(folder, dest);
                }
            }
            return true;
        }
    }
}
