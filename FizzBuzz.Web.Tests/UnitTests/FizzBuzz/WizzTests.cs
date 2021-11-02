using FizzBuzz.Web.BusinessService;
using System;
using Xunit;

namespace FizzBuzz.Web.Tests.UnitTests.FizzBuzz
{
    public class WizzTests
    {
        private readonly IFizzBuzzBusinessService _fizzBuzzBusinessService;

        public WizzTests()
        {
            _fizzBuzzBusinessService = new FizzBuzzBusinessService();
        }

        [Fact]
        public void ShouldHandleNumberDivisableByThree()
        {
            var number = new[] { 3, 6, 9, 12, 15, 18, 21, 24, 27, 30 };
            var rand = (int)new Random().NextDouble() * (10 - 1) + 1;

            string date = "2021-11-03";

            var shouldReturnWizz = _fizzBuzzBusinessService.GetNumbers(number[rand], date);

            Assert.Equal("Wizz", shouldReturnWizz[number[rand] - 1].Value.ToString());
        }
    }
}
