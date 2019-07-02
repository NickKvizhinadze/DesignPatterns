using OpenClosePrinciple.Filters;
using OpenClosePrinciple.Models;
using OpenClosePrinciple.Specifications;
using System;

namespace OpenClosePrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            Product[] products = new Product[]
            {
                new Product("Apple", Color.Green, Size.Small),
                new Product("Tree", Color.Green, Size.Large),
                new Product("House", Color.Blue, Size.Large)
            };

            var productFilter = new ProductFilter();

            Console.WriteLine("Green Products (old):");
            foreach (var product in productFilter.FilterByColor(products, Color.Green))
            {
                Console.WriteLine($" - {product.Name} is Green");
            }

            var betterFilter = new BetterFilter();

            Console.WriteLine("Green Products (new):");
            foreach (var product in betterFilter.Filter(products, new ColorSpecification(Color.Green)))
            {
                Console.WriteLine($" - {product.Name} is Green");
            }

            Console.WriteLine("Blue large Products:");
            foreach (var product in betterFilter.Filter(products, 
                new AndSpecification<Product>(
                    new ColorSpecification(Color.Blue),
                    new SizeSpecification(Size.Large)
                )))
            {
                Console.WriteLine($" - {product.Name} is Green");
            }


        }
    }
}
