using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R52_M2_Class_12_Work_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Store follwing data in an array
             * 39 11 34, 51, 17, 52
             * Sort them and print
             * 
             * Print only numbers divisible by 17
             * */
            int[] values = new int[] { 39, 11, 34, 51, 17, 52 };
            Array.Sort(values);
            foreach (int value in values)
            {
                Console.Write(value+ " ");
            }
            Console.WriteLine();
            foreach (int value in values)
            {
                if (value % 17 == 0) Console.Write(value + " ");
            }
            /*
            Console.WriteLine();
            var q1 = from n in values
                     where n % 17 == 0
                     select n;     
            foreach (int value in q1)
            {
                Console.Write(value + " ");
            }
            Console.WriteLine();
            values
                     .Where(n => n%17==0)
                     .ToList()
                     .ForEach(n => Console.Write(n + " "));
            */
            Console.ReadLine();
        }
        
    }
}
