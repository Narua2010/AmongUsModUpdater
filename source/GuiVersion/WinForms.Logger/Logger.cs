using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForms.Logger
{
    public class Logger
    {
        private static String ErrorlineNo, Errormsg, extype;

        public static void Log(string errorMsg = null, Exception ex = null)
        {
            var line = Environment.NewLine + Environment.NewLine;

            if (errorMsg != null)
            {
                ErrorlineNo = null;
                Errormsg = errorMsg;
                extype = "Info";
            }
            else
            {
                ErrorlineNo = ex.StackTrace;
                Errormsg = ex.InnerException.Message;
                extype = ex.GetType().ToString();
            }


            try
            {
                string filepath = Environment.ExpandEnvironmentVariables("%AppData%\\AmongUsModUpdaterLog\\");  //Text File Path

                if (!Directory.Exists(filepath))
                {
                    Directory.CreateDirectory(filepath);

                }
                filepath = filepath + "AmongUsModUpdaterLog_" + DateTime.Today.ToString("dd-MM-yy") + ".txt";   //Text File Name
                if (!File.Exists(filepath))
                {


                    File.Create(filepath).Dispose();

                }
                using (StreamWriter sw = File.AppendText(filepath))
                {
                    string _error = "Log Written Date:" + " " + DateTime.Now.ToString() + line + "Error Line No :" + " " + ErrorlineNo + line + "Error Message:" + " " + Errormsg + line + "Exception Type:" + " " + extype + line + "Error Location :" + " " + line;
                    sw.WriteLine("-----------Exception Details on " + " " + DateTime.Now.ToString() + "-----------------");
                    sw.WriteLine("-------------------------------------------------------------------------------------");
                    sw.WriteLine(line);
                    sw.WriteLine(_error);
                    sw.WriteLine("--------------------------------*End*------------------------------------------");
                    sw.WriteLine(line);
                    sw.Flush();
                    sw.Close();

                }

            }
            catch (Exception e)
            {
                e.ToString();
            }
        }
    }
}
