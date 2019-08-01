using ChainOfResponsibility.BrokerChain.Enums;
using ChainOfResponsibility.BrokerChain.Models;

namespace ChainOfResponsibility.BrokerChain.Modifiers
{
    public class DoubleAttackModifier : CreatureModifier
    {
        public DoubleAttackModifier(Game game, Creature creature) : base(game, creature)
        {
        }

        protected override void Handle(object sender, Query q)
        {
            if (q.CreatureName == creature.Name && q.WhatToQuery == Argument.Attak)
            {
                q.Value *= 2;
            }
        }
    }
}
