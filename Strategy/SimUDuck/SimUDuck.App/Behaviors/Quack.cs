using System;
using SimUDuck.App.Abstraction;

namespace SimUDuck.App.Behaviors
{
    public class Quack : IQuackBehavior
    {
        void IQuackBehavior.Quack()
        {
            Console.WriteLine("duck quacking");
        }
    }
}
