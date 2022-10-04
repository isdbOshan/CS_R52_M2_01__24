using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace R52_M2_Class_25_Work_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Task> tasks = new List<Task>();
            int[] numbers = { 40, 25, 35, 20 };
            for (int i = 0; i < numbers.Length; i++)
            {
                var t= RunSumAsync($"1+2+3+...+{numbers[i]}", numbers[i]);
                tasks.Add(t);
            }
            Console.WriteLine("Waiting......");
            Task.WaitAll(tasks.ToArray());
            Console.WriteLine("All processing ended");
            Console.ReadLine();
        }
        static async Task RunSumAsync(string label, int n)
        {
            int sum = await SumAsync(n);
            Console.WriteLine($"{label}: {sum}");
        }
        static async Task<int> SumAsync(int n)
        {
            int sum = 0;
            
            await Task.Run(() =>
            {
                Console.WriteLine($"Thread {Thread.CurrentThread.ManagedThreadId} started with {n}");
                for (int i = 0; i <= n; i++)
                {
                    sum += i;
                    Task.Delay(100).Wait();
                }
                Console.WriteLine($"{Thread.CurrentThread.ManagedThreadId} calculated sum {sum}");
            });
            return sum;

        }
    }
}
