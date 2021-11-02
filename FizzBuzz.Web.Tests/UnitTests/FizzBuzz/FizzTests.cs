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
            var number = new[] {3,6,9,12,15,18,21,24,27,30};
            var rand = (int)new Random().NextDouble() * (10 - 1) + 1; 

            var shouldReturnFizz = _handler.CanHandle(number[rand]);

            Assert.True(shouldReturnFizz);
        }

        [Fact]
        public void OutputWillMatchFizz()
        {
            var number = new[] { 3, 6, 9, 12, 15, 18, 21, 24, 27, 30 };
            var rand = (int)new Random().NextDouble() * (10 - 1) + 1; 

            var result = _handler.Handle(number[rand]);

            Assert.Equal("Fizz", result);
        }
    }
}
