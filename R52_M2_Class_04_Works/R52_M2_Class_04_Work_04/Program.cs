using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R52_M2_Class_04_Work_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Message("");
            Message("Hello");
            FormattedMessage("Message");
            FormattedMessage("Message", "warning");
            FormattedMessage(type: "warning", msg: "A fatal error encountered.");
            Console.ReadLine();
        }//Main
        static void Message(string msg)
        {
            if(msg == "")
            {
                return;
            }
            Console.WriteLine(msg);
            
        }
        static void FormattedMessage( string msg , string type= "info")
        {
            if(type == "info")
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine(msg);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(msg);
            }
        }
    }//Program
}//namespace
