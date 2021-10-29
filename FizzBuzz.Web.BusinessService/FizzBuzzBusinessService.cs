#region Namespaces
using FizzBuzz.Web.Models;
using System.Collections.Generic;
#endregion

namespace FizzBuzz.Web.BusinessService
{
    public class FizzBuzzBusinessService : IFizzBuzzBusinessService
    {
        public List<FizzBuzzModel> GetNumbers(int number)
        {
            List<FizzBuzzModel> outputList = new List<FizzBuzzModel>();
            for (int i = 1; i < number; i++)
            {
                string res = CatagorizerChain.Calculate(i);
                outputList.Add(new FizzBuzzModel() { Value = res });
            }
            return outputList;
        }
    }
}
