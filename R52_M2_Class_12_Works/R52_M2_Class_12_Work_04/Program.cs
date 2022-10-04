using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R52_M2_Class_12_Work_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] table = new int[10, 10];
            for(int i=0; i< table.GetLength(0); i++)
            {
                for(int j=0; j< table.GetLength(1); j++)
                {
                    table[i, j] = (i+1)*(j+1);
                }
            }
            for (int i = 0; i < table.GetLength(0); i++)
            {
                for (int j = 0; j < table.GetLength(1); j++)
                {
                    Console.Write($"{table[i, j]}\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("Jagged array");
            string[][] cities= new string[3][]
            {
               new string[] {"Dhaka", "Chittagong", "Chapai" },
               new string[] {"Delhi", "Kolkata" },
               new string[] {"Lahore", "Islamabad", "Pindi" }
            };
            foreach (string[] item in cities)
            {
                foreach(string c in item)
                {
                    Console.Write($"{c}\t");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
