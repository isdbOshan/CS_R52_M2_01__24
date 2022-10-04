using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R52_M2_Class_09_Work_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Box b = new Box();
            b.Length = 10.5;
            b.Width = 8.5;
            Console.WriteLine(b.Area());
            Console.ReadLine();
        }
    }//Program
    public class Box
    {
        private double _Length;
        private double _Width;
        public double Length
        {
            get { return _Length; }
            set {
                if (value <= 0)
                    throw new Exception("Invalid length");
                else
                    _Length = value;
            }
        }
        public double Width
        {
            get { return _Width; }
            set
            {
                if (value <= 0)
                    throw new Exception("Invalid width");
                else
                    _Width = value;
            }
        }
        public double Area()
        {
            return _Length * _Width;
        }
    }
    
}

