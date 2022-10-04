using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R52_Class_05_Work_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter marks: ");
            double mark = double.Parse(Console.ReadLine());
            if (mark >= 80)
                Console.WriteLine("Grade A+");
            else if (mark >= 70)
                Console.WriteLine("Grade A");
            else if (mark >= 60)
                Console.WriteLine("Grade A-");
            else if (mark >= 50)
                Console.WriteLine("Grade B");
            else if (mark >= 40)
                Console.WriteLine("Grade C");
            else if (mark >= 33)
                Console.WriteLine("Grade D");
            else
                Console.WriteLine("Grade F");

            Console.ReadLine();

        }//Main
    }//Program
}//namespace
