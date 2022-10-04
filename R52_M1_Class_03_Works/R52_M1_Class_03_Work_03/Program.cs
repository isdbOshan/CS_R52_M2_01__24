using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R52_M1_Class_03_Work_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("You name: ");
            string name = Console.ReadLine();
            Console.Write("Date of birth: ");
            DateTime dob = Convert.ToDateTime( Console.ReadLine());
            int age = (DateTime.Now - dob).Days / 365;
            Console.WriteLine($"{name} is of age {age}");
            Console.ReadLine();
        }//Main
    }
}
