using Interpreter.Enums;
using Interpreter.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = "(13+4)-(12+3)";

            var tokens = Lex(input);
            Console.WriteLine(string.Join("\t", tokens));
            var parsed = Parse(tokens);
            Console.WriteLine($"{input} = {parsed.Value}");
        }


        static List<Token> Lex(string input)
        {
            var result = new List<Token>();
            for (int i = 0; i < input.Length; i++)
            {
                switch (input[i])
                {
                    case '+':
                        result.Add(new Token(Enums.Type.Plus, "+"));
                        break;
                    case '-':
                        result.Add(new Token(Enums.Type.Minus, "-"));
                        break;
                    case '(':
                        result.Add(new Token(Enums.Type.Lparen, "("));
                        break;
                    case ')':
                        result.Add(new Token(Enums.Type.Rparen, ")"));
                        break;
                    default:
                        var sb = new StringBuilder();
                        sb.Append(input[i].ToString());
                        for (int j = i + 1; j < input.Length; j++)
                        {
                            if (char.IsDigit(input[j]))
                            {
                                sb.Append(input[j].ToString());
                                ++i;
                            }
                            else
                            {
                                result.Add(new Token(Enums.Type.Integer, sb.ToString()));
                                break;
                            }
                        }
                        break;
                }
            }

            return result;
        }

        static IElement Parse(IReadOnlyList<Token> tokens)
        {
            var result = new BinaryOperation();
            bool haveLeftSide = false;
            for (int i = 0; i < tokens.Count; i++)
            {
                var token = tokens[i];
                switch (token.MyType)
                {
                    case Enums.Type.Integer:
                        var integer = new Integer(int.Parse(token.Text));
                        if (!haveLeftSide)
                        {
                            result.Left = integer;
                            haveLeftSide = true;
                        }
                        else
                        {
                            result.Right = integer;
                        }
                        break;
                    case Enums.Type.Plus:
                        result.MyType = OperationType.Addition;
                        break;
                    case Enums.Type.Minus:
                        result.MyType = OperationType.Substraction;
                        break;
                    case Enums.Type.Lparen:
                        int j = i;
                        for (; j < tokens.Count; ++j)
                        {
                            if (tokens[j].MyType == Enums.Type.Rparen)
                                break;
                        }

                        var subExpression = tokens.Skip(i + 1).Take(j - i - 1).ToList();
                        var element = Parse(subExpression);
                        if (!haveLeftSide)
                        {
                            result.Left = element;
                            haveLeftSide = true;
                        }
                        else
                        {
                            result.Right = element;
                        }
                        i = j;
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
            }
            return result;
        }
    }
}
