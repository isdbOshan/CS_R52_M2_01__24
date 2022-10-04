using R52_M2_Class_24_Work_02.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace R52_M2_Class_24_Work_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<ProductCategory> categories = new List<ProductCategory>
            {
                        new ProductCategory{ ProductCategoryID = 1,
                                            Name = "Bikes" },
                        new ProductCategory{ ProductCategoryID = 2,
                                        Name = "Components" },
                        new ProductCategory{ ProductCategoryID = 3,
                                        Name = "Clothing" },
                        new ProductCategory{ ProductCategoryID = 4,
                                        Name = "Accessories" },
                        new ProductCategory{ ProductCategoryID = 5,
                                        Name = "Mountain Bikes" }

            };
            List<ProductModel> models = new List<ProductModel>
            {
                new ProductModel{ ProductModelID = 1,
                                    Name = "Classic Vest" },
                new ProductModel{ProductModelID = 2,
                                Name = "Cycling Cap" },
                new ProductModel{ProductModelID = 3,
                                Name = "Full-Finger Gloves" },
                new ProductModel{ProductModelID = 4,
                                Name = "Half-Finger Gloves" },
                new ProductModel{ProductModelID = 5,
                                Name = "HL Mountain Frame" }
            };
            List<Product> products = new List<Product>
            {
               new Product { ProductID = 1,
                Name = "Mountain-100 Silver, 44",
                ProductNumber = "BK-M82S-44",
                Color = "Silver",
                StandardCost = 1912.1544,
                ListPrice = 3399.99,
                Size = 44,
                Weight = 9584.36,
                ProductCategoryID = 5,
                ProductModelID = 3 },

                new Product
                {
                    ProductID = 2,
                    Name = "Mountain-100 Silver, 48",
                    ProductNumber = "BK-M82S-48",
                    Color = "Silver",
                    StandardCost = 1912.1544,
                    ListPrice = 3399.99,
                    Size = 48,
                    Weight = 9715.9,
                    ProductCategoryID = 3,
                    ProductModelID = 2
                },
                new Product
                {
                    ProductID = 3,
                    Name = "Mountain-100 Black, 38",
                    ProductNumber = "BK-M82B-38",
                    Color = "Black",
                    StandardCost = 1898.0944,
                    ListPrice = 3374.99,
                    Size = 38,
                    Weight = 9230.56,
                    ProductCategoryID = 2,
                    ProductModelID = 1
                },
                new Product
                {
                    ProductID = 4,
                    Name = "Mountain-100 Black, 42",
                    ProductNumber = "BK-M82B-42",
                    Color = "Black",
                    StandardCost = 1898.0944,
                    ListPrice = 3374.99,
                    Size = 42,
                    Weight = 9421.06,
                    ProductCategoryID = 1,
                    ProductModelID = 4
                },

                new Product
                {
                    ProductID = 5,
                    Name = "Mountain-100 Black, 44",
                    ProductNumber = "BK-M82B-44",
                    Color = "Black",
                    StandardCost = 1898.0944,
                    ListPrice = 3374.99,
                    Size = 44,
                    Weight = 9584.36,
                    ProductCategoryID = 2,
                    ProductModelID = 11
                },

                new Product
                {
                    ProductID = 6,
                    Name = "Mountain-100 Black, 48",
                    ProductNumber = "BK-M82B-48",
                    Color = "Black",
                    StandardCost = 1898.0944,
                    ListPrice = 3374.99,
                    Size = 48,
                    Weight = 9715.9,
                    ProductCategoryID = 5,
                    ProductModelID = 3
                }
            };
            (from p in products
                      join c in categories on p.ProductCategoryID equals c.ProductCategoryID
                      join m in models on p.ProductModelID equals m.ProductModelID
                      select new { p.Name, Category = c.Name, Model = m.Name, p.Color, p.StandardCost, p.ListPrice, p.Weight, p.Size })
                     .ToList()
                     .ForEach(x => Console.WriteLine($"{x.Name} Categor={x.Category} Model={x.Model} Color={x.Color} Price={x.ListPrice} Cost={x.StandardCost}"));
            Console.WriteLine();
            products.Join(categories,
                p => p.ProductCategoryID,
                c => c.ProductCategoryID,
                (p, c) => new { p, c })
                .Join(models,
                x => x.p.ProductModelID,
                m => m.ProductModelID,
                (x, m) => new { x.p.Name, Category = x.c.Name, Model = m.Name, x.p.Color, x.p.StandardCost, x.p.ListPrice, x.p.Weight, x.p.Size })
                .ToList()
                .ForEach(x => Console.WriteLine($"{x.Name} Categor={x.Category} Model={x.Model} Color={x.Color} Price={x.ListPrice} Cost={x.StandardCost}"));
            Console.WriteLine();
            products.GroupBy(x => x.ProductCategoryID)
                .ToList()
                .ForEach(g =>
                {
                    Console.WriteLine(categories.First(c => c.ProductCategoryID == g.Key));
                    g.ToList()
                    .ForEach(x => Console.WriteLine($"\t{x.Name} Color={x.Color} Price={x.ListPrice} Cost={x.StandardCost}"));
                });
            Console.ReadLine();
                
        }
    }
}
