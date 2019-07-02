using LiskovSubtitutionPrinciple.Models;
using System;

namespace LiskovSubtitutionPrinciple
{
    class Program
    {
        public static int Area(Rectangle r) => r.Width * r.Height;

        static void Main(string[] args)
        {
            Rectangle rc = new Rectangle(3, 4);

            Console.WriteLine($"{rc} has area {Area(rc)}");

            Rectangle sq = new Square();
            sq.Width = 4;

            Console.WriteLine($"{sq} has area {Area(sq)}");
        }
    }
}
