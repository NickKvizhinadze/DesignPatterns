using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosePrinciple.Models
{
    public class Product
    {
        public Product(string name, Color color, Size size)
        {
            if (string.IsNullOrEmpty(name))
                throw new ArgumentNullException(paramName: nameof(name));

            Name = name;
            Color = color;
            Size = size;
        }

        public string Name { get; set; }
        public Color Color { get; set; }
        public Size Size { get; set; }
    }
}
