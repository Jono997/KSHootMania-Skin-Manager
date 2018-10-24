using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace KShootMania_Skin_Manager
{
    public static class Installation_details
    {
        /// <summary>
        /// Is the KShootMania instance indicated in KShootManiaInstallLocation specific to KShootMania Skin Manager
        /// </summary>
        public static bool PersonalKSMInstallation { get; set; }

        /// <summary>
        /// The instances of KShootMania tied to KShootMania Skin Manager
        /// </summary>
        public static string KShootManiaInstallLocation { get; set; }

        /// <summary>
        /// A shortcut to KShootMania was added during installation
        /// </summary>
        public static bool StartMenuShortcut { get; set; }

        /// <summary>
        /// Is KShootMania Skin Manager installed for all users
        /// </summary>
        public static bool InstallForAll { get; set; }

        public class installation_details
        {
            public bool PersonalKSMInstallation { get; set; }
            public string KShootManiaInstallLocation { get; set; }
            public bool StartMenuShortcut { get; set; }
            public bool InstallForAll { get; set; }

            public installation_details()
            {

            }
        }

        public static void Setup()
        {
            if (File.Exists(CommonData.InstallPath))
            {
                installation_details details;
                using (FileStream reader = File.OpenRead(CommonData.InstallPath))
                {
                    XmlSerializer serialiser = new XmlSerializer(typeof(installation_details));
                    details = serialiser.Deserialize(reader) as installation_details;
                }

                PersonalKSMInstallation = details.PersonalKSMInstallation;
                KShootManiaInstallLocation = details.KShootManiaInstallLocation;
                StartMenuShortcut = details.StartMenuShortcut;
                InstallForAll = details.InstallForAll;
            }
        }

        public static void Save(string path = null)
        {
            string _path = path == null ? CommonData.InstallPath : path;

            installation_details details = new installation_details
            {
                PersonalKSMInstallation = PersonalKSMInstallation,
                KShootManiaInstallLocation = KShootManiaInstallLocation,
                StartMenuShortcut = StartMenuShortcut,
                InstallForAll = InstallForAll
            };

            using (StreamWriter writer = new StreamWriter(_path))
            {
                XmlSerializer serialiser = new XmlSerializer(typeof(installation_details));
                serialiser.Serialize(writer, details);
                writer.Flush();
            }
        }
    }
}
