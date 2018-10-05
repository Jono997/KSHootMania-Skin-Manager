namespace KShootMania_Skin_Manager
{
    partial class Change_skinForm
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
            this.Skin_libraryLabel = new System.Windows.Forms.Label();
            this.Loaded_skinsLabel = new System.Windows.Forms.Label();
            this.Skin_libraryListBox = new System.Windows.Forms.ListBox();
            this.Loaded_skinsListBox = new System.Windows.Forms.ListBox();
            this.Add_skinButton = new System.Windows.Forms.Button();
            this.Remove_skinButton = new System.Windows.Forms.Button();
            this.Up_priorityButton = new System.Windows.Forms.Button();
            this.Down_priorityButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.helpButton = new System.Windows.Forms.Button();
            this.Organise_skinsButton = new System.Windows.Forms.Button();
            this.SettingsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Skin_libraryLabel
            // 
            this.Skin_libraryLabel.AutoSize = true;
            this.Skin_libraryLabel.Location = new System.Drawing.Point(12, 9);
            this.Skin_libraryLabel.Name = "Skin_libraryLabel";
            this.Skin_libraryLabel.Size = new System.Drawing.Size(58, 13);
            this.Skin_libraryLabel.TabIndex = 0;
            this.Skin_libraryLabel.Text = "Skin library";
            // 
            // Loaded_skinsLabel
            // 
            this.Loaded_skinsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Loaded_skinsLabel.AutoSize = true;
            this.Loaded_skinsLabel.Location = new System.Drawing.Point(718, 9);
            this.Loaded_skinsLabel.Name = "Loaded_skinsLabel";
            this.Loaded_skinsLabel.Size = new System.Drawing.Size(70, 13);
            this.Loaded_skinsLabel.TabIndex = 1;
            this.Loaded_skinsLabel.Text = "Loaded skins";
            // 
            // Skin_libraryListBox
            // 
            this.Skin_libraryListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Skin_libraryListBox.FormattingEnabled = true;
            this.Skin_libraryListBox.Location = new System.Drawing.Point(12, 25);
            this.Skin_libraryListBox.Name = "Skin_libraryListBox";
            this.Skin_libraryListBox.Size = new System.Drawing.Size(307, 407);
            this.Skin_libraryListBox.TabIndex = 1;
            this.Skin_libraryListBox.SelectedIndexChanged += new System.EventHandler(this.Skin_libraryListBox_SelectedIndexChanged);
            // 
            // Loaded_skinsListBox
            // 
            this.Loaded_skinsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Loaded_skinsListBox.FormattingEnabled = true;
            this.Loaded_skinsListBox.Location = new System.Drawing.Point(481, 25);
            this.Loaded_skinsListBox.Name = "Loaded_skinsListBox";
            this.Loaded_skinsListBox.Size = new System.Drawing.Size(307, 407);
            this.Loaded_skinsListBox.TabIndex = 3;
            this.Loaded_skinsListBox.SelectedIndexChanged += new System.EventHandler(this.Loaded_skinsListBox_SelectedIndexChanged);
            // 
            // Add_skinButton
            // 
            this.Add_skinButton.Enabled = false;
            this.Add_skinButton.Location = new System.Drawing.Point(325, 54);
            this.Add_skinButton.Name = "Add_skinButton";
            this.Add_skinButton.Size = new System.Drawing.Size(150, 23);
            this.Add_skinButton.TabIndex = 2;
            this.Add_skinButton.Text = "Add ->";
            this.Add_skinButton.UseVisualStyleBackColor = true;
            this.Add_skinButton.Click += new System.EventHandler(this.Add_skinButton_Click);
            // 
            // Remove_skinButton
            // 
            this.Remove_skinButton.Enabled = false;
            this.Remove_skinButton.Location = new System.Drawing.Point(325, 83);
            this.Remove_skinButton.Name = "Remove_skinButton";
            this.Remove_skinButton.Size = new System.Drawing.Size(150, 23);
            this.Remove_skinButton.TabIndex = 4;
            this.Remove_skinButton.Text = "<- Remove";
            this.Remove_skinButton.UseVisualStyleBackColor = true;
            this.Remove_skinButton.Click += new System.EventHandler(this.Remove_skinButton_Click);
            // 
            // Up_priorityButton
            // 
            this.Up_priorityButton.Enabled = false;
            this.Up_priorityButton.Location = new System.Drawing.Point(325, 112);
            this.Up_priorityButton.Name = "Up_priorityButton";
            this.Up_priorityButton.Size = new System.Drawing.Size(150, 23);
            this.Up_priorityButton.TabIndex = 5;
            this.Up_priorityButton.Text = "Increase higherarchy";
            this.Up_priorityButton.UseVisualStyleBackColor = true;
            this.Up_priorityButton.Click += new System.EventHandler(this.Up_priorityButton_Click);
            // 
            // Down_priorityButton
            // 
            this.Down_priorityButton.Enabled = false;
            this.Down_priorityButton.Location = new System.Drawing.Point(325, 141);
            this.Down_priorityButton.Name = "Down_priorityButton";
            this.Down_priorityButton.Size = new System.Drawing.Size(150, 23);
            this.Down_priorityButton.TabIndex = 6;
            this.Down_priorityButton.Text = "Decrease higherarchy";
            this.Down_priorityButton.UseVisualStyleBackColor = true;
            this.Down_priorityButton.Click += new System.EventHandler(this.Down_priorityButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(325, 228);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(150, 23);
            this.SaveButton.TabIndex = 9;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // helpButton
            // 
            this.helpButton.Location = new System.Drawing.Point(325, 25);
            this.helpButton.Name = "helpButton";
            this.helpButton.Size = new System.Drawing.Size(150, 23);
            this.helpButton.TabIndex = 0;
            this.helpButton.Text = "Help";
            this.helpButton.UseVisualStyleBackColor = true;
            this.helpButton.Click += new System.EventHandler(this.HelpButton_Click);
            // 
            // Organise_skinsButton
            // 
            this.Organise_skinsButton.Location = new System.Drawing.Point(325, 170);
            this.Organise_skinsButton.Name = "Organise_skinsButton";
            this.Organise_skinsButton.Size = new System.Drawing.Size(150, 23);
            this.Organise_skinsButton.TabIndex = 7;
            this.Organise_skinsButton.Text = "Organise skins";
            this.Organise_skinsButton.UseVisualStyleBackColor = true;
            this.Organise_skinsButton.Click += new System.EventHandler(this.Organise_skinsButton_Click);
            // 
            // SettingsButton
            // 
            this.SettingsButton.Location = new System.Drawing.Point(325, 199);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.Size = new System.Drawing.Size(150, 23);
            this.SettingsButton.TabIndex = 8;
            this.SettingsButton.Text = "Settings";
            this.SettingsButton.UseVisualStyleBackColor = true;
            this.SettingsButton.Click += new System.EventHandler(this.SettingsButton_Click);
            // 
            // Change_skinForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SettingsButton);
            this.Controls.Add(this.Organise_skinsButton);
            this.Controls.Add(this.helpButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.Down_priorityButton);
            this.Controls.Add(this.Up_priorityButton);
            this.Controls.Add(this.Remove_skinButton);
            this.Controls.Add(this.Add_skinButton);
            this.Controls.Add(this.Loaded_skinsListBox);
            this.Controls.Add(this.Skin_libraryListBox);
            this.Controls.Add(this.Loaded_skinsLabel);
            this.Controls.Add(this.Skin_libraryLabel);
            this.MinimumSize = new System.Drawing.Size(440, 240);
            this.Name = "Change_skinForm";
            this.Text = "KShootMania Skin Manager";
            this.SizeChanged += new System.EventHandler(this.Change_skinForm_SizeChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Skin_libraryLabel;
        private System.Windows.Forms.Label Loaded_skinsLabel;
        private System.Windows.Forms.ListBox Skin_libraryListBox;
        private System.Windows.Forms.ListBox Loaded_skinsListBox;
        private System.Windows.Forms.Button Add_skinButton;
        private System.Windows.Forms.Button Remove_skinButton;
        private System.Windows.Forms.Button Up_priorityButton;
        private System.Windows.Forms.Button Down_priorityButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button helpButton;
        private System.Windows.Forms.Button Organise_skinsButton;
        private System.Windows.Forms.Button SettingsButton;
    }
}