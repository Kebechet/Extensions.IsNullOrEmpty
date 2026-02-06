using System;
using System.Diagnostics.CodeAnalysis;

namespace IsNullOrEmpty.Extensions
{
    public static class GuidExtensions
    {
    	public static bool IsNullOrEmpty([NotNullWhen(false)] this Guid? guid)
    	{
    		return guid is null || guid == Guid.Empty;
    	}
    }
}
