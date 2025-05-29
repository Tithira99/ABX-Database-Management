using System;
using System.Windows.Forms;


namespace ABX_Database
{
    public partial class GRN_details : Form
    {
        GRNDao gdao = new GRNDao();
        public GRN_details()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                GRNc gob = new GRNc((textBox1.Text), int.Parse(comboBox1.Text), (comboBox2.Text), (comboBox3.Text), (comboBox4.Text), int.Parse(textBox2.Text), (textBox3.Text), (textBox4.Text));
                gdao.insertnewGRN(gob);
                MessageBox.Show("Recorded Successfully", "GRN Details Store");
                textBox1.Text = "";
                comboBox1.Text = "";
                comboBox2.Text = "";
                comboBox3.Text = "";
                comboBox4.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";


            }
            catch
            {
                MessageBox.Show("Error", "GRN Details Store");

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                GRNc gob = new GRNc((textBox1.Text), int.Parse(comboBox1.Text), (comboBox2.Text), (comboBox3.Text), (comboBox4.Text), int.Parse(textBox2.Text), (textBox3.Text), (textBox4.Text));
                gdao.updateGRNbyid(gob);
                MessageBox.Show("Updated Successfully", "GRN Details Store");
                textBox1.Text = "";
                comboBox1.Text = "";
                comboBox2.Text = "";
                comboBox3.Text = "";
                comboBox4.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
            }
            catch
            {
                MessageBox.Show("Error", "GRN Details Store");
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                gdao.deleteGRNbyID((textBox1.Text), int.Parse(comboBox1.Text));
                MessageBox.Show("Deleted Successfully", "GRN Details Store");
                textBox1.Text = "";
                comboBox1.Text = "";
                comboBox2.Text = "";
                comboBox3.Text = "";
                comboBox4.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
            }
            catch
            {
                MessageBox.Show("Error", "GRN Details Store");
            }

        }

        private void GRN_details_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'abx_furnitureDataSet14.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter4.Fill(this.abx_furnitureDataSet14.Employee);
            // TODO: This line of code loads data into the 'abx_furnitureDataSet13.GRN_details' table. You can move, or remove it, as needed.
            this.gRN_detailsTableAdapter.Fill(this.abx_furnitureDataSet13.GRN_details);
            // TODO: This line of code loads data into the 'abx_furnitureDataSet12.Supplier' table. You can move, or remove it, as needed.
            this.supplierTableAdapter2.Fill(this.abx_furnitureDataSet12.Supplier);
            // TODO: This line of code loads data into the 'abx_furnitureDataSet11.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter3.Fill(this.abx_furnitureDataSet11.Employee);
            // TODO: This line of code loads data into the 'abx_furnitureDataSet10.Product' table. You can move, or remove it, as needed.
            this.productTableAdapter3.Fill(this.abx_furnitureDataSet10.Product);
            // TODO: This line of code loads data into the 'abx_furnitureDataSet9.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter2.Fill(this.abx_furnitureDataSet9.Employee);
            // TODO: This line of code loads data into the 'abx_furnitureDataSet8.Product' table. You can move, or remove it, as needed.
            //this.productTableAdapter2.Fill(this.abx_furnitureDataSet8.Product);
            // TODO: This line of code loads data into the 'abx_furnitureDataSet6.Employee' table. You can move, or remove it, as needed.
            //this.employeeTableAdapter1.Fill(this.abx_furnitureDataSet6.Employee);
            // TODO: This line of code loads data into the 'abx_furnitureDataSet5.Supplier' table. You can move, or remove it, as needed.
            //this.supplierTableAdapter1.Fill(this.abx_furnitureDataSet5.Supplier);
            // TODO: This line of code loads data into the 'abx_furnitureDataSet4.Product' table. You can move, or remove it, as needed.
            //this.productTableAdapter1.Fill(this.abx_furnitureDataSet4.Product);
            // TODO: This line of code loads data into the 'abx_furnitureDataSet3.Supplier' table. You can move, or remove it, as needed.
            //this.supplierTableAdapter.Fill(this.abx_furnitureDataSet3.Supplier);
            // TODO: This line of code loads data into the 'abx_furnitureDataSet2.Employee' table. You can move, or remove it, as needed.
            //this.employeeTableAdapter.Fill(this.abx_furnitureDataSet2.Employee);
            //TODO: This line of code loads data into the 'abx_furnitureDataSet1.Product' table. You can move, or remove it, as needed.
            //this.productTableAdapter.Fill(this.abx_furnitureDataSet1.Product);

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 ob = new Form1();
            ob.Show();
        }
    }
}
