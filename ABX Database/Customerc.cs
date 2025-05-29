using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABX_Database
{
    public class Customerc
    {
        private string CustomerID;
        private string CustomerName;
        private string Cust_Address;
        private string Tel_No;

        public Customerc()
        {

        }

        public Customerc(string id)
        {
            this.CustomerID = id;

        }
        public Customerc(string id, string name, string address, string telNO)
        {
            this.CustomerID = id;
            this.CustomerName = name;
            this.Cust_Address = address;
            this.Tel_No = telNO;
        }

        public string getid()
        {
            return this.CustomerID;
        }

        public string getname()
        {
            return this.CustomerName;
        }

        public string getaddress()
        {
            return this.Cust_Address;

        }
        public string gettelNO()
        {
            return this.Tel_No;

        }

        public void setID(string id)
        {
            this.CustomerID = id;

        }

        public void setname(string name)
        {
            this.CustomerName = name;

        }
        public void setaddress(string address)
        {
            this.Cust_Address = address;

        }
        public void settelNO(string telNo)
        {
            this.Tel_No = telNo;
        }
    }

}
