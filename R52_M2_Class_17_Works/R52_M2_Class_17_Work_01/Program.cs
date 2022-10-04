using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R52_M2_Class_17_Work_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 11, 14, 17, 22, 9, 21 };
            int[] numberscopy = new int[numbers.Length+1];
            numbers.CopyTo(numberscopy, 1);
            foreach(int i in numberscopy)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();
            int[] numberscopy2 = new int[3];
            Array.Copy(numbers, 1, numberscopy2, 0, 3);
            foreach (int i in numberscopy2)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();
            int[] cloned = (int[])numbers.Clone();
            foreach (int i in cloned)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}
