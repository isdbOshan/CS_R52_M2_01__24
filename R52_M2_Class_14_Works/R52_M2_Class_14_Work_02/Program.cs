using R52_M2_Class_14_Work_02.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R52_M2_Class_14_Work_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student { Id = 1, Name="Arif", DateOfBirth= new DateTime(1999, 7, 12), Semester=Semester.Spring, AdmissionDate=new DateTime(2022, 3, 2) };
            Student s2 = new Student(2, "Shan.To", new DateTime(2000, 2, 12), Semester.Fall, new DateTime(2022, 4, 12));
            Console.WriteLine(s1);
            Console.WriteLine($"Age: {s1.Age()}");
            Console.WriteLine(s2);
            Console.WriteLine($"Age: {s2.Age()}");
            Console.ReadLine();
        }
    }
}
