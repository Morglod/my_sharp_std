using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System.Linq {
    public static class Enumerable {
        public static bool IndexOf<TSource>(this IEnumerable<TSource> source, TSource value, out int foundIndex) {
            for (var i = 0; i < source.Count(); ++i) {
                var x = source.ElementAt(i);
                if ((x == null && value == null) || x.Equals(value)) {
                    foundIndex = i;
                    return true;
                }
            }

            foundIndex = -1;
            return false;
        }
    }
}
