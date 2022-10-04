using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R52_Class_05_Work_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 1;
            for (; ;)
            {
                Console.WriteLine(n);
                n++;
                if (n == 11) break;
            }
            Console.WriteLine();
            for(int i=1; i<=10; i++)
            {
                if (i %2 == 1) continue;
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }//Main
    }//Program
}//namespace
