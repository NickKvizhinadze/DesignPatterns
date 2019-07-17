using Prototype.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            var line = new Line { Start = new Point { X = 0, Y = 0 }, End = new Point { X = 5, Y = 5 } };

            var line2 = line.DeepCopy();

            line2.Start.X = 3;

            Console.WriteLine(line.Start.X);
            Console.WriteLine(line2.Start.X);
        }
    }
}
