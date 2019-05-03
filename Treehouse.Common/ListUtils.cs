using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Treehouse.Collections.Generic
{
    public static class ListUtils
    {
        private static Random _random = new Random();

        public static T RandomItem<T>(this List<T> l)
        {
            return l[_random.Next(0, l.Count)];
        }
    }
}
