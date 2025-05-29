using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ABX_Database
{
    class GRNDao
    {
        static string con = "Data Source=DESKTOP-2ORO7LR\\SQLEXPRESS;Initial Catalog=abx_furniture;User ID=tithirayw;Password=Tithira@123";
        SqlConnection m_con = new SqlConnection(con);


        public void insertnewGRN(GRNc gobj)
        {
            try
            {
                string sql = "insert into GRN_details(GRN_No, ProductID, Receivedby, checkedby, supplierID, purchase_quty, Requested_Date, Delivered_Date) VALUES('" + gobj.getid() + "', '" + gobj.getpid() + "', '" + gobj.getrby() + "', '" + gobj.getcby() + "','" + gobj.getsid() + "', '" + gobj.getpurqty() + "', '" + gobj.getrdate() + "', '" + gobj.getddate() + "')";
                SqlCommand cmd = new SqlCommand(sql, m_con);
                m_con.Open();
                cmd.ExecuteNonQuery();
            }
            finally
            {
                m_con.Close();
            }


        }
        public void deleteGRNbyID(string id1, int id2)
        {
            try
            {
                string sql = "delete from GRN_details where GRN_No='" + id1 + "' AND productID= "+id2+"";
                SqlCommand cmd = new SqlCommand(sql, m_con);
                m_con.Open();
                cmd.ExecuteNonQuery();
            }
            finally
            {
                m_con.Close();
            }
        }

        public void updateGRNbyid(GRNc gobj)
        {
            try
            {
                string sql= "UPDATE GRN_details SET  Receivedby='" + gobj.getrby() + "' , checkedby='" + gobj.getcby() + "', supplierID= '" + gobj.getsid() + "', purchase_quty=" + gobj.getpurqty() + ", Requested_Date='" + gobj.getrdate() + "', Delivered_Date= '" + gobj.getddate() + "' WHERE GRN_No='"+ gobj.getid()+ "' AND ProductID= " + gobj.getpid() + "";
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
