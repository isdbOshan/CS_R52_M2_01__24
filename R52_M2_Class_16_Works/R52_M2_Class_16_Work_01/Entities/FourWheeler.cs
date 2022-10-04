using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace R52_M2_Class_16_Work_01.Entities
{
    public class FourWheeler:Vehicle
    {
        public FourWheeler() { }
        public FourWheeler(VehicleType type, int engineCapacity,string model, int yearMake, int numberOfGear, 
            int numbOfSeat):base(type, engineCapacity)
        {
            Model = model;
            YearMake = yearMake;
            NumberOfGear = numberOfGear;
            NumbOfSeat = numbOfSeat;
        }

        public string Model { get; set; }
        public int YearMake { get; set; }
        public int NumberOfGear { get; set; }
        public int NumbOfSeat { get; set; }
        public override string Info()
        {
            return $"{Model}, {YearMake}\n{base.Info()}\nSeats: {NumbOfSeat}";
        }
    }
}
