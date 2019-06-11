using System;
using SimUDuck.App.Abstraction;

namespace SimUDuck.App.Behaviors
{
    public class MuteQuack : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("can't quack");
        }
    }
}
