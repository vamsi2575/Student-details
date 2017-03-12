namespace studentdetails
{
    partial class Form2
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode(".NET");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("c#");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("windows", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("python");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Linux", new System.Windows.Forms.TreeNode[] {
            treeNode4});
            this.Department = new System.Windows.Forms.ListBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // Department
            // 
            this.Department.FormattingEnabled = true;
            this.Department.Items.AddRange(new object[] {
            "ICT",
            "CSE",
            "MECH",
            "ECE"});
            this.Department.Location = new System.Drawing.Point(12, 82);
            this.Department.Name = "Department";
            this.Department.Size = new System.Drawing.Size(163, 160);
            this.Department.TabIndex = 0;
            this.Department.SelectedIndexChanged += new System.EventHandler(this.Department_SelectedIndexChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(12, 38);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.ShowUpDown = true;
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(199, 82);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Node1";
            treeNode1.Text = ".NET";
            treeNode2.Name = "Node2";
            treeNode2.Text = "c#";
            treeNode3.Name = "windows";
            treeNode3.Text = "windows";
            treeNode4.Name = "Node4";
            treeNode4.Text = "python";
            treeNode5.Name = "Node3";
            treeNode5.Text = "Linux";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode5});
            this.treeView1.Size = new System.Drawing.Size(163, 160);
            this.treeView1.TabIndex = 2;
            this.treeView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.treeView1_MouseDoubleClick);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 312);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.Department);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox Department;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TreeView treeView1;
    }
}