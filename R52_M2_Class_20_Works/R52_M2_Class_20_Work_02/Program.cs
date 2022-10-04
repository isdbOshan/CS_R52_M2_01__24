using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R52_M2_Class_20_Work_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            uint n = 0b0_1010100110;
            
            Console.WriteLine($"Binary: {Convert.ToString(n, 2)}");
            Console.WriteLine($"Decimal: {Convert.ToString(n, 10)}");
            Console.WriteLine($"Hexa: {Convert.ToString(n, 16)}");
            Console.WriteLine($"Octal: {Convert.ToString(n, 8)}");
            Console.ReadLine();
        }
    }
}
