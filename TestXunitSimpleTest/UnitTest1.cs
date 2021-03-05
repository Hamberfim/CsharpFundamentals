using System;
using Xunit;

namespace TestXunitSimpleTest
{
    public class UnitTest1
    {
        [Fact]
        public void TestTrueIsTrue()
        {
            Assert.True(true);
        }

        [Fact]
        public void TestMockInputFormatException()
        {
            var mockInput = "pizza";
            Assert.Throws<FormatException>(() => (int)Convert.ToInt64(mockInput));
        }

        [Theory]
        [InlineData(27, 5.196152422706632)]
        [InlineData(15, 3.872983346207417)]
        public void TestSqrRoot(int number, double expected)
        {
            var result = Math.Sqrt(number);
            Assert.Equal(result, expected);
        }

    }
}
