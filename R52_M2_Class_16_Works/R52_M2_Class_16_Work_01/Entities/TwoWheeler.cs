using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R52_M2_Class_16_Work_01.Entities
{
    public class TwoWheeler:Vehicle
    {
        public TwoWheeler() { }
        public TwoWheeler(VehicleType type, int engineCapacity, string model, int yearMake, int numberOfGear, 
            bool frontBrake, bool rearBrake, double milage): base(type, engineCapacity)
        {
            Model = model;
            YearMake = yearMake;
            NumberOfGear = numberOfGear;
            FrontBrake = frontBrake;
            RearBrake = rearBrake;
            Milage = milage;
        }

        public string Model { get; set; }
        public int YearMake { get; set; }
        public int NumberOfGear { get; set; }
        public bool FrontBrake { get; set; }    
        public bool RearBrake { get; set; }
        public double Milage { get; set; }
        public override string Info()
        {
            return $"{Model}, {YearMake}\n{base.Info()}\nMilage {Milage}KMPL";
        }
    }
}
