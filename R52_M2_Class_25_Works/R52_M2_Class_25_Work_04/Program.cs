using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace R52_M2_Class_25_Work_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 40, 25, 35, 20 };
            for(int i=0; i< numbers.Length; i++)
            {
                RunSum(numbers[i]);
            }
            Console.WriteLine("Waiting......");
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
            int sum = 0;
            Task.Run(() =>
            {
                Console.WriteLine($"Thread {Thread.CurrentThread.ManagedThreadId} started with {n}");
                for (int i = 0; i <= n; i++)
                {
                    sum += i;
                    Task.Delay(100).Wait();
                }
                Console.WriteLine($"{Thread.CurrentThread.ManagedThreadId} calculated sum {sum}");
            }).Wait();
            return sum;
            
        }
    }
}
