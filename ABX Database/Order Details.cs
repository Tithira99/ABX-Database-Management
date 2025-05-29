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
    
    public partial class Order_Details : Form
    {
        OrderDao odao = new OrderDao();
        ProductDao pdao = new ProductDao();
        public Order_Details()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Order_detailsc oob = new Order_detailsc((textBox1.Text), int.Parse(comboBox1.Text), (comboBox2.Text), (textBox2.Text), int.Parse(textBox3.Text), int.Parse(textBox4.Text));
                odao.insertneworder(oob);
                MessageBox.Show("Order Placed", "Order Details Store");
                textBox1.Text = "";
                comboBox1.Text = "";
                comboBox2.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                


            }
            catch
            {
                MessageBox.Show("Error", "Order Details Store");
            }

            

        }

        private void Order_Details_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'abx_furnitureDataSet23.Product' table. You can move, or remove it, as needed.
            this.productTableAdapter2.Fill(this.abx_furnitureDataSet23.Product);
            // TODO: This line of code loads data into the 'abx_furnitureDataSet22.Product' table. You can move, or remove it, as needed.
            this.productTableAdapter1.Fill(this.abx_furnitureDataSet22.Product);
            // TODO: This line of code loads data into the 'abx_furnitureDataSet21.Order_details' table. You can move, or remove it, as needed.
            this.order_detailsTableAdapter1.Fill(this.abx_furnitureDataSet21.Order_details);
            // TODO: This line of code loads data into the 'abx_furnitureDataSet17.Customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.abx_furnitureDataSet17.Customer);
            // TODO: This line of code loads data into the 'abx_furnitureDataSet16.Order_details' table. You can move, or remove it, as needed.
            this.order_detailsTableAdapter.Fill(this.abx_furnitureDataSet16.Order_details);
            // TODO: This line of code loads data into the 'abx_furnitureDataSet15.Product' table. You can move, or remove it, as needed.
            this.productTableAdapter.Fill(this.abx_furnitureDataSet15.Product);


        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Order_detailsc oob = new Order_detailsc((textBox1.Text), int.Parse(comboBox1.Text), (comboBox2.Text), (textBox2.Text), int.Parse(textBox3.Text), int.Parse(textBox4.Text));
                odao.udateorderbyid(oob);
                MessageBox.Show("Update Successfully", "Order Details Store");
                textBox1.Text = "";
                comboBox1.Text = "";
                comboBox2.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
            }
            catch
            {

                MessageBox.Show("Error", "Order Details Store");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                odao.deleteOrderbyID((textBox1.Text), int.Parse(comboBox1.Text));
                MessageBox.Show("Deleted Successfully", "Order Details Store");
            }
            catch
            {
                MessageBox.Show("Error", "Order Details Store");
            }


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = pdao.searchproductbyname((textBox5.Text));

                dataGridView1.DataSource = dt;

            }
            catch
            {
                MessageBox.Show("Error");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            ABX_Furniture ob = new ABX_Furniture();
            ob.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }
    }
}
