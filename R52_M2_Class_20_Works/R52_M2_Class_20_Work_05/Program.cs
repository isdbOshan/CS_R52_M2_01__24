using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R52_M2_Class_20_Work_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            list.Add(33);
            list.Add(20);
            Console.WriteLine("Count: "+list.Count);
            Console.WriteLine("Capacity "+list.Capacity);
            list.AddRange(new int[] { 37, 11 });
            list.Add(21);
            Console.WriteLine("Count: " + list.Count);
            Console.WriteLine("Capacity " + list.Capacity);
            foreach (int n in list)
            {
                Console.WriteLine(n);
            }
            list.RemoveAt(1);
            list.Remove(11);
            Console.WriteLine("Count: " + list.Count);
            Console.WriteLine("Capacity " + list.Capacity);
            foreach (int n in list)
            {
                Console.WriteLine(n);
            }
            Console.ReadLine();
        }
    }
}
