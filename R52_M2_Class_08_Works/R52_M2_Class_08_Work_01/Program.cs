using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace R52_M2_Class_08_Work_01
{
    internal class Program
    {
        static string globalVar = "ESAD";
        static void Main(string[] args)
        {
            Console.WriteLine("Operators");
            OperatorEx();
            Console.WriteLine("Expression");
            ExpressionEx();
            Console.WriteLine("Global & Local Scope");
            ScopeEx();
            Console.WriteLine("Decisions");
            DecisionEx();
            Console.WriteLine("Compound Statements");
            CompoundStamentsEx();
            Console.WriteLine("Loops");
            LoopsEx();
            Console.WriteLine("Prefix & PostFix");
            PrePostFixEx();
            Console.WriteLine("Exception handling");
            ExceptionsEx();
            Console.WriteLine("Methods");
            Console.WriteLine("Call by position");
            ShowMessage("Hello", 3);
            Console.WriteLine("Call by name");
            ShowMessage(n: 2, msg: "ESAD");
            Console.WriteLine("Optional parameter");
            FomatMessage("52", "Round");
            FomatMessage("Hello");
            Console.WriteLine("Return value");
            double r = Add(.76, .312);
            Console.WriteLine(r);
            Console.WriteLine("Multiple return value");
            var rr = AddNumbers(.566, .121);
            Console.WriteLine($"Sum={rr.sum}, Average={rr.avg}");
            Console.ReadLine();
        }//Main
        private static (double sum, double avg) AddNumbers(double a, double b)
        {
            return (a + b, (a + b) / 2);
        }
        private static double Add(double v1, double v2)
        {
            return v1 + v2;
        }

        private static void FomatMessage(string msg, string label="")
        {
            if(label!="")
            {
                Console.WriteLine($"{label}: {msg}");
            }
            else
            {
                Console.WriteLine($"{msg}");
            }
        }

        private static void ShowMessage(string msg, int n)
        {
            for (int i=1; i<= n; i++)
            {
                Console.WriteLine(msg);
            }
        }

        private static void ExceptionsEx()
        {
            try
            {
                //throw new DivideByZeroException("Diviide by zero");
                throw new FormatException("Input not in correct format");
                //throw new FileNotFoundException("File not found");
            }
            catch(DivideByZeroException dex) {
                Console.WriteLine(dex.Message);
            }
            catch(FormatException fex) {
                Console.WriteLine(fex.Message);
            }
            catch(Exception ex) {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Exiting..");
            }
        }

        private static void PrePostFixEx()
        {
            int n = 10, m;
            m = n++;
            Console.WriteLine($"n = {n}, m={m}");
            m = ++n;
            Console.WriteLine($"n = {n}, m={m}");
        }

        private static void LoopsEx()
        {
            Console.WriteLine("for loop");
            for(int i=1; i <= 5; i++)
            {
                Console.Write($"{i}\t");
            }
            Console.WriteLine();
            Console.WriteLine("while loop");
            int n = 1;
            while (n <= 5)
            {
                Console.Write($"{n}\t");
                n++;
            }
            Console.WriteLine();
            Console.WriteLine("do while loop");
            do
            {
                Console.WriteLine(n);
                n++;
            }while (n <= 5); //one time executing loop body
           
        }

        private static void CompoundStamentsEx()
        {
            int x = 10, y=2;
            x += y;
            x *= y+1;
            x /= y;
            Console.WriteLine(x);
        }

        private static void DecisionEx()
        {
            Console.WriteLine("if...else ...");
            if(DateTime.Now.DayOfWeek == DayOfWeek.Friday)
            {
                Console.WriteLine("Today is off day");
            }
            else if (DateTime.Now.DayOfWeek == DayOfWeek.Saturday)
            {
                Console.WriteLine("Today is off day");
            }
            else
            {
                Console.WriteLine("Today is work day");
            }
            Console.WriteLine("switch.. case..");
            switch (DateTime.Now.DayOfWeek)
            {
                case DayOfWeek.Friday:
                    Console.WriteLine("Today is off day");
                    break;
                case DayOfWeek.Saturday:
                    Console.WriteLine("Today is off day");
                    break;
                default:
                    Console.WriteLine("Today is off day");
                    break;
            }
        }

        private static void ScopeEx()
        {
            string localVar = "Round 52";
            {
                string scopeVar = "ACSL";
                Console.WriteLine($"{globalVar} {localVar} {scopeVar}");
            }
            Console.WriteLine($"{globalVar} {localVar}");
        }

        private static void ExpressionEx()
        {
            int a = 10, b = 4, c = 3;
            Console.WriteLine($"a - c * b /c={a - c * b / c}");
        }

        private static void OperatorEx()
        {
            //int x = 20, y = 7;
            Random r = new Random();
            int x = r.Next(10, 20);
            int y = r.Next(1, 10);
            Console.WriteLine($"{x}+{y}={x + y}");
            Console.WriteLine($"{x}-{y}={x - y}");
            Console.WriteLine($"{x}*{y}={x * y}");
            Console.WriteLine($"{x}/{y}={x / y}");
            Console.WriteLine($"{x}%{y}={x % y}");
        }
    }//Program
}
