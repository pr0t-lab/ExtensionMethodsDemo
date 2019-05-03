using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Treehouse.Common
{
    public static class IListExtensions
    {
        private static Random _random = new Random();

        public static T GetRandom<T>(this IList<T> l)
        {
            return l[_random.Next(0, l.Count)];
        }
    }
}
