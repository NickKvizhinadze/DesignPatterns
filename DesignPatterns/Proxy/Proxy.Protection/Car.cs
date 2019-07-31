using System;
using Proxy.Protection.Interfaces;

namespace Proxy.Protection
{
    public class Car : ICar
    {
        public void Drive()
        {
            Console.WriteLine("Car is being driven");
        }
    }
}
