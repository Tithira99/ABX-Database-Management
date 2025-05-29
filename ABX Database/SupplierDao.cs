using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ABX_Database
{
    class SupplierDao
    {
        static string con = "Data Source=DESKTOP-2ORO7LR\\SQLEXPRESS;Initial Catalog=abx_furniture;User ID=tithirayw;Password=Tithira@123";
        SqlConnection m_con = new SqlConnection(con);

        public void insertnewsupplier(Supplierc sobj)
        {
            try
            {
                string sql = "insert into supplier(supplierID,sup_name, sup_address)values('" + sobj.getid() + "', '" + sobj.getname() + "','" + sobj.getaddress() + "')";
                SqlCommand cmd = new SqlCommand(sql, m_con);
                m_con.Open();
                cmd.ExecuteNonQuery();
            }
            finally
            {
                m_con.Close();
            }
        }
        public void deletesupplierbyID(string id)
        {
            try
            {
                string sql = "delete from supplier where supplierid='" + id + "'";
                SqlCommand cmd = new SqlCommand(sql, m_con);
                m_con.Open();
                cmd.ExecuteNonQuery();

            }
            finally
            {
                m_con.Close();
            }
        }

        public void updatesupplier(Supplierc sobj)
        {
            try
            {
                string sql = "update supplier set sup_name=('" + sobj.getname() + "'),sup_address= ('" + sobj.getaddress() + "') where supplierid='" + sobj.getid() + "'";
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
