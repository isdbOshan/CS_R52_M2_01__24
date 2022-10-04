using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R52_M2_Class_14_Work_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] rainfallls = { 7.33, 11.80, 22.30, 5.15 };
            Console.WriteLine(SumUp(rainfallls));
            Console.WriteLine(SumUp(new double[] { 11.33, 7.19, 8.33 }));
            Console.WriteLine(SumUpParams(7.33, 11.80, 22.30, 5.15));
            Console.ReadLine();
        }//Main
        private static double SumUp(double[] numbers)
        {
            return numbers.Sum();
        }
        private static double SumUpParams(params double[] numbers)
        {
            return numbers.Sum();
        }
        /*private static double SumUpParamsG(params object[] values)
        {
            double sum = 0;
            foreach(object o in values)
            {
                double d = (double)o;
                if(d != Double.NaN)
                {
                    sum += d;
                }
            }
            return sum;
        }*/
    }
}
