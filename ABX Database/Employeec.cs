using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABX_Database
{
    class Employeec
    {
        string empid;
        string empname;

        public Employeec()
        {

        }

        public Employeec(string eid)
        {
            this.empid = eid;
        }
        
        public Employeec(string eid, string name)
        {
            this.empid = eid;
            this.empname = name;

        }

        public string getid()
        {
            return this.empid;

        }
        public string getname()
        {
            return this.empname;
        }

        public void setid(string id)
        {
            this.empid = id;
        }
        public void setname(string name)
        {
            this.empname = name;
        }
    }
}
