using CodeCoverageSample;
using Xunit;

namespace TestProject1
{
    public class CalculatorTests
    {
        private readonly Calculator _calculator = new Calculator();

        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(0, 2, 2)]
        public void GivenTwoNumbers_Add_ReturnsTheTwoNumbersAddedTogether(int one, int two, int expected)
        {
            var actual = _calculator.Add(one, two);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void GivenTwoNumbers_Subtract_ReturnsTheFirstNumberSubtractedFromTheSecond()
        {
            var one = 1;
            var two = 2;

            var actual = _calculator.Subtract(one, two);

            Assert.Equal(-1, actual);
        }
    }
}
