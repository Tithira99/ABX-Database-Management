using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABX_Database
{
    class Loginc
    {
        private string password;
        private string username;
        private string adid;//admin id which is a forign key references admin table

        public Loginc()//default constructor for logi class
        {


        }
        public Loginc(string usrnm)//parameterized constructor for login class with one parameter(identifier)
        {
            this.username = usrnm;
        }


        public Loginc(string pswrd, string usrnm)//Parameterized constructor for login class with 2 parameters
        {
            this.password = pswrd;
            this.username = usrnm;
        }
        public Loginc(string pswrd, string usrnm, string aid)//parameterized constructor for login class with 3 parameters
        {
            this.password = pswrd;
            this.username = usrnm;
            this.adid = aid;
        }

        public string getpswrd()//getter for the password
        {
            return this.password;
        }

        public string getusrnm()//getter for the user name
        {
            return this.username;
        }

        public string getaid()//getter for the admin id
        {
            return this.adid;
        }
        public void setpswrd(string pswrd)//setter for the password 
        {
            this.password = pswrd;
        }

        public void setusrnm(string usrnm)//setter for the user name
        {
            this.username = usrnm;
        }
        public void setaid(string aid)//setter for the  admin id 
        {

            this.adid = aid;
        }
    }
}
