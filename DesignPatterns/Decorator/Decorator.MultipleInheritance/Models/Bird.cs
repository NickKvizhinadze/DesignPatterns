using System;
using Decorator.MultipleInheritance.Interfaces;

namespace Decorator.MultipleInheritance.Models
{
    public class Bird : IBird
    {
        public int Weight { get; set; }
        public void Fly()
        {
            Console.WriteLine($"Soaring in the sky with {Weight}");
        }
    }
}
