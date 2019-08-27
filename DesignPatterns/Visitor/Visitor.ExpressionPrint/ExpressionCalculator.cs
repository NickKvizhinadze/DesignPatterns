using Visitor.ExpressionPrint.Models;

namespace Visitor.ExpressionPrint
{
    public class ExpressionCalculator : IExpressionVisitor
    {
        public double Result;

        public void Visit(DoubleExpression de)
        {
            Result = de.Value;
        }

        public void Visit(AdditionExpression ae)
        {
            ae.Left.Accept(this);
            var left = Result;
            ae.Right.Accept(this);
            Result += left;
        }
    }
}
