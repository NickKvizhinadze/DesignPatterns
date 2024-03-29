﻿using System.Text;
using Visitor.ExpressionPrint.Models;

namespace Visitor.ExpressionPrint
{
    public class ExpressionPrinter : IExpressionVisitor
    {
        private StringBuilder sb;
        public ExpressionPrinter(StringBuilder sb)
        {
            this.sb = sb;
        }
        public void Visit(DoubleExpression de)
        {
            sb.Append(de.Value);
        }

        public void Visit(AdditionExpression ae)
        {
            sb.Append("(");
            ae.Left.Accept(this);
            sb.Append("+");
            ae.Right.Accept(this);
            sb.Append(")");
        }

        public override string ToString()
        {
            return sb.ToString();
        }
    }
}
