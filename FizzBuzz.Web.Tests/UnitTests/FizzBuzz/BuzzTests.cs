using FizzBuzz.Web.BusinessService.FizzBuzz;
using System;
using Xunit;

namespace FizzBuzz.Web.Tests.UnitTests.FizzBuzz
{
    public class BuzzTests
    {
        private readonly IFizzBuzzHandler _handler;
        public BuzzTests()
        {
            _handler = new BuzzOutput();
        }

        [Fact]
        public void ShouldHandleNumberDivisableByFive()
        {
            // Arrange
            var number = new[] { 5, 10, 15, 20, 25, 30, 35, 40, 45, 50 };
            var rand = (int)new Random().NextDouble() * (10 - 1) + 1;

            // Act
            var shouldReturnBuzz = _handler.CanHandle(number[rand]);

            // Assert
            Assert.True(shouldReturnBuzz);
        }

        [Fact]
        public void OutputWillMatchBuzz()
        {
            //Arrange
            var number = new[] { 5, 10, 15, 20, 25, 30, 35, 40, 45, 50 };
            var rand = (int)new Random().NextDouble() * (10 - 1) + 1;

            // Act
            var result = _handler.Handle(number[rand]);

            // Assert
            Assert.Equal("Buzz", result);
        }
    }
}
