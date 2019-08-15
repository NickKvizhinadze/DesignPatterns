using System;
using System.Reactive.Linq;
using Mediator.EventBroker.Events;

namespace Mediator.EventBroker.Models
{
    public class FootballPlayer : Actor
    {
        public string Name { get; set; }
        public int GoalScored { get; set; } = 0;

        public FootballPlayer(EventBroker broker, string name) : base(broker)
        {
            Name = name ?? throw new System.ArgumentNullException(nameof(name));
            broker.OfType<PlayerScoredEvent>()
                .Where(ps => !ps.Name.Equals(name))
                .Subscribe(ps => Console.WriteLine($"{name}: Nicely done, {ps.Name}! It's your {ps.GoalsScored}"));

            broker.OfType<PlayerSentOffEvent>()
                .Where(ps => !ps.Name.Equals(name))
                .Subscribe(ps => Console.WriteLine($"{name}: see you in the lockers, {ps.Name}."));
        }

        public void Score()
        {
            GoalScored++;
            broker.Publish(new PlayerScoredEvent { Name = Name, GoalsScored = GoalScored });
        }


        public void AssaultReferree()
        {
            GoalScored++;
            broker.Publish(new PlayerSentOffEvent { Name = Name, Reason = "violence" });
        }
    }
}
