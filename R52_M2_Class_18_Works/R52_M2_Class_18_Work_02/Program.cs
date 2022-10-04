using R52_M2_Class_18_Work_02.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R52_M2_Class_18_Work_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Faculty f1 = new Faculty(103, "F1", AcademicDesignation.Teacher);
            f1.AddSubjects(new[] { "Prigramming", "Database" });
            Executive e1 = new Executive(209, "E1", OfficeDesignation.Peon);
            e1.AddRoles(new[] { "Helping", "Coveying" });
            Console.WriteLine(f1.Info());
            Console.WriteLine($"Subjects: {f1.GetSubjects()}");
            Console.WriteLine();
            Console.WriteLine(e1.Info());
            Console.WriteLine($"Roles: {e1.GetRoles()}");
            Console.ReadLine();
        }
    }
}
