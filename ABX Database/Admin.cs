using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABX_Database
{
    public partial class Admin : Form
    {
        AdminDao adao = new AdminDao();
        public Admin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Adminc aob = new Adminc((textBox1.Text), (textBox2.Text));
                adao.insertnewadmin(aob);
                MessageBox.Show("Recorded Successfully", "Admin Registration");
                textBox1.Text = "";
                textBox2.Text = "";

            }
            catch
            {
                MessageBox.Show("Error", "Admin Registration");

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                adao.deleteadmin((textBox1.Text));
                MessageBox.Show("Deleted Successfully", "Admin Registration");
                textBox1.Text = "";
                textBox2.Text = "";

            }

            catch
            {
                MessageBox.Show("Error", "Admin Registration");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Adminc aob = new Adminc((textBox1.Text), (textBox2.Text));
                adao.updateadmin(aob);
                MessageBox.Show("Updated Successfully", "Admin Registration");

                textBox1.Text = "";
                textBox2.Text = "";

            }
            catch
            {
                MessageBox.Show("Error", "Admin Registration");

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 ob = new Form1();
            ob.Show();
        }
    }
}
