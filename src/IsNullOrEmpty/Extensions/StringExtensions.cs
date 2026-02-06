using System.Diagnostics.CodeAnalysis;

namespace IsNullOrEmpty.Extensions
{
    public static class StringExtensions
    {
    	public static bool IsNullOrEmpty([NotNullWhen(false)] this string? value)
    	{
    		return string.IsNullOrEmpty(value);
    	}

    	public static bool IsNullOrWhiteSpace([NotNullWhen(false)] this string? value)
    	{
    		return string.IsNullOrWhiteSpace(value);
    	}
    }
}
