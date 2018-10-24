namespace KShootMania_Skin_Manager
{
    partial class InstallForm
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
            this.components = new System.ComponentModel.Container();
            this.Install_locationLabel = new System.Windows.Forms.Label();
            this.Install_locationTextBox = new System.Windows.Forms.TextBox();
            this.Install_location_browseButton = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.KShootMania_install_typeGroupBox = new System.Windows.Forms.GroupBox();
            this.Add_to_preexisting_KShootMania_installationRadioButton = new System.Windows.Forms.RadioButton();
            this.Install_with_new_KShootMania_installationRadioButton = new System.Windows.Forms.RadioButton();
            this.KShootMania_install_location_browseButton = new System.Windows.Forms.Button();
            this.KShootMania_install_locationTextBox = new System.Windows.Forms.TextBox();
            this.KShootMania_install_locationLabel = new System.Windows.Forms.Label();
            this.Add_KShootMania_to_start_menuCheckBox = new System.Windows.Forms.CheckBox();
            this.Install_for_allCheckBox = new System.Windows.Forms.CheckBox();
            this.KShootMania_zip_locationLabel = new System.Windows.Forms.Label();
            this.KShootMania_zip_locationTextBox = new System.Windows.Forms.TextBox();
            this.KShootMania_zip_location_browseButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.InstallButton = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.KShootMania_install_typeGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // Install_locationLabel
            // 
            this.Install_locationLabel.AutoSize = true;
            this.Install_locationLabel.Location = new System.Drawing.Point(12, 9);
            this.Install_locationLabel.Name = "Install_locationLabel";
            this.Install_locationLabel.Size = new System.Drawing.Size(74, 13);
            this.Install_locationLabel.TabIndex = 0;
            this.Install_locationLabel.Text = "Install location";
            // 
            // Install_locationTextBox
            // 
            this.Install_locationTextBox.Location = new System.Drawing.Point(12, 25);
            this.Install_locationTextBox.Name = "Install_locationTextBox";
            this.Install_locationTextBox.Size = new System.Drawing.Size(537, 20);
            this.Install_locationTextBox.TabIndex = 1;
            // 
            // Install_location_browseButton
            // 
            this.Install_location_browseButton.Location = new System.Drawing.Point(555, 23);
            this.Install_location_browseButton.Name = "Install_location_browseButton";
            this.Install_location_browseButton.Size = new System.Drawing.Size(26, 23);
            this.Install_location_browseButton.TabIndex = 2;
            this.Install_location_browseButton.Text = "...";
            this.Install_location_browseButton.UseVisualStyleBackColor = true;
            this.Install_location_browseButton.Click += new System.EventHandler(this.Install_location_browseButton_Click);
            // 
            // KShootMania_install_typeGroupBox
            // 
            this.KShootMania_install_typeGroupBox.Controls.Add(this.Add_to_preexisting_KShootMania_installationRadioButton);
            this.KShootMania_install_typeGroupBox.Controls.Add(this.Install_with_new_KShootMania_installationRadioButton);
            this.KShootMania_install_typeGroupBox.Location = new System.Drawing.Point(12, 52);
            this.KShootMania_install_typeGroupBox.Name = "KShootMania_install_typeGroupBox";
            this.KShootMania_install_typeGroupBox.Size = new System.Drawing.Size(569, 67);
            this.KShootMania_install_typeGroupBox.TabIndex = 3;
            this.KShootMania_install_typeGroupBox.TabStop = false;
            // 
            // Add_to_preexisting_KShootMania_installationRadioButton
            // 
            this.Add_to_preexisting_KShootMania_installationRadioButton.AutoSize = true;
            this.Add_to_preexisting_KShootMania_installationRadioButton.Location = new System.Drawing.Point(6, 42);
            this.Add_to_preexisting_KShootMania_installationRadioButton.Name = "Add_to_preexisting_KShootMania_installationRadioButton";
            this.Add_to_preexisting_KShootMania_installationRadioButton.Size = new System.Drawing.Size(231, 17);
            this.Add_to_preexisting_KShootMania_installationRadioButton.TabIndex = 1;
            this.Add_to_preexisting_KShootMania_installationRadioButton.Text = "Add to pre-exsiting KShootMania installation";
            this.Add_to_preexisting_KShootMania_installationRadioButton.UseVisualStyleBackColor = true;
            this.Add_to_preexisting_KShootMania_installationRadioButton.CheckedChanged += new System.EventHandler(this.Add_to_preexisting_KShootMania_installationRadioButton_CheckedChanged);
            // 
            // Install_with_new_KShootMania_installationRadioButton
            // 
            this.Install_with_new_KShootMania_installationRadioButton.AutoSize = true;
            this.Install_with_new_KShootMania_installationRadioButton.Checked = true;
            this.Install_with_new_KShootMania_installationRadioButton.Location = new System.Drawing.Point(6, 19);
            this.Install_with_new_KShootMania_installationRadioButton.Name = "Install_with_new_KShootMania_installationRadioButton";
            this.Install_with_new_KShootMania_installationRadioButton.Size = new System.Drawing.Size(216, 17);
            this.Install_with_new_KShootMania_installationRadioButton.TabIndex = 0;
            this.Install_with_new_KShootMania_installationRadioButton.TabStop = true;
            this.Install_with_new_KShootMania_installationRadioButton.Text = "Install with new KShootMania installation";
            this.Install_with_new_KShootMania_installationRadioButton.UseVisualStyleBackColor = true;
            this.Install_with_new_KShootMania_installationRadioButton.CheckedChanged += new System.EventHandler(this.Install_with_new_KShootMania_installationRadioButton_CheckedChanged);
            // 
            // KShootMania_install_location_browseButton
            // 
            this.KShootMania_install_location_browseButton.Enabled = false;
            this.KShootMania_install_location_browseButton.Location = new System.Drawing.Point(555, 136);
            this.KShootMania_install_location_browseButton.Name = "KShootMania_install_location_browseButton";
            this.KShootMania_install_location_browseButton.Size = new System.Drawing.Size(26, 23);
            this.KShootMania_install_location_browseButton.TabIndex = 5;
            this.KShootMania_install_location_browseButton.Text = "...";
            this.KShootMania_install_location_browseButton.UseVisualStyleBackColor = true;
            this.KShootMania_install_location_browseButton.Click += new System.EventHandler(this.KShootMania_install_location_browseButton_Click);
            // 
            // KShootMania_install_locationTextBox
            // 
            this.KShootMania_install_locationTextBox.Enabled = false;
            this.KShootMania_install_locationTextBox.Location = new System.Drawing.Point(12, 138);
            this.KShootMania_install_locationTextBox.Name = "KShootMania_install_locationTextBox";
            this.KShootMania_install_locationTextBox.Size = new System.Drawing.Size(537, 20);
            this.KShootMania_install_locationTextBox.TabIndex = 6;
            // 
            // KShootMania_install_locationLabel
            // 
            this.KShootMania_install_locationLabel.AutoSize = true;
            this.KShootMania_install_locationLabel.Location = new System.Drawing.Point(12, 122);
            this.KShootMania_install_locationLabel.Name = "KShootMania_install_locationLabel";
            this.KShootMania_install_locationLabel.Size = new System.Drawing.Size(140, 13);
            this.KShootMania_install_locationLabel.TabIndex = 7;
            this.KShootMania_install_locationLabel.Text = "KShootMania install location";
            // 
            // Add_KShootMania_to_start_menuCheckBox
            // 
            this.Add_KShootMania_to_start_menuCheckBox.AutoSize = true;
            this.Add_KShootMania_to_start_menuCheckBox.Checked = true;
            this.Add_KShootMania_to_start_menuCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Add_KShootMania_to_start_menuCheckBox.Enabled = false;
            this.Add_KShootMania_to_start_menuCheckBox.Location = new System.Drawing.Point(12, 164);
            this.Add_KShootMania_to_start_menuCheckBox.Name = "Add_KShootMania_to_start_menuCheckBox";
            this.Add_KShootMania_to_start_menuCheckBox.Size = new System.Drawing.Size(194, 17);
            this.Add_KShootMania_to_start_menuCheckBox.TabIndex = 8;
            this.Add_KShootMania_to_start_menuCheckBox.Text = "Add KShootMania to the start menu";
            this.Add_KShootMania_to_start_menuCheckBox.UseVisualStyleBackColor = true;
            // 
            // Install_for_allCheckBox
            // 
            this.Install_for_allCheckBox.AutoSize = true;
            this.Install_for_allCheckBox.Location = new System.Drawing.Point(12, 226);
            this.Install_for_allCheckBox.Name = "Install_for_allCheckBox";
            this.Install_for_allCheckBox.Size = new System.Drawing.Size(238, 17);
            this.Install_for_allCheckBox.TabIndex = 9;
            this.Install_for_allCheckBox.Text = "Install for all users (admin privelages required)";
            this.Install_for_allCheckBox.UseVisualStyleBackColor = true;
            this.Install_for_allCheckBox.CheckedChanged += new System.EventHandler(this.Install_for_allCheckBox_CheckedChanged);
            // 
            // KShootMania_zip_locationLabel
            // 
            this.KShootMania_zip_locationLabel.AutoSize = true;
            this.KShootMania_zip_locationLabel.Location = new System.Drawing.Point(9, 184);
            this.KShootMania_zip_locationLabel.Name = "KShootMania_zip_locationLabel";
            this.KShootMania_zip_locationLabel.Size = new System.Drawing.Size(127, 13);
            this.KShootMania_zip_locationLabel.TabIndex = 10;
            this.KShootMania_zip_locationLabel.Text = "KShootMania zip location";
            // 
            // KShootMania_zip_locationTextBox
            // 
            this.KShootMania_zip_locationTextBox.Location = new System.Drawing.Point(12, 200);
            this.KShootMania_zip_locationTextBox.Name = "KShootMania_zip_locationTextBox";
            this.KShootMania_zip_locationTextBox.Size = new System.Drawing.Size(537, 20);
            this.KShootMania_zip_locationTextBox.TabIndex = 11;
            // 
            // KShootMania_zip_location_browseButton
            // 
            this.KShootMania_zip_location_browseButton.Location = new System.Drawing.Point(555, 198);
            this.KShootMania_zip_location_browseButton.Name = "KShootMania_zip_location_browseButton";
            this.KShootMania_zip_location_browseButton.Size = new System.Drawing.Size(26, 23);
            this.KShootMania_zip_location_browseButton.TabIndex = 12;
            this.KShootMania_zip_location_browseButton.Text = "...";
            this.KShootMania_zip_location_browseButton.UseVisualStyleBackColor = true;
            this.KShootMania_zip_location_browseButton.Click += new System.EventHandler(this.KShootMania_zip_location_browseButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // InstallButton
            // 
            this.InstallButton.Location = new System.Drawing.Point(12, 249);
            this.InstallButton.Name = "InstallButton";
            this.InstallButton.Size = new System.Drawing.Size(569, 48);
            this.InstallButton.TabIndex = 13;
            this.InstallButton.Text = "Install";
            this.InstallButton.UseVisualStyleBackColor = true;
            this.InstallButton.Click += new System.EventHandler(this.InstallButton_Click);
            // 
            // InstallForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 309);
            this.Controls.Add(this.InstallButton);
            this.Controls.Add(this.KShootMania_zip_location_browseButton);
            this.Controls.Add(this.KShootMania_zip_locationTextBox);
            this.Controls.Add(this.KShootMania_zip_locationLabel);
            this.Controls.Add(this.Install_for_allCheckBox);
            this.Controls.Add(this.Add_KShootMania_to_start_menuCheckBox);
            this.Controls.Add(this.KShootMania_install_locationLabel);
            this.Controls.Add(this.KShootMania_install_locationTextBox);
            this.Controls.Add(this.KShootMania_install_location_browseButton);
            this.Controls.Add(this.KShootMania_install_typeGroupBox);
            this.Controls.Add(this.Install_location_browseButton);
            this.Controls.Add(this.Install_locationTextBox);
            this.Controls.Add(this.Install_locationLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "InstallForm";
            this.Text = "KShootMania Skin Manager Installer";
            this.KShootMania_install_typeGroupBox.ResumeLayout(false);
            this.KShootMania_install_typeGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Install_locationLabel;
        private System.Windows.Forms.TextBox Install_locationTextBox;
        private System.Windows.Forms.Button Install_location_browseButton;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.GroupBox KShootMania_install_typeGroupBox;
        private System.Windows.Forms.RadioButton Install_with_new_KShootMania_installationRadioButton;
        private System.Windows.Forms.RadioButton Add_to_preexisting_KShootMania_installationRadioButton;
        private System.Windows.Forms.TextBox KShootMania_install_locationTextBox;
        private System.Windows.Forms.Button KShootMania_install_location_browseButton;
        private System.Windows.Forms.Label KShootMania_install_locationLabel;
        private System.Windows.Forms.CheckBox Add_KShootMania_to_start_menuCheckBox;
        private System.Windows.Forms.CheckBox Install_for_allCheckBox;
        private System.Windows.Forms.Label KShootMania_zip_locationLabel;
        private System.Windows.Forms.TextBox KShootMania_zip_locationTextBox;
        private System.Windows.Forms.Button KShootMania_zip_location_browseButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button InstallButton;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}