using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R52_M2_Class_06_Work_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for(int i=1; i< 10; i++)
            {
                Console.Write($"{i}\t");
                if (i % 3 == 0) Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
