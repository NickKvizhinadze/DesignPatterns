using Proxy.Protection.Interfaces;
using Proxy.Protection.Models;

namespace Proxy.Protection
{
    class Program
    {
        static void Main(string[] args)
        {
            ICar car = new CarProxy(new Driver(12));
            car.Drive();
        }
    }
}
