using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R52_M2_Class_24_Work_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle c1 = new Circle { Radius = 3.0 };
            Circle c2 = new Circle { Radius = 4.0 };
            Circle big = c1 + c2;
            Circle small = c1 - c2;
            Console.WriteLine($"{big.Radius:0.00}R Area={big.Area:0.00}");
            Console.WriteLine($"{small.Radius:0.00}R Area={small.Area:0.00}");
            big++;
            small--;
            Console.WriteLine($"{big.Radius:0.00}R Area={big.Area:0.00}");
            Console.WriteLine($"{small.Radius:0.00}R Area={small.Area:0.00}");
            Console.WriteLine(c1 == c2);
            Console.WriteLine(c1 != c2);
           
            Console.ReadLine();
        }
    }
    public class Circle
    {
        public double Radius { get; set; }  
        public double Area { get => Math.PI * Radius * Radius; }
        public static Circle operator + (Circle l, Circle r)
        {
            return new Circle { Radius = l.Radius + r.Radius };
        }
        public static Circle operator - (Circle l, Circle r)
        {
            return new Circle { Radius = Math.Abs(l.Radius - r.Radius) };
        }
        public static Circle operator ++ (Circle c)
        {
            return new Circle { Radius = c.Radius + 1 };
        }
        public static Circle operator --(Circle c)
        {
            return new Circle { Radius = c.Radius - 1 > 1 ? c.Radius-1:0 };
        }
        public static bool operator == (Circle l, Circle r)
        {
            return l.Radius == r.Radius;
        }
        public static bool operator !=(Circle l, Circle r)
        {
            return l.Radius != r.Radius;
        }
    }
}
