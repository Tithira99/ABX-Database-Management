using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABX_Database
{
    class Adminc
    {
        private string adminid;//admin identification number
        private string adminname;//admin's name related with admin id

        public Adminc()//default constructor for class admin
        {


        }
        public Adminc(string adid)//parameterized constructor for admin class with one parameter
        {
            this.adminid = adid;//assigning the value taken by parameter to the private variable of the admin class
        }


        public Adminc(string adid, string adname)//parameterized constructor for admin class with two parameters
        {
            this.adminid = adid;//assigning the value taken by parameter adid to the private variable adminid of the admin class 
            this.adminname = adname;//assigning the value taken by parameter adname to the private variable adminname of the admin class 
        }


        public string getadid()//getter for adminid
        {
            return this.adminid;
        }

        public string getadname()//getter for adminname
        {
            return this.adminname;
        }


        public void setadid(string adid)//setter for adminid
        {
            this.adminid = adid;
        }

        public void setadname(string adname)//setter for adminname
        {
            this.adminname = adname;
        }

    }
}
