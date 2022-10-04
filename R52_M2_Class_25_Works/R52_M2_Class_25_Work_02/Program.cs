using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace R52_M2_Class_25_Work_02
{
    internal class Program
    {
        static  void Main(string[] args)
        {
            var t1=Task.Run(() => Run());
            var t2 = Task.Run(() => Run());
            Task.WaitAll(t1, t2);
            Run();
            Console.ReadLine();
        }
        static void Run()
        {
            for (int i = 1; i <= 20; i++)
            {
                Thread.Sleep(250);
                Console.WriteLine(Thread.CurrentThread.ManagedThreadId + ": " + i);
            }
        }
    }
}
