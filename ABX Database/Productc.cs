using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABX_Database
{
    class Productc
    {
        private int prodID;
        private string prod_Des;
        private int S_UnitPrice;
        private int B_UnitPrice;
        private int Available_quty;
      

        public Productc()
        {

        }
        public Productc(int id)
        {
            this.prodID = id;
        }

        public Productc(int id, string Description, int SPrice, int BPrice)
        {
            this.prodID = id;
            this.prod_Des = Description;
            this.S_UnitPrice = SPrice;
            this.B_UnitPrice = BPrice;



        }
        public Productc(int id, string Description, int SPrice, int BPrice, int aqty)
        {
            this.prodID = id;
            this.prod_Des = Description;
            this.S_UnitPrice = SPrice;
            this.B_UnitPrice = BPrice;
            this.Available_quty = aqty;
          

        }

        public int getid()
        {
            return this.prodID;
        }
        public string getdescription()
        {
            return this.prod_Des;
        }
        public int getSPrice()
        {
            return this.S_UnitPrice;
        }
        public int getBPrice()
        {
            return this.B_UnitPrice;

        }

        public int getaqty()
        {
            return this.Available_quty;

        }



        public void setid(int id)
        {
            this.prodID = id;
        }
        public void setdescription(string description)
        {
            this.prod_Des = description;

        }
        public void setSPrice(int SPrice)
        {
            this.S_UnitPrice = SPrice;

        }
        public void setBPrice(int BPrice)
        {
            this.B_UnitPrice = BPrice;

        }
        public void setaqty(int aqty)
        {
            this.Available_quty = aqty;

        }





    }
}
