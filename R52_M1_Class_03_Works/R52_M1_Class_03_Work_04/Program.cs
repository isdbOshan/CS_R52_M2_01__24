using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R52_M1_Class_03_Work_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 10;
            int m = n++;//n += 1;//n = n + 1;
            int o = ++n;
            Console.WriteLine($"n={n}, m={m}, o={o}");
            Console.WriteLine($"{--o} {o--} {o}");
            Console.ReadLine();
        }//Main
    }
}
