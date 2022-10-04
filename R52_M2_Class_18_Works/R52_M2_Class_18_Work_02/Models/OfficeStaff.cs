using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R52_M2_Class_18_Work_02.Models
{
    public class OfficeStaff: Staff
    {
        public OfficeStaff() { }
        public OfficeStaff(int id, string name, OfficeDesignation officeDesignation):base(id, name)
        {
            OfficeDesignation = officeDesignation;
        }

        public OfficeDesignation OfficeDesignation { get; set; }
        public override string Info()
        {
            return $"{base.Info()}, Designation: {OfficeDesignation}";
        }
    }
}
