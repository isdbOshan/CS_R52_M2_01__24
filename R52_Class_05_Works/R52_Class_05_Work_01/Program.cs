using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R52_Class_05_Work_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a whole number: ");
            int n = int.Parse(Console.ReadLine());
            if (n % 2 == 0)
            {
                Console.WriteLine($"{n} is even");
            } 
            else
            {
                Console.WriteLine($"{n} is odd");
            }
                

            Console.ReadLine();
        }//Main
    }//Program
}//namespace
