using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security.Principal;

namespace KShootMania_Skin_Manager
{
    /// <summary>
    /// A class summarising certain aspects of the environment KShootMania Skin Manager is running in
    /// </summary>
    public static class Runtime_context
    {
        /// <summary>
        /// If true, KShootMania Skin Manager is running on a 64 bit computer. If false, it's a 32 bit computer.
        /// </summary>
        public static bool SixtyFour_Bit { get; private set; }

        /// <summary>
        /// If true, KShootMania Skin Manager is being run as administrator
        /// </summary>
        public static bool Administrator { get; private set; }

        public static void Setup()
        {
            SixtyFour_Bit = Directory.Exists("C:\\Program Files (x86)");

            WindowsPrincipal windowsPrincipal = new WindowsPrincipal(WindowsIdentity.GetCurrent());
            Administrator = windowsPrincipal.IsInRole(WindowsBuiltInRole.Administrator);
        }
    }
}
