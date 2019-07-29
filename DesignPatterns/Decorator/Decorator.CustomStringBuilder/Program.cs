using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.CustomStringBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            MyStringBuilder s = "Hello ";
            s += "world";

            Console.WriteLine(s);
        }
    }
}
