using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApplication8
{
    public delegate void calculateInterest(int principal, int rate, int years);
    class DeligatesAssignment
    {

       

        public static void getInterest(int principle, int rate, int years)
        {
            Console.WriteLine("Interest is:{0}",(principle*rate*years/100));
        }

        public static void getInterestRate(int principle,int interest,int years)
        {
           
            Console.WriteLine("Interest rate is:{0}", ((interest*100)/(principle*years)));
            
        }
        public static void getInterestingFact(string fact)
        {
            Console.WriteLine(fact);
        }





    }
}
