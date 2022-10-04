using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R52_M2_Class_11_Work_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IShape r = new Rectangle { Length = 5.4, Width = 4.2 };
            PrintArea(r);
            Circle c = new Circle { Radius = 5.0 };
            PrintArea(c);
            Triangle t = new Triangle { SideA = 3.0, SideB = 4.0, SideC = 5.0 };
            PrintArea(t);
            Console.ReadLine();
        }
        public static void PrintArea(IShape s)
        {
            Console.WriteLine($"Area={s.Area()}");
        }
    }
}
