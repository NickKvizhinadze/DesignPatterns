using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator.ArrayBacked.Models
{
    public class Creature : IEnumerable<int>
    {
        private int[] stats = new int[3];
        private const int strength = 0;
        public int Strength
        {
            get { return stats[strength]; }
            set { stats[strength] = value; }
        }

        private const int agility = 1;
        public int Agility
        {
            get { return stats[agility]; }
            set { stats[agility] = value; }
        }

        private const int inteligence = 1;

        public int Inteligence
        {
            get { return stats[inteligence]; }
            set { stats[inteligence] = value; }
        }

        public double AverageStat => stats.Average();

        public IEnumerator<int> GetEnumerator()
        {
            return stats.AsEnumerable().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public int this[int index]
        {
            get => stats[index];
            set => stats[index] = value;
        }
    }
}
