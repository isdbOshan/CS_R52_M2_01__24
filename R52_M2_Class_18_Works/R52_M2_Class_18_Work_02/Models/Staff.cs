using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R52_M2_Class_18_Work_02.Models
{
    public class Staff
    {
        public Staff() { }
        public Staff(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public virtual string Info()
        {
            return $"Id:{Id}, Name: {Name}";
        }
    }
}
