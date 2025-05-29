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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Supplier ob = new Supplier();
            ob.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Employee ob = new Employee();
            ob.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Customer ob = new Customer();
            ob.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Product ob = new Product();
            ob.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Order_Details ob = new Order_Details();
            ob.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            GRN_details ob = new GRN_details();
            ob.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login_Registration ob = new Login_Registration();
            ob.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin ob = new Admin();
            ob.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login ob = new Login();
            ob.Show();
        }
    }
}
