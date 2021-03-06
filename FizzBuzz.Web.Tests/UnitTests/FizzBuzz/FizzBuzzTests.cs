using FizzBuzz.Web.BusinessService.FizzBuzz;
using System;
using Xunit;

namespace FizzBuzz.Web.Tests.UnitTests.FizzBuzz
{
    public class FizzBuzzTests
    {
        private readonly IFizzBuzzHandler _handler;
        public FizzBuzzTests() 
        {
            _handler = new FizzBuzzOutput();
        }

        [Fact]
        public void ShouldHandleNumberDivisableByThreeAndFive()
        {
            // Arrange
            var number = new[] { 15, 30, 45, 60, 75, 90 };
            var rand = (int)new Random().NextDouble() * (6 - 1) + 1; 

            // Act
            var shouldReturnBuzz = _handler.CanHandle(number[rand]);

            // Assert
            Assert.True(shouldReturnBuzz);
        }

        [Fact]
        public void OutputWillMatchFizzBuzz()
        {
            // Arrange
            var number = new[] { 15, 30, 45, 60, 75, 90 };
            var rand = (int)new Random().NextDouble() * (6 - 1) + 1; 

            // Act
            var result = _handler.Handle(number[rand]);

            // Assert
            Assert.Equal("FizzBuzz",result);
        }
    }
}
