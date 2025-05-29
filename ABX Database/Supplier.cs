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
    public partial class Supplier : Form
    {
        SupplierDao sdao = new SupplierDao();
        public Supplier()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Supplierc sob = new Supplierc((textBox1.Text), (textBox2.Text), (textBox3.Text));
                sdao.insertnewsupplier(sob);
                MessageBox.Show("Recorded Succesfully", "Supplier Registration");
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
            }
            catch
            {
                MessageBox.Show("Error", "Supplier Registration");

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
               Supplierc sob = new Supplierc((textBox1.Text), (textBox2.Text), (textBox3.Text));
                sdao.updatesupplier(sob);
                MessageBox.Show("Updated Successfully", "Employee Registration");
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";

            }
            catch
            {
                MessageBox.Show("Error", "Supplier Registration");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                sdao.deletesupplierbyID(textBox1.Text);
                MessageBox.Show("Deleted Successfully", "Supplier Registration");
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
            }
            catch
            {
                MessageBox.Show("Error", "Supplier Registration");
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
