using System;
using ChainOfResponsibility.BrokerChain.Models;
using ChainOfResponsibility.BrokerChain.Modifiers;

namespace ChainOfResponsibility.BrokerChain
{
    class Program
    {
        static void Main(string[] args)
        {
            var game = new Game();
            var goblin = new Creature(game, "Strong Goblin", 3, 3);

            using (new DoubleAttackModifier(game, goblin))
            {
                Console.WriteLine(goblin);
                using(new IncreaseDefenseModifier(game, goblin))
                {
                    Console.WriteLine(goblin);
                }
            }
            Console.WriteLine(goblin);

        }
    }
}
