using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R52_M2_Class_21_Work_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, double> marks = new Dictionary<string, double>
            {
                ["AnyT"]=    67.5,
                ["JabT"]=    78.4,
                ["MosT"]=    56.7,
                ["SakT"]=    78.0
            };
            marks.OrderBy(kv => kv.Value)
                .ToList()
                .ForEach(kv => Console.WriteLine($"{kv.Key}: {kv.Value}"));

            var highest = marks.Max(kv => kv.Value);
            Console.WriteLine("Highest mark achiever");
            //var q1 = from kv in marks
            //         where kv.Value == highest
            //         select kv.Key;
            
            //foreach (var name in q1)
            //{
            //    Console.WriteLine(name);
            //}
            marks.Where(kv => kv.Value == highest)
                .ToList()
                .ForEach(kv => Console.WriteLine(kv.Key));
            Console.ReadLine();
        }
    }
}
