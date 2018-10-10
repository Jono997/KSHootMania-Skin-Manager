using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.IO.Compression;
using System.Security.Principal;
using ATEM;

namespace KShootMania_Skin_Manager
{
    /// <summary>
    /// The form where users install KShootMania Skin Manager
    /// </summary>
    public partial class SetupForm : Form
    {
        public SetupForm()
        {
            InitializeComponent();
            KSM_install_locationFolderBrowserDialog.SelectedPath = CommonData.ExeDir;
        }

        /// <summary>
        /// Open the folder select window to choose where KShootMania is installed
        /// </summary>
        private void KSM_install_locationButton_Click(object sender, EventArgs e)
        {
            if (KSM_install_locationFolderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                CommonData.KSMDir = KSM_install_locationFolderBrowserDialog.SelectedPath;
                KSM_install_locationTextBox.Text = CommonData.KSMDir;
            }
        }

        /// <summary>
        /// Open the file select window to select the KShootMania zip file
        /// </summary>
        private void Zip_fileButton_Click(object sender, EventArgs e)
        {
            if (Zip_fileOpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                Zip_fileTextBox.Text = Zip_fileOpenFileDialog.FileName;
            }
        }
        
        /// <summary>
        /// Check if KShootMania Skin Manager is being run as administrator and uncheck Install_for_allCheckBox and lecture the user if not.
        /// </summary>
        private void Install_for_allCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (Install_for_allCheckBox.Checked)
            {
                WindowsPrincipal windowsPrincipal = new WindowsPrincipal(WindowsIdentity.GetCurrent());
                if (!windowsPrincipal.IsInRole(WindowsBuiltInRole.Administrator))
                {
                    Install_for_allCheckBox.Checked = false;
                    MessageBox.Show("KShootMania Skin Manager isn't being run as administrator.\nYou can still install it to this user though.", "Unable to install to all users");
                }
            }
         }

        /// <summary>
        /// Install KShootMania Skin Manager
        /// </summary>
        private void Begin_setupButton_Click(object sender, EventArgs e)
        {
            Directory.CreateDirectory(CommonData.SkinDir);
            CommonData.KSMDir = KSM_install_locationTextBox.Text;
            CommonData.Save();

            #region Copy default skin
            #region Create unique id
                Random randint = new Random();
                string id = randint.Next(9999).ToString();
                while (Directory.Exists(CommonData.ExeDir + '\\' + id))
                {
                    id = randint.Next(9999).ToString();
                }
            #endregion

            ZipFile.ExtractToDirectory(Zip_fileTextBox.Text, CommonData.ExeDir + '\\' + id);

            ATEMMethods.CopyDirectory(CommonData.ExeDir + "\\" + id + "\\kshootmania\\imgs", CommonData.SkinDir + '\\' + CommonData.DefaultSkinName + "\\imgs", true);
            ATEMMethods.CopyDirectory(CommonData.ExeDir + '\\' + id + "\\kshootmania\\se", CommonData.SkinDir + '\\' + CommonData.DefaultSkinName + "\\se", true);

            Directory.Delete(CommonData.ExeDir + "\\" + id, true);
            #endregion

            #region Insert shortcut into startup folder
            WindowsPrincipal windowsPrincipal = new WindowsPrincipal(WindowsIdentity.GetCurrent());
            string startup_path = "C:\\";
            if (Install_for_allCheckBox.Checked && windowsPrincipal.IsInRole(WindowsBuiltInRole.Administrator))
            {
                startup_path += "ProgramData";
            }
            else
            {
                startup_path += "Users\\" + Environment.UserName + "\\Appdata\\Roaming";
            }
            startup_path += "\\Microsoft\\Windows\\Start Menu\\Programs\\Startup\\KShootMania Skin Manager.lnk";

            IWshRuntimeLibrary.WshShell shell = new IWshRuntimeLibrary.WshShell();
            IWshRuntimeLibrary.IWshShortcut shortcut = shell.CreateShortcut(startup_path);
            shortcut.TargetPath = Environment.GetCommandLineArgs()[0];
            shortcut.Save();
            #endregion

            MessageBox.Show("Installation complete. Please note that in order to best make use of KShootMania Skin Manager, KShootMania must be run in windowed mode. Fullscreen mode will work, but it'll be a bit messy");
            Close();
        }
    }
}
