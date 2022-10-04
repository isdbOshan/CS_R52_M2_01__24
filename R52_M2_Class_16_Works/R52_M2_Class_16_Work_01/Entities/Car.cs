using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R52_M2_Class_16_Work_01.Entities
{
    public class Car:FourWheeler
    {
        public Car() { }
        public Car(VehicleType type, int engineCapacity, string model, int yearMake, int numberOfGear, int numbOfSeat, 
            int numberOfDoor):base(type,engineCapacity, model, yearMake, numberOfGear, numbOfSeat)
        {
            NumberOfDoor = numberOfDoor;
        }
        string[] interior;
        public int NumberOfDoor { get; set; }
        public void AddInteriorDesign (string[] design)
        {
            this.interior = design;
        }
        public string GetInterorDesign()
        {
            return string.Join(",", interior);
        }
        public override string Info()
        {
            return $"{base.Info()}\nFeature: {GetInterorDesign()}";
        }
    }
}
