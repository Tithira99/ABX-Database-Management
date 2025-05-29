using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABX_Database
{
    class Supplierc
    {
        
            private string supid;
            private string supName;
            private string supAddress;
            
            public Supplierc()
            {

            }

            public Supplierc(string id)
            {
                this.supid = id;

            }
            public Supplierc(string id, string name, string address)
            {
                this.supid = id;
                this.supName = name;
                this.supAddress = address;
                
            }

            public string getid()
            {
                return this.supid;
            }

            public string getname()
            {
                return this.supName;
            }

            public string getaddress()
            {
                return this.supAddress;

            }
           
            public void setID(string id)
            {
                this.supid = id;

            }

            public void setname(string name)
            {
                this.supName = name;

            }
            public void setaddress(string address)
            {
                this.supAddress = address;

            }
           

    }


}
