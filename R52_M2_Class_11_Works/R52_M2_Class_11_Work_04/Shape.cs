using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R52_M2_Class_11_Work_04
{
    public interface IShape
    {
        double Area();

    }
    public class Rectangle : IShape
    {
        public double Length { get; set; }
        public double Width { get; set; }

        public double Area()
        {
            return Length*Width;
        }
    }
    public class Circle : IShape
    {
        public double Radius { get; set; }
        public  double Area()
        {
            return Math.PI * Radius * Radius;
        }
    }
    public class Triangle : IShape
    {
        public double SideA { get; set; }
        public double SideB { get; set; }
        public double SideC { get; set; }
        public  double Area()
        {
            var s = (SideA + SideB + SideC) / 2;
            return Math.Sqrt(s * (s - SideA) * (s - SideB) * (s - SideC));
        }
    }
}
