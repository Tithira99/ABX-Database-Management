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
    public partial class Employee : Form
    {
        EmployeeDao edao = new EmployeeDao();
        public Employee()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Employeec eob = new Employeec((textBox1.Text), (textBox2.Text));
                edao.insertnewEmployee(eob);
                MessageBox.Show("Recorded Succesfully", "Employee Registration");
                textBox1.Text = "";
                textBox2.Text = "";
            }
            catch
            {
                MessageBox.Show("Error", "Employee Registration");

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Employeec eob = new Employeec((textBox1.Text), (textBox2.Text));
                edao.updateemployee(eob);
                MessageBox.Show("Updated Successfully", "Employee Registration");
                textBox1.Text = "";
                textBox2.Text = "";

            }
            catch
            {
                MessageBox.Show("Error", "Employee Registration");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                edao.deleteemployeebyid(textBox1.Text);
                MessageBox.Show("Deleted Successfully", "Employee Registration");
                textBox1.Text = "";
                textBox2.Text = "";
            }
            catch
            {
                MessageBox.Show("Error", "Employee Registration");
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
