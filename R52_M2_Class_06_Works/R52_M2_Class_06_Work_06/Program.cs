using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R52_M2_Class_06_Work_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"5!={Factorial(5)}");
            Console.WriteLine($"12!={Factorial(12)}");
            Console.ReadLine();
        }//Main
        static long Factorial(int n)
        {
            long f = 1;
            for(int i=n; i >= 1; i--)
            {
                f *= i;
            }
            return f;
        }
    }
}
