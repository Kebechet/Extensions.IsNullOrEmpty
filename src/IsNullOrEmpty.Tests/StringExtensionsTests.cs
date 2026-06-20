using IsNullOrEmpty.Extensions;

namespace IsNullOrEmpty.Tests
{
    public class StringExtensionsTests
    {
        [Theory]
        [InlineData(null, true)]
        [InlineData("", true)]
        [InlineData(" ", false)]
        [InlineData("a", false)]
        public void IsNullOrEmpty_ReturnsExpected(string? value, bool expected)
        {
            // Act
            var result = value.IsNullOrEmpty();

            // Assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(null, true)]
        [InlineData("", true)]
        [InlineData("   ", true)]
        [InlineData("\t\n", true)]
        [InlineData(" a ", false)]
        public void IsNullOrWhiteSpace_ReturnsExpected(string? value, bool expected)
        {
            // Act
            var result = value.IsNullOrWhiteSpace();

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void IsNullOrEmpty_WhenFalse_NarrowsNullability()
        {
            // Arrange
            string? value = "value";

            // Act & Assert
            if (value.IsNullOrEmpty())
            {
                Assert.Fail("Expected a non-empty string.");
            }

            // No nullable warning here proves [NotNullWhen(false)] narrows the type.
            Assert.Equal(5, value.Length);
        }
    }
}
