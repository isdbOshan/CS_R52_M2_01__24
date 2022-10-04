using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R52_M2_Class_22_Work_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>()
            {
                new Product{Name="Topi", Category="Caps", Price=150.00M, Stock=60},
                new Product{Name="Sacrf", Category="Scarfs & Bandana", Price=300.00M, Stock=30},
                new Product{ Name="Musk", Category="Musks", Price=230.00M, Stock=45},
                new Product{Name="Short Sacrf", Category="Scarfs & Bandana", Price=250.00M, Stock=30},
                new Product{Name="Pakistani Topi", Category="Caps", Price=400.00M, Stock=30},
                new Product{Name="KN95 Musk", Category="Musks", Price=300.00M, Stock=30},
            };
            var q1 = from p in products
                     group p by p.Category into gr
                     select gr;
            foreach(var g in q1)
            {
                Console.WriteLine(g.Key);
                foreach(var p in g)
                {
                    Console.WriteLine($"\t{p.Name}, {p.Price}");
                }
            }
            Console.WriteLine();
            products
                .GroupBy(p => p.Category)
                .ToList()
                .ForEach(g =>
                {
                    Console.WriteLine(g.Key);
                    foreach (var p in g)
                    {
                        Console.WriteLine($"\t{p.Name}, {p.Price}");
                    }
                });
            Console.ReadLine();
        }
    }
    public class Product
    {
        public string Name { get; set; }
        public string Category { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
    }
}
