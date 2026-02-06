using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace IsNullOrEmpty.Extensions
{
    public static class IEnumerableExtensions
    {
    	public static bool IsNullOrEmpty<T>([NotNullWhen(false)] this IEnumerable<T>? enumerable)
    	{
    		return enumerable is null || !enumerable.Any();
    	}
    }
}
