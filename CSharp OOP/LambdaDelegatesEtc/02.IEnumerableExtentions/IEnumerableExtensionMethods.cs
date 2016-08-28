using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.IEnumerableExtentions
{
    public static class IEnumerableExtensionMethods
    {
        //sum, product, min, max, average
        public static int Summ(this IEnumerable<int> collection)
        {
            return collection.Sum();
        }
        
        public static int Productt(this IEnumerable<int> collection)
        {
            int product = 1;
            product = collection.Aggregate(product, (current, item) => current * item);
            return product;
        }

        public static int Minn(this IEnumerable<int> collection)
        {
            return Enumerable.Min(collection);
        }

        public static int Maxx(this IEnumerable<int> collection)
        {
            return Enumerable.Max(collection);
        }
        
        public static double Averagee(this IEnumerable<int> collection)
        {
            return collection.Sum() / collection.Count();
        }
    }
}
