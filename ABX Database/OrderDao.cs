using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ABX_Database
{
    class OrderDao
    {
        static string con = "Data Source=DESKTOP-2ORO7LR\\SQLEXPRESS;Initial Catalog=abx_furniture;User ID=tithirayw;Password=Tithira@123";
        SqlConnection m_con = new SqlConnection(con);

        public void insertneworder(Order_detailsc oobj)
        {
            try
            {
                string sql = "INSERT INTO order_details(OrderID, productID, customerID, OrderDate, Quantity, Prod_Discount) VALUES ('" + oobj.getoid() + "', " + oobj.getpid() + ", '" + oobj.getcid() + "','" + oobj.getodate() + "', " + oobj.getqty() + ", " + oobj.getpdis() + ")";
                SqlCommand cmd = new SqlCommand(sql, m_con);
                m_con.Open();
                cmd.ExecuteNonQuery();
          
            }
            finally
            {
                m_con.Close();
            }
        }

        public void deleteOrderbyID(string oid, int pid)
        {
            try
            {
                string sql = "delete from Order_details where OrderID='" + oid + "' AND productID=" + pid + "";
                SqlCommand cmd = new SqlCommand(sql, m_con);
                m_con.Open();
                cmd.ExecuteNonQuery();
            }
            finally
            {
                m_con.Close();
            }
        }

        public void udateorderbyid(Order_detailsc oobj)
        {
            try
            {
                string sql = "UPDATE order_details SET customerID= '" + oobj.getcid() + "', OrderDate= '" + oobj.getodate() + "' , Quantity= " + oobj.getqty() + ", Prod_Discount= " + oobj.getpdis() + " WHERE orderID= '" + oobj.getoid() + "' AND productID= " + oobj.getpid() + "";
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
