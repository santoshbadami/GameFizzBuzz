using FizzBuzz.Web.BusinessService.FizzBuzz;
using System;
using Xunit;

namespace FizzBuzz.Web.Tests.UnitTests.FizzBuzz
{
    public class NumberTests
    {

         private readonly IFizzBuzzHandler _handler;
        public NumberTests() 
        {
            _handler = new NumberOutput();
        }

        [Fact]
        public void ShouldHandleNumberNotDivisableByThreeOrFive()
        {
            // Arrange
            var number = new[] { 1, 2, 4, 7, 8, 10, 11, 13, 14, 16 };
            var rand = (int)new Random().NextDouble() * (10 - 1) + 1;

            // Act
            var shouldReturnNumber = _handler.CanHandle(number[rand]);

            //Assert
            Assert.True(shouldReturnNumber);
        }

        [Fact]
        public void OutputWillMatchNumber()
        {
            // Arrange
            var number = new[] { 1, 2, 4, 7, 8, 10, 11, 13, 14, 16 };
            var rand = (int)new Random().NextDouble() * (10 - 1) + 1;
            var expectedResult = number[rand].ToString();

            // Act
            var result = _handler.Handle(number[rand]);

            // Assert
            Assert.Equal(expectedResult, result);
        }
    }
}
