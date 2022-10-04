using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R52_M2_Class_13_Work_04.Models
{
    public abstract class Person
    {
        public Person(string name, DateTime birthDate)
        {
            this.Name = name;
            this.BirthDate = birthDate;
        }

        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public abstract string Age();

    }
}
