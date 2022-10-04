using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R52_M2_Class_04_Work_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            M1();
            M1("Hello");
            M1(30);
            Console.ReadKey();
        }//Main
        static void M1()
        {
            Console.WriteLine("M1");
        }
        static void M1(string message)
        {
            Console.WriteLine(message);
        }
        static void M1(int n)
        {
            Console.WriteLine($"I got {n}");
        }
    }//Program
}//namespace
