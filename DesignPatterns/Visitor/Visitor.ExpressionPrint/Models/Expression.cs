
namespace Visitor.ExpressionPrint.Models
{
    public abstract class Expression
    {
        public abstract void Accept(IExpressionVisitor visitor);
    }
}
