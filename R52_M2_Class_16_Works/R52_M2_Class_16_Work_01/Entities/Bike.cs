using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R52_M2_Class_16_Work_01.Entities
{
    public class Bike:TwoWheeler
    {
        string[] exterior;
        public Bike() { }
        public Bike(VehicleType type, int engineCapacity, string model, int yearMake, 
            int numberOfGear, bool frontBrake, bool rearBrake, double milage, string cooling)
            :base(type,engineCapacity, model, yearMake, numberOfGear, frontBrake, rearBrake, milage)
        {
            
            Cooling = cooling;
        }

        public string Cooling { get; set; }
        public void AddExteriorDesign(string[] design)
        {
            this.exterior = design;
        }
        public string GetExteriorDesign()
        {
            return string.Join(",", exterior);
        }
        public override string Info()
        {
            return $"{base.Info()}\nFeature: {GetExteriorDesign()}";
        }
    }
}
