using System.Collections.Generic;

namespace Memento
{
    public class BankAccount
    {
        private int _balance;
        private List<Memento> _changes = new List<Memento>();
        private int _current;

        public BankAccount(int balance)
        {
            _balance = balance;
            _changes.Add(new Memento(balance));
        }

        public Memento Deposit(int amount)
        {
            _balance += amount;
            var memento = new Memento(_balance);
            _changes.Add(memento);
            ++_current;
            return memento;
        }

        public Memento Restore(Memento m)
        {
            if (m != null)
            {
                _balance = m.Balance;
                _changes.Add(m);
                ++_current;
                return m;
            }
            return null;
        }

        public Memento Undo()
        {
            if (_current > 0)
            {
                var memento = _changes[--_current];
                _balance = memento.Balance;
                return memento;
            }
            return null;
        }

        public Memento Redo()
        {
            if (_current < _changes.Count)
            {
                var memento = _changes[++_current];
                _balance = memento.Balance;
                return memento;
            }
            return null;
        }

        public override string ToString()
        {
            return $"Balance: {_balance}";
        }
    }
}
