using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R52_M2_Class_04_Work_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            FormattedMessage("I am going to teach you a lesson so hard..", 
                "warning");
            FormattedMessage("Work done", "info");
            Console.ReadLine();
        }//Main
        static void FormattedMessage(string message, string type)
        {
            if (type == "warning")
            {
                
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(message);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine(message);
            }
        }
    }//Program
}
