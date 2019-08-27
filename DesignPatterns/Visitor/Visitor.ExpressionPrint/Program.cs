using System;
using System.Text;
using Visitor.ExpressionPrint.Models;

namespace Visitor.ExpressionPrint
{
    class Program
    {
        static void Main(string[] args)
        {
            var e = new AdditionExpression(
                new DoubleExpression(1),
                new AdditionExpression(
                    new DoubleExpression(2),
                    new DoubleExpression(3)
                    )
                );

            var sb = new StringBuilder();
            var ep = new ExpressionPrinter(sb);
            ep.Visit(e);
            Console.WriteLine(ep);
        }
    }
}
