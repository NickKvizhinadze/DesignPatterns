using Adapter.Interfaces;

namespace Adapter.Extentions
{
    public static class ExtentionMethods
    {
        public static int Area(this IRectangle rc)
        {
            return rc.Width * rc.Height;
        }
    }
}
