namespace KShootMania_Skin_Manager
{
    partial class SetupForm
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
            this.KSM_install_locationLabel = new System.Windows.Forms.Label();
            this.KSM_install_locationTextBox = new System.Windows.Forms.TextBox();
            this.KSM_install_locationButton = new System.Windows.Forms.Button();
            this.KSM_install_locationFolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.Zip_fileTextBox = new System.Windows.Forms.TextBox();
            this.Zip_fileButton = new System.Windows.Forms.Button();
            this.Zip_fileOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.Begin_setupButton = new System.Windows.Forms.Button();
            this.Install_for_allCheckBox = new System.Windows.Forms.CheckBox();
            this.Zip_fileLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // KSM_install_locationLabel
            // 
            this.KSM_install_locationLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.KSM_install_locationLabel.AutoSize = true;
            this.KSM_install_locationLabel.Location = new System.Drawing.Point(12, 9);
            this.KSM_install_locationLabel.Name = "KSM_install_locationLabel";
            this.KSM_install_locationLabel.Size = new System.Drawing.Size(141, 13);
            this.KSM_install_locationLabel.TabIndex = 0;
            this.KSM_install_locationLabel.Text = "KShootMania Install location";
            // 
            // KSM_install_locationTextBox
            // 
            this.KSM_install_locationTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.KSM_install_locationTextBox.Location = new System.Drawing.Point(12, 25);
            this.KSM_install_locationTextBox.Name = "KSM_install_locationTextBox";
            this.KSM_install_locationTextBox.Size = new System.Drawing.Size(695, 20);
            this.KSM_install_locationTextBox.TabIndex = 1;
            // 
            // KSM_install_locationButton
            // 
            this.KSM_install_locationButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.KSM_install_locationButton.Location = new System.Drawing.Point(713, 23);
            this.KSM_install_locationButton.Name = "KSM_install_locationButton";
            this.KSM_install_locationButton.Size = new System.Drawing.Size(75, 23);
            this.KSM_install_locationButton.TabIndex = 2;
            this.KSM_install_locationButton.Text = "Browse";
            this.KSM_install_locationButton.UseVisualStyleBackColor = true;
            this.KSM_install_locationButton.Click += new System.EventHandler(this.KSM_install_locationButton_Click);
            // 
            // Zip_fileTextBox
            // 
            this.Zip_fileTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Zip_fileTextBox.Location = new System.Drawing.Point(12, 64);
            this.Zip_fileTextBox.Name = "Zip_fileTextBox";
            this.Zip_fileTextBox.Size = new System.Drawing.Size(695, 20);
            this.Zip_fileTextBox.TabIndex = 1;
            // 
            // Zip_fileButton
            // 
            this.Zip_fileButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Zip_fileButton.Location = new System.Drawing.Point(713, 62);
            this.Zip_fileButton.Name = "Zip_fileButton";
            this.Zip_fileButton.Size = new System.Drawing.Size(75, 23);
            this.Zip_fileButton.TabIndex = 0;
            this.Zip_fileButton.Text = "Browse";
            this.Zip_fileButton.UseVisualStyleBackColor = true;
            this.Zip_fileButton.Click += new System.EventHandler(this.Zip_fileButton_Click);
            // 
            // Zip_fileOpenFileDialog
            // 
            this.Zip_fileOpenFileDialog.DefaultExt = "zip";
            this.Zip_fileOpenFileDialog.FileName = "kshootmania_v164e.zip";
            // 
            // Begin_setupButton
            // 
            this.Begin_setupButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Begin_setupButton.Location = new System.Drawing.Point(12, 115);
            this.Begin_setupButton.Name = "Begin_setupButton";
            this.Begin_setupButton.Size = new System.Drawing.Size(776, 50);
            this.Begin_setupButton.TabIndex = 4;
            this.Begin_setupButton.Text = "Done";
            this.Begin_setupButton.UseVisualStyleBackColor = true;
            this.Begin_setupButton.Click += new System.EventHandler(this.Begin_setupButton_Click);
            // 
            // Install_for_allCheckBox
            // 
            this.Install_for_allCheckBox.AutoSize = true;
            this.Install_for_allCheckBox.Location = new System.Drawing.Point(12, 90);
            this.Install_for_allCheckBox.Name = "Install_for_allCheckBox";
            this.Install_for_allCheckBox.Size = new System.Drawing.Size(244, 17);
            this.Install_for_allCheckBox.TabIndex = 5;
            this.Install_for_allCheckBox.Text = "Install for everyone (admin privelages required)";
            this.Install_for_allCheckBox.UseVisualStyleBackColor = true;
            this.Install_for_allCheckBox.CheckedChanged += new System.EventHandler(this.Install_for_allCheckBox_CheckedChanged);
            // 
            // Zip_fileLabel
            // 
            this.Zip_fileLabel.AutoSize = true;
            this.Zip_fileLabel.Location = new System.Drawing.Point(12, 48);
            this.Zip_fileLabel.Name = "Zip_fileLabel";
            this.Zip_fileLabel.Size = new System.Drawing.Size(154, 13);
            this.Zip_fileLabel.TabIndex = 6;
            this.Zip_fileLabel.Text = "Location of KSM installation zip";
            // 
            // SetupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 177);
            this.Controls.Add(this.Zip_fileLabel);
            this.Controls.Add(this.Zip_fileTextBox);
            this.Controls.Add(this.Zip_fileButton);
            this.Controls.Add(this.Install_for_allCheckBox);
            this.Controls.Add(this.Begin_setupButton);
            this.Controls.Add(this.KSM_install_locationButton);
            this.Controls.Add(this.KSM_install_locationTextBox);
            this.Controls.Add(this.KSM_install_locationLabel);
            this.Name = "SetupForm";
            this.Text = "KShootMania Skin Manager setup";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label KSM_install_locationLabel;
        private System.Windows.Forms.TextBox KSM_install_locationTextBox;
        private System.Windows.Forms.Button KSM_install_locationButton;
        private System.Windows.Forms.FolderBrowserDialog KSM_install_locationFolderBrowserDialog;
        private System.Windows.Forms.TextBox Zip_fileTextBox;
        private System.Windows.Forms.Button Zip_fileButton;
        private System.Windows.Forms.OpenFileDialog Zip_fileOpenFileDialog;
        private System.Windows.Forms.Button Begin_setupButton;
        private System.Windows.Forms.CheckBox Install_for_allCheckBox;
        private System.Windows.Forms.Label Zip_fileLabel;
    }
}

