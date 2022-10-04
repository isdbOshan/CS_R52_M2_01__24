using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R52_M2_Class_12_Work_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int[] numbers = new int[3];
            numbers[0] = random.Next(1, 5000);
            numbers[1] = random.Next(1, 5000);
            numbers[2] = random.Next(1, 5000);
            for(int i=0;i<numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
            Console.WriteLine();
            foreach(int n in numbers)
            {
                Console.WriteLine(n);
            }
            Console.WriteLine($"Sum={numbers.Sum()}");
            Console.WriteLine($"Avg={numbers.Average()}");
            Console.WriteLine($"Max={numbers.Max()}");
            Console.WriteLine($"Min={numbers.Min()}");
            Console.ReadLine();
        }//Main
    }
}
