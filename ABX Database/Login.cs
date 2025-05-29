using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ABX_Database
{
   
    public partial class Login : Form
    {
        LoginDao ldao = new LoginDao();
        static string con = "Data Source=DESKTOP-2ORO7LR\\SQLEXPRESS;Initial Catalog=abx_furniture;User ID=tithirayw;Password=Tithira@123";
        SqlConnection m_con = new SqlConnection(con);

        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = ldao.searchLogin((textBox1.Text), (textBox2.Text));
                if (dt.Rows[0][0].ToString() == "1")//Check whether the entered data is available in the login Registration Table
                {
                    this.Hide();


                    Form1 ob = new Form1();
                    ob.Show();//Display the main menu
                    MessageBox.Show("Login Successful", "ABX Furniture");

                }
                else
                {
                    MessageBox.Show("Invalid Access", "ABX Furniture");
                }
            }
            catch
            {
                m_con.Close();
            }
            /*Reference - https://www.c-sharpcorner.com/UploadFile/9582c9/login-form-with-sql-in-C-Sharp/ - (Online website)*/



        }
    }
}
