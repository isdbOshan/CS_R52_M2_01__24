using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R52_M2_Class_21_Work_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> capitals = new Dictionary<string, string>();
            capitals["Bangladesh"] = "Dhaka";
            capitals.Add("India", "Delhi");
            capitals["Nepal"] = "Kathmundu";
            capitals.Add("Bhutan", "Thimpu");
            foreach(KeyValuePair<string, string> pair in capitals)
            {
                Console.WriteLine($"{pair.Key}: {pair.Value}");
            }
            Console.WriteLine();
            foreach(string key in capitals.Keys)
            {
                Console.WriteLine($"{key}: {capitals[key]}");
            }
            Console.ReadLine();
        }
    }
}
