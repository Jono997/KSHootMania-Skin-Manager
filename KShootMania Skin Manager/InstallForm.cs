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
using ATEM;

namespace KShootMania_Skin_Manager
{
    /// <summary>
    /// The form where users install KShootMania Skin Manager
    /// </summary>
    public partial class InstallForm : Form
    {
        public InstallForm()
        {
            InitializeComponent();

            Install_locationTextBox.Text = Default_install_location();
        }

        /// <summary>
        /// The default install location for KShootMania Skin Manager
        /// </summary>
        /// <param name="all_users">Get all users default install directory</param>
        /// <returns>The default install location</returns>
        public static string Default_install_location(bool all_users = false)
        {
            if (all_users)
                return "C:\\Program Files" + (Runtime_context.SixtyFour_Bit ? " (x86)" : "") + "\\KShootMania Skin Manager";
            else
                return @"C:\Users\" + Environment.UserName + @"\Appdata\Roaming\KShootMania Skin Manager";
        }

        /// <summary>
        /// Browse to a specific folder to install KShootMania Skin Manager to
        /// </summary>
        private void Install_location_browseButton_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.SelectedPath = Install_locationTextBox.Text;
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                string path = folderBrowserDialog1.SelectedPath;
                string[] path_split = path.Split('\\');

                if (Directory.Exists(path) && Directory.GetFiles(path).Length > 0 && path_split.Last() != "KShootMania Skin Manager")
                {
                    path += "\\KShootMania Skin Manager";
                }

                Install_locationTextBox.Text = path;
            }
        }

        /// <summary>
        /// Disable interaction with the kshootmania install location controls and force adding kshootmania to the start menu
        /// </summary>
        private void Install_with_new_KShootMania_installationRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            KShootMania_install_locationTextBox.Enabled = KShootMania_install_location_browseButton.Enabled = Add_KShootMania_to_start_menuCheckBox.Enabled = false;
            Add_KShootMania_to_start_menuCheckBox.Checked = true;
        }

        /// <summary>
        /// Enable interaction with the kshootmania install location controls
        /// </summary>
        private void Add_to_preexisting_KShootMania_installationRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            KShootMania_install_locationTextBox.Enabled = KShootMania_install_location_browseButton.Enabled = Add_KShootMania_to_start_menuCheckBox.Enabled = true;
        }

        /// <summary>
        /// Browse to a specific folder kshootmania is installed in
        /// </summary>
        private void KShootMania_install_location_browseButton_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.SelectedPath = KShootMania_install_locationTextBox.Text;
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
                KShootMania_install_locationTextBox.Text = folderBrowserDialog1.SelectedPath;
        }

        /// <summary>
        /// Browse to a zip file of kshootmania
        /// </summary>
        private void KShootMania_zip_location_browseButton_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = KShootMania_zip_locationTextBox.Text;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                KShootMania_zip_locationTextBox.Text = openFileDialog1.FileName;
        }

        /// <summary>
        /// Check if the user has the permissions to do this and auto-uncheck the box if not
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Install_for_allCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (Install_for_allCheckBox.Checked && !Runtime_context.Administrator)
            {
                MessageBox.Show("Permission denied. If you want to install for all users, run the installer as an administrator.");
                Install_for_allCheckBox.Checked = false;
            }
            
            if (Install_locationTextBox.Text == Default_install_location(!Install_for_allCheckBox.Checked))
                Install_locationTextBox.Text = Default_install_location(Install_for_allCheckBox.Checked);
        }

        /// <summary>
        /// Install KShootMania Skin Manager
        /// </summary>
        private void InstallButton_Click(object sender, EventArgs e)
        {
            #region Write details of installation to Installation_details
            Installation_details.PersonalKSMInstallation = Install_with_new_KShootMania_installationRadioButton.Checked;
            // KShootManiaInstallLocation gets set later
            Installation_details.StartMenuShortcut = Add_KShootMania_to_start_menuCheckBox.Checked;
            Installation_details.InstallForAll = Install_for_allCheckBox.Checked;
            #endregion

            #region Define IFA dependant variables
            string registry_key = "HKEY_";
            string shortcut_path = "C:\\";
            if (Installation_details.InstallForAll)
            {
                registry_key += "LOCAL_MACHINE";
                shortcut_path += "ProgramData";
            }
            else
            {
                registry_key += "CURRENT_USER";
                shortcut_path += "Users\\" + Environment.UserName + @"\Appdata\Roaming";
            }
            registry_key += @"\SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall\KShootMania Skin Manager";
            shortcut_path += @"\Microsoft\Windows\Start Menu\Programs";
            #endregion

            #region Create folder structure
            if (!Directory.Exists(Install_locationTextBox.Text))
                Directory.CreateDirectory(Install_locationTextBox.Text);
            File.Copy(CommonData.ARGV[0], Install_locationTextBox.Text + "\\KShootMania Skin Manager.exe");
            File.Copy(CommonData.ExeDir + "\\ATEM.dll", Install_locationTextBox.Text + "\\ATEM.dll");
            File.Copy(CommonData.ExeDir + "\\EasyRegistry.dll", Install_locationTextBox.Text + "\\EasyRegistry.dll");
            Directory.CreateDirectory(Install_locationTextBox.Text + "\\Skins");
            #endregion

            #region Add to installed programs
            EasyRegistry.SetValue(registry_key, "DisplayName", "KShootMania Skin Manager");
            EasyRegistry.SetValue(registry_key, "DisplayVersion", "0.7");
            EasyRegistry.SetValue(registry_key, "InstallLocation", Install_locationTextBox.Text);
            EasyRegistry.SetValue(registry_key, "Publisher", "Jono99");
            EasyRegistry.SetValue(registry_key, "UninstallString", "\"" + Install_locationTextBox.Text + "\\KShootMania Skin Manager.exe\" uninstall");
            #endregion

            #region Extract KShootMania
            string default_skin_dir;
            if (Installation_details.PersonalKSMInstallation)
            {
                default_skin_dir = Install_locationTextBox.Text;
                Installation_details.KShootManiaInstallLocation = default_skin_dir + "\\KShootMania";
            }
            else
            {
                Installation_details.KShootManiaInstallLocation = KShootMania_install_locationTextBox.Text;
                Random randint = new Random();
                default_skin_dir = Install_locationTextBox.Text + '\\' + randint.Next(9999).ToString();
                while (Directory.Exists(default_skin_dir))
                    default_skin_dir = Install_locationTextBox.Text + '\\' + randint.Next(9999).ToString();
            }
            System.IO.Compression.ZipFile.ExtractToDirectory(KShootMania_zip_locationTextBox.Text, default_skin_dir);
            default_skin_dir += "\\kshootmania";
            #endregion

            #region Copy default skin to skins
            Directory.CreateDirectory(Install_locationTextBox.Text + "\\Skins\\Default skin");
            ATEMMethods.CopyDirectory(default_skin_dir + "\\imgs", Install_locationTextBox.Text + "\\Skins\\Default skin\\imgs", ATEMMethods.FolderExistsResponse.MergeOverwrite, true);
            ATEMMethods.CopyDirectory(default_skin_dir + "\\se", Install_locationTextBox.Text + "\\Skins\\Default skin\\se", ATEMMethods.FolderExistsResponse.MergeOverwrite, true);
            #endregion

            #region Cleanup after creating default skin (attached KShootMania instance only)
            if (!Installation_details.PersonalKSMInstallation) {
                default_skin_dir = default_skin_dir.Substring(0, default_skin_dir.Length - 12);
                Directory.Delete(default_skin_dir, true);
            }
            #endregion

            #region Add shortcuts
            IWshRuntimeLibrary.WshShell shell = new IWshRuntimeLibrary.WshShell();

            #region Add startup shortcut
            IWshRuntimeLibrary.IWshShortcut startup_shortcut = shell.CreateShortcut(shortcut_path + "\\Startup\\KShootMania Skin Manager.lnk");
            startup_shortcut.TargetPath = Install_locationTextBox.Text + "\\KShootMania Skin Manager.exe";
            startup_shortcut.Save();
            #endregion

            #region Add start menu shortcuts
            Directory.CreateDirectory(shortcut_path + "\\KShootMania Skin Manager");

            IWshRuntimeLibrary.IWshShortcut help_shortcut = shell.CreateShortcut(shortcut_path + "\\KShootMania Skin Manager\\Help.lnk");
            help_shortcut.TargetPath = startup_shortcut.TargetPath;
            help_shortcut.Arguments = "help";
            help_shortcut.Save();

            IWshRuntimeLibrary.IWshShortcut uninstall_shortcut = shell.CreateShortcut(shortcut_path + "\\KShootMania Skin Manager\\Uninstal" + (Runtime_context.Administrator ? "l" : "") + ".lnk");
            uninstall_shortcut.TargetPath = startup_shortcut.TargetPath;
            uninstall_shortcut.Arguments = "uninstall";
            uninstall_shortcut.Save();

            if (Installation_details.StartMenuShortcut)
            {
                IWshRuntimeLibrary.IWshShortcut ksm_shortcut = shell.CreateShortcut(shortcut_path + "\\KShootMania.lnk");
                ksm_shortcut.TargetPath = Installation_details.KShootManiaInstallLocation + "\\kshootmania.exe";
                ksm_shortcut.Save();
            }
            #endregion
            #endregion

            Installation_details.Save(Install_locationTextBox.Text + "\\Install.xml");

            #region Wrap up
            Hide();
            MessageBox.Show("Installation complete! Opening KShootMania...");
            Environment.CurrentDirectory = Install_locationTextBox.Text;
            System.Diagnostics.Process.Start("KShootMania Skin Manager.exe");
            System.Diagnostics.Process.Start(Installation_details.KShootManiaInstallLocation + "\\kshootmania.exe");
            Close();
            #endregion
        }
    }
}
