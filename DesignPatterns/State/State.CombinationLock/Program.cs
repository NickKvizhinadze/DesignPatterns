using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State.CombinationLock
{
    class Program
    {
        static void Main(string[] args)
        {
            var code = "1234";
            var state = State.Locked;
            var entry = new StringBuilder();

            while (true)
            {
                switch (state)
                {
                    case State.Locked:
                        entry.Append(Console.ReadKey().KeyChar);
                        if (entry.ToString() == code)
                        {
                            state = State.Unclocked;
                            break;
                        }
                        if (!code.StartsWith(entry.ToString()))
                            state = State.Failed;
                        break;
                    case State.Failed:
                        Console.CursorLeft = 0;
                        Console.WriteLine("FAILED");
                        entry.Clear();
                        state = State.Locked;
                        break;
                    case State.Unclocked:
                        Console.CursorLeft = 0;
                        Console.WriteLine("UNLOCKED");
                        break;
                }
            }
        }
    }
}
