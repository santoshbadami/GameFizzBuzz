#region Namespaces
using FizzBuzz.Web.BusinessService.FizzBuzz;
using FizzBuzz.Web.Models;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
#endregion

namespace FizzBuzz.Web.BusinessService
{
    public class FizzBuzzBusinessService : IFizzBuzzBusinessService
    {
        private readonly IConfiguration _configuration;
        public FizzBuzzBusinessService(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public List<FizzBuzzModel> GetNumbers(int number)
        {
            List<FizzBuzzModel> outputList = new List<FizzBuzzModel>();

            string day = _configuration["DefaultDate"];

            IWizzWuzzHandler wizzWuzz = new WizzOutput()
                .SetSuccessor(new WuzzOutput());

            IFizzBuzzHandler fizzBuzz = new NumberOutput()
                .SetSuccessor(new FizzBuzzOutput())
                .SetSuccessor(new FizzOutput())
                .SetSuccessor(new BuzzOutput());

            for (var i = 1; i <= number; i++)
            {
                string result = string.Empty;
                string wizzWuzzResult = wizzWuzz.WizzWuzzOutput(i, day);

                if (string.IsNullOrEmpty(wizzWuzzResult))
                    result = fizzBuzz.FizzBuzzOutput(i);
                else
                    result = wizzWuzzResult;

                outputList.Add(new FizzBuzzModel() { Value = result });
            }

            return outputList;
        }
    }
}
