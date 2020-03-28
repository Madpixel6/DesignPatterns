using System;
using System.Collections.Generic;
using FactoryMethod.Models;

namespace FactoryMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var products = new List<Product>
            {
                new Laptop(),
                new Workstation(),
                new Tablet()
            };
            foreach(var item in products)
            {
                item.CreateProduct($"Average {item.GetType().Name}");
                Console.WriteLine(item.Description +", it has these parts:");
                foreach (var part in item.Parts)
                { 
                    Console.WriteLine("- " +part.Name + ", priced at:"+ part.Cost);
                } 
                Console.WriteLine("======================");
            }

            Console.ReadKey();
        }
    }
}
