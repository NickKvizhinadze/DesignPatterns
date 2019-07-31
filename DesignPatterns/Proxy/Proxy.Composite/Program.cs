using Proxy.Composite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy.Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            var creatures = new Creature[100];
            foreach (Creature c in creatures)
            {
                c.X++;
            }

            var creatures2 = new Creatures(100);
            foreach (Creatures.CreatureProxy c in creatures2)
            {
                c.X++;
            }
        }
    }
}
