using System;
using System.Reactive.Linq;
using Mediator.EventBroker.Events;

namespace Mediator.EventBroker.Models
{
    public class FootballCoach : Actor
    {
        public FootballCoach(EventBroker broker) : base(broker)
        {
            broker.OfType<PlayerScoredEvent>()
                .Subscribe(pe =>
                {
                    if (pe.GoalsScored < 3)
                    {
                        Console.WriteLine($"Coach: Well done, {pe.Name}");
                    }
                });

            broker.OfType<PlayerSentOffEvent>()
               .Subscribe(pe =>
               {
                   if (pe.Reason == "violence")
                   {
                       Console.WriteLine($"Coach: How could you, {pe.Name}");
                   }
               });
        }
    }
}
