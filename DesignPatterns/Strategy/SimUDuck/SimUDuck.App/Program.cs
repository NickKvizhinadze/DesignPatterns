using SimUDuck.App.Behaviors;

namespace SimUDuck.App
{
    class Program
    {
        static void Main(string[] args)
        {
            var mallard = new MallardDuck();
            mallard.PerformFly();
            mallard.PerformQuack();
            mallard.SetFlyBehavior(new FlyRocketPowered());
            mallard.PerformFly();

        }
    }
}
