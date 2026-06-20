using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.CompilerServices;

namespace IsNullOrEmpty.Extensions
{
    public static class IEnumerableExtensions
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsNullOrEmpty<T>([NotNullWhen(false)] this IEnumerable<T>? enumerable)
        {
            if (enumerable is null)
            {
                return true;
            }

            if (enumerable is ICollection<T> collection)
            {
                return collection.Count == 0;
            }

            if (enumerable is IReadOnlyCollection<T> readOnlyCollection)
            {
                return readOnlyCollection.Count == 0;
            }

            return !enumerable.Any();
        }
    }
}
