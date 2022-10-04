using R52_M2_Class_16_Work_01.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R52_M2_Class_16_Work_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car c1 = new Car(VehicleType.Racing, 4000, "Ferrari 10XT", 2016, 6, 6, 4);
            c1.AddInteriorDesign(new string[] { "Auto Gear", "AC", "GPS" });
            Console.WriteLine(c1.Info());
            Console.WriteLine();
            Bike b1 = new Bike { Type = VehicleType.Normal, EngineCapacity = 80, Model = "Stylex", 
                NumberOfGear = 4, Milage = 60.0, 
                Cooling = "Air Cooling", RearBrake = true, YearMake = 2018, FrontBrake = true };
            b1.AddExteriorDesign(new string[] { "Fog Light", "VIP Hprn" });
            Console.WriteLine(b1.Info());
            Console.ReadLine();
        }
    }
}
