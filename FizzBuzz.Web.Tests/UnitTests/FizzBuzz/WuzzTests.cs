using FizzBuzz.Web.BusinessService;
using System;
using Xunit;

namespace FizzBuzz.Web.Tests.UnitTests.FizzBuzz
{
    public class WuzzTests
    {
        private readonly IFizzBuzzBusinessService _fizzBuzzBusinessService;

        public WuzzTests()
        {
            _fizzBuzzBusinessService = new FizzBuzzBusinessService();
        }

        [Fact]
        public void ShouldHandleNumberDivisableByFive()
        {
            var number = new[] { 5, 10, 15, 20, 25, 30, 35, 40, 45, 50 };
            var rand = (int)new Random().NextDouble() * (10 - 1) + 1;

            string date = "2021-11-03";

            var shouldReturnWuzz = _fizzBuzzBusinessService.GetNumbers(number[rand], date);

            Assert.Equal("Wuzz", shouldReturnWuzz[number[rand] - 1].Value.ToString());
        }
    }
}
