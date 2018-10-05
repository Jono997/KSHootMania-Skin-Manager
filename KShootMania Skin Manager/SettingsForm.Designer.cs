namespace KShootMania_Skin_Manager
{
    partial class SettingsForm
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
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.Hierarchy_arrangemenGroupBox = new System.Windows.Forms.GroupBox();
            this.Show_heirarchy_descendingRadioButton = new System.Windows.Forms.RadioButton();
            this.Show_hierarchy_ascendingButton = new System.Windows.Forms.RadioButton();
            this.Change_skinButton_positionRadioButton = new System.Windows.Forms.GroupBox();
            this.Top_leftRadioButton = new System.Windows.Forms.RadioButton();
            this.Top_rightRadioButton = new System.Windows.Forms.RadioButton();
            this.Bottom_leftRadioButton = new System.Windows.Forms.RadioButton();
            this.Bottom_rightRadioButton = new System.Windows.Forms.RadioButton();
            this.SaveButton = new System.Windows.Forms.Button();
            this.Hierarchy_arrangemenGroupBox.SuspendLayout();
            this.Change_skinButton_positionRadioButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // Hierarchy_arrangemenGroupBox
            // 
            this.Hierarchy_arrangemenGroupBox.Controls.Add(this.Show_heirarchy_descendingRadioButton);
            this.Hierarchy_arrangemenGroupBox.Controls.Add(this.Show_hierarchy_ascendingButton);
            this.Hierarchy_arrangemenGroupBox.Location = new System.Drawing.Point(12, 12);
            this.Hierarchy_arrangemenGroupBox.Name = "Hierarchy_arrangemenGroupBox";
            this.Hierarchy_arrangemenGroupBox.Size = new System.Drawing.Size(102, 69);
            this.Hierarchy_arrangemenGroupBox.TabIndex = 0;
            this.Hierarchy_arrangemenGroupBox.TabStop = false;
            this.Hierarchy_arrangemenGroupBox.Text = "Hierarchy";
            this.toolTip1.SetToolTip(this.Hierarchy_arrangemenGroupBox, "How selected skins are arranged according to their position in the hierarchy");
            // 
            // Show_heirarchy_descendingRadioButton
            // 
            this.Show_heirarchy_descendingRadioButton.AutoSize = true;
            this.Show_heirarchy_descendingRadioButton.Location = new System.Drawing.Point(6, 42);
            this.Show_heirarchy_descendingRadioButton.Name = "Show_heirarchy_descendingRadioButton";
            this.Show_heirarchy_descendingRadioButton.Size = new System.Drawing.Size(82, 17);
            this.Show_heirarchy_descendingRadioButton.TabIndex = 1;
            this.Show_heirarchy_descendingRadioButton.TabStop = true;
            this.Show_heirarchy_descendingRadioButton.Text = "Descending";
            this.toolTip1.SetToolTip(this.Show_heirarchy_descendingRadioButton, "Skins higher in the hierarchy will appear at the bottom of the list");
            this.Show_heirarchy_descendingRadioButton.UseVisualStyleBackColor = true;
            // 
            // Show_hierarchy_ascendingButton
            // 
            this.Show_hierarchy_ascendingButton.AutoSize = true;
            this.Show_hierarchy_ascendingButton.Location = new System.Drawing.Point(6, 19);
            this.Show_hierarchy_ascendingButton.Name = "Show_hierarchy_ascendingButton";
            this.Show_hierarchy_ascendingButton.Size = new System.Drawing.Size(75, 17);
            this.Show_hierarchy_ascendingButton.TabIndex = 0;
            this.Show_hierarchy_ascendingButton.TabStop = true;
            this.Show_hierarchy_ascendingButton.Text = "Ascending";
            this.toolTip1.SetToolTip(this.Show_hierarchy_ascendingButton, "(Default) Skins higher in the hierarchy will appear at the top of the list");
            this.Show_hierarchy_ascendingButton.UseVisualStyleBackColor = true;
            // 
            // Change_skinButton_positionRadioButton
            // 
            this.Change_skinButton_positionRadioButton.Controls.Add(this.Bottom_rightRadioButton);
            this.Change_skinButton_positionRadioButton.Controls.Add(this.Bottom_leftRadioButton);
            this.Change_skinButton_positionRadioButton.Controls.Add(this.Top_rightRadioButton);
            this.Change_skinButton_positionRadioButton.Controls.Add(this.Top_leftRadioButton);
            this.Change_skinButton_positionRadioButton.Location = new System.Drawing.Point(120, 12);
            this.Change_skinButton_positionRadioButton.Name = "Change_skinButton_positionRadioButton";
            this.Change_skinButton_positionRadioButton.Size = new System.Drawing.Size(176, 69);
            this.Change_skinButton_positionRadioButton.TabIndex = 1;
            this.Change_skinButton_positionRadioButton.TabStop = false;
            this.Change_skinButton_positionRadioButton.Text = "Change skin button position";
            this.toolTip1.SetToolTip(this.Change_skinButton_positionRadioButton, "The corner the change skin button will appear in");
            // 
            // Top_leftRadioButton
            // 
            this.Top_leftRadioButton.AutoSize = true;
            this.Top_leftRadioButton.Location = new System.Drawing.Point(6, 19);
            this.Top_leftRadioButton.Name = "Top_leftRadioButton";
            this.Top_leftRadioButton.Size = new System.Drawing.Size(61, 17);
            this.Top_leftRadioButton.TabIndex = 0;
            this.Top_leftRadioButton.TabStop = true;
            this.Top_leftRadioButton.Text = "Top-left";
            this.Top_leftRadioButton.UseVisualStyleBackColor = true;
            // 
            // Top_rightRadioButton
            // 
            this.Top_rightRadioButton.AutoSize = true;
            this.Top_rightRadioButton.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Top_rightRadioButton.Location = new System.Drawing.Point(101, 19);
            this.Top_rightRadioButton.Name = "Top_rightRadioButton";
            this.Top_rightRadioButton.Size = new System.Drawing.Size(67, 17);
            this.Top_rightRadioButton.TabIndex = 1;
            this.Top_rightRadioButton.TabStop = true;
            this.Top_rightRadioButton.Text = "Top-right";
            this.toolTip1.SetToolTip(this.Top_rightRadioButton, "(Default) This one may cover up the tweet button in fullscreen mode");
            this.Top_rightRadioButton.UseVisualStyleBackColor = true;
            // 
            // Bottom_leftRadioButton
            // 
            this.Bottom_leftRadioButton.AutoSize = true;
            this.Bottom_leftRadioButton.Location = new System.Drawing.Point(6, 42);
            this.Bottom_leftRadioButton.Name = "Bottom_leftRadioButton";
            this.Bottom_leftRadioButton.Size = new System.Drawing.Size(75, 17);
            this.Bottom_leftRadioButton.TabIndex = 2;
            this.Bottom_leftRadioButton.TabStop = true;
            this.Bottom_leftRadioButton.Text = "Bottom-left";
            this.Bottom_leftRadioButton.UseVisualStyleBackColor = true;
            // 
            // Bottom_rightRadioButton
            // 
            this.Bottom_rightRadioButton.AutoSize = true;
            this.Bottom_rightRadioButton.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Bottom_rightRadioButton.Location = new System.Drawing.Point(87, 42);
            this.Bottom_rightRadioButton.Name = "Bottom_rightRadioButton";
            this.Bottom_rightRadioButton.Size = new System.Drawing.Size(81, 17);
            this.Bottom_rightRadioButton.TabIndex = 3;
            this.Bottom_rightRadioButton.TabStop = true;
            this.Bottom_rightRadioButton.Text = "Bottom-right";
            this.Bottom_rightRadioButton.UseVisualStyleBackColor = true;
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(12, 87);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(282, 41);
            this.SaveButton.TabIndex = 2;
            this.SaveButton.Text = "Save settings";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 140);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.Change_skinButton_positionRadioButton);
            this.Controls.Add(this.Hierarchy_arrangemenGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SettingsForm";
            this.Text = "KSM Skin Manager settings";
            this.Hierarchy_arrangemenGroupBox.ResumeLayout(false);
            this.Hierarchy_arrangemenGroupBox.PerformLayout();
            this.Change_skinButton_positionRadioButton.ResumeLayout(false);
            this.Change_skinButton_positionRadioButton.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.GroupBox Hierarchy_arrangemenGroupBox;
        private System.Windows.Forms.RadioButton Show_heirarchy_descendingRadioButton;
        private System.Windows.Forms.RadioButton Show_hierarchy_ascendingButton;
        private System.Windows.Forms.GroupBox Change_skinButton_positionRadioButton;
        private System.Windows.Forms.RadioButton Bottom_rightRadioButton;
        private System.Windows.Forms.RadioButton Bottom_leftRadioButton;
        private System.Windows.Forms.RadioButton Top_rightRadioButton;
        private System.Windows.Forms.RadioButton Top_leftRadioButton;
        private System.Windows.Forms.Button SaveButton;
    }
}