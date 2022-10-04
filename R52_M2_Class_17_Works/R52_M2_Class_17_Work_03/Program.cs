using R52_M2_Class_17_Work_03.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R52_M2_Class_17_Work_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PermanentEmployee e1 = new PermanentEmployee (1, "E1", new DateTime(2021, 2, 1), Designation.Manager, 45000.00M);
            Console.WriteLine (e1.Details());
            Console.WriteLine($"Salary: {e1.Salary()}");
            Console.WriteLine();
            HiredEmployee e2 = new HiredEmployee(2, "E2", new DateTime(2022, 1, 1), 2500.00M);
            Console.WriteLine(e2.Details());
            Console.WriteLine($"Salary current month: {e2.Salary(DateTime.Now.Year, DateTime.Now.Month)}");
            Console.ReadLine();
        }
    }
}
