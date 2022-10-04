using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R52_M2_Class_23_Work_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var dumbs = new[]
            {
                new {Name="Curly", Rank=3},
                new{Name="Moe", Rank=4},
                new{Name="Larry", Rank=5},
                new{Name="Abott", Rank=3},
                new {Name="Costello", Rank=5}
            };
            dumbs.OrderBy(d=> d.Rank)
                .ToList()
                .ForEach(d=> Console.WriteLine($"{d.Name}-{d.Rank}"));
            Console.WriteLine();
            dumbs.Where(d => d.Rank == dumbs.Max(x => x.Rank))
            .ToList()
            .ForEach(d => Console.WriteLine($"{d.Name}-{d.Rank}"));
            Console.WriteLine();
            dumbs.Where(d => d.Rank == dumbs.Min(x => x.Rank))
            .ToList()
            .ForEach(d => Console.WriteLine($"{d.Name}-{d.Rank}"));
            Console.ReadLine();
        }
    }
}
