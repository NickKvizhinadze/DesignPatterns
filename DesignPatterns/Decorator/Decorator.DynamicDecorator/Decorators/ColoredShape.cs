﻿using System;
using Decorator.DynamicDecorator.Interfaces;

namespace Decorator.DynamicDecorator.Decorators
{
    public class ColoredShape : IShape
    {
        private IShape _shape;
        private string _color;

        public ColoredShape(IShape shape, string color)
        {
            _shape = shape ?? throw new ArgumentNullException(nameof(shape));
            _color = color ?? throw new ArgumentNullException(nameof(color));
        }

        public string AsString()
        {
            return $"{_shape.AsString()} has the color {_color}";
        }
    }
}
