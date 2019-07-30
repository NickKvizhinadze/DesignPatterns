using Decorator.DynamicDecorator.Interfaces;

namespace Decorator.DynamicDecorator.Models
{
    public class Square: IShape
    {
        private float _side;

        public Square(float side)
        {
            _side = side;
        }

        public void Resize(float factor)
        {
            _side *= factor;
        }

        public string AsString()
        {
            return $"A square with side {_side}";
        }
    }
}
