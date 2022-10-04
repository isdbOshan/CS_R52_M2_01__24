using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R52_M2_Class_18_Work_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string line = "Oh hell yeah!";
            Console.WriteLine(line.StripSpaces());
            Console.WriteLine(line.StripSpaces("-"));
            Console.WriteLine("Iqubal Hossain".StripSpaces());
            Console.ReadLine();
        }
    }
}
