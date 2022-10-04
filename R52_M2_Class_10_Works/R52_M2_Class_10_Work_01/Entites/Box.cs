using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R52_M2_Class_10_Work_01.Entites
{
    public class Box
    {
        #region Fields
        private double _length;
        private double _width;
        #endregion
        #region Ctors
        public Box():this(1.0,1.0)
        {
            
        }
        public Box(double length, double width)
        {
           this.Length = length;
            this.Width = width;
        }
        #endregion
        #region Props
        public double Length
        {
            get { return _length; }
            set
            {
                if (value > 0) _length = value;
                else throw new Exception("Lengh must be > 0");
            }
        }
        public double Width
        {
            get { return _width; }
            set
            {
                if (value > 0) _width = value;
                else throw new Exception("Width must be > 0");
            }
        }
        #endregion
        #region Methods
        public double Circuference()
        {
            return 2 *( this.Length + this.Width);
        }
        public double Area()
        {
            return this.Length * this.Width;
        }
        #endregion
    }//Box
}
