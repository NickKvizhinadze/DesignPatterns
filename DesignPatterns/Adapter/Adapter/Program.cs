using Adapter.Extentions;
using Adapter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            var square = new Square { Side = 10 };
            var adapter = new SquareToRectangleAdapter(square);
            var area = adapter.Area();
            Console.WriteLine($"Area = {area}");
        }
    }
}
