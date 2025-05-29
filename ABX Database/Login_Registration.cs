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
    public partial class Login_Registration : Form
    {
        LoginDao logdao = new LoginDao();
        public Login_Registration()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Loginc logob = new Loginc ((textBox2.Text), (textBox1.Text), (comboBox1.Text));
                logdao.insertnewlogin(logob);
                MessageBox.Show("New Login Inserted Successfully", "ABX Furinture System");
                textBox1.Text = "";
                textBox2.Text = "";
                comboBox1.Text = "";


            }
            catch
            {
                MessageBox.Show("Error", "ABX Furniture System");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Loginc logob = new Loginc((textBox2.Text), (textBox1.Text), (comboBox1.Text));
                logdao.updatelogin(logob);
                MessageBox.Show("Updated Login Successfully", "ABX Furinture System");
                textBox1.Text = "";
                textBox2.Text = "";
                comboBox1.Text = "";
            }
            catch
            {
                MessageBox.Show("Error", "ABX Furinture System");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                logdao.deletelogin(textBox1.Text);
                MessageBox.Show("Deleted LoginSuccessfully", "ABX Furinture System");
                textBox1.Text = "";
                textBox2.Text = "";
                comboBox1.Text = "";
            }
            catch
            {
                MessageBox.Show("Error", "ABX Furinture System");
            }
        }

        private void Login_Registration_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'abx_furnitureDataSet20.Login' table. You can move, or remove it, as needed.
            this.loginTableAdapter.Fill(this.abx_furnitureDataSet20.Login);
            // TODO: This line of code loads data into the 'abx_furnitureDataSet18.Admin' table. You can move, or remove it, as needed.
            this.adminTableAdapter.Fill(this.abx_furnitureDataSet18.Admin);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 ob = new Form1();
            ob.Show();
        }
    }
    
}
