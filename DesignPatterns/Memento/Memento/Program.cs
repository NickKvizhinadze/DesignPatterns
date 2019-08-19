using System;

namespace Memento
{
    class Program
    {
        static void Main(string[] args)
        {
            var bankAccount = new BankAccount(100);
            bankAccount.Deposit(50); //150
            bankAccount.Deposit(25); //175

            Console.WriteLine(bankAccount);

            bankAccount.Undo();
            Console.WriteLine($"Undo 1: {bankAccount}");

            bankAccount.Undo();
            Console.WriteLine($"Undo 2: {bankAccount}");

            bankAccount.Redo();
            Console.WriteLine($"Redo 1: {bankAccount}");
        }
    }
}
