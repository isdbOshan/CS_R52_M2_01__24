using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R52_M2_Class_07_Work_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int? n = 20;
            int m = n ?? 30;
            Console.WriteLine(n?.ToString());
            if (n.HasValue)
            {
                Console.WriteLine(n);
            }
            else
            {
                Console.WriteLine("n is unassigned");
            }
            Console.WriteLine(m);
            int x = 10;
            object o = x; //boxing
            int y = (int)o; //unboxing
            Console.ReadLine();
        }//Main
    }
}
