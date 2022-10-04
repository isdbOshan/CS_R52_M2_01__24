using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R52_M2_Class_13_Work_01
{
    public enum Course { ESAD=1, NT, GAVE, J2EE, WPFI, DDD}
    internal class Program
    {
        static void Main(string[] args)
        {
            Course myCource = Course.ESAD;
            myCource++;
            Console.WriteLine(myCource);
            Console.WriteLine((int)myCource);
            Console.ReadLine();
        }
    }
}
