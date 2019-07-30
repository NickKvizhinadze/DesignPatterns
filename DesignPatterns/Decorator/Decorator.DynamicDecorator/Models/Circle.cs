﻿using Decorator.DynamicDecorator.Interfaces;

namespace Decorator.DynamicDecorator.Models
{
    public class Circle: IShape
    {
        private float _radius;

        public Circle(float radius)
        {
            _radius = radius;
        }

        public void Resize(float factor)
        {
            _radius *= factor;
        }

        public string AsString()
        {
            return $"A circle with radius {_radius}";
        }
    }
}
