using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R52_M2_Class_04_Work_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double m = 3.99, n = .786;
            Message($"{m}+{n}= {Add(m, n)}");
            PauseScreen();
        }//Main
        static void Message (string msg)=> Console.WriteLine(msg);
        static double Add(double a, double b)=> a + b;
        static void PauseScreen() => Console.ReadLine();
        
    }//Program
}//namespace
