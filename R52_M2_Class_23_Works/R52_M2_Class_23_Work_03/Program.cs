using R52_M2_Class_23_Work_03.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R52_M2_Class_23_Work_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Category> categories = new List<Category>
            {
                new Category{ CategoryId=1, Name="C1"},
                new Category{ CategoryId=2, Name="C2"},
                new Category { CategoryId=3, Name="C3"},
                new Category{ CategoryId=4, Name="C4"},
                new Category{CategoryId=5, Name="C5"}
            };
            List<Product> products = new List<Product>
            {
                new Product{Id=1, Name="P1", Price=9.99M, CategoryId=1},
                new Product{Id=2, Name="P2", Price=97.99M, CategoryId=1},
                new Product{Id=3, Name="P3", Price=8.99M, CategoryId=2},
                new Product{Id=4, Name="P4", Price=6.99M, CategoryId=3},
                new Product{Id=5, Name="P5", Price=7.55M, CategoryId=4}
            };
            var q = from p in products
                    join c in categories on p.CategoryId equals c.CategoryId
                    select new {p.Name, p.Price, Category=c.Name};
            foreach(var x in q)
            {
                Console.WriteLine($"{x.Name}\t{x.Price}\t{x.Category}");
            }
            Console.WriteLine();
            products.Join(categories,
                p => p.CategoryId,
                c => c.CategoryId,
                (p, c) => new { p.Name, p.Price, Category = c.Name })
                .ToList()
                .ForEach(x => Console.WriteLine($"{x.Name}\t{x.Price}\t{x.Category}"));
            Console.WriteLine();
            products.GroupBy(p => p.CategoryId)
                .ToList()
                .ForEach(g=>
                {
                    Console.WriteLine(categories.First(c=> c.CategoryId == g.Key).Name);
                    g.ToList()
                    .ForEach(p =>
                    {
                        Console.WriteLine($"\t{p.Name} {p.Price}");
                    });
                });
             Console.WriteLine();
            categories.ForEach(c =>
            {
                Console.WriteLine(c.Name);
                products.Where(p => p.CategoryId == c.CategoryId)
                .ToList()
                .ForEach(p => Console.WriteLine($"\t{p.Name} {p.Price}"));
            });
            Console.ReadLine();
        }
    }
}
