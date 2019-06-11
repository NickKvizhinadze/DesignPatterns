using System;
using SimUDuck.App.Abstraction;

namespace SimUDuck.App.Behaviors
{
    public class FlyWithWings: IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("duck flying");
        }
    }
}
