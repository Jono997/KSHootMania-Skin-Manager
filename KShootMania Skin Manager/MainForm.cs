using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace KShootMania_Skin_Manager
{
    /// <summary>
    /// The form that displays the Change skin button
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// If true, this form will close when no instances of KShootMania are running
        /// </summary>
        static bool closeable;

        public MainForm()
        {
            closeable = true;
            InitializeComponent();
        }

        /// <summary>
        /// Calls Update_Position when the form opens
        /// </summary>
        private void MainForm_Shown(object sender, EventArgs e)
        {
            Update_Position();
        }

        /// <summary>
        /// Update the location of Change_skinButton
        /// </summary>
        private void Update_Position()
        {
            Rectangle resolution = Screen.PrimaryScreen.Bounds;
            switch (CommonData.ChangeSkinButtonPosition)
            {
                case CommonData.ButtonPosition.TopLeft:
                    Location = new Point(0, 0);
                    break;
                case CommonData.ButtonPosition.TopRight:
                    Location = new Point(resolution.Width - Width, 0);
                    break;
                case CommonData.ButtonPosition.BottomLeft:
                    Location = new Point(0, resolution.Height - Height);
                    break;
                case CommonData.ButtonPosition.BottomRight:
                    Location = new Point(resolution.Width - Width, resolution.Height - Height);
                    break;
            }
        }

        /// <summary>
        /// If an instance of KShootMania is running or closeable is false, call Update_Position
        /// Otherwise, close the form
        /// </summary>
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!Program.KSMRunning() && closeable)
                Close();
            else
                Update_Position();
        }

        /// <summary>
        /// Disable autoclosing, close all instances of KShootMania, open Change_SkinForm and open a new instance of KShootMania after Change_SkinForm closes
        /// </summary>
        private void Change_skinButton_Click(object sender, EventArgs e)
        {
            Visible = false;
            closeable = false;
            foreach (Process process in CommonData.KSM_processes())
            {
                process.Kill();
            }
            Change_skinForm change_SkinForm = new Change_skinForm();
            change_SkinForm.ShowDialog();
            Process.Start(CommonData.KSMDir + "\\kshootmania.exe");
            closeable = true;
            Visible = true;
        }
    }
}
