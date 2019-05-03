using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Treehouse.Collections.Generic
{
    public class List<T> : System.Collections.Generic.List<T>
    {
        private static Random _random = new Random();

        public T RandomItem() => this[_random.Next(0, this.Count)];
        //{
        //    return this[_random.Next(0, this.Count)];
        //}
    }
}
