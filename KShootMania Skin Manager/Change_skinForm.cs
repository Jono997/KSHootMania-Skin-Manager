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
        public Change_skinForm()
        {
            Load_Skins();

            InitializeComponent();
            Redraw_ListBoxes();
            Change_skinForm_SizeChanged(null, null);
        }

        private void Change_skinForm_SizeChanged(object sender, EventArgs e)
        {
            #region create base
            int base_size = Width - 40; // Removing window padding
            int overflow = base_size % 8;
            base_size = (base_size - overflow) / 8;

            #region create overflow
            int overflow2 = overflow % 3;
            overflow = (overflow - overflow2) / 3;
            #endregion
            #endregion

            Skin_libraryListBox.Size = new Size(base_size * 3 + overflow - 3, Height - 82);
            int button_width = base_size * 2 + overflow - 6;
            int button_x = Skin_libraryListBox.Location.X + Skin_libraryListBox.Width + 6;
            Loaded_skinsListBox.Size = new Size(base_size * 3 + overflow + overflow2 - 3 + overflow, Height - 82);
            Loaded_skinsListBox.Location = new Point(button_x + button_width + 6, Loaded_skinsListBox.Location.Y);

            #region Apply to buttons
            foreach (Control control in Controls)
            {
                if (control.GetType() == typeof(Button))
                {
                    control.Width = button_width;
                    control.Location = new Point(button_x, control.Location.Y);
                }
            }
            #endregion
        }

        private void Load_Skins()
        {
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
        }

        private void Redraw_ListBoxes()
        {
            Skin_libraryListBox.Items.Clear();
            Skin_libraryListBox.Items.AddRange(unloaded_skins.ToArray());

            Loaded_skinsListBox.Items.Clear();
            for (int i = 0; i < loaded_skins.Count; i++)
            {
                if (CommonData.TopPriorityOnTop)
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
                Up_priorityButton.Enabled = Loaded_skinsListBox.SelectedIndex != (CommonData.TopPriorityOnTop ? 0 : loaded_skins.Count - 1);
                Down_priorityButton.Enabled = Loaded_skinsListBox.SelectedIndex != (CommonData.TopPriorityOnTop ? loaded_skins.Count - 1 : 0);
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
            if (CommonData.TopPriorityOnTop)
                index = loaded_skins.Count - 1 - index;
            string skin = loaded_skins[index];
            loaded_skins.RemoveAt(index);
            loaded_skins.Insert(index + 1, skin);
            index = Loaded_skinsListBox.SelectedIndex;

            Redraw_ListBoxes();
            if (CommonData.TopPriorityOnTop)
                index--;
            else
                index++;
            Loaded_skinsListBox.SelectedIndex = index;
        }

        private void Down_priorityButton_Click(object sender, EventArgs e)
        {
            int index = Loaded_skinsListBox.SelectedIndex;
            if (CommonData.TopPriorityOnTop)
                index = loaded_skins.Count - 1 - index;
            string skin = loaded_skins[index];
            loaded_skins.RemoveAt(index);
            loaded_skins.Insert(index - 1, skin);
            index = Loaded_skinsListBox.SelectedIndex;

            Redraw_ListBoxes();
            if (CommonData.TopPriorityOnTop)
                index++;
            else
                index--;
            Loaded_skinsListBox.SelectedIndex = index;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            CommonData.Save_skins_xml(loaded_skins);
            Skin_result checksum = new Skin_result(loaded_skins.ToArray());
            switch (checksum.result)
            {
                case Skin_result.CheckResult.Good:
                    {
                        Load_Skin();
                        break;
                    }
                case Skin_result.CheckResult.Error:
                    {
                        if (checksum.errors.Contains(Skin_result.SkinErrors.Missing_elements))
                            MessageBox.Show("This skin setup is missing certain elements. Consider adding the default skin to the bottom of the skin heirarchy to cover any missing elements.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }
                case Skin_result.CheckResult.Warning:
                    {
                        if (checksum.warnings.Contains(Skin_result.SkinWarnings.Unneeded_skins))
                            MessageBox.Show("This skin setup includes skins that go unused. The skin will stil work, but will load slower than if these skins were removed.", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        if (MessageBox.Show("Load the skin anyway?", "WARNING", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            Load_Skin();
                        break;
                    }
            }
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
                string imgdir = CommonData.SkinDir + '\\' + loaded_skins[i] + "\\imgs";
                if (Directory.Exists(imgdir))
                    ATEMMethods.CopyDirectory(imgdir, CommonData.KSMDir + "\\imgs", ATEMMethods.FolderExistsResponse.MergeOverwrite, true);

                string sedir = CommonData.SkinDir + '\\' + loaded_skins[i] + "\\se";
                if (Directory.Exists(sedir))
                    ATEMMethods.CopyDirectory(sedir, CommonData.KSMDir + "\\se", ATEMMethods.FolderExistsResponse.MergeOverwrite, true);
            }
            #endregion
            Close();
        }

        private void HelpButton_Click(object sender, EventArgs e)
        {
            HelpForm help = new HelpForm();
            help.ShowDialog();
        }

        private void Organise_skinsButton_Click(object sender, EventArgs e)
        {
            Manage_skinsForm manage_SkinsForm = new Manage_skinsForm();
            manage_SkinsForm.ShowDialog();
            Load_Skins();
            Redraw_ListBoxes();
        }

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            SettingsForm settingsForm = new SettingsForm();
            settingsForm.ShowDialog();
            Redraw_ListBoxes();
        }
    }
}
