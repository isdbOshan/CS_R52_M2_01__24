using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R52_M2_Class_07_Work_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 20;
            Console.WriteLine(n);
            Increase(n);
            Console.WriteLine(n);
            IncreaseBy5(ref n);
            Console.WriteLine(n);
            int p;
            //IncreaseBy5(ref p);
            
            Initialize(out p);
            Console.WriteLine(p);
            Console.ReadLine();
        }//Main
        static void Increase(int x)
        {
            x += 5;
        }
        static void IncreaseBy5(ref int x)
        {
            x += 5;
        }
        static void Initialize(out int x)
        {
            x = 10;
        }
    }//Program
}
