using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight.Repeating.Models
{
    public class User2
    {
        public List<string> strings = new List<string>();

        private int[] names;

        public User2(string fullname)
        {
           names = fullname.Split(' ').Select(GetOrAdd).ToArray();
        }

        public string FullName => string.Join(" ", names.Select(i => strings[i]));

        private int GetOrAdd(string s)
        {
            int index = strings.IndexOf(s);
            if (index != -1)
                return index;
            strings.Add(s);
            return strings.Count - 1;
        }
    }
}
