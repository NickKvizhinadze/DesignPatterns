using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderExercise
{
    public class CodeBuilder
    {
        private const int indentSize = 2;

        private readonly StringBuilder _stringBuilder = new StringBuilder();

        public CodeBuilder(string className)
        {
            _stringBuilder.AppendLine($"public class {className}");
            _stringBuilder.AppendLine("{");
        }

        public CodeBuilder AddField(string propertyName, string type)
        {
            var i = new string(' ', indentSize);
            _stringBuilder.AppendLine($"{i}public {type} {propertyName};");
            return this;
        }

        public override string ToString()
        {
            _stringBuilder.AppendLine("}");
            return _stringBuilder.ToString();
        }

    }
}
