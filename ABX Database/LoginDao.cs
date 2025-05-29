using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace ABX_Database
{
    class LoginDao
    {
        static string con = "Data Source=DESKTOP-2ORO7LR\\SQLEXPRESS;Initial Catalog=abx_furniture;User ID=tithirayw;Password=Tithira@123";
        SqlConnection m_con = new SqlConnection(con);

        public void insertnewlogin(Loginc lobj)
        {
            try
            {
                string sql = "insert into Login(password, username, adid)values('" + lobj.getpswrd() + "','" + lobj.getusrnm() + "', '" + lobj.getaid() + "')";
                SqlCommand cmd = new SqlCommand(sql, m_con);
                m_con.Open();
                cmd.ExecuteNonQuery();

            }
            finally
            {
                m_con.Close();
            }
        }

        public void deletelogin(string usrnm)
        {
            try
            {
                string sql = "delete from Login where username = " + usrnm + " ";
                SqlCommand cmd = new SqlCommand(sql, m_con);
                m_con.Open();
                cmd.ExecuteNonQuery();
            }
            finally
            {
                m_con.Close();
            }

        }

        public void updatelogin(Loginc lobj)
        {
            try
            {
                string sql = "Update login set password = ('" + lobj.getpswrd() + "'),adid = ('" + lobj.getaid() + "') where username = ('" + lobj.getusrnm() + "')";
                SqlCommand cmd = new SqlCommand(sql, m_con);
                m_con.Open();
                cmd.ExecuteNonQuery();
            }
            finally
            {
                m_con.Close();
            }
        }

        public DataTable searchLogin(string usrnm, string pswrd)//Method for searching Login a record by password and username
        {
            try
            {
                string sql = "Select count(*) from login where username = '" + usrnm + "' and password = '" + pswrd + "'";
                SqlDataAdapter Adapt = new SqlDataAdapter(sql, m_con);
                DataTable dt = new DataTable();
                Adapt.Fill(dt);

                return dt;
            }
            finally
            {
                m_con.Close();
            }
        }

    }
}
