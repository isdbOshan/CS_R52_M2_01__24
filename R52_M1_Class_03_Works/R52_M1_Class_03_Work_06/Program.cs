using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R52_M1_Class_03_Work_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Basic Salary: ");
            decimal basic = Convert.ToDecimal(Console.ReadLine());
            decimal hr = basic * .45M;
            Console.WriteLine($"Net Salary: {(basic + 1500+hr):0.00}");
            Console.ReadLine();
        }//Main
    }
}
