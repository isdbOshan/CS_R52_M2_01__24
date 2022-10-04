using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R52_M2_Class_17_Work_03.Models
{
    public enum Designation { Executive, Assitant, Manager}
    public class Employee
    {
        public Employee() { }
        public Employee(int id, string name, DateTime joinDate)
        {
            Id = id;
            Name = name;
            JoinDate = joinDate;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime JoinDate { get; set; }
        public virtual string Details()
        {
            return $"Id:{Id} Name:{Name}, Join date{JoinDate:yyyy-MM-dd}";
        }
        
    }
    public class PermanentEmployee : Employee
    {
        public PermanentEmployee() { }
        public PermanentEmployee(int id, string name, DateTime joinDate, Designation designation, decimal basic):base(id, name, joinDate)
        {
            Designation = designation;
            Basic = basic;
        }

        public Designation Designation { get; set; }
        public decimal Basic { get; set; }
        public decimal Salary()
        {
            return Basic + .45M * Basic + .15M * Basic;
        }
        public override string Details()
        {
            return $"{base.Details()} Designation: {Designation}";
        }
    }
    public class HiredEmployee : Employee
    {
        public HiredEmployee() { }
        public HiredEmployee(int id, string name, DateTime joinDate,decimal payRatePerDay):base(id, name, joinDate)
        {
            PayRatePerDay = payRatePerDay;
        }

        public decimal PayRatePerDay { get; set; }  
        public decimal Salary(int year, int month)
        {
            return PayRatePerDay*DateTime.DaysInMonth(year, month);
        }
        public override string Details()
        {
            return $"{base.Details()} Pay Rate/Day: {PayRatePerDay:0.00}";
        }
    }
    
}
