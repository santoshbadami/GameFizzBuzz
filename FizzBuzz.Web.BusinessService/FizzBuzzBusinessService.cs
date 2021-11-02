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

            bool isWednesday = Convert.ToDateTime(date).DayOfWeek.ToString() == "Wednesday";

            IFizzBuzzHandler fizzBuzz = new NumberOutput()
                .SetSuccessor(new FizzBuzzOutput())
                .SetSuccessor(isWednesday ? new WizzOutput() : new FizzOutput())
                .SetSuccessor(isWednesday ? new WuzzOutput() : new BuzzOutput());

            for (var i = 1; i <= number; i++)
            {
                string res = fizzBuzz.FizzBuzzOutput(i);
                outputList.Add(new FizzBuzzModel() { Value = res });
            }

            return outputList;
        }
    }
}
