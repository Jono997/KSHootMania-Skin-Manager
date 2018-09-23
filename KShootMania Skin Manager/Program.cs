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
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            if (!Directory.Exists(CommonData.SkinDir))
            {
                SetupForm setup = new SetupForm();
                setup.ShowDialog();
            }

            if (Directory.Exists(CommonData.SkinDir))
            {
                CommonData.Load();
                MainForm main = new MainForm();
                
                while (true)
                {
                    Thread.Sleep(990);
                    if (KSMRunning())
                    {
                        main.ShowDialog();
                    }
                }
            }
        }

        public static bool KSMRunning()
        {
            return CommonData.KSM_processes().Length > 0;
        }
    }
}
