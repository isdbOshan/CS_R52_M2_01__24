using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R52_M2_Class_20_Work_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ValueContainer<int> c1 = new ValueContainer<int> { Value = 212 };
            ValueContainer<string> c2 = new ValueContainer<string> { Value = "Habib" };
            double a = 1.9, b = 7.3;
            Console.WriteLine($"{a},{b}");
            Swap<double>(ref a, ref b);
            Console.WriteLine($"{a},{b}");
            Console.ReadLine();
        }
        static void Swap<T>(ref T x, ref T y)
        {
            T pot = x;
            x = y;
            y = pot;
        }
    }
    public class ValueContainer<T>
    {
        public T Value { get; set; }
    }
}
