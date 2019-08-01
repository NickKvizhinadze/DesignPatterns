using ChainOfResponsibility.MethodChain.Models;
using ChainOfResponsibility.MethodChain.Modifiers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility.MethodChain
{
    class Program
    {
        static void Main(string[] args)
        {
            var goblin = new Creature("Goblin", 2, 2);
            Console.WriteLine(goblin);

            var root = new CreatureModifier(goblin);

            Console.WriteLine("Let's prevent the goblin get bonuses");
            root.Add(new NoBonusesModifier(goblin));

            Console.WriteLine("Let's double the goblin's attack");
            root.Add(new DoubleAttackModifier(goblin));

            Console.WriteLine("Let's increase the goblin's defense");
            root.Add(new IncreasedDefenseModifier(goblin));

            root.Handle();
            Console.WriteLine(goblin);
        }
    }
}
