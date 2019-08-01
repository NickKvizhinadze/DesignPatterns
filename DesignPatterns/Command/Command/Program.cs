using Command.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    class Program
    {
        static void Main(string[] args)
        {
            var ba = new BankAccount();
            var commands = new List<BankAccountCommand> {
                new BankAccountCommand(ba, Enums.Action.Deposit, 100),
                new BankAccountCommand(ba, Enums.Action.Withdraw, 1000)
            };

            Console.WriteLine("appling commnads");

            foreach (var command in commands)
            {
                command.Call();
            }

            Console.WriteLine(ba);

            foreach (var command in Enumerable.Reverse(commands))
            {
                command.Undo();
            }

            Console.WriteLine(ba);
        }
    }
}
