using Interpreter.Enums;
using System;
using Interpreter.Interfaces;

namespace Interpreter
{
    public class BinaryOperation : IElement
    {
        public OperationType MyType;
        public IElement Left, Right;

        public int Value
        {
            get
            {
                switch (MyType)
                {
                    case OperationType.Addition:
                        return Left.Value + Right.Value;
                    case OperationType.Substraction:
                        return Left.Value - Right.Value;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
            }
        }
    }
}
