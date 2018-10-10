using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KShootMania_Skin_Manager
{
    public partial class SettingsForm : Form
    {
        /// <summary>
        /// The form in which the users adjust their settings
        /// </summary>
        public SettingsForm()
        {
            InitializeComponent();

            #region Integrate tooltips
            foreach (Control control in Controls)
                if (control.GetType() == typeof(GroupBox))
                {
                    string tooltip = toolTip1.GetToolTip(control);
                    if (tooltip != "")
                    {
                        foreach (Control subcontrol in control.Controls)
                        {
                            string subtooltip = toolTip1.GetToolTip(subcontrol);
                            if (subtooltip != "")
                                tooltip += "\n" + subcontrol.Text + ": " + subtooltip;
                        }
                        toolTip1.SetToolTip(control, tooltip);
                    }
                }
            #endregion

            #region Setup UI
            // Hierarchy
            if (CommonData.TopPriorityOnTop)
                Show_hierarchy_ascendingButton.Checked = true;
            else
                Show_heirarchy_descendingRadioButton.Checked = true;

            // Change_skinButton orientation
            switch (CommonData.ChangeSkinButtonPosition)
            {
                case CommonData.ButtonPosition.TopLeft:
                    Top_leftRadioButton.Checked = true;
                    break;
                case CommonData.ButtonPosition.TopRight:
                    Top_rightRadioButton.Checked = true;
                    break;
                case CommonData.ButtonPosition.BottomLeft:
                    Bottom_leftRadioButton.Checked = true;
                    break;
                case CommonData.ButtonPosition.BottomRight:
                    Bottom_rightRadioButton.Checked = true;
                    break;
            }
            #endregion
        }

        /// <summary>
        /// Save the user's settings and close the form
        /// </summary>
        private void SaveButton_Click(object sender, EventArgs e)
        {
            CommonData.TopPriorityOnTop = Show_hierarchy_ascendingButton.Checked;
            if (Top_leftRadioButton.Checked)
                CommonData.ChangeSkinButtonPosition = CommonData.ButtonPosition.TopLeft;
            else if (Top_rightRadioButton.Checked)
                CommonData.ChangeSkinButtonPosition = CommonData.ButtonPosition.TopRight;
            else if (Bottom_leftRadioButton.Checked)
                CommonData.ChangeSkinButtonPosition = CommonData.ButtonPosition.BottomLeft;
            else
                CommonData.ChangeSkinButtonPosition = CommonData.ButtonPosition.BottomRight;

            CommonData.Save();
            Close();
        }
    }
}
