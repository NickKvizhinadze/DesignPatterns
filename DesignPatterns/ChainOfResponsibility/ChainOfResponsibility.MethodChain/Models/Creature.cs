using System;

namespace ChainOfResponsibility.MethodChain.Models
{
    public class Creature
    {
        public string Name;
        public int Attack, Defense;

        public Creature(string name, int attack, int defense)
        {
            Name = name ?? throw new ArgumentException("message", nameof(name));
            Attack = attack;
            Defense = defense;
        }

        public override string ToString()
        {
            return $"{nameof(Name)} : {Name}, {nameof(Attack)} : {Attack}, {nameof(Defense)} : {Defense}";
        }
    }
}
