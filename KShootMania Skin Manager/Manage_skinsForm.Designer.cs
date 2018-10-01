namespace KShootMania_Skin_Manager
{
    partial class Manage_skinsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Installed_skinsListBox = new System.Windows.Forms.ListBox();
            this.Installed_skinsLabel = new System.Windows.Forms.Label();
            this.Install_skinButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.Uninstall_skinButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Installed_skinsListBox
            // 
            this.Installed_skinsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Installed_skinsListBox.FormattingEnabled = true;
            this.Installed_skinsListBox.Location = new System.Drawing.Point(198, 25);
            this.Installed_skinsListBox.Name = "Installed_skinsListBox";
            this.Installed_skinsListBox.Size = new System.Drawing.Size(305, 420);
            this.Installed_skinsListBox.TabIndex = 0;
            this.Installed_skinsListBox.SelectedIndexChanged += new System.EventHandler(this.Installed_skinsListBox_SelectedIndexChanged);
            // 
            // Installed_skinsLabel
            // 
            this.Installed_skinsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Installed_skinsLabel.AutoSize = true;
            this.Installed_skinsLabel.Location = new System.Drawing.Point(430, 9);
            this.Installed_skinsLabel.Name = "Installed_skinsLabel";
            this.Installed_skinsLabel.Size = new System.Drawing.Size(73, 13);
            this.Installed_skinsLabel.TabIndex = 1;
            this.Installed_skinsLabel.Text = "Installed skins";
            // 
            // Install_skinButton
            // 
            this.Install_skinButton.Location = new System.Drawing.Point(12, 25);
            this.Install_skinButton.Name = "Install_skinButton";
            this.Install_skinButton.Size = new System.Drawing.Size(180, 23);
            this.Install_skinButton.TabIndex = 2;
            this.Install_skinButton.Text = "Install skin";
            this.Install_skinButton.UseVisualStyleBackColor = true;
            this.Install_skinButton.Click += new System.EventHandler(this.Install_skinButton_Click);
            // 
            // Uninstall_skinButton
            // 
            this.Uninstall_skinButton.Enabled = false;
            this.Uninstall_skinButton.Location = new System.Drawing.Point(12, 54);
            this.Uninstall_skinButton.Name = "Uninstall_skinButton";
            this.Uninstall_skinButton.Size = new System.Drawing.Size(180, 23);
            this.Uninstall_skinButton.TabIndex = 3;
            this.Uninstall_skinButton.Text = "Uninstall skin";
            this.Uninstall_skinButton.UseVisualStyleBackColor = true;
            this.Uninstall_skinButton.Click += new System.EventHandler(this.Uninstall_skinButton_Click);
            // 
            // Manage_skinsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 450);
            this.Controls.Add(this.Uninstall_skinButton);
            this.Controls.Add(this.Install_skinButton);
            this.Controls.Add(this.Installed_skinsLabel);
            this.Controls.Add(this.Installed_skinsListBox);
            this.Name = "Manage_skinsForm";
            this.Text = "Skin manager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox Installed_skinsListBox;
        private System.Windows.Forms.Label Installed_skinsLabel;
        private System.Windows.Forms.Button Install_skinButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button Uninstall_skinButton;
    }
}