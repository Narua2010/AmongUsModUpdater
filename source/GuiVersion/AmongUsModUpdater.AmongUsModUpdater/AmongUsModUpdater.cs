using System;
using System.Net.Http;
using System.Net.Http.Headers;
using WinForms.Logger;
using AmongUsModUpdater.UpdaterFunctions;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace AmongUsModUpdater.AmongUsModUpdater
{
    public class AmongUsModUpdater
    {
        static string projectUrl = "https://api.github.com/repos/Narua2010/AmongUsModUpdater/releases/latest";
        public async static Task<string> checkVersionsUpdate(dynamic mainWindow)
        {
            dynamic json = await ModFunctions.getModData(projectUrl);
            if (Application.ProductVersion != json.tag_name.ToString().Replace("v", ""))
            {
                mainWindow.newVersionButton.Visible = true;
                return json.assets[0].browser_download_url;
            }
            return null;
        }
    }
}
