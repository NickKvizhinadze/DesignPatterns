using Factory.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            var factory = new PersonFactory();
            var person = factory.CreatePerson("Nick");
            var person1 = factory.CreatePerson("Nick 1");

            Console.WriteLine($"Id: {person1.Id} , Name: {person1.Name}");
        }
    }
}
