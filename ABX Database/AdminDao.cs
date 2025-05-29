using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace ABX_Database
{
    class AdminDao
    {
        static string con = "Data Source=DESKTOP-2ORO7LR\\SQLEXPRESS;Initial Catalog=abx_furniture;User ID=tithirayw;Password=Tithira@123";
        SqlConnection m_con = new SqlConnection(con);

        public void insertnewadmin(Adminc aobj)
        {
            try
            {
                //set of instruction are executed accordingly to excute the sql code writen by accessing the path way and changing string into sql code
                string sql = "insert into Admin(adminid, adminname)values('" + aobj.getadid() + "','" + aobj.getadname() + "')";
                SqlCommand cmd = new SqlCommand(sql, m_con);
                m_con.Open();
                cmd.ExecuteNonQuery();

            }
            finally
            {//closing the open pathway to the database since its purpose ending in this state
                m_con.Close();
            }
        }

        public void deleteadmin(string adid)
        {
            try
            {
                //set of instruction are executed accordingly to excute the sql code writen by accessing the path way and changing string into sql code
                string sql = "delete from Admin where adminid = '" + adid + "' ";
                SqlCommand cmd = new SqlCommand(sql, m_con);
                m_con.Open();
                cmd.ExecuteNonQuery();
            }
            finally
            {
                //closing the open pathway to the database since its purpose ending in this state
                m_con.Close();
            }

        }

        public void updateadmin(Adminc aobj)
        {
            try
            {
                //set of instruction are executed accordingly to excute the sql code writen by accessing the path way and changing string into sql code
                string sql = "Update admin set adminname = ('" + aobj.getadname() + "') where adminid = ('" + aobj.getadid() + "')";
                SqlCommand cmd = new SqlCommand(sql, m_con);
                m_con.Open();
                cmd.ExecuteNonQuery();
            }
            finally
            {
                //closing the opened pathway to the database since it's purpose enda in this state.
                m_con.Close();
            }
        }



    }
}
