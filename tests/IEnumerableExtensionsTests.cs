using System.Collections;
using IsNullOrEmpty.Extensions;

namespace IsNullOrEmpty.Tests
{
    public class IEnumerableExtensionsTests
    {
        [Fact]
        public void IsNullOrEmpty_WhenNull_ReturnsTrue()
        {
            // Arrange
            IEnumerable<int>? enumerable = null;

            // Act & Assert
            Assert.True(enumerable.IsNullOrEmpty());
        }

        [Fact]
        public void IsNullOrEmpty_EmptyList_ReturnsTrue()
        {
            // ICollection<T> fast-path
            Assert.True(new List<int>().IsNullOrEmpty());
        }

        [Fact]
        public void IsNullOrEmpty_PopulatedList_ReturnsFalse()
        {
            // ICollection<T> fast-path
            Assert.False(new List<int> { 1 }.IsNullOrEmpty());
        }

        [Fact]
        public void IsNullOrEmpty_EmptyArray_ReturnsTrue()
        {
            // ICollection<T> fast-path (arrays)
            Assert.True(Array.Empty<int>().IsNullOrEmpty());
        }

        [Fact]
        public void IsNullOrEmpty_PopulatedArray_ReturnsFalse()
        {
            // ICollection<T> fast-path (arrays)
            Assert.False(new[] { 1 }.IsNullOrEmpty());
        }

        [Fact]
        public void IsNullOrEmpty_EmptyReadOnlyCollection_ReturnsTrue()
        {
            // IReadOnlyCollection<T> fast-path (does not implement ICollection<T>)
            Assert.True(new ReadOnlyOnlyCollection<int>(0).IsNullOrEmpty());
        }

        [Fact]
        public void IsNullOrEmpty_PopulatedReadOnlyCollection_ReturnsFalse()
        {
            // IReadOnlyCollection<T> fast-path (does not implement ICollection<T>)
            Assert.False(new ReadOnlyOnlyCollection<int>(3).IsNullOrEmpty());
        }

        [Fact]
        public void IsNullOrEmpty_EmptyLazySequence_ReturnsTrue()
        {
            // Any() fallback (neither ICollection<T> nor IReadOnlyCollection<T>)
            Assert.True(Generate(0).IsNullOrEmpty());
        }

        [Fact]
        public void IsNullOrEmpty_PopulatedLazySequence_ReturnsFalse()
        {
            // Any() fallback (neither ICollection<T> nor IReadOnlyCollection<T>)
            Assert.False(Generate(2).IsNullOrEmpty());
        }

        private static IEnumerable<int> Generate(int count)
        {
            for (var i = 0; i < count; i++)
            {
                yield return i;
            }
        }

        private sealed class ReadOnlyOnlyCollection<T> : IReadOnlyCollection<T>
        {
            private readonly T[] _items;

            public ReadOnlyOnlyCollection(int count)
            {
                _items = new T[count];
            }

            public int Count => _items.Length;

            public IEnumerator<T> GetEnumerator()
            {
                return ((IEnumerable<T>) _items).GetEnumerator();
            }

            IEnumerator IEnumerable.GetEnumerator()
            {
                return _items.GetEnumerator();
            }
        }
    }
}
