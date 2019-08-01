using ChainOfResponsibility.BrokerChain.Enums;
using ChainOfResponsibility.BrokerChain.Models;

namespace ChainOfResponsibility.BrokerChain.Modifiers
{
    public class IncreaseDefenseModifier : CreatureModifier
    {
        public IncreaseDefenseModifier(Game game, Creature creature) : base(game, creature)
        {
        }

        protected override void Handle(object sender, Query q)
        {
            if (q.CreatureName == creature.Name && q.WhatToQuery == Argument.Defense)
            {
                q.Value += 3;
            }
        }
    }
}
