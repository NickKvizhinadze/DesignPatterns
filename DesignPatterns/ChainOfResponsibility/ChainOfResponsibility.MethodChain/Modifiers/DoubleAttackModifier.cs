using System;
using ChainOfResponsibility.MethodChain.Models;

namespace ChainOfResponsibility.MethodChain.Modifiers
{
    public class DoubleAttackModifier : CreatureModifier
    {
        public DoubleAttackModifier(Creature creature) : base(creature)
        {
        }
        public override void Handle()
        {
            Console.WriteLine($"Doublic {creature.Name}'s attack");
            creature.Attack *= 2;
            base.Handle();
        }
    }
}
