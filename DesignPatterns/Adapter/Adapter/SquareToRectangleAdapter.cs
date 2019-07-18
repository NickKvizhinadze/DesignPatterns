using Adapter.Interfaces;
using Adapter.Models;

namespace Adapter
{
    public class SquareToRectangleAdapter : IRectangle
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public SquareToRectangleAdapter(Square square)
        {
            Width = Height = square.Side;
        }
    }
}
