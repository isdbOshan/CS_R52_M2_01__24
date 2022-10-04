using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R52_M2_Class_04_Work_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var r = SumUp(.9, .11, .7);
            Console.WriteLine($"Sum={r.Item1}, Average: {r.Item2}");
            var r1 = SumUp(.9, .7);
            Console.WriteLine($"Sum={r1.sum}, average={r1.avg}, max={r1.max}, min={r1.min}");
            Console.ReadLine();
        }//Main
        static (double, double) SumUp(double a, double b, double c)
        {
            return (a + b + c, (a + b + c) / 3);
        }
        static  (double sum, double avg, double max, double min) SumUp(double a, double b)
        {
            return (a + b, a + b / 2, a > b ? a : b, a < b ? a : b);
        }
    }//Program
}//namespace
