using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R52_M2_Class_11_Work_02
{
    public class Shape
    {
        public virtual double Area()
        {
            return 0.0;
        }
    }
    public class Rectangle:Shape
    {
        public double Length { get; set; }
        public double Width { get; set; }
        public override double Area()
        {
            return Length * Width;
        }
    }
    public class Circle:Shape
    {
        public double Radius { get; set; }
        public override double Area()
        {
            return Math.PI * Radius * Radius;
        }
    }
    public class Triangle:Shape
    { 
        public double SideA { get; set; }
        public double SideB { get; set; }
        public double SideC { get; set; }
        public override double Area()
        {
            var s = (SideA + SideB + SideC) / 2;
            return Math.Sqrt(s * (s - SideA) * (s - SideB) * (s - SideC));
        }
    }
}
