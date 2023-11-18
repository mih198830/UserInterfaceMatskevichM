using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserInterfaceMatskevichM.Utilities
{
    internal static class Extensions
    {
        private static readonly Random r_random = new();

        public static T GetRandomElement<T>(this IList<T> list)
        {
            int randomIndex = r_random.Next(list.Count);
            return list[randomIndex];
        }
    }
}
