using FizzBuzz.Web.BusinessService.FizzBuzz;
using System;
using Xunit;

namespace FizzBuzz.Web.Tests.UnitTests.FizzBuzz
{
    public class WizzTests
    {
        private readonly IWizzWuzzHandler _handler;
        public WizzTests()
        {
            _handler = new WizzOutput();
        }

        [Fact]
        public void ShouldHandleNumberDivisableByThree()
        {
            // Arrange
            var number = new[] { 3, 6, 9, 12, 15, 18, 21, 24, 27, 30 };
            var rand = (int)new Random().NextDouble() * (10 - 1) + 1;

            // Act
            var shouldReturnWizz = _handler.CanHandleNumber(number[rand]);

            // Assert
            Assert.True(shouldReturnWizz);
        }

        [Fact]
        public void ShouldHandleDate()
        {
            // Arrange
            string date = "2021-11-03";

            // Act
            var shouldReturnWizz = _handler.CanHandleDate(date);

            //Assert
            Assert.True(shouldReturnWizz);
        }

        [Fact]
        public void OutputWillMatchWizz()
        {
            // Arrange
            var number = new[] { 3, 6, 9, 12, 15, 18, 21, 24, 27, 30 };
            var rand = (int)new Random().NextDouble() * (10 - 1) + 1;

            // Act
            var result = _handler.Handle(number[rand]);

            // Assert
            Assert.Equal("Wizz", result);
        }
    }
}
