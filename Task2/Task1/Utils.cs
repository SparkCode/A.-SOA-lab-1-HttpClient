using System;
using System.Collections.Generic;
using System.Linq;

namespace Serialization
{
    internal static class Utils
    {
        public static decimal Sum(IEnumerable<decimal> array) => array.Sum();

        public static int Multiplication(IEnumerable<int> array) => array.Aggregate(1, (x, y) => x * y);

        public static IEnumerable<decimal> Concat(IEnumerable<decimal> first, int[] second)
        {
            var secondDecimal = Array.ConvertAll(second, x => (decimal) x);

            return first.Concat(secondDecimal).ToArray();
        }
    }
}
