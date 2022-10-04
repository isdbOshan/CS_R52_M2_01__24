using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R52_M2_Class_21_Work_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<double> rainfalls = new List<double>
            {
                71.33, 81.42, 87.21, 119.33, 77.67, 61.47
            };
            rainfalls.OrderBy(r=> r)
                .ToList()
                .ForEach(r=> Console.WriteLine(r));
            Console.WriteLine($"Average: {rainfalls.Average()}");
            Console.WriteLine($"Total: {rainfalls.Sum()}");
            Console.ReadLine();
        }
    }
}
