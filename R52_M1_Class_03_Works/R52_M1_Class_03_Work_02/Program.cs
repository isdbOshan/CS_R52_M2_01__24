using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R52_M1_Class_03_Work_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 20,  y = 12;
            Console.WriteLine($"{x}+{y}={x + y}");
            Console.WriteLine($"{x}-{y}={x - y}");
            Console.WriteLine($"{x}*{y}={x * y}");
            Console.WriteLine($"{x}/{y}={x / y}");
            Console.WriteLine($"{x}/{y}={(double)x / y}");
            Console.WriteLine($"{x}%{y}={x % y}");
            Console.ReadLine();
        }//Main
    }
}
