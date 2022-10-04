using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R52_M2_Class_21_Work_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> list = new LinkedList<int>();
            LinkedListNode<int> first =list.AddLast(23);
            list.AddAfter(first, 29);
            list.AddAfter(first, 17);
            list.AddBefore(first, 21);
            list.AddBefore(first, 49);
            for(var node =list.First; node!=null; node= node.Next)
            {
                Console.WriteLine(node.Value);
            }
            Console.ReadLine();
        }
    }
}
