using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R52_M2_Class_13_Work_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var data = new { Name = "Ashiquzzaman", Marks = 78.5, Grade = "A" };
            Console.WriteLine(data.GetType());
            Console.WriteLine($"{data.Name}, {data.Marks}, {data.Grade}");
            var prices = new[] {
                new {Item="AK47", Price=23000.00M},
                new {Item="Cruise Missaile", Price=43000.00M},
                new {Item="F35 War Fighter", Price=890000.00M}
            };
            foreach (var p in prices)
            {
                Console.WriteLine($"{p.Item} {p.Price}");
            }
            Console.ReadLine();
        }
    }
}
