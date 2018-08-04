namespace KSM_Skin_Manager_Help
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
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("How to use KShootMania Skin Manager", new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode4,
            treeNode5});
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("General", new System.Windows.Forms.TreeNode[] {
            treeNode2,
            treeNode6});
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Moving KShootMania after installation");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Moving KShootMania Skin Manager after installation");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Uninstalling KShootMania Skin Manager");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("System", new System.Windows.Forms.TreeNode[] {
            treeNode8,
            treeNode9,
            treeNode10});
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
            treeNode6.Name = "How to use KShootMania Skin Manager";
            treeNode6.Text = "How to use KShootMania Skin Manager";
            treeNode7.Name = "General";
            treeNode7.Text = "General";
            treeNode8.Name = "Moving KShootMania after installation";
            treeNode8.Text = "Moving KShootMania after installation";
            treeNode9.Name = "Moving KShootMania Skin Manager after installation";
            treeNode9.Text = "Moving KShootMania Skin Manager after installation";
            treeNode10.Name = "Uninstalling KShootMania Skin Manager";
            treeNode10.Text = "Uninstalling KShootMania Skin Manager";
            treeNode11.Name = "System";
            treeNode11.Text = "System";
            this.TopicsTreeView.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode7,
            treeNode11});
            this.TopicsTreeView.Size = new System.Drawing.Size(238, 426);
            this.TopicsTreeView.TabIndex = 0;
            this.TopicsTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TopicsTreeView_AfterSelect);
            // 
            // TopicLabel
            // 
            this.TopicLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TopicLabel.LinkArea = new System.Windows.Forms.LinkArea(0, 0);
            this.TopicLabel.Location = new System.Drawing.Point(256, 12);
            this.TopicLabel.Name = "TopicLabel";
            this.TopicLabel.Size = new System.Drawing.Size(532, 426);
            this.TopicLabel.TabIndex = 1;
            this.TopicLabel.Text = "Select a topic to view it\'s information";
            this.TopicLabel.VisitedLinkColor = System.Drawing.Color.Blue;
            this.TopicLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.TopicLabel_LinkClicked);
            // 
            // HelpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TopicLabel);
            this.Controls.Add(this.TopicsTreeView);
            this.Name = "HelpForm";
            this.Text = "KShootMania Skin Manager Help";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView TopicsTreeView;
        private System.Windows.Forms.LinkLabel TopicLabel;
    }
}