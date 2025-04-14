using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("My first app","Alert",MessageBoxButtons.YesNo);
            txtName.Text = txtName.Text+"1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtName.Text = txtName.Text + "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtName.Text = txtName.Text + "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtName.Text = txtName.Text + "4";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (txtName.Text == "")
                txtName.Text = "0";
            else
                txtName.Text = (Convert.ToInt32(txtName.Text) + 1).ToString();
        }
    }
}
