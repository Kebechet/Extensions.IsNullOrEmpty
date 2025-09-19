using System;

namespace IsNullOrEmpty
{
    public static class GuidExtensions
    {
    	public static bool IsNullOrEmpty(this Guid? guid)
    	{
    		return guid is null || guid == Guid.Empty;
    	}
    }
}
