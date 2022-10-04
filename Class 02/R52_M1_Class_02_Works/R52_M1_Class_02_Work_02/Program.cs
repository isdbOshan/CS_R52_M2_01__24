using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R52_M1_Class_02_Work_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Whole numbers
            int n = 10;
            long m = 20L; //L for long
            Console.WriteLine($"n={n}");
            Console.WriteLine($"m={m}");
            //fraction
            float f = 3.33F; //F for float
            double d = 6.78;
            decimal p = 7.15M; //M for decimal
            Console.WriteLine($"f={f}");
            Console.WriteLine($"d={d}");
            Console.WriteLine($"p={p}");
            //bool
            bool isOk = false;
            bool isEven = 5 % 2 == 0;
            Console.WriteLine($"{isOk}");
            Console.WriteLine($"{isEven}");

            Console.ReadLine();
        }//Main
    }//Program
}//namespace
