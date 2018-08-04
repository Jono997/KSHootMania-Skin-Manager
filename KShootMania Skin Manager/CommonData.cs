using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ATEM;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace KShootMania_Skin_Manager
{
    static class CommonData
    {
        /// <summary>
        /// The directory of the executable
        /// </summary>
        public static string ExeDir { get; private set; }

        /// <summary>
        /// The path to the settings.ini file
        /// </summary>
        public static string SettingsPath { get; private set; }

        /// <summary>
        /// The skins directory
        /// </summary>
        public static string SkinDir { get; private set; }

        /// <summary>
        /// The directory of KShootMania
        /// </summary>
        public static string KSMDir { get; set; }

        /// <summary>
        /// If true, the higher priority skins will appear at the top of the skin order rather than at the bottom.
        /// </summary>
        public static bool TopPriorityOnTop { get; set; }

        public static void Setup()
        {
            string[] directory_split = Environment.GetCommandLineArgs()[0].Split('\\');
            directory_split = directory_split.SubArray(0, directory_split.Length - 1);
            ExeDir = directory_split.Stitch('\\');
            SettingsPath = ExeDir + "\\settings.ini";
            SkinDir = ExeDir + "\\Skins";
        }

        public static void Save()
        {
            string[] settings = new string[] { "[KSMSkinManager]",
                                               "KSMDir=" + KSMDir,
                                               "TopPriorityOnTop=" + (TopPriorityOnTop ? "true" : "false")
            };
            File.WriteAllLines(SettingsPath, settings);
        }

        public static void Load()
        {
            string[] settings = File.ReadAllLines(SettingsPath);

            #region Parse the settings ini for the settings pertaining to KSM Skin Manager
            int zero = -1;
            int length = 0;
            for (int i = 0; i < settings.Length; i++)
            {
                if (settings[i] == "[KSMSkinManager]")
                {
                    zero = i;
                }
                if (zero != -1 && settings[i][0] == '[')
                {
                    length = i - zero;
                    break;
                }
            }
            if (length == 0)
            {
                length = settings.Length;
            }
            if (zero == -1)
            {
                MessageBox.Show("settings.ini file invalid", "KShootMania Skin Manager", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            settings = settings.SubArray(zero + 1, length - 1);
            #endregion

            foreach (string setting in settings)
            {
                string[] setting_split = setting.Split('=');
                switch (setting_split[0])
                {
                    case "KSMDir":
                        KSMDir = setting_split[1]; break;
                    case "TopPriorityOnTop":
                        TopPriorityOnTop = (setting_split[1] == "true" ? true : false); break;
                }
            }
        }

        public static System.Diagnostics.Process[] KSM_processes()
        {
            System.Diagnostics.Process[] result = System.Diagnostics.Process.GetProcessesByName("kshootmania");
            System.Threading.Thread.Sleep(10);
            return result;
        }

        public static void Save_skins_xml(List<string> skins_xml)
        {
            using (var writer = new StreamWriter(ExeDir + "\\Skin.xml"))
            {
                var serializer = new XmlSerializer(typeof(List<string>));
                serializer.Serialize(writer, skins_xml);
                writer.Flush();
            }
        }

        public static List<string> Load_skins_xml()
        {
            if (File.Exists(ExeDir + "\\Skin.xml"))
            {
                using (var stream = File.OpenRead(ExeDir + "\\Skin.xml"))
                {
                    var serializer = new XmlSerializer(typeof(List<string>));
                    return serializer.Deserialize(stream) as List<string>;
                }
            }
            else
            {
                return new string[] { "Default skin" }.ToList();
            }
        }
    }
}
