using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R52_M2_Class_14_Work_02.Entities
{
    public sealed class Student : Person, ISubject
    {
        private string[] subjects;
        public Student() { }
        public Student(int id, string name, DateTime dob, Semester semester, DateTime admissionDate):base(name, dob)
        {
            Id = id;
            Semester = semester;
            AdmissionDate = admissionDate;
            
        }

        public int Id { get; set; }
        public Semester Semester { get; set; }
        public DateTime AdmissionDate { get; set; }
        public override string Age()
        {
            var age = DateTime.Now - DateOfBirth;
            int y = age.Days / 365;
            int m = (age.Days % 365) / 30;
            return $"{y:00} years {m:00} months";
        }

        public string GetSubjects()
        {
            return string.Join(",", this.subjects);
        }
        public void Add(string[] subjects)
        {
            this.subjects = subjects;
        }
        public override string ToString()
        {
            return $"{Name}, Id: {Id}\n{Semester}, {AdmissionDate:yyyy-MM-dd}";
        }
    }
}
