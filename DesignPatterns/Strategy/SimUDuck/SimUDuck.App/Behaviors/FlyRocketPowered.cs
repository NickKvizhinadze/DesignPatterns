using System;
using SimUDuck.App.Abstraction;

namespace SimUDuck.App.Behaviors
{
    public class FlyRocketPowered : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("I'm flying with a rocket!");
        }
    }
}
