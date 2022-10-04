using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R52_M2_Class_07_Work_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for(int n = 1; n <= 10; n++)
            {
                Console.Write($"{(n + 1) * (n + 2) / 2 * n} ");
            }
            Console.ReadLine();
        }
    }
}
