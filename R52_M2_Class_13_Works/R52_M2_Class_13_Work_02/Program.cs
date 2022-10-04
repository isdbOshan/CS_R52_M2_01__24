using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R52_M2_Class_13_Work_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(3, 4);
            Point p0 = new Point();
            Console.WriteLine(p1.Distance(p0));
            Console.WriteLine(p1.Distance(-3, -4));
            Console.WriteLine(p1);
            Console.ReadLine();
        }
    }
    public struct Point
    {
        public Point(int x, int y) { this.X = x; this.Y = y; }
        public int X { get; set; }
        public int Y { get; set; }
        public double Distance(Point p)
        {
            return Math.Sqrt((p.X - X) * (p.X - X) + (p.Y - Y) * (p.Y - Y));
        }
        public double Distance(int x, int y)
        {
            return Math.Sqrt((this.X - x) * (this.X - x) + (this.Y - y) * (this.Y - y));
        }
        public override string ToString()
        {
            return $"({this.X}, {this.Y})";
        }
    }
}
