using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R52_Class_05_Work_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number #1: ");
            double n1 = double.Parse(Console.ReadLine());
            Console.Write("Enter number #2: ");
            double n2 = double.Parse(Console.ReadLine());
            Console.Write("Choose operator [+, -, *, /]: ");
            string op = Console.ReadLine();
            if(op == "+")
            {
                Console.WriteLine($"{n1}{op}{n2}={n1 + n2}");
            }
            else if (op == "-")
            {
                Console.WriteLine($"{n1}{op}{n2}={n1 - n2}");
            }
            else if (op == "*")
            {
                Console.WriteLine($"{n1}{op}{n2}={n1 * n2}");
            }
            else if(op == "/")
            {
                Console.WriteLine($"{n1}{op}{n2}={n1 / n2}");
            }
            else
            {
                Console.WriteLine("Invalid operator");
            }
            Console.WriteLine();
            switch (op)
            {
                case "+":
                    Console.WriteLine($"{n1}{op}{n2}={n1 + n2}");
                    break;
                case "-":
                    Console.WriteLine($"{n1}{op}{n2}={n1 - n2}");
                    break;
                case "*":
                    Console.WriteLine($"{n1}{op}{n2}={n1 * n2}");
                    break;
                case "/":
                    Console.WriteLine($"{n1}{op}{n2}={n1 / n2}");
                    break;
                default:
                    Console.WriteLine("Invalid operator");
                    break;
            }
            Console.ReadLine();
        }//Main
    }//Program
}//namespace
