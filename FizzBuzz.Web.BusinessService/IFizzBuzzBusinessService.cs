using FizzBuzz.Web.Models;
using System.Collections.Generic;

namespace FizzBuzz.Web.BusinessService
{
    public interface IFizzBuzzBusinessService
    {
        List<FizzBuzzModel> GetNumbers(int number,string date);
    }
}
