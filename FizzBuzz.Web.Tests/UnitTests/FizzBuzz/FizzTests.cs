using FizzBuzz.Web.BusinessService.FizzBuzz;
using System;
using Xunit;

namespace FizzBuzz.Web.Tests.UnitTests.FizzBuzz
{
    public class FizzTests
    {
        private readonly IFizzBuzzHandler _handler;
        public FizzTests() 
        {
            _handler = new FizzOutput();
        }

        [Fact]
        public void ShouldHandleNumberDivisableByThree()
        {
            // Arrange
            var number = new[] {3,6,9,12,15,18,21,24,27,30};
            var rand = (int)new Random().NextDouble() * (10 - 1) + 1; 

            // Act
            var shouldReturnFizz = _handler.CanHandle(number[rand]);

            //Assert
            Assert.True(shouldReturnFizz);
        }

        [Fact]
        public void OutputWillMatchFizz()
        {
            // Arrange
            var number = new[] { 3, 6, 9, 12, 15, 18, 21, 24, 27, 30 };
            var rand = (int)new Random().NextDouble() * (10 - 1) + 1; 

            // Act
            var result = _handler.Handle(number[rand]);

            // Assert
            Assert.Equal("Fizz", result);
        }
    }
}
