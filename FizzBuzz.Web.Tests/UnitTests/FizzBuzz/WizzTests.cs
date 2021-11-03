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
            var number = new[] { 3, 6, 9, 12, 15, 18, 21, 24, 27, 30 };
            var rand = (int)new Random().NextDouble() * (10 - 1) + 1;

            var shouldReturnWizz = _handler.CanHandleNumber(number[rand]);

            Assert.True(shouldReturnWizz);
        }

        [Fact]
        public void ShouldHandleDate()
        {
            string date = "2021-11-03";
            var shouldReturnWizz = _handler.CanHandleDate(date);

            Assert.True(shouldReturnWizz);
        }

        [Fact]
        public void OutputWillMatchWizz()
        {
            var number = new[] { 3, 6, 9, 12, 15, 18, 21, 24, 27, 30 };
            var rand = (int)new Random().NextDouble() * (10 - 1) + 1;

            var result = _handler.Handle(number[rand]);

            Assert.Equal("Wizz", result);
        }
    }
}
