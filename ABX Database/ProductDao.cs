using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace ABX_Database
{
    class ProductDao
    {
        Productc pob1;
        static string con = "Data Source=DESKTOP-2ORO7LR\\SQLEXPRESS;Initial Catalog=abx_furniture;User ID=tithirayw;Password=Tithira@123";
        SqlConnection m_con = new SqlConnection(con);

        public void insertnewproduct(Productc pobj)
        {
            try
            {
                string sql = "insert into Product(ProductID, Prod_Des, S_UnitPrice,B_UnitPrice, Available_quty) Values(" + pobj.getid() + ", '" + pobj.getdescription() + "' , " + pobj.getSPrice() + ", " + pobj.getBPrice() + ", "+ pobj.getaqty()+")";
                SqlCommand cmd = new SqlCommand(sql, m_con);
                m_con.Open();
                cmd.ExecuteNonQuery();

            }
            finally
            {
                m_con.Close();

            }
        }

        public void deleteproductbyid(int id)
        {
            try
            {
                string sql = "delete from product where productid=" + id + "";
                SqlCommand cmd = new SqlCommand(sql, m_con);
                m_con.Open();
                cmd.ExecuteNonQuery();



            }
            finally
            {
                m_con.Close();

            }
        }


        public void updateproductbyid(Productc pobj)
        {
            try
            {
                string sql = "update product set prod_Des='" + pobj.getdescription() + "' , S_UnitPrice=" + pobj.getSPrice() + ", B_Unitprice =" + pobj.getBPrice() + ",Available_quty= " + pobj.getaqty() + " where productid= " + pobj.getid() + "";
                SqlCommand cmd = new SqlCommand(sql, m_con);
                m_con.Open();
                cmd.ExecuteNonQuery();


            }
            finally
            {
                m_con.Close();

            }
        }

        public DataTable searchproductbyname(string name)
        {
            try
            {
                string sql = "select * from product where Prod_des Like '%" + name + "%'";
                m_con.Open();
                SqlDataAdapter Adapt = new SqlDataAdapter(sql, m_con);
                DataTable dt1 = new DataTable();
                Adapt.Fill(dt1);




                return dt1;
            }
            finally
            {
                m_con.Close();
            }
            
        }

    }
}
