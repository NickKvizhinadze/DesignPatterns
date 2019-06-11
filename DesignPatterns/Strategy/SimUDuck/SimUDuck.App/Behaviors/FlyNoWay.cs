using System;
using SimUDuck.App.Abstraction;

namespace SimUDuck.App.Behaviors
{
    public class FlyNoWay : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("can't fly");
        }
    }
}
