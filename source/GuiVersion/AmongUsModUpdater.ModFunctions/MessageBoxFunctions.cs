using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AmongUsModUpdater.UpdaterFunctions
{
    public class MessageBoxFunctions
    {
        public static void openMessageBox(string message, string caption)
        {
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            MessageBox.Show(message, caption, buttons);
        }
        public static DialogResult openMessageBoxWithResponse(string message, string caption)
        {
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult response = MessageBox.Show(message, caption, buttons);
            return response;
        }
    }
}
