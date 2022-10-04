using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R52_M2_Class_09_Work_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Box b = new Box();
            b.Length = 10.5;
            b.Width = 8.5;
            Console.WriteLine(b.Area());
            Box b2 = new Box(5.5, 4.5);
            Console.WriteLine (b2.Area());
            Console.ReadLine();
        }//Main
    }
}
