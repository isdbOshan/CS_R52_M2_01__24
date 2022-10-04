using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R52_M2_Class_18_Work_02.Models
{
    public class Faculty : AcademicStaff
    {
        public Faculty() { }
        public Faculty(int id, string name, AcademicDesignation academicDesignation):base(id, name,academicDesignation)
        {

        }
        string[] subjects;
        public void AddSubjects(string[] subjects)
        {
            this.subjects = subjects;
        }
        public string GetSubjects()
        {
            return string.Join(",", subjects);
        }
    }
}
