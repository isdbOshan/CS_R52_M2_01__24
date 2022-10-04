using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R52_M2_Class_11_Work_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            B obj = new B(20);
            obj.M();
            Console.ReadLine();
            
        }//Main
    }//Program
    public class A
    {
        public A(int x)
        {
            PublicProp = x;
            Console.WriteLine("A instance is created");
        }
        private int PrivateProp { get; set; }
        protected int ProtectedProp { get; set; }
        public int PublicProp { get; set; }
    }
    public class B : A
    {
        public B(int x):base(x)
        {
            Console.WriteLine("B instance is created");
        }
        public void M()
        {
            base.ProtectedProp++;
            base.PublicProp++;
            Console.WriteLine(base.ProtectedProp);
            Console.WriteLine(base.PublicProp);
        }
    }
}
