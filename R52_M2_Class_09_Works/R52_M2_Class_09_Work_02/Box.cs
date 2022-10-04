using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R52_M2_Class_09_Work_02
{
    public class Box
    {
        private double _Length;
        private double _Width;
        public Box() { }
        public Box(double l, double w)
        {
            this.Length = l;
            this.Width = w;
        }
        public double Length
        {
            get { return _Length; }
            set
            {
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
