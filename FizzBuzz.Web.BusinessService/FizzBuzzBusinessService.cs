#region Namespaces
using FizzBuzz.Web.BusinessService.FizzBuzz;
using FizzBuzz.Web.Models;
using System;
using System.Collections.Generic;
#endregion

namespace FizzBuzz.Web.BusinessService
{
    public class FizzBuzzBusinessService : IFizzBuzzBusinessService
    {
        public List<FizzBuzzModel> GetNumbers(int number, string date)
        {
            List<FizzBuzzModel> outputList = new List<FizzBuzzModel>();


            IWizzWuzzHandler wizzWuzz = new WizzOutput()
                .SetSuccessor(new WuzzOutput());

            IFizzBuzzHandler fizzBuzz = new NumberOutput()
                .SetSuccessor(new FizzBuzzOutput())
                .SetSuccessor(new FizzOutput())
                .SetSuccessor(new BuzzOutput());

            for (var i = 1; i <= number; i++)
            {
                string result = string.Empty;
                string wizzWuzzResult = wizzWuzz.WizzWuzzOutput(i, date);

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
