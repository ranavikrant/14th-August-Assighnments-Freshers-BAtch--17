using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication8
{
    class IsAs
    {
        public int x;
    }
    public class baseClass
    {
        public void hello()
        {
            Console.WriteLine("Say hello");
        }
    }
    public class derieved:baseClass
    {
        public void hi()
        {
            Console.WriteLine("Say hi");
        }
    }


}
