using FizzBuzz.Con;
using Xunit;
using FluentAssertions;

namespace FizzBuzz.Test
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(3, "Fizz")]
        [InlineData(6, "Fizz")]
        [InlineData(18, "Fizz")]
        [InlineData(21, "Fizz")]
        [InlineData(24, "Fizz")]
        [InlineData(27, "Fizz")]
        [InlineData(33, "Fizz")]
        [InlineData(36, "Fizz")]
        public void FizzTest(int number, string expected)
        {
            var sut = new FizzBuzzCalculate();
            var result = sut.FindFizzBuzz(number);
            result.Should().Be(expected);
        }

        [Theory]
        [InlineData(5, "Buzz")]
        [InlineData(10, "Buzz")]
        [InlineData(20, "Buzz")]
        [InlineData(25, "Buzz")]
        [InlineData(35, "Buzz")]
        [InlineData(40, "Buzz")]
        [InlineData(50, "Buzz")]
        [InlineData(55, "Buzz")]
        [InlineData(70, "Buzz")]
        [InlineData(95, "Buzz")]
        public void BuzzTest(int number, string expected)
        {
            var sut = new FizzBuzzCalculate();
            var result = sut.FindFizzBuzz(number);
            result.Should().Be(expected);
        }

        [Theory]
        [InlineData(15, "FizzBuzz")]
        [InlineData(30, "FizzBuzz")]
        [InlineData(45, "FizzBuzz")]
        public void FizzBuzzTest(int number, string expected)
        {
            var sut = new FizzBuzzCalculate();
            var result = sut.FindFizzBuzz(number);
            result.Should().Be(expected);
        }

        [Theory]
        [InlineData(5, "Buzz")]
        [InlineData(13, "Fizz")]
        [InlineData(23, "Fizz")]
        [InlineData(33, "Fizz")]
        [InlineData(34, "Fizz")]
        [InlineData(36, "Fizz")]
        [InlineData(50, "Fizz")]
        [InlineData(51, "Buzz")]
        [InlineData(52, "Buzz")]
        [InlineData(55, "Buzz")]
        [InlineData(36, "Fizz")]
        [InlineData(15, "FizzBuzz")]
        [InlineData(35, "FizzBuzz")]
        [InlineData(53, "FizzBuzz")]
        [InlineData(54, "FizzBuzz")]
        [InlineData(90, "FizzBuzz")]

        public void FindFizzBuzzWithDivisibleOrContains3And5Test(int number, string expected)
        {
            var sut = new FizzBuzzCalculate();
            var result = sut.FindFizzBuzzWithDivisibleOrContains3And5(number);
            result.Should().Be(expected);
        }
    }
}
