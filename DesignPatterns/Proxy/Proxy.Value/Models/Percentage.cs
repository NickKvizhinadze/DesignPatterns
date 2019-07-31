using System.Diagnostics;

namespace Proxy.Value.Models
{
    [DebuggerDisplay("{value*100.0f}%")]
    public struct Percentage
    {
        private float value;

        internal Percentage(float value)
        {
            this.value = value;
        }

        public static float operator *(float f, Percentage p)
        {
            return f * p.value;
        }
        public static Percentage operator +(Percentage a, Percentage b)
        {
            return new Percentage(a.value * b.value);
        }

        public override string ToString()
        {
            return $"{value * 100}%"; 
        }

        public override int GetHashCode()
        {
            return value.GetHashCode();
        }
    }
}
