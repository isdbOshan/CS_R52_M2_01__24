using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R52_M2_Class_21_Work_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> set = new HashSet<int>();
            set.Add(21);
            set.Add(22);
            set.Add(43);
            foreach(int n in set)
            {
                Console.WriteLine(n);
            }
            HashSet<int> set2 = new HashSet<int>();
            set2.Add(11);
            set2.Add(21);
            set2.Add(43);
            set2.Add(47);
            var intersect = set.Intersect<int>(set2);
            Console.WriteLine();
            foreach(int n in intersect)
            {
                Console.WriteLine(n);
            }
            var union = set.Union<int>(set2);
            Console.WriteLine();
            foreach (int n in union)
            {
                Console.WriteLine(n);
            }
            Console.ReadLine();
        }
    }
}
