using System;
using System.IO;
using System.Threading.Tasks;
using AmongUsModUpdater.UpdaterFunctions;
using System.Windows.Forms;
using WinForms.Logger;
using System.Threading;
using System.IO.Compression;

namespace AmongUsModUpdater.TheOtherRoles
{
    public class TheOtherRoles
    {

        static string projectApi = "https://api.github.com/repos/Eisbison/TheOtherRoles/releases/latest";
        static string releaseName, downloadUrl, currentReleaseId;
        static bool configControll = false;
        public static string projectUrl
        {
            get
            {
                return "https://github.com/Eisbison/TheOtherRoles";
            }
        }

        public static async void getTheOtherRoles(dynamic mainWindow)
        {
#if DEBUG
            Properties.Settings.Default.ReleaseId = null;
            Properties.Settings.Default.GamePath = null;
            Properties.Settings.Default.Save();
#endif
            dynamic json = await ModFunctions.getModData(projectApi);
            downloadUrl = json.assets[0].browser_download_url;
            releaseName = json.name;
            currentReleaseId = json.assets[0].id.ToString();

            if (string.IsNullOrWhiteSpace(Properties.Settings.Default.ReleaseId))
            {
                mainWindow.buttonHomeInstall.Visible = true;
                mainWindow.buttonHomeStart.Visible = false;
                mainWindow.buttonHomeUpdate.Visible = false;
            }
            else if(Properties.Settings.Default.ReleaseId == currentReleaseId)
            {
                mainWindow.buttonHomeInstall.Visible = false;
                mainWindow.buttonHomeStart.Visible = true;
                mainWindow.buttonHomeUpdate.Visible = false;
            }
            else
            {
                mainWindow.buttonHomeInstall.Visible = false;
                mainWindow.buttonHomeStart.Visible = false;
                mainWindow.buttonHomeUpdate.Visible = true;
            }
        }
        public static async void installTheOtherRoles(dynamic mainWindow, string rootPath)
        {
            mainWindow.buttonHomeInstall.Enabled = false;
            if (deleteOldVersionInRoot(rootPath).Result)
            {
                string gamePath = rootPath + "\\The Other Roles";
                Properties.Settings.Default.GamePath = gamePath;
                Properties.Settings.Default.Save();
                updateTheOtherRoles(mainWindow, rootPath);
            }
        }

        public static async void updateTheOtherRoles(dynamic mainWindow, string rootPath)
        {
            mainWindow.buttonHomeUpdate.Enabled = false;
            if (deleteOldFiles(rootPath).Result)
            {
                //Create Mod Folder
                Properties.Settings.Default.ReleaseId = currentReleaseId;
                Properties.Settings.Default.Save();
                string gamePath = Properties.Settings.Default.GamePath;
                Directory.CreateDirectory(gamePath);

                await SystemFunctions.copyFolder(rootPath, gamePath);

                mainWindow.downloadProgress.Visible = true;


                //Download Mod
                string zipPath = Properties.Settings.Default.GamePath + "\\" + releaseName + ".zip";
                await ModFunctions.downloadNewVersion(downloadUrl, zipPath, mainWindow);

                ZipFile.ExtractToDirectory(zipPath, Properties.Settings.Default.GamePath);

                if (!Directory.Exists(Properties.Settings.Default.GamePath + "\\BepInex\\config"))
                {
                    Directory.CreateDirectory(Properties.Settings.Default.GamePath + "\\BepInex\\config");
                }
                if (configControll)
                {
                    var _tmpCheck = false;
                    do
                    {
                        if (File.Exists(Properties.Settings.Default.GamePath + "\\me.eisbison.theotherroles.cfg"))
                        {
                            File.Copy(Properties.Settings.Default.GamePath + "\\me.eisbison.theotherroles.cfg", Properties.Settings.Default.GamePath + "\\BepInex\\config\\me.eisbison.theotherroles.cfg", true);
                            _tmpCheck = true;
                            Logger.Log("File copy successed (z329)", null);
                        }
                        else
                        {
                            Logger.Log("Waiting for copy (z333)", null);
                            Thread.Sleep(100);
                        }
                    } while (!_tmpCheck);
                }

                mainWindow.buttonHomeInstall.Visible = false;
                mainWindow.buttonHomeUpdate.Visible = false;
                mainWindow.buttonHomeStart.Visible = true;
                mainWindow.downloadProgress.Visible = false;

                if (File.Exists(rootPath + "\\me.eisbison.theotherroles.cfg")) File.Delete(rootPath + "\\me.eisbison.theotherroles.cfg");
                if (File.Exists(Properties.Settings.Default.GamePath + "\\me.eisbison.theotherroles.cfg")) File.Delete(Properties.Settings.Default.GamePath + "\\me.eisbison.theotherroles.cfg");
                if (File.Exists(Properties.Settings.Default.GamePath + "\\" + releaseName + ".zip")) File.Delete(Properties.Settings.Default.GamePath + "\\" + releaseName + ".zip");

                mainWindow.buttonHomeInstall.Enabled = true;
                mainWindow.buttonHomeUpdate.Enabled = true;

                DialogResult messageBoxResponse = MessageBoxFunctions.openMessageBoxWithResponse("The mod has been successfully updated. Would you like to start the game now?", "Update finished");

                if (messageBoxResponse == DialogResult.Yes)
                {
                    startTheOtherRoles(mainWindow);
                }
            }
        }

        public static void startTheOtherRoles(dynamic mainWindow)
        {
            mainWindow.buttonHomeStart.Enabled = false;
            ModFunctions.startGame(Properties.Settings.Default.GamePath, checkInstallation(), mainWindow);
        }

        public static async Task<bool> deleteOldFiles(string rootPath)
        {
            string gamePath = Properties.Settings.Default.GamePath;

            if (File.Exists(gamePath + "\\BepInex\\config\\me.eisbison.theotherroles.cfg"))
            {
                File.Copy(gamePath + "\\BepInex\\config\\me.eisbison.theotherroles.cfg", rootPath + "\\me.eisbison.theotherroles.cfg", true);
                configControll = true;
            }

            if (Directory.Exists(gamePath)) Directory.Delete(gamePath, true);

            return true;
        }

        public static async Task<bool> deleteOldVersionInRoot(string gamePath)
        {
            if(Directory.Exists(gamePath + "\\mono")) Directory.Delete(gamePath + "\\mono", true);
            if (Directory.Exists(gamePath + "\\BepInex")) Directory.Delete(gamePath + "\\BepInex", true);
            if (Directory.Exists(gamePath + "\\TheOtherHats")) Directory.Delete(gamePath + "\\TheOtherHats", true);
            if (File.Exists(gamePath + "\\winhttp.dll")) File.Delete(gamePath + "\\winhttp.dll");
            if (File.Exists(gamePath + "\\steam_appid.txt")) File.Delete(gamePath + "\\steam_appid.txt");
            if (File.Exists(gamePath + "\\doorstop_config.ini")) File.Delete(gamePath + "\\doorstop_config.ini");

            return true;
        }
        private static bool checkInstallation()
        {
            string path = Properties.Settings.Default.GamePath;

            if (!Directory.Exists(path) && (!Directory.Exists(path + "\\mono") || !Directory.Exists(path + "\\BepInex") || !Directory.Exists(path + "\\TheOtherHats") || !File.Exists(path + "\\winhttp.dll") || !File.Exists(path + "\\steam_appid.txt") || !File.Exists(path + "\\doorstop_config.ini"))) return false;

            return true;
        }
    }
}
