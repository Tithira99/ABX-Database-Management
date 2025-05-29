using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ABX_Database
{
    class CustomerDao
    {
        static string con = "Data Source=DESKTOP-2ORO7LR\\SQLEXPRESS;Initial Catalog=abx_furniture;User ID=tithirayw;Password=Tithira@123";//connection string to the database
        SqlConnection m_con = new SqlConnection(con);//database connection

        public void insertnewcustomer(Customerc cobj)//method for inserting new records.
        {
            try
            {
                string sql= "insert into customer(CustomerID,customername, cust_address,tel_no)values('"+cobj.getid()+"', '"+cobj.getname()+"','"+cobj.getaddress()+"', '"+ cobj.gettelNO()+"')";//sql quety to insert new records to the customer table
                SqlCommand cmd = new SqlCommand(sql, m_con);//sql command to connect to the database
                m_con.Open();//openning the pathway to the database
                cmd.ExecuteNonQuery();
            }
            finally
            {
                m_con.Close();//closing the pathway to the database
            }
        }
        public void deleteCustomerbyID(string id)//Method for deleting records from the database table
        {
            try
            {
                string sql = "delete from customer where customerid='" + id + "'";//sql quey to delete records from the database
                SqlCommand cmd = new SqlCommand(sql, m_con);//sql command to connect to the database
                m_con.Open();//openning pathway to the database
                cmd.ExecuteNonQuery();

            }
            finally
            {
                m_con.Close();//closing the pathway of the database
            }
        }

        public void updatecustomer(Customerc cobj)//method to update data of the customer table
        {
            try
            {
                string sql = "update customer set customername=('" + cobj.getname() + "'),cust_address= ('" + cobj.getaddress() + "'), tel_no=('" + cobj.gettelNO() + "') where customerid='" + cobj.getid() + "'";//sql query to delete data
                SqlCommand cmd = new SqlCommand(sql, m_con);//sql command to connect to the database
                m_con.Open();//openning the pathway to the database
                cmd.ExecuteNonQuery();

            }
            finally
            {
                m_con.Close();//closing the pathway to the database
            }
        }

        

        
    }
}
