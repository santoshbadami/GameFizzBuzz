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
            var number = new[] { 1, 2, 4, 7, 8, 10, 11, 13, 14, 16 };
            var rand = (int)new Random().NextDouble() * (10 - 1) + 1;

            var shouldReturnNumber = _handler.CanHandle(number[rand]);

            Assert.True(shouldReturnNumber);
        }

        [Fact]
        public void OutputWillMatchNumber()
        {
            var number = new[] { 1, 2, 4, 7, 8, 10, 11, 13, 14, 16 };
            var rand = (int)new Random().NextDouble() * (10 - 1) + 1;
            var expectedResult = number[rand].ToString();

            var result = _handler.Handle(number[rand]);

            Assert.Equal(expectedResult, result);
        }
    }
}
