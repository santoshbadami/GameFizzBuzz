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
            var number = new[] { 5, 10, 15, 20, 25, 30, 35, 40, 45, 50 };
            var rand = (int)new Random().NextDouble() * (10 - 1) + 1;

            var shouldReturnBuzz = _handler.CanHandle(number[rand]);

            Assert.True(shouldReturnBuzz);
        }

        [Fact]
        public void OutputWillMatchBuzz()
        {
            var number = new[] { 5, 10, 15, 20, 25, 30, 35, 40, 45, 50 };
            var rand = (int)new Random().NextDouble() * (10 - 1) + 1;

            var result = _handler.Handle(number[rand]);

            Assert.Equal("Buzz", result);
        }
    }
}
