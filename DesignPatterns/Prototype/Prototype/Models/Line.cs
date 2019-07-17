using System;

namespace Prototype.Models
{
    [Serializable]
    public class Line
    {
        public Point Start { get; set; }
        public Point End { get; set; }

        public Line DeepCopy(Line other)
        {
            return other.DeepCopy();
        }

    }
}
