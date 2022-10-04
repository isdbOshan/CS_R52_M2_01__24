using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R52_M2_Class_06_Work_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            M1();
            Console.ReadLine();
        }

        static void M1()
        {
            try
            {
                int a = 20, b = 10;
                int r = a / b;
                throw new Exception("A fatal error");
            }
            catch (Exception ex)
            {

                Console.WriteLine("Message: " + ex.Message);
                Console.WriteLine("StackTrace:  " + ex.StackTrace);
                Console.WriteLine("Source: " + ex.Source);
            }
            finally
            {
                Console.WriteLine("Done");
            }
            
        }
    }
}
