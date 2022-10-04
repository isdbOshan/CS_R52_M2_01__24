using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R52_M2_Class_14_Work_02.Entities
{
    public abstract class Person
    {
        public Person() { }
        public Person(string name, DateTime dob) 
        { 
            this.Name = name; this.DateOfBirth = dob;
        }

        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public abstract string Age();
    }
}
