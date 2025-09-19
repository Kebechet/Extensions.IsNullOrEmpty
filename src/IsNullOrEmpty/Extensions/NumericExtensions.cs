namespace IsNullOrEmpty.Extensions
{
    public static class NumericExtensions
    {
        public static bool IsNullOrZero(this int? value) =>
            value is null || value == 0;

        public static bool IsNullOrZero(this long? value) =>
            value is null || value == 0L;

        public static bool IsNullOrZero(this double? value) =>
            value is null || value == 0.0;

        public static bool IsNullOrZero(this decimal? value) =>
            value is null || value == 0m;

        public static bool IsNullOrZero(this float? value) =>
            value is null || value == 0f;
    }
}
