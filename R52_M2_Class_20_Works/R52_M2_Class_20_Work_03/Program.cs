using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R52_M2_Class_20_Work_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            uint m = 0b0_1010100110;
            uint n = 0b0_1011100010;
            Console.WriteLine($"Binary: {Convert.ToString(m, 2)}");
            Console.WriteLine($"Decimal: {Convert.ToString(m, 10)}");
            Console.WriteLine($"Binary: {Convert.ToString(n, 2)}");
            Console.WriteLine($"Decimal: {Convert.ToString(n, 10)}");
            Console.WriteLine("*****************************");
            Console.WriteLine($"m & n={Convert.ToString(m & n, 2)}");
            Console.WriteLine($"m & n={Convert.ToString(m & n, 10)}");
            Console.WriteLine("*****************************");
            Console.WriteLine($"m | n={Convert.ToString(m | n, 2)}");
            Console.WriteLine($"m | n={Convert.ToString(m | n, 10)}");
            Console.WriteLine("*****************************");
            Console.WriteLine($"m ^ n={Convert.ToString(m ^ n, 2)}");
            Console.WriteLine($"m ^ n={Convert.ToString(m ^ n, 10)}");
            Console.WriteLine("*****************************");
            Console.WriteLine($"~m={Convert.ToString(~m, 2)}");
            Console.WriteLine($"~m={Convert.ToString(~m, 10)}");
            Console.WriteLine("*****************************");
            Console.WriteLine($"m << 2={Convert.ToString(m << 2, 2)}");
            Console.WriteLine($"m << 2={Convert.ToString(m << 2, 10)}");
            Console.WriteLine("*****************************");
            Console.WriteLine($"m >> 2={Convert.ToString(m >> 2, 2)}");
            Console.WriteLine($"m >> 2={Convert.ToString(m >> 2, 10)}");
            Console.WriteLine("*****************************");
            Console.WriteLine($"6th bit is 0={(m & (1<<5)) == 0}");
            Console.WriteLine($"6th bit is 1={(m & (1 << 5)) != 0}");
            Console.WriteLine("*****************************");
            m &=  (~((uint)1 << 2));
            Console.WriteLine($"m={Convert.ToString(m, 2)}");
            Console.WriteLine($"m={Convert.ToString(m, 10)}");
            
            Console.ReadLine();
        }
    }
}
