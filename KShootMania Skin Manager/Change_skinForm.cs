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
using System.Diagnostics;

namespace KShootMania_Skin_Manager
{
    public partial class Change_skinForm : Form
    {
        List<string> unloaded_skins;
        List<string> loaded_skins;
        bool top_priority_on_top;
        public Change_skinForm()
        {
            #region Load skins
            unloaded_skins = new List<string>();
            foreach (string skin in Directory.GetDirectories(CommonData.SkinDir))
            {
                unloaded_skins.Add(skin.Substring(CommonData.SkinDir.Length + 1));
            }
            loaded_skins = CommonData.Load_skins_xml();
            foreach (string skin in loaded_skins)
            {
                unloaded_skins.Remove(skin);
            }
            #endregion
            top_priority_on_top = CommonData.TopPriorityOnTop;

            InitializeComponent();
            Redraw_ListBoxes();
        }

        private void Redraw_ListBoxes()
        {
            Skin_libraryListBox.Items.Clear();
            Skin_libraryListBox.Items.AddRange(unloaded_skins.ToArray());

            Loaded_skinsListBox.Items.Clear();
            for (int i = 0; i < loaded_skins.Count; i++)
            {
                if (top_priority_on_top)
                {
                    Loaded_skinsListBox.Items.Add(loaded_skins.GetFromLast(i));
                }
                else
                {
                    Loaded_skinsListBox.Items.Add(loaded_skins[i]);
                }
            }
        }

        private void Skin_libraryListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Add_skinButton.Enabled = Skin_libraryListBox.SelectedIndex != -1;
        }

        private void Loaded_skinsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Loaded_skinsListBox.SelectedIndex == -1)
            {
                Remove_skinButton.Enabled = false;
            }
            else
            {
                Remove_skinButton.Enabled = true;
                Up_priorityButton.Enabled = Loaded_skinsListBox.SelectedIndex != (top_priority_on_top ? 0 : loaded_skins.Count - 1);
                Down_priorityButton.Enabled = Loaded_skinsListBox.SelectedIndex != (top_priority_on_top ? loaded_skins.Count - 1 : 0);
            }
        }

        private void Add_skinButton_Click(object sender, EventArgs e)
        {
            string skin = (string)Skin_libraryListBox.SelectedItem;
            unloaded_skins.Remove(skin);

            if (Loaded_skinsListBox.SelectedIndex == -1)
            {
                loaded_skins.Add(skin);
            }
            else
            {
                loaded_skins.Insert(Loaded_skinsListBox.SelectedIndex, skin);
            }
            Redraw_ListBoxes();
        }

        private void Remove_skinButton_Click(object sender, EventArgs e)
        {
            string skin = (string)Loaded_skinsListBox.SelectedItem;
            loaded_skins.Remove(skin);
            unloaded_skins.Add(skin);
            Redraw_ListBoxes();
        }

        private void Up_priorityButton_Click(object sender, EventArgs e)
        {
            int index = Loaded_skinsListBox.SelectedIndex;
            if (top_priority_on_top)
                index = loaded_skins.Count - 1 - index;
            string skin = loaded_skins[index];
            loaded_skins.RemoveAt(index);
            loaded_skins.Insert(index + 1, skin);
            index = Loaded_skinsListBox.SelectedIndex;

            Redraw_ListBoxes();
            if (top_priority_on_top)
            {
                index--;
            }
            else
            {
                index++;
            }
            Loaded_skinsListBox.SelectedIndex = index;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            CommonData.Save_skins_xml(loaded_skins);
            Load_Skin();
        }

        private void Load_Skin()
        {
            #region Empty directories
            Directory.Delete(CommonData.KSMDir + "\\imgs", true);
            Directory.Delete(CommonData.KSMDir + "\\se", true);
            Directory.Delete(CommonData.KSMDir + "\\cache", true);
            Directory.CreateDirectory(CommonData.KSMDir + "\\imgs");
            Directory.CreateDirectory(CommonData.KSMDir + "\\se");
            Directory.CreateDirectory(CommonData.KSMDir + "\\cache");
            #endregion

            #region Repopulate directories
            for (int i = 0; i < loaded_skins.Count; i++)
            {
                CopyDirectoryContents(CommonData.SkinDir + '\\' + loaded_skins[i] + "\\imgs", CommonData.KSMDir + "\\imgs");
                CopyDirectoryContents(CommonData.SkinDir + '\\' + loaded_skins[i] + "\\se", CommonData.KSMDir + "\\se");
            }
            #endregion
            Close();
        }

        private void CopyDirectoryContents(string fromdir, string todir)
        {
            foreach (string file in Directory.GetFiles(fromdir))
            {
                string filename = file.Substring(fromdir.Length);
                File.Copy(file, todir + filename, true);
            }

            foreach (string directory in Directory.GetDirectories(fromdir))
            {
                string dirname = directory.Substring(fromdir.Length);
                Directory.CreateDirectory(todir + dirname);
                CopyDirectoryContents(directory, todir + dirname);
            }
        }

        private void Change_skinForm_HelpButtonClicked(object sender, CancelEventArgs e)
        {
            Process.Start(CommonData.ExeDir + "\\KSM Skin Manager Help.exe");
        }
    }
}
