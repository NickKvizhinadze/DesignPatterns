using System;
using ChainOfResponsibility.BrokerChain.Enums;

namespace ChainOfResponsibility.BrokerChain
{
    public class Query
    {
        public string CreatureName;

        public Argument WhatToQuery;
        public int Value;

        public Query(string creatureName, Argument whatToQuery, int value)
        {
            CreatureName = creatureName ?? throw new ArgumentNullException(nameof(creatureName));
            WhatToQuery = whatToQuery;
            Value = value;
        }
    }
}
