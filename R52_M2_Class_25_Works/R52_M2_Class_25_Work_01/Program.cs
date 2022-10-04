using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace R52_M2_Class_25_Work_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Thread th1 = new Thread(Run);
            Thread th2 = new Thread(Run);
            th1.Start();
            th2.Start();
            th1.Join();
            //th2.Join();
            Run();
            Console.ReadLine();
        }
        static void Run()
        {
            for(int i=1; i <= 100; i++)
            {
                Thread.Sleep(250);
                Console.WriteLine(Thread.CurrentThread.ManagedThreadId + ": " + i);
            }
        }
    }
}
