using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R52_M1_Class_02_Work_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string project = "IsDb-BISEW IT Scholarship Project";
            Console.WriteLine(project.ToLower());
            Console.WriteLine(project.ToUpper());
            Console.WriteLine($"Total characters: {project.Length}");
            Console.WriteLine($"Total characters (without spaces): {project.Replace(" ", "").Length}");
            decimal deposit = 987.87654M;
            Console.WriteLine($"Deposit: {deposit:0.00}");
            Console.WriteLine($"Today: {DateTime.Now:yyyy-MM-dd HH:mm tt}");
            Console.ReadLine();
        }//Main
    }//Program
}//namespace
