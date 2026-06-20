using IsNullOrEmpty.Extensions;

namespace IsNullOrEmpty.Tests
{
    public class GuidExtensionsTests
    {
        [Fact]
        public void IsNullOrEmpty_WhenNull_ReturnsTrue()
        {
            // Arrange
            Guid? guid = null;

            // Act & Assert
            Assert.True(guid.IsNullOrEmpty());
        }

        [Fact]
        public void IsNullOrEmpty_WhenEmpty_ReturnsTrue()
        {
            // Arrange
            Guid? guid = Guid.Empty;

            // Act & Assert
            Assert.True(guid.IsNullOrEmpty());
        }

        [Fact]
        public void IsNullOrEmpty_WhenPopulated_ReturnsFalse()
        {
            // Arrange
            Guid? guid = Guid.NewGuid();

            // Act & Assert
            Assert.False(guid.IsNullOrEmpty());
        }
    }
}
