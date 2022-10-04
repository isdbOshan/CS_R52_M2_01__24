using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R52_M2_Class_22_Work_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Owner> owners = new List<Owner>
            {
                new Owner{ OwnerId=1, OwnerName="K Uddin", Phone="01710XXXXXX"},
                new Owner{ OwnerId=2, OwnerName="H Uddin", Phone="01764XXXXXX"},
                new Owner{ OwnerId=3, OwnerName="R Uddin", Phone="01610XXXXXX"}
            };
            List<Car> cars = new List<Car>
            {
                new Car{ CarId=1, Model="Toyota X", RegistraionYear=2017, OwnerId=1},
                new Car{ CarId=2, Model="Toyota Y", RegistraionYear=2017, OwnerId=1},
                new Car{ CarId=3, Model="Honda X", RegistraionYear=2018, OwnerId=2},
                new Car{ CarId=4, Model="Toyota Y", RegistraionYear=2019, OwnerId=3}
            };
            owners.ForEach(o =>
            {
                Console.WriteLine($"{o.OwnerName}, {o.Phone}");
                cars.Where(c => c.OwnerId == o.OwnerId)
                .ToList()
                .ForEach(c => Console.WriteLine($"\t{c.Model}, {c.RegistraionYear}"));
            });
            cars.GroupBy(c => c.Model)
                .ToList()
                .ForEach(g =>
                {
                    Console.WriteLine(g.Key);
                    g.ToList()
                    .ForEach(x =>
                    {
                        Console.Write($"\t{x.CarId} {x.RegistraionYear} ");
                        var owner = owners.Where(o => o.OwnerId == x.OwnerId)
                            .First();
                        Console.WriteLine(owner.OwnerName);

                    });
                });
            Console.ReadLine();
        }
    }
    public class Owner
    {
        public int OwnerId { get; set; }    
        public string OwnerName { get; set; }
        public string Phone { get; set; }
    }
    public class Car
    {
        public int CarId { get; set; }
        public string Model { get; set; }
        public int RegistraionYear { get; set; }
        public int OwnerId { get; set; }
    }
}
