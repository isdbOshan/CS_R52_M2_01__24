using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace R52_M2_Class_20_Work_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Record> records = new List<Record>()
            {
                new Record{ Name="Scarf", Value=42},
                new Record{ Name="Beauty Box", Value=7},
                new Record { Name="Grooming Essentials", Value=15}

            };
            records.ForEach(r => Console.WriteLine($"{r.Name} {r.Value}"));
            Console.WriteLine();
            var q1 = from r in records
                     orderby r.Value 
                     select r;
            q1.ToList()
                .ForEach(r => Console.WriteLine($"{r.Name} {r.Value}"));
            Console.WriteLine();
            records.OrderBy(r => r.Value)
                .ToList()
                .ForEach(r => Console.WriteLine($"{r.Name} {r.Value}"));
            Console.ReadLine();
        }
    }
    public class Record
    {
        public string Name { get; set; }
        public int Value { get; set; }
    }
}
