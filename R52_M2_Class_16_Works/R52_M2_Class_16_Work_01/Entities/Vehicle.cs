using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R52_M2_Class_16_Work_01.Entities
{
    public class Vehicle
    {
        public Vehicle() { }
        public Vehicle(VehicleType type, int engineCapacity)
        {
            Type = type;
            EngineCapacity = engineCapacity;
        }

        public VehicleType Type { get; set; }
        public int EngineCapacity { get; set; } 
        public virtual string Info()
        {
            return $"{Type}, {EngineCapacity}cc";
        }
       

    }
}
