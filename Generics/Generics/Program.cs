using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            ListClass<int> L = new ListClass<int>();
            L.add(1);
        }
    }
}
