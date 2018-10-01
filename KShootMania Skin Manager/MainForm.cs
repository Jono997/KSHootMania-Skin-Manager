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
    public partial class MainForm : Form
    {
        static bool closeable;

        public MainForm()
        {
            closeable = true;
            InitializeComponent();
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            Update_Position();
        }

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

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!Program.KSMRunning() && closeable)
                Close();
            else
                Update_Position();
        }

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
