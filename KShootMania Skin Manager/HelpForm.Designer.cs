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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("What is KShootMania?");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("What is KShootMania Skin Manager", new System.Windows.Forms.TreeNode[] {
            treeNode1});
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Installation");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Skin hierarchy");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Installing additional skins");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Settings.ini breakdown");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Settings", new System.Windows.Forms.TreeNode[] {
            treeNode6});
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("How to use KShootMania Skin Manager", new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode4,
            treeNode5,
            treeNode7});
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("General", new System.Windows.Forms.TreeNode[] {
            treeNode2,
            treeNode8});
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Moving KShootMania after installation");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Moving KShootMania Skin Manager after installation");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Uninstalling KShootMania Skin Manager");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("System", new System.Windows.Forms.TreeNode[] {
            treeNode10,
            treeNode11,
            treeNode12});
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
            treeNode1.Name = "What is KShootMania?";
            treeNode1.Text = "What is KShootMania?";
            treeNode2.Name = "What is KShootMania Skin Manager";
            treeNode2.Text = "What is KShootMania Skin Manager";
            treeNode3.Name = "Installation";
            treeNode3.Text = "Installation";
            treeNode4.Name = "Skin hierarchy";
            treeNode4.Text = "Skin hierarchy";
            treeNode5.Name = "Installing additional skins";
            treeNode5.Text = "Installing additional skins";
            treeNode6.Name = "Settings.ini breakdown";
            treeNode6.Text = "Settings.ini breakdown";
            treeNode7.Name = "Settings";
            treeNode7.Text = "Settings";
            treeNode8.Name = "How to use KShootMania Skin Manager";
            treeNode8.Text = "How to use KShootMania Skin Manager";
            treeNode9.Name = "General";
            treeNode9.Text = "General";
            treeNode10.Name = "Moving KShootMania after installation";
            treeNode10.Text = "Moving KShootMania after installation";
            treeNode11.Name = "Moving KShootMania Skin Manager after installation";
            treeNode11.Text = "Moving KShootMania Skin Manager after installation";
            treeNode12.Name = "Uninstalling KShootMania Skin Manager";
            treeNode12.Text = "Uninstalling KShootMania Skin Manager";
            treeNode13.Name = "System";
            treeNode13.Text = "System";
            this.TopicsTreeView.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode9,
            treeNode13});
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