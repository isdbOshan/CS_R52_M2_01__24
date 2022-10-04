using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R52_M2_Class_23_Work_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> production = new Dictionary<string, int>
            {
                ["Rice"] = 970000,
                ["Wheat"] = 630000,
                ["Corn"] = 270000,
                ["Oil"] = 560000
            };
            production.OrderBy(kv => kv.Value)
                .ToList()
                .ForEach(kv => Console.WriteLine($"{kv.Key}: {kv.Value}"));
            Console.WriteLine();
            production.OrderByDescending(kv => kv.Key)
                .ToList()
                .ForEach(kv => Console.WriteLine($"{kv.Key}: {kv.Value}"));
            Console.WriteLine();
            Console.WriteLine($"Total Production: {production.Sum(kv => kv.Value)}");
            Console.ReadLine();

        }
    }
}
