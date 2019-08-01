using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChainOfResponsibility.MethodChain.Models;

namespace ChainOfResponsibility.MethodChain.Modifiers
{
    public class IncreasedDefenseModifier : CreatureModifier
    {
        public IncreasedDefenseModifier(Creature creature) : base(creature)
        {
        }

        public override void Handle()
        {
            Console.WriteLine($"Increasing {creature.Name}'s defense");
            creature.Defense += 3;
            base.Handle();
        }
    }
}
