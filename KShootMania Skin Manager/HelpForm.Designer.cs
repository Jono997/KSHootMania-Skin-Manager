namespace KShootMania_Skin_Manager
{
    partial class HelpForm
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
            System.Windows.Forms.TreeNode treeNode34 = new System.Windows.Forms.TreeNode("What is KShootMania?");
            System.Windows.Forms.TreeNode treeNode35 = new System.Windows.Forms.TreeNode("What is KShootMania Skin Manager", new System.Windows.Forms.TreeNode[] {
            treeNode34});
            System.Windows.Forms.TreeNode treeNode36 = new System.Windows.Forms.TreeNode("Installation");
            System.Windows.Forms.TreeNode treeNode37 = new System.Windows.Forms.TreeNode("Skin hierarchy");
            System.Windows.Forms.TreeNode treeNode38 = new System.Windows.Forms.TreeNode("Installing additional skins");
            System.Windows.Forms.TreeNode treeNode39 = new System.Windows.Forms.TreeNode("How to use KShootMania Skin Manager", new System.Windows.Forms.TreeNode[] {
            treeNode36,
            treeNode37,
            treeNode38});
            System.Windows.Forms.TreeNode treeNode40 = new System.Windows.Forms.TreeNode("General", new System.Windows.Forms.TreeNode[] {
            treeNode35,
            treeNode39});
            System.Windows.Forms.TreeNode treeNode41 = new System.Windows.Forms.TreeNode("Moving KShootMania after installation");
            System.Windows.Forms.TreeNode treeNode42 = new System.Windows.Forms.TreeNode("Moving KShootMania Skin Manager after installation");
            System.Windows.Forms.TreeNode treeNode43 = new System.Windows.Forms.TreeNode("Uninstalling KShootMania Skin Manager");
            System.Windows.Forms.TreeNode treeNode44 = new System.Windows.Forms.TreeNode("System", new System.Windows.Forms.TreeNode[] {
            treeNode41,
            treeNode42,
            treeNode43});
            this.TopicsTreeView = new System.Windows.Forms.TreeView();
            this.TopicLabel = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // TopicsTreeView
            // 
            this.TopicsTreeView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.TopicsTreeView.Location = new System.Drawing.Point(12, 12);
            this.TopicsTreeView.Name = "TopicsTreeView";
            treeNode34.Name = "What is KShootMania?";
            treeNode34.Text = "What is KShootMania?";
            treeNode35.Name = "What is KShootMania Skin Manager";
            treeNode35.Text = "What is KShootMania Skin Manager";
            treeNode36.Name = "Installation";
            treeNode36.Text = "Installation";
            treeNode37.Name = "Skin hierarchy";
            treeNode37.Text = "Skin hierarchy";
            treeNode38.Name = "Installing additional skins";
            treeNode38.Text = "Installing additional skins";
            treeNode39.Name = "How to use KShootMania Skin Manager";
            treeNode39.Text = "How to use KShootMania Skin Manager";
            treeNode40.Name = "General";
            treeNode40.Text = "General";
            treeNode41.Name = "Moving KShootMania after installation";
            treeNode41.Text = "Moving KShootMania after installation";
            treeNode42.Name = "Moving KShootMania Skin Manager after installation";
            treeNode42.Text = "Moving KShootMania Skin Manager after installation";
            treeNode43.Name = "Uninstalling KShootMania Skin Manager";
            treeNode43.Text = "Uninstalling KShootMania Skin Manager";
            treeNode44.Name = "System";
            treeNode44.Text = "System";
            this.TopicsTreeView.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode40,
            treeNode44});
            this.TopicsTreeView.Size = new System.Drawing.Size(299, 426);
            this.TopicsTreeView.TabIndex = 0;
            this.TopicsTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TopicsTreeView_AfterSelect);
            // 
            // TopicLabel
            // 
            this.TopicLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TopicLabel.LinkArea = new System.Windows.Forms.LinkArea(0, 0);
            this.TopicLabel.Location = new System.Drawing.Point(317, 9);
            this.TopicLabel.Name = "TopicLabel";
            this.TopicLabel.Size = new System.Drawing.Size(535, 432);
            this.TopicLabel.TabIndex = 1;
            this.TopicLabel.Text = "Select a topic to view it\'s information";
            this.TopicLabel.VisitedLinkColor = System.Drawing.Color.Blue;
            this.TopicLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.TopicLabel_LinkClicked);
            // 
            // HelpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 450);
            this.Controls.Add(this.TopicLabel);
            this.Controls.Add(this.TopicsTreeView);
            this.MinimumSize = new System.Drawing.Size(535, 260);
            this.Name = "HelpForm";
            this.Text = "KShootMania Skin Manager Help";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView TopicsTreeView;
        private System.Windows.Forms.LinkLabel TopicLabel;
    }
}