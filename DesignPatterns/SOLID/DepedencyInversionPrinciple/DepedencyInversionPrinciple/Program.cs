using DepedencyInversionPrinciple.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepedencyInversionPrinciple
{
    class Program
    {
        public Program(Relationships relationships)
        {
            var relations = relationships.FindAllChildrenOf("John");
            foreach (var child in relations)
            {
                Console.WriteLine($"John has a child called {child.Name}");
            }
        }
        static void Main(string[] args)
        {
            //Research
            var parent = new Person { Name = "John" };
            var child1 = new Person { Name = "Chris" };
            var child2 = new Person { Name = "Mary" };

            var relationships = new Relationships();
            relationships.AddParentAndChild(parent, child1);
            relationships.AddParentAndChild(parent, child2);

            new Program(relationships);
        }
    }
}
