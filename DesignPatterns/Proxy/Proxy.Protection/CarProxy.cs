using Proxy.Protection.Interfaces;
using System;
using Proxy.Protection.Models;

namespace Proxy.Protection
{
    public class CarProxy : ICar
    {
        private Driver _driver;
        private Car _car = new Car();
        public CarProxy(Driver driver)
        {
            this._driver = driver;
        }
        public void Drive()
        {
            if (_driver.Age > 16)
                _car.Drive();
            else
                Console.WriteLine("Your to young");
        }
    }
}
