using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R52_M2_Class_20_Work_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<double> list = new List<double>
            {
                98.33, 77.11, 11.26, 22.33, 40.42, 27.12
            };
            list.ForEach(d => Console.WriteLine(d));
            Console.WriteLine();
            var q1 = from d in list
                     where d > 30
                     select d;
            foreach (var d in q1)
            {
                Console.WriteLine(d);
            }
            Console.WriteLine();
            list.Where(d => d > 30)
                .ToList()
                .ForEach(d => Console.WriteLine(d));
            Console.ReadLine();
        }
    }
}
