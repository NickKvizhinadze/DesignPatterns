using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubtitutionPrinciple.Models
{
    public class Rectangle
    {
        public Rectangle()
        {
        }

        public Rectangle(int width, int height)
        {
            Width = width;
            Height = height;
        }

        public virtual int Width { get; set; }
        public virtual int Height { get; set; }

        public override string ToString()
        {
            return $"{nameof(Width)}: {Width}, {nameof(Height)}: {Height}";
        }
    }
}
