using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ABX_Database
{
    class EmployeeDao
    {
        static string con = "Data Source=DESKTOP-2ORO7LR\\SQLEXPRESS;Initial Catalog=abx_furniture;User ID=tithirayw;Password=Tithira@123";
        SqlConnection m_con = new SqlConnection(con);

        public void insertnewEmployee (Employeec eobj)
        {
            try
            {
                string sql = "insert into employee(employeeid, employeename)values('" + eobj.getid() + "', '" + eobj.getname() + "')";
                SqlCommand cmd = new SqlCommand(sql, m_con);
                m_con.Open();
                cmd.ExecuteNonQuery();
            }
            finally
            {
                m_con.Close();
            }
        }
        public void updateemployee (Employeec eobj)
        {
            try
            {
                string sql = "update employee set employeename='" + eobj.getname() + "' where employeeid ='" + eobj.getid() + "'";
                SqlCommand cmd = new SqlCommand(sql, m_con);
                m_con.Open();
                cmd.ExecuteNonQuery();
            }
            catch
            {
                m_con.Close();
            }
        }

        public void deleteemployeebyid( string id)
        {
            try
            {
                string sql = "delete from employee where employeeid='" + id + "'";
                SqlCommand cmd = new SqlCommand(sql, m_con);
                m_con.Open();
                cmd.ExecuteNonQuery();
            }
            finally
            {
                m_con.Close();
            }
        }
    }
}
