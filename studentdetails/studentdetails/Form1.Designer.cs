namespace studentdetails
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxname = new System.Windows.Forms.TextBox();
            this.textBoxregno = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBoxcomp = new System.Windows.Forms.CheckBox();
            this.checkBoxds = new System.Windows.Forms.CheckBox();
            this.checkBoxjava = new System.Windows.Forms.CheckBox();
            this.checkBoxdbms = new System.Windows.Forms.CheckBox();
            this.cmdsubmit = new System.Windows.Forms.Button();
            this.comboBoxsem = new System.Windows.Forms.ComboBox();
            this.comboBoxbranch = new System.Windows.Forms.ComboBox();
            this.groupBoxgender = new System.Windows.Forms.GroupBox();
            this.radioButtonfemale = new System.Windows.Forms.RadioButton();
            this.radioButtonmale = new System.Windows.Forms.RadioButton();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.cmdnext = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.groupBox1.SuspendLayout();
            this.groupBoxgender.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "NAME";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "REG.NO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "SEM";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "BRANCH";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // textBoxname
            // 
            this.textBoxname.Location = new System.Drawing.Point(91, 36);
            this.textBoxname.Name = "textBoxname";
            this.textBoxname.Size = new System.Drawing.Size(100, 20);
            this.textBoxname.TabIndex = 4;
            this.toolTip1.SetToolTip(this.textBoxname, "enter ur name");
            this.textBoxname.TextChanged += new System.EventHandler(this.textBoxname_TextChanged);
            // 
            // textBoxregno
            // 
            this.textBoxregno.Location = new System.Drawing.Point(91, 72);
            this.textBoxregno.Name = "textBoxregno";
            this.textBoxregno.Size = new System.Drawing.Size(100, 20);
            this.textBoxregno.TabIndex = 5;
            this.toolTip1.SetToolTip(this.textBoxregno, "enter ur registration number");
            this.textBoxregno.TextChanged += new System.EventHandler(this.textBoxregno_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBoxcomp);
            this.groupBox1.Controls.Add(this.checkBoxds);
            this.groupBox1.Controls.Add(this.checkBoxjava);
            this.groupBox1.Controls.Add(this.checkBoxdbms);
            this.groupBox1.Location = new System.Drawing.Point(356, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(269, 140);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "COURSE";
            this.toolTip1.SetToolTip(this.groupBox1, "select courses");
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // checkBoxcomp
            // 
            this.checkBoxcomp.AutoSize = true;
            this.checkBoxcomp.Location = new System.Drawing.Point(144, 32);
            this.checkBoxcomp.Name = "checkBoxcomp";
            this.checkBoxcomp.Size = new System.Drawing.Size(57, 17);
            this.checkBoxcomp.TabIndex = 3;
            this.checkBoxcomp.Text = "COMP";
            this.checkBoxcomp.UseVisualStyleBackColor = true;
            this.checkBoxcomp.CheckedChanged += new System.EventHandler(this.checkBoxcomp_CheckedChanged);
            // 
            // checkBoxds
            // 
            this.checkBoxds.AutoSize = true;
            this.checkBoxds.Location = new System.Drawing.Point(15, 99);
            this.checkBoxds.Name = "checkBoxds";
            this.checkBoxds.Size = new System.Drawing.Size(41, 17);
            this.checkBoxds.TabIndex = 2;
            this.checkBoxds.Text = "DS";
            this.checkBoxds.UseVisualStyleBackColor = true;
            this.checkBoxds.CheckedChanged += new System.EventHandler(this.checkBoxds_CheckedChanged);
            // 
            // checkBoxjava
            // 
            this.checkBoxjava.AutoSize = true;
            this.checkBoxjava.Location = new System.Drawing.Point(15, 65);
            this.checkBoxjava.Name = "checkBoxjava";
            this.checkBoxjava.Size = new System.Drawing.Size(52, 17);
            this.checkBoxjava.TabIndex = 1;
            this.checkBoxjava.Text = "JAVA";
            this.checkBoxjava.UseVisualStyleBackColor = true;
            this.checkBoxjava.CheckedChanged += new System.EventHandler(this.checkBoxjava_CheckedChanged);
            // 
            // checkBoxdbms
            // 
            this.checkBoxdbms.AutoSize = true;
            this.checkBoxdbms.Location = new System.Drawing.Point(15, 32);
            this.checkBoxdbms.Name = "checkBoxdbms";
            this.checkBoxdbms.Size = new System.Drawing.Size(57, 17);
            this.checkBoxdbms.TabIndex = 0;
            this.checkBoxdbms.Text = "DBMS";
            this.checkBoxdbms.UseVisualStyleBackColor = true;
            this.checkBoxdbms.CheckedChanged += new System.EventHandler(this.checkBoxdbms_CheckedChanged);
            // 
            // cmdsubmit
            // 
            this.cmdsubmit.Location = new System.Drawing.Point(387, 240);
            this.cmdsubmit.Name = "cmdsubmit";
            this.cmdsubmit.Size = new System.Drawing.Size(106, 28);
            this.cmdsubmit.TabIndex = 9;
            this.cmdsubmit.Text = "Submit";
            this.toolTip1.SetToolTip(this.cmdsubmit, "click on submit to view details");
            this.cmdsubmit.UseVisualStyleBackColor = true;
            this.cmdsubmit.Click += new System.EventHandler(this.cmdsubmit_Click);
            // 
            // comboBoxsem
            // 
            this.comboBoxsem.FormattingEnabled = true;
            this.comboBoxsem.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.comboBoxsem.Location = new System.Drawing.Point(91, 105);
            this.comboBoxsem.Name = "comboBoxsem";
            this.comboBoxsem.Size = new System.Drawing.Size(100, 21);
            this.comboBoxsem.TabIndex = 10;
            this.toolTip1.SetToolTip(this.comboBoxsem, "select semister");
            this.comboBoxsem.SelectedIndexChanged += new System.EventHandler(this.comboBoxsem_SelectedIndexChanged);
            // 
            // comboBoxbranch
            // 
            this.comboBoxbranch.FormattingEnabled = true;
            this.comboBoxbranch.Items.AddRange(new object[] {
            "ICT",
            "CSE",
            "ECE",
            "EEE",
            "MECH"});
            this.comboBoxbranch.Location = new System.Drawing.Point(91, 139);
            this.comboBoxbranch.Name = "comboBoxbranch";
            this.comboBoxbranch.Size = new System.Drawing.Size(100, 21);
            this.comboBoxbranch.TabIndex = 11;
            this.toolTip1.SetToolTip(this.comboBoxbranch, "select ur branch");
            this.comboBoxbranch.SelectedIndexChanged += new System.EventHandler(this.comboBoxbranch_SelectedIndexChanged);
            // 
            // groupBoxgender
            // 
            this.groupBoxgender.Controls.Add(this.radioButtonfemale);
            this.groupBoxgender.Controls.Add(this.radioButtonmale);
            this.groupBoxgender.Location = new System.Drawing.Point(31, 213);
            this.groupBoxgender.Name = "groupBoxgender";
            this.groupBoxgender.Size = new System.Drawing.Size(191, 55);
            this.groupBoxgender.TabIndex = 12;
            this.groupBoxgender.TabStop = false;
            this.groupBoxgender.Text = "Gender";
            this.toolTip1.SetToolTip(this.groupBoxgender, "select ur gender");
            this.groupBoxgender.Enter += new System.EventHandler(this.groupBoxgender_Enter);
            // 
            // radioButtonfemale
            // 
            this.radioButtonfemale.AutoSize = true;
            this.radioButtonfemale.Location = new System.Drawing.Point(98, 20);
            this.radioButtonfemale.Name = "radioButtonfemale";
            this.radioButtonfemale.Size = new System.Drawing.Size(56, 17);
            this.radioButtonfemale.TabIndex = 1;
            this.radioButtonfemale.TabStop = true;
            this.radioButtonfemale.Text = "female";
            this.radioButtonfemale.UseVisualStyleBackColor = true;
            this.radioButtonfemale.CheckedChanged += new System.EventHandler(this.radioButtonfemale_CheckedChanged);
            // 
            // radioButtonmale
            // 
            this.radioButtonmale.AutoSize = true;
            this.radioButtonmale.Location = new System.Drawing.Point(20, 19);
            this.radioButtonmale.Name = "radioButtonmale";
            this.radioButtonmale.Size = new System.Drawing.Size(47, 17);
            this.radioButtonmale.TabIndex = 0;
            this.radioButtonmale.TabStop = true;
            this.radioButtonmale.Text = "male";
            this.radioButtonmale.UseVisualStyleBackColor = true;
            this.radioButtonmale.CheckedChanged += new System.EventHandler(this.radioButtonmale_CheckedChanged);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(31, 285);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(123, 23);
            this.progressBar1.TabIndex = 13;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // cmdnext
            // 
            this.cmdnext.Location = new System.Drawing.Point(528, 240);
            this.cmdnext.Name = "cmdnext";
            this.cmdnext.Size = new System.Drawing.Size(97, 28);
            this.cmdnext.TabIndex = 14;
            this.cmdnext.Text = "Next";
            this.toolTip1.SetToolTip(this.cmdnext, "click to proceed");
            this.cmdnext.UseVisualStyleBackColor = true;
            this.cmdnext.Click += new System.EventHandler(this.cmdnext_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel2,
            this.toolStripLabel1,
            this.toolStripSeparator1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 327);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(647, 25);
            this.toolStrip1.TabIndex = 15;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(43, 22);
            this.toolStripLabel2.Text = "HELLO";
            this.toolStripLabel2.Click += new System.EventHandler(this.toolStripLabel2_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(86, 22);
            this.toolStripLabel1.Text = "toolStripLabel1";
            this.toolStripLabel1.Click += new System.EventHandler(this.toolStripLabel1_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            // 
            // toolStrip2
            // 
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(647, 25);
            this.toolStrip2.TabIndex = 16;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 352);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.cmdnext);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.groupBoxgender);
            this.Controls.Add(this.comboBoxbranch);
            this.Controls.Add(this.comboBoxsem);
            this.Controls.Add(this.cmdsubmit);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBoxregno);
            this.Controls.Add(this.textBoxname);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxgender.ResumeLayout(false);
            this.groupBoxgender.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxname;
        private System.Windows.Forms.TextBox textBoxregno;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBoxcomp;
        private System.Windows.Forms.CheckBox checkBoxds;
        private System.Windows.Forms.CheckBox checkBoxjava;
        private System.Windows.Forms.CheckBox checkBoxdbms;
        private System.Windows.Forms.Button cmdsubmit;
        private System.Windows.Forms.ComboBox comboBoxsem;
        private System.Windows.Forms.ComboBox comboBoxbranch;
        private System.Windows.Forms.GroupBox groupBoxgender;
        private System.Windows.Forms.RadioButton radioButtonfemale;
        private System.Windows.Forms.RadioButton radioButtonmale;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button cmdnext;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolStrip toolStrip2;
    }
}

