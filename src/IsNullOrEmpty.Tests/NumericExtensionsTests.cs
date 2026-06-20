using IsNullOrEmpty.Extensions;

namespace IsNullOrEmpty.Tests
{
    public class NumericExtensionsTests
    {
        [Fact]
        public void IsNullOrZero_SByte()
        {
            // Arrange
            sbyte? nullValue = null;
            sbyte? zero = 0;
            sbyte? nonZero = 1;

            // Act & Assert
            Assert.True(nullValue.IsNullOrZero());
            Assert.True(zero.IsNullOrZero());
            Assert.False(nonZero.IsNullOrZero());
        }

        [Fact]
        public void IsNullOrZero_Byte()
        {
            // Arrange
            byte? nullValue = null;
            byte? zero = 0;
            byte? nonZero = 1;

            // Act & Assert
            Assert.True(nullValue.IsNullOrZero());
            Assert.True(zero.IsNullOrZero());
            Assert.False(nonZero.IsNullOrZero());
        }

        [Fact]
        public void IsNullOrZero_Short()
        {
            // Arrange
            short? nullValue = null;
            short? zero = 0;
            short? nonZero = 1;

            // Act & Assert
            Assert.True(nullValue.IsNullOrZero());
            Assert.True(zero.IsNullOrZero());
            Assert.False(nonZero.IsNullOrZero());
        }

        [Fact]
        public void IsNullOrZero_UShort()
        {
            // Arrange
            ushort? nullValue = null;
            ushort? zero = 0;
            ushort? nonZero = 1;

            // Act & Assert
            Assert.True(nullValue.IsNullOrZero());
            Assert.True(zero.IsNullOrZero());
            Assert.False(nonZero.IsNullOrZero());
        }

        [Fact]
        public void IsNullOrZero_Int()
        {
            // Arrange
            int? nullValue = null;
            int? zero = 0;
            int? nonZero = 1;

            // Act & Assert
            Assert.True(nullValue.IsNullOrZero());
            Assert.True(zero.IsNullOrZero());
            Assert.False(nonZero.IsNullOrZero());
        }

        [Fact]
        public void IsNullOrZero_UInt()
        {
            // Arrange
            uint? nullValue = null;
            uint? zero = 0;
            uint? nonZero = 1;

            // Act & Assert
            Assert.True(nullValue.IsNullOrZero());
            Assert.True(zero.IsNullOrZero());
            Assert.False(nonZero.IsNullOrZero());
        }

        [Fact]
        public void IsNullOrZero_Long()
        {
            // Arrange
            long? nullValue = null;
            long? zero = 0;
            long? nonZero = 1;

            // Act & Assert
            Assert.True(nullValue.IsNullOrZero());
            Assert.True(zero.IsNullOrZero());
            Assert.False(nonZero.IsNullOrZero());
        }

        [Fact]
        public void IsNullOrZero_ULong()
        {
            // Arrange
            ulong? nullValue = null;
            ulong? zero = 0;
            ulong? nonZero = 1;

            // Act & Assert
            Assert.True(nullValue.IsNullOrZero());
            Assert.True(zero.IsNullOrZero());
            Assert.False(nonZero.IsNullOrZero());
        }

        [Fact]
        public void IsNullOrZero_Double()
        {
            // Arrange
            double? nullValue = null;
            double? zero = 0.0;
            double? negativeZero = -0.0;
            double? nonZero = 1.5;

            // Act & Assert
            Assert.True(nullValue.IsNullOrZero());
            Assert.True(zero.IsNullOrZero());
            Assert.True(negativeZero.IsNullOrZero());
            Assert.False(nonZero.IsNullOrZero());
        }

        [Fact]
        public void IsNullOrZero_Double_NaN_IsNotZero()
        {
            // Arrange
            double? nan = double.NaN;

            // Act & Assert
            Assert.False(nan.IsNullOrZero());
        }

        [Fact]
        public void IsNullOrZero_Decimal()
        {
            // Arrange
            decimal? nullValue = null;
            decimal? zero = 0m;
            decimal? nonZero = 1.5m;

            // Act & Assert
            Assert.True(nullValue.IsNullOrZero());
            Assert.True(zero.IsNullOrZero());
            Assert.False(nonZero.IsNullOrZero());
        }

        [Fact]
        public void IsNullOrZero_Float()
        {
            // Arrange
            float? nullValue = null;
            float? zero = 0f;
            float? nonZero = 1.5f;

            // Act & Assert
            Assert.True(nullValue.IsNullOrZero());
            Assert.True(zero.IsNullOrZero());
            Assert.False(nonZero.IsNullOrZero());
        }
    }
}
