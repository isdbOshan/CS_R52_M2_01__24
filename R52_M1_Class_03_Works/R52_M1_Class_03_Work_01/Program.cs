using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R52_M1_Class_03_Work_01
{
    internal class Program
    {     
        static void Main(string[] args)
        {
            Console.Write("Your name: ");
            string name = Console.ReadLine();
            Console.Write("Yearly income: ");
            decimal income = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine($"Income : {income:0.00}");
            Console.WriteLine($"Tax to pay: {income * 7.5M / 100}");
            Console.ReadLine();
        }//Main
        
    }//Program
  
}//namespace
