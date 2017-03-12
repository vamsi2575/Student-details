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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

            private void Department_SelectedIndexChanged(object sender, EventArgs e)
            {
               
                MessageBox.Show("Department="+Department.SelectedItem);
                
            }

            private void treeView1_MouseDoubleClick(object sender, MouseEventArgs e)
            {
                TreeNode node = treeView1.SelectedNode;
                MessageBox.Show("You selected:" + node.Text);
            }
    }
}
