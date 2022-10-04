using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R52_M2_Class_01_Work_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string batch = "ESAD-CS";
            int round = 52;
            Console.WriteLine(batch + " Round " + round);
            Console.WriteLine("{0} Round {1}", batch, round);
            Console.WriteLine($"{batch} Round {round}");
            Console.ReadLine();
        }//Main
    }//Program
}//namespace
