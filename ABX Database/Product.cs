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
    public partial class Product : Form
    {
        ProductDao pdao = new ProductDao();
        public Product()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Productc pob = new Productc(int.Parse(textBox1.Text), (textBox2.Text), int.Parse(textBox3.Text), int.Parse(textBox4.Text), int.Parse(textBox5.Text));
                pdao.insertnewproduct(pob);
                MessageBox.Show("Recorded Successfully", "Product Registration");
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";

            }
            catch
            {
                MessageBox.Show("Error", "ProductRegistration");
            }




        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Productc pob = new Productc(int.Parse(textBox1.Text), (textBox2.Text), int.Parse(textBox3.Text), int.Parse(textBox4.Text), int.Parse(textBox5.Text));
                pdao.updateproductbyid(pob);
                MessageBox.Show("Updated Successfully", "Product Registration");
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
            }
            catch
            {
                MessageBox.Show("Error", "ProductRegistration");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                pdao.deleteproductbyid(int.Parse(textBox1.Text));
                MessageBox.Show("Deleted Successfully", " Product Registration");
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
            }
            catch
            {
                MessageBox.Show("Error", "ProductRegistration");
            }
            
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 ob = new Form1();
            ob.Show();
        }

        private void Product_Load(object sender, EventArgs e)
        {

        }
    }
}
