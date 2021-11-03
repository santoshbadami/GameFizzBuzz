using FizzBuzz.Web.BusinessService;
using FizzBuzz.Web.BusinessService.FizzBuzz;
using System;
using Xunit;

namespace FizzBuzz.Web.Tests.UnitTests.FizzBuzz
{
    public class WuzzTests
    {
        private readonly IWizzWuzzHandler _handler;
        public WuzzTests()
        {
            _handler = new WuzzOutput();
        }

        [Fact]
        public void ShouldHandleNumberDivisableByFive()
        {
            var number = new[] { 5, 10, 15, 20, 25, 30, 35, 40, 45, 50 };
            var rand = (int)new Random().NextDouble() * (10 - 1) + 1;

            var shouldReturnBuzz = _handler.CanHandleNumber(number[rand]);

            Assert.True(shouldReturnBuzz);
        }

        [Fact]
        public void ShouldHandleDate()
        {
            string date = "2021-11-03";
            var shouldReturnWizz = _handler.CanHandleDate(date);

            Assert.True(shouldReturnWizz);
        }

        [Fact]
        public void OutputWillMatchWuzz()
        {
            var number = new[] { 5, 10, 15, 20, 25, 30, 35, 40, 45, 50 };
            var rand = (int)new Random().NextDouble() * (10 - 1) + 1;

            var result = _handler.Handle(number[rand]);

            Assert.Equal("Wuzz", result);
        }
    }
}
