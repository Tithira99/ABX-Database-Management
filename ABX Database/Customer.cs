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
    public partial class Customer : Form
    {
        CustomerDao cdao = new CustomerDao();
        public Customer()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)//button click to insert data to the database
        {
            try
            {
                Customerc cob = new Customerc((textBox1.Text), (textBox2.Text), (textBox3.Text), (textBox4.Text));
                cdao.insertnewcustomer(cob);
                MessageBox.Show("Recorded Successfully", "Customer Registration");
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";

            }
            catch
            {
                MessageBox.Show("Error", "Customer Registration");

            }
        }

        private void button3_Click(object sender, EventArgs e)//button click to delete data from the database
        {
            try
            {
                cdao.deleteCustomerbyID(textBox1.Text);
                MessageBox.Show("Deleted Successfully", "Customer Registration");
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
            }
            catch
            {
                MessageBox.Show("Error", "Customer Registration");
            }
        }

        private void Customer_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)//button click to update data in the database
        {
            try
            {
                Customerc cob = new Customerc((textBox1.Text), (textBox2.Text), (textBox3.Text), (textBox4.Text));
                cdao.updatecustomer(cob);
                MessageBox.Show("Updated Successfully", "Customer Registration");
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
            }
            catch
            {
                MessageBox.Show("Error", "Customer Registration");

            }


        }

        private void button4_Click(object sender, EventArgs e)//button click to go back to the main menu
        {
            this.Hide();
            Form1 ob = new Form1();
            ob.Show();
        }
    }
}
