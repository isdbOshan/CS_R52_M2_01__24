using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R52_Class_05_Work_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Find the sum of all the consecutive number between 50 and 100
             * */
            int sum = 0;
            for(int i=50; i <= 100; i++)
            {
                sum += i;
            }
            Console.WriteLine($"50+51+..+100={sum}");
            Console.WriteLine();
            /*
             * Find the sum of all the odd and even number between 50 and 100
             * */
            int sumodd = 0, sumeven = 0;
            for (int i = 50; i <= 100; i++)
            {
                if (i % 2 == 0) sumeven += i;
                else sumodd += i;
            }
            Console.WriteLine($"51+53+..+99={sumodd}");
            Console.WriteLine($"50+52+..+100={sumeven}");
            Console.WriteLine();
            /*
            * Find the sum of 1*2*....*10
            * */
            int summ = 1;
            for (int i = 1; i <= 10; i++)
            {
                summ *= i;
            }
            Console.WriteLine($"1*2+..+10={summ}");
            Console.WriteLine();
            /*
             * Find the sum of 1^2 + 2^2....*10^2
             * */
            long sums = 0;
            for (int i = 1; i <= 10; i++)
            {
                sums *= i*i;
            }
            Console.WriteLine($"1^2+2^2+..+10^2={sums}");
            Console.WriteLine();
            Console.ReadLine();
        }//Main
    }//Program
}//namespace
