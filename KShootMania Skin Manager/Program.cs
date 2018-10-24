using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Threading;

namespace KShootMania_Skin_Manager
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            CommonData.Setup();
            Runtime_context.Setup();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            if (!Directory.Exists(CommonData.ExeDir + "\\Install.xml"))
                Application.Run(new InstallForm());
            else
            {
                Installation_details.Setup();
                CommonData.KSMDir = Installation_details.KShootManiaInstallLocation;
                MainForm main = new MainForm();
                while (true)
                {
                    Thread.Sleep(990);
                    if (KSMRunning())
                        main.ShowDialog();
                }
            }
        }

        public static bool KSMRunning()
        {
            return CommonData.KSM_processes().Length > 0;
        }
    }
}
