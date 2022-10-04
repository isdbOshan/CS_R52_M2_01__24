using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R52_M2_Class_12_Work_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = new double[] { 9.33, 7.22, 12.11, 11.06 };
            foreach (double n in numbers)
            {
                Console.WriteLine(n);
            }
            Console.WriteLine("Sorted in ascending order");
            Array.Sort(numbers);
            //var q1 = from n in numbers
            //         orderby n
            //         select n;
            foreach (double n in numbers)
            {
                Console.WriteLine(n);
            }
            Array.Reverse(numbers);
            Console.WriteLine("Sorted in descending order");
            //var q2 = from n in numbers
            //         orderby n descending
            //         where n > 10
            //         select n;
            foreach (double n in numbers)
            {
                Console.WriteLine(n);
            }
            Console.WriteLine($"Sum={numbers.Sum()}");
            Console.WriteLine($"Avg={numbers.Average()}");
            Console.WriteLine($"Max={numbers.Max()}");
            Console.WriteLine($"Min={numbers.Min()}"); 
            Console.ReadLine();
        }
    }
}
