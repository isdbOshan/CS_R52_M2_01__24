using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R52_M2_Class_13_Work_04.Models
{
    public sealed class Trainee:Person
    {
        public Trainee(int id, string name, DateTime birthDate, Course course, int round, Status status):base(name, birthDate)
        {
            this.Id = id;
            this.Course = course;
            this.Round = round;
            this.Status = status;
        }
        public int Id { get; set; }
        public Course Course { get; set; }
        public int Round {get; set; }
        public Status Status { get; set; }

        public override string Age()
        {
            var age = DateTime.Now - this.BirthDate;
            int y = age.Days / 365;
            int m = (age.Days % 365) / 30;
            return $"{y} years {m} months";
        }
    }
}
