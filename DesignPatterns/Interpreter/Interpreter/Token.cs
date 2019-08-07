using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interpreter.Enums;

namespace Interpreter
{
    public class Token
    {

        public Enums.Type MyType;
        public string Text;

        public Token(Enums.Type myType, string text)
        {
            MyType = myType;
            Text = text ?? throw new ArgumentNullException(nameof(text));
        }

        public override string ToString()
        {
            return $"`{Text}`";
        }
    }
}
