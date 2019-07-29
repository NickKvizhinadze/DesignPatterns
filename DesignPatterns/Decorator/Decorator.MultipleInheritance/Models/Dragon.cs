using System;
using Decorator.MultipleInheritance.Interfaces;

namespace Decorator.MultipleInheritance.Models
{
    public class Dragon : IBird, ILizard
    {
        private Bird _bird = new Bird();
        private Lizard _lizard = new Lizard();
        private int _weight;

        public int Weight
        {
            get => _weight; set
            {
                _weight = value;
                _bird.Weight = value;
                _lizard.Weight = value;
            }
        }

        public void Crawl()
        {
            _lizard.Crawl();
        }

        public void Fly()
        {
            _bird.Fly();
        }
    }
}
