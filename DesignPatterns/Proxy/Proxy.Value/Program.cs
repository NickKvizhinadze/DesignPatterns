using System;
using Proxy.Value.Extentions;

namespace Proxy.Value
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(10f * 5.Percent());
            Console.WriteLine(2.Percent() + 3.Percent());
        }
    }
}
