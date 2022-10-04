using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R52_M2_Class_18_Work_02.Models
{
    public class AcademicStaff:Staff
    {
        public AcademicStaff() { }
        public AcademicStaff(int id, string name,AcademicDesignation academicDesignation):base(id, name)
        {
            AcademicDesignation = academicDesignation;
        }

        public AcademicDesignation AcademicDesignation { get; set; }
        public override string Info()
        {
            return $"{base.Info()}, Designation: {AcademicDesignation}";
        }
    }
}
