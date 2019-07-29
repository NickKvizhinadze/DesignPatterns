using System;
using Decorator.MultipleInheritance.Interfaces;

namespace Decorator.MultipleInheritance.Models
{
    public class Lizard : ILizard
    {
        public int Weight { get; set; }
        public void Crawl()
        {
            Console.WriteLine($"Crawling in the dirt with {Weight}");
        }
    }
}
