using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABX_Database
{
    class Order_detailsc
    {
        private string OrderID;
        private int ProductID;
        private string CustomerID;
        private string Order_Date;
        private int Quantity;
        private int Prod_Discount;


        public Order_detailsc()
        {

        }

        public Order_detailsc(string oid, int pid)
        {
            this.OrderID = oid;
            this.ProductID = pid;
        }

        public Order_detailsc(string oid, int pid, string cid,  string odate, int qty, int proDis)
        {
            this.OrderID = oid;
            this.ProductID = pid;
            this.CustomerID = cid;
            this.Order_Date = odate;
            this.Quantity = qty;
            this.Prod_Discount = proDis;
        }

        public string getoid()
        {
            return this.OrderID;

        }

        public int getpid()
        {
            return this.ProductID;

        }

        public string getcid()
        {
            return this.CustomerID;

        }
        public string getodate()
        {
            return this.Order_Date;

        }

        

        public int getqty()
        {
            return this.Quantity;

        }

        public int getpdis()
        {
            return this.Prod_Discount;

        }

        public void setoid(string oid)
        {
            this.OrderID = oid;
        }

        public void setpid(int pid)
        {
             
            this.ProductID = pid;
        }

        public void setcid(string cid)
        {
            this.CustomerID = cid;
        }

        public void setodate(string odate)
        {
            this.Order_Date = odate;
        }

        public void setqty(int qty)
        {
            this.Quantity = qty;
        }

        public void setdiscount(int pdis)
        {
            this.Prod_Discount = pdis;
        }








    }
}
