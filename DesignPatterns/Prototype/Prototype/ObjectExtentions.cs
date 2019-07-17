using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Prototype
{
    public static class ObjectExtentions
    {
        public static T DeepCopy<T>(this T source)
        {
            using (var ms = new MemoryStream())
            {
                var formatter = new BinaryFormatter();
                formatter.Serialize(ms, source);
                ms.Seek(0, SeekOrigin.Begin);
                var copy = (T) formatter.Deserialize(ms);
                return copy;
            }
        }
    }
}
