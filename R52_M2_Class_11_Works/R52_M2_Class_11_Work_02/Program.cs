using System;

namespace R52_M2_Class_11_Work_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            //Rectangle r = new Rectangle();
            //r.Length = 5.4;
            //r.Width = 4.2;
            Rectangle r = new Rectangle { Length = 5.4, Width = 4.2 };
            PrintArea(r);
            Circle c = new Circle { Radius = 5.0 };
            PrintArea(c);
            Triangle t = new Triangle { SideA = 3.0, SideB = 4.0, SideC = 5.0 };
            PrintArea(t);
            Console.ReadLine();
        }
        public static void PrintArea(Shape s)
        {
            Console.WriteLine($"Area={s.Area()}");
        }

    }
}
