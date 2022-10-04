using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R52_M2_Class_04_Work_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = GetLuckyNumber();
            Console.WriteLine(n);
            Console.WriteLine(GetNum(30, 50));
            Console.ReadLine();
        }//Main
        static int GetLuckyNumber()
        {
            Random r = new Random();
            return r.Next(1, 10);
        }
        static int GetNum(int min, int max)
        {
            Random r = new Random();
            return r.Next(min, max);
        }
    }//Program
}//namespace
