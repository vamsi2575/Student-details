using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace studentdetails
{
    public partial class Form1 : Form
    {
        string name;
        string regno;
        string var1;
        string var2;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBoxname_TextChanged(object sender, EventArgs e)
        {
            name = textBoxname.Text;
        }

        private void textBoxregno_TextChanged(object sender, EventArgs e)
        {
            regno = textBoxregno.Text;
        }

        private void comboBoxsem_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            var1 = comboBoxsem.Text;
        }

        private void comboBoxbranch_SelectedIndexChanged(object sender, EventArgs e)
        {
            var2 = comboBoxbranch.Text;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void checkBoxdbms_CheckedChanged(object sender, EventArgs e)
        {
            toolStripLabel1.Text = "DBMS Check box selected";
        }

        private void checkBoxjava_CheckedChanged(object sender, EventArgs e)
        {
            toolStripLabel1.Text = "JAVA Check box selected";
        }

        private void checkBoxds_CheckedChanged(object sender, EventArgs e)
        {
            toolStripLabel1.Text = "DS Check box selected";
        }

        private void checkBoxcomp_CheckedChanged(object sender, EventArgs e)
        {
            toolStripLabel1.Text = "COMP Check box selected";
        }

        private void groupBoxgender_Enter(object sender, EventArgs e)
        {
            toolStripLabel1.Text = "female is selected";
        }

        private void radioButtonmale_CheckedChanged(object sender, EventArgs e)
        {
            toolStripLabel1.Text = "male is selected";
        }

        private void radioButtonfemale_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cmdsubmit_Click(object sender, EventArgs e)
        {
            string msg=string.Empty;
            if (checkBoxcomp.Checked == true)
            {
                msg = "comp";
            }
            if (checkBoxdbms.Checked == true)
            {
                msg = msg + ",dbms";
            }
            if (checkBoxjava.Checked == true)
            {
                msg = msg + ",java";
            }
            if (checkBoxds.Checked == true)
            {
                msg = msg + ",ds";
            }
            /*else
            {
                MessageBox.Show("nocheck box selected");
            }*/
            string rd = string.Empty;
            if (radioButtonmale.Checked == true)
                rd = radioButtonmale.Text;
            else if (radioButtonfemale.Checked == true)
                rd = radioButtonfemale.Text;
            else
                rd = "gender not selected";

            MessageBox.Show("name:"+name+"\n"+"regno:"+regno+"\n"+"sem:"+var1+"\n"+"branch:"+var2+"\n"+"gender:"+rd+"\n"+msg);
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
            int i;
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 10;
            for (i = 0; i <= 10; i++)
            {
                System.Threading.Thread.Sleep(10);
                progressBar1.Value = i;
            }
        }

        private void cmdnext_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2(); // creates a new object for Form 2.
            f2.Show(); // Projecting the second form.
            this.Hide(); // Hides the Form 1 but doesn’t close.
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void progressBar2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripProgressBar1_Click(object sender, EventArgs e)
        {
            int i;
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 200;
            for (i = 0; i <= 200; i++)
            {
                System.Threading.Thread.Sleep(70);
                progressBar1.Value = i;
            }
        }

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {

        }
        
    }
}
