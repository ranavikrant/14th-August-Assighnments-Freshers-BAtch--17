using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication8
{
    class Program
    {
          
        static void Main(string[] args)
        {
            // var test = 1234567890;
            // int test2 = 300000;
            // int c;
            // try
            // {
            //     // c = checked(test * test2);
            //    // Console.WriteLine(c);
            // }
            // catch(Exception E)
            // {
            //     Console.WriteLine("Number out of bound");
            // }


            // if(test is int)
            // {
            //     Console.WriteLine("Its int");

            // }
            // object[] obj = new object[4];
            // obj[0] = 34;
            // obj[2] = "Hellow";
            // obj[1] = new IsAs();

            // obj[3] = null;
            // foreach(object i in obj)
            // {
            //     IsAs ss = i as IsAs;

            //     //ss=i as IsAs;

            //     if (ss == null)
            //     {
            //         Console.WriteLine("Not  Object of IsAs");
            //     }
            //     else
            //     {
            //         ss.x = Convert.ToInt32(Console.ReadLine());
            //         Console.WriteLine(ss.x);

            //     }
            // }
            // Console.WriteLine("type:{0}",typeof(object));

            // long val = 9000000000000000444;
            //// int j =checked( (int)val);
            //// Console.WriteLine(j);
            // string s = "4";
            // int parsed = int.Parse( s);
            // object o = parsed;
            // int k = (int)o;
            // IsAs A = new IsAs();
            // IsAs B = A;
            // baseClass b = new baseClass();
            //// derieved d = new derieved();
            // derieved dcopy = (derieved)b;
            // dcopy.hi();
            //   Console.WriteLine(ReferenceEquals(A,B));

           // DeligatesAssignment d = new DeligatesAssignment(); 
           //// public delegate void calculateInterest(int principal, int rate, int years);
        
           // calculateInterest c = new calculateInterest(DeligatesAssignment.getInterest);
           // c += new calculateInterest(DeligatesAssignment.getInterestRate);
           // Console.WriteLine("Enter Principle,rate and tenure");
           // int principle = Convert.ToInt32(Console.ReadLine());
           // int rate = Convert.ToInt32(Console.ReadLine());
           // int tenure = Convert.ToInt32(Console.ReadLine());
            
           // c+=(n,m,r)=> {
           //     Console.WriteLine("This is lambda call");
           // };
           // c(principle, rate, tenure);

           // Func<int, int, int> add = Sum;
           // int result = add(10, 10);

           // Console.WriteLine("sum is:{0}",result);
           // Action<int> printActionDel = ConsolePrint;
           // printActionDel(10);

           // Events e = new Events();
           // e.subscribe(e);
           // e.print();

            List<Employee> empList = new List<Employee>();
            empList.Add(new Employee("abc","aProject","aDept",1));
            empList.Add(new Employee("def", "bProject", "bDept", 2));
            empList.Add(new Employee("kaka", "cProject", "cDept", 3));
            empList.Add(new Employee("mama", "dProject", "dDept", 4));
            empList.Add(new Employee("nana", "eProject", "eDept", 5));
            Console.WriteLine("Employee with id<3");
            foreach  (Employee e in empList.Where(e=>e.ID<3))
            {
                Console.WriteLine("Name: {0}", e.name);
            }

            Console.WriteLine("Employee nana exists or not");
           if( empList.Exists(e => (e.name == "nana")))
            {
                Console.WriteLine("Nana exists");
            }

            Console.WriteLine("sum of ids");
            int sum = empList.Sum(e => e.ID);
            Console.WriteLine(sum);





            Console.ReadLine();
        }

        static void ConsolePrint(int i)
        {
            Console.WriteLine("This is printing action:{0}",i);
        }

        static int Sum(int x, int y)
        {
            return x + y;
        }
    }
}
