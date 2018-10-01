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

namespace KShootMania_Skin_Manager
{
    public partial class Manage_skinsForm : Form
    {
        List<string> installed_skins;

        public Manage_skinsForm()
        {
            Get_Installed_Skins();
            InitializeComponent();
            openFileDialog1.InitialDirectory = @"C:\Users\" + Environment.UserName + @"\Downloads";
            Refresh_Installed_skinsListBox();
        }

        private void Get_Installed_Skins()
        {
            installed_skins = new List<string>();
            foreach (string skin in Directory.GetDirectories(CommonData.SkinDir))
            {
                installed_skins.Add(skin.Substring(CommonData.SkinDir.Length + 1));
            }
        }

        private void Refresh_Installed_skinsListBox(bool runwithoutrefresh = false)
        {
            if (!runwithoutrefresh)
                Get_Installed_Skins();
            Installed_skinsListBox.Items.Clear();
            foreach (string skin in installed_skins)
            {
                Installed_skinsListBox.Items.Add(skin);
            }
        }

        private void Installed_skinsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Uninstall_skinButton.Enabled = (Installed_skinsListBox.SelectedIndex != -1 && (string)Installed_skinsListBox.SelectedItem != "Default skin");
        }

        private void Install_skinButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                CommonData.Install_Skin(openFileDialog1.FileName);
                Refresh_Installed_skinsListBox();
            }
        }

        private void Uninstall_skinButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to uninstall " + Installed_skinsListBox.SelectedItem + "?", "Uninstall " + Installed_skinsListBox.SelectedItem, MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                List<string> skinsetup = CommonData.Load_skins_xml();
                if (skinsetup.Contains(Installed_skinsListBox.SelectedItem))
                {
                    if (MessageBox.Show(Installed_skinsListBox.SelectedItem + " is used in the current skin. Still uninstall it?", "Skin is being used", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        skinsetup.Remove((string)Installed_skinsListBox.SelectedItem);
                        CommonData.Save_skins_xml(skinsetup);
                    }
                    else
                        return;
                }
                Directory.Delete(CommonData.SkinDir + '\\' + Installed_skinsListBox.SelectedItem, true);
                Refresh_Installed_skinsListBox();
            }
        }

    }
}
