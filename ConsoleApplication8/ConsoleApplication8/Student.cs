using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication8
{
    class Employee
    {

        public int ID;
        public string name;
        public string dName;
        public string pName;

        public Employee(string name, string pname, string dname, int ID)
        {
            this.ID = ID;
            this.name = name;
            this.pName = pname;
            this.dName = dname; 
        }
    }
}
