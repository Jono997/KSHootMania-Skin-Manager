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

namespace KShootMania_Skin_Manager
{
    public partial class SetupForm : Form
    {
        public SetupForm()
        {
            InitializeComponent();
            KSM_install_locationFolderBrowserDialog.SelectedPath = CommonData.ExeDir;
        }

        private void KSM_install_locationButton_Click(object sender, EventArgs e)
        {
            if (KSM_install_locationFolderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                CommonData.KSMDir = KSM_install_locationFolderBrowserDialog.SelectedPath;
                KSM_install_locationTextBox.Text = CommonData.KSMDir;
            }
        }

        private void Zip_fileButton_Click(object sender, EventArgs e)
        {
            if (Zip_fileOpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                Zip_fileTextBox.Text = Zip_fileOpenFileDialog.FileName;
            }
        }

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

        private void Begin_setupButton_Click(object sender, EventArgs e)
        {
            Directory.CreateDirectory(CommonData.SkinDir);
            CommonData.KSMDir = KSM_install_locationTextBox.Text;
            CommonData.Save();

            #region Copy default skin
            #region Create unique id
                Random randint = new Random();
                int id = randint.Next(9999);
                while (Directory.Exists(CommonData.ExeDir + '\\' + id.ToString()))
                {
                    id = randint.Next(9999);
                }
            #endregion

            ZipFile.ExtractToDirectory(Zip_fileTextBox.Text, CommonData.ExeDir + '\\' + id.ToString());

            Directory.CreateDirectory(CommonData.SkinDir + "\\Default skin\\imgs");
            foreach (string file in Directory.GetFiles(CommonData.ExeDir + "\\" + id.ToString() + "\\kshootmania\\imgs"))
            {
                File.Copy(file, CommonData.SkinDir + "\\Default skin\\imgs\\" + file.Split('\\').Last());
            }
            Directory.CreateDirectory(CommonData.SkinDir + "\\Default skin\\se");
            foreach (string file in Directory.GetFiles(CommonData.ExeDir + "\\" + id.ToString() + "\\kshootmania\\se"))
            {
                File.Copy(file, CommonData.SkinDir + "\\Default skin\\se\\" + file.Split('\\').Last());
            }

            Directory.Delete(CommonData.ExeDir + "\\" + id.ToString(), true);
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
