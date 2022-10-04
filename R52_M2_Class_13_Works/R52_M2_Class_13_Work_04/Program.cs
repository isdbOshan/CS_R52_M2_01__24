using R52_M2_Class_13_Work_04.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R52_M2_Class_13_Work_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Trainee[] trainees = new Trainee[]
            {
                new Trainee(1, "T1", new DateTime(1997, 2, 2), Course.ESAD, 52, Status.Continuing),
                new Trainee(2, "T2", DateTime.Parse("1998-07-12"), Course.NT, 50, Status.Withdrawn),
                new Trainee(3, "T3", new DateTime(1997, 2, 2), Course.GAVE, 52, Status.Continuing),
                new Trainee(4, "T4", new DateTime(1997, 2, 2), Course.ESAD, 52, Status.Continuing)
            };
            foreach(Trainee t in trainees)
            {
                Console.WriteLine($"{t.Id}\t{t.Name}\t{t.Course}\t{t.Round}\t{t.Status}\t{t.Age()}");
            }
            Console.ReadLine();
        }
    }
}
