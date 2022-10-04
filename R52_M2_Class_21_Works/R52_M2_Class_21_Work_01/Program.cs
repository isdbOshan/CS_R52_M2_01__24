using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R52_M2_Class_21_Work_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Queue");
            Queue<string> queue = new Queue<string>();
            queue.Enqueue("X");
            queue.Enqueue("D");
            queue.Enqueue("C");
            queue.Enqueue("M");
            queue.Enqueue("W");
            while(queue.Count > 0)
            {
                Console.WriteLine(queue.Dequeue());
            }
            Console.WriteLine("Stack");
            Stack<string> stack = new Stack<string>();
            stack.Push("X");
            stack.Push("D");
            stack.Push("C");
            stack.Push("M");
            stack.Push("W");
            while(stack.Count> 0)
            {
                Console.WriteLine(stack.Pop());
            }
            Console.ReadLine();
        }
    }
}
