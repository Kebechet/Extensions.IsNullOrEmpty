using System.Diagnostics.CodeAnalysis;

namespace IsNullOrEmpty.Extensions
{
    public static class NumericExtensions
    {
        public static bool IsNullOrZero([NotNullWhen(false)] this int? value) =>
            value is null || value == 0;

        public static bool IsNullOrZero([NotNullWhen(false)] this long? value) =>
            value is null || value == 0L;

        public static bool IsNullOrZero([NotNullWhen(false)] this double? value) =>
            value is null || value == 0.0;

        public static bool IsNullOrZero([NotNullWhen(false)] this decimal? value) =>
            value is null || value == 0m;

        public static bool IsNullOrZero([NotNullWhen(false)] this float? value) =>
            value is null || value == 0f;
    }
}
