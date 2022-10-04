using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace R52_M2_Class_25_Work_03
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            int[] numbers = { 40, 25, 35, 20 };
            for (int i=0; i< numbers.Length; i++)
            {
                    RunSum(numbers[i]);
            }
            Console.ReadLine();
        }
        static void RunSum(int n)
        {
            Task.Run(() =>
            {
                int sum = Sum(n);
                Console.WriteLine(sum);
            });
        }
        static int Sum(int n)
        {
            Console.WriteLine($"Thread {Thread.CurrentThread.ManagedThreadId} started with {n}");
            int sum = 0;
            for(var i=1; i<=n; i++)
            {
                Thread.Sleep(100);
                sum += i;
            }
            Console.WriteLine($"{Thread.CurrentThread.ManagedThreadId} calculated sum {sum}");
            return sum;
        }
    }
}
