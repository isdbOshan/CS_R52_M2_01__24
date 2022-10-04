using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R52_M2_Class_19_Work_01.Models
{
    public class Person
    {
        public Person() { }
        public Person(string name, DateTime birthDate)
        {
            Name = name;
            BirthDate = birthDate;
        }

        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public int Age()
        {
            return DateTime.Now.Year- BirthDate.Year;
        }
        public virtual string Details()
        {
            return $"{Name} born {BirthDate:yyyy-MM-dd}";
        }
    }
}
