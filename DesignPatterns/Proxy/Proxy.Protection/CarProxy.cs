using Proxy.Protection.Interfaces;
using Proxy.Protection.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
