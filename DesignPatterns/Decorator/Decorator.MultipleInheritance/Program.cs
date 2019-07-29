using Decorator.MultipleInheritance.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.MultipleInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            var dragon = new Dragon();
            dragon.Weight = 80;
            dragon.Fly();
            dragon.Crawl();
            
        }
    }
}
