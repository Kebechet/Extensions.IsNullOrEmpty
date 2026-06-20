using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace IsNullOrEmpty.Extensions
{
    public static class GuidExtensions
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsNullOrEmpty([NotNullWhen(false)] this Guid? guid)
        {
            return guid is null || guid == Guid.Empty;
        }
    }
}
