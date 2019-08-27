using Visitor.ExpressionPrint.Models;

namespace Visitor.ExpressionPrint
{
    public interface IExpressionVisitor
    {
        void Visit(DoubleExpression de);
        void Visit(AdditionExpression ae);
    }
}
