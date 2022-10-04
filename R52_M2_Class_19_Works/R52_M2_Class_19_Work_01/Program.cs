using R52_M2_Class_19_Work_01.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R52_M2_Class_19_Work_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            Console.WriteLine("Input");
            Console.WriteLine("********************");
            Console.Write("ID: ");
            emp.Id = int.Parse(Console.ReadLine());
            Console.Write("Name: ");
            emp.Name = Console.ReadLine();
            Console.Write("Birth Date: ");
            emp.BirthDate = DateTime.Parse(Console.ReadLine());
            Console.Write("Join Date: ");
            emp.JoinDate = DateTime.Parse(Console.ReadLine());
            Console.Write("Designation [Programmer,QA,DBA]: ");
            emp.Designation = (Designation)Enum.Parse(typeof(Designation), Console.ReadLine());
            Console.Write("Roles: ");
            emp.AddRoles(Console.ReadLine().Split(','));
            Console.WriteLine("Output");
            Console.WriteLine("********************");
            Console.WriteLine($"ID: {emp.Id}");
            Console.WriteLine($"Name: {emp.Name}");
            Console.WriteLine($"Birth date: {emp.BirthDate:yyyy-MM-dd}");
            Console.WriteLine($"Jon Date: {emp.JoinDate:yyyy-MM-dd}");
            Console.WriteLine($"Desination: {emp.Designation}");
            Console.WriteLine($"Age: {emp.Age()}");
            Console.WriteLine($"Role plays: {emp.RolePlays()}");
            Console.ReadLine();
        }
    }
}
