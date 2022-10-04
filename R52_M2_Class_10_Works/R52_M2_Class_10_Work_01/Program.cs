using R52_M2_Class_10_Work_01.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R52_M2_Class_10_Work_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Box b1 = new Box();
            Console.WriteLine($"Circumference: {b1.Circuference()}, AreaL {b1.Area()}");
            Box b2 = new Box(5.5, 4.5);
            Console.WriteLine($"Circumference: {b2.Circuference()}, AreaL {b2.Area()}");
            Console.ReadLine();
        }//Main
    }
}
