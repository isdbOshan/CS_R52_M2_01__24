using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R52_M2_Class_19_Work_01.Models
{
    public class Employee:Person
    {
        string[] roles;
        public Employee() { }
        public Employee(int id, string name, DateTime birthDate, DateTime joinDate, Designation designation):base(name, birthDate)
        {
            Id = id;
            JoinDate = joinDate;
            Designation = designation;
        }

        public int Id { get; set; }
        public DateTime JoinDate { get; set; }
        public Designation Designation { get; set; }
        public void AddRoles(string[] roles)
        {
            this.roles = roles;
        }
        public string RolePlays()
        {
            return string.Join(", ", roles);
        }
        public override string Details()
        {
            return $"{base.Details()}\n Id: {Id}, Designation:{Designation}";
        }
    }
}
