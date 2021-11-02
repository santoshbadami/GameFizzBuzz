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
            var number = new[] { 15, 30, 45, 60, 75, 90 };
            var rand = (int)new Random().NextDouble() * (6 - 1) + 1; 

            var shouldReturnBuzz = _handler.CanHandle(number[rand]);

            Assert.True(shouldReturnBuzz);
        }

        [Fact]
        public void OutputWillMatchFizzBuzz()
        {
            var number = new[] { 15, 30, 45, 60, 75, 90 };
            var rand = (int)new Random().NextDouble() * (6 - 1) + 1; 

            var result = _handler.Handle(number[rand]);

            Assert.Equal("FizzBuzz",result);
        }
    }
}
