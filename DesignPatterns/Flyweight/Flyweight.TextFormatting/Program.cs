using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight.TextFormatting
{
    class Program
    {
        static void Main(string[] args)
        {
            var ft = new FormattedText("This is a barve new wolrd");
            ft.Capitalize(10, 15);
            Console.WriteLine(ft.ToString());

            var bft = new BetterFormattedText("This is a barve new wolrd");
            bft.GetRange(10, 15).Capitalize = true;
            Console.WriteLine(bft.ToString());

        }
    }
}
