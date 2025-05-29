using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABX_Database
{
    class GRNc
    {
        private string GRN_No;
        private int productID;
        private string receivedby;
        private string checkedby;
        private string supplierID;
        private int purchaseqty;
        private string requestedDate;
        private string DeliveredDate;

        public GRNc()
        {

        }

        public GRNc(string GRNn, int pid)
        {
            this.GRN_No = GRNn;
            this.productID = pid;
        }

        public GRNc(string GRNn, int pid, string rby, string cby, string sid, int purqty, string rdate, string ddate)
        {
            this.GRN_No = GRNn;
            this.productID = pid;
            this.receivedby = rby;
            this.checkedby = cby;
            this.supplierID = sid;
            this.purchaseqty = purqty;
            this.requestedDate = rdate;
            this.DeliveredDate = ddate;
        }

        public string getid()
        {
            return this.GRN_No;
        }

        public int getpid() 
        {
            return this.productID;
        }

        public string getrby()
        {
            return this.receivedby;
        }

        public string getcby()
        {
            return this.checkedby;
        }

        public string getsid()
        {
            return this.supplierID;
        }

        public int getpurqty()
        {
            return this.purchaseqty;
        }

        public string getrdate()
        {
            return this.requestedDate;


        }

        public string getddate()
        {
            return this.DeliveredDate;
        }

       
        public void setid(string GRNn)
        {
            this.GRN_No = GRNn;
           
        }
        public void setpid( int pid)
        {
            
            this.productID = pid;
            
        }
        public void setrby( string rby)
        {
            
            this.receivedby = rby;
           
        }
        public void setcby( string cby)
        {
            
            this.checkedby = cby;
            
        }
        public void setsid(string sid)
        {
            
            this.supplierID = sid;
           
        }
        public void setpurqty( int purqty)
        {
            
            this.purchaseqty = purqty;
           
        }
        public void setrdate(string rdate)
        {

            this.receivedby = rdate;
        }

        public void setddate( string ddate)
        {
           
            this.DeliveredDate = ddate;
        }





    }

}
