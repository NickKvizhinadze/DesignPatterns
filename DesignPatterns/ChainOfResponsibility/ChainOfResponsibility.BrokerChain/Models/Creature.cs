using ChainOfResponsibility.BrokerChain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility.BrokerChain.Models
{
    public class Creature
    {
        private Game game;
        public string Name;
        private int attack, defense;

        public Creature(Game game, string name, int attack, int defense)
        {
            this.game = game ?? throw new ArgumentNullException(nameof(game));
            Name = name ?? throw new ArgumentException("message", nameof(name));
            this.attack = attack;
            this.defense = defense;
        }

        public int Attack
        {
            get
            {
                var q = new Query(Name, Argument.Attak, attack);
                game.PerformQuery(this, q);
                return q.Value;
            }
        }
        public int Defense
        {
            get
            {
                var q = new Query(Name, Argument.Defense, defense);
                game.PerformQuery(this, q);
                return q.Value;
            }
        }


        public override string ToString()
        {
            return $"{nameof(Name)} : {Name}, {nameof(attack)} : {Attack}, {nameof(defense)} : {Defense}";
        }
    }
}
