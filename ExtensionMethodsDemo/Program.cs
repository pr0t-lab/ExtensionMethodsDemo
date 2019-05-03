using System;
using System.Collections.Generic;
//using Treehouse.Collections.Generic;
using Treehouse.Common;
using static Treehouse.Common.IntExtensions;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethodsDemo
{
    class Program
    {
        static void Main(string[] args)
        {            
            bool isEven = 5.IsEven();

            var synonymsForBest = new List<string>
            {
                "best",
                "finest",
                "greatest",
                "top",
                "foremost"
            };

            //Console.WriteLine(synonymsForBest.RandomItem());
            //Console.WriteLine(ListUtils<string>.RandomItem(synonymsForBest));
            Console.WriteLine(synonymsForBest.GetRandom<string>());

            Console.ReadLine();
        }
    }
}
