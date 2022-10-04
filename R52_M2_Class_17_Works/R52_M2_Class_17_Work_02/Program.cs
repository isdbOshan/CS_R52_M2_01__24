using R52_M2_Class_17_Work_02.Books;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R52_M2_Class_17_Work_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintBook b1 = new PrintBook("C#", 1450.00M, new DateTime(2021, 11, 7), "Programming", 150.00M);
            Console.WriteLine(b1.Details());
            Console.WriteLine();
            EBook b2 = new EBook("SQL", 1720.00M, new DateTime(2019, 7, 3), "Database", Format.PDF, true);
            Console.WriteLine(b2.Details());
            Console.WriteLine();
            EBook b3 = new EBook("UML", 1720.00M, new DateTime(2019, 7, 3), "Database", Format.EPub, false);
            Console.WriteLine(b3.Details());
            Console.ReadLine();
        }
    }
}
