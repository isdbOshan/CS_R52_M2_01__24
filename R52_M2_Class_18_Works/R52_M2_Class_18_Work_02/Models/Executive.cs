using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R52_M2_Class_18_Work_02.Models
{
    public class Executive:OfficeStaff
    {
        public Executive() { }
        public Executive(int id, string name, OfficeDesignation officeDesignation):base(id, name, officeDesignation) { }
        string[] roles;
        public void AddRoles(string[] roles)
        {
            this.roles = roles;
        }
        public string GetRoles()
        {
            return string.Join(",", roles);
        }
    }
}
