using System;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            var words = new string[] { "hello", "world" };

            var builder = new HtmlBuilder("ul");
            foreach (var word in words)
            {
                builder.AddChild("li", word);
            }
            Console.WriteLine(builder.ToString());
        }
    }
}
