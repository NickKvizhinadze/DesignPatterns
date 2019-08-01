using System;

namespace ChainOfResponsibility.BrokerChain
{
    public class Game
    {
        public EventHandler<Query> Queries;

        public void PerformQuery(object sender, Query q)
        {
            Queries?.Invoke(sender, q);
        }
    }
}
