using Interpreter.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter
{
    public class Integer : IElement
    {
        public Integer(int vaue)
        {
            Value = vaue;
        }

        public int Value { get; }
    }
}
