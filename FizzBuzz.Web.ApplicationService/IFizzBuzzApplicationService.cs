using FizzBuzz.Web.Models;
using System.Collections.Generic;

namespace FizzBuzz.Web.ApplicationService
{
    public interface IFizzBuzzApplicationService
    {
        List<FizzBuzzModel> GetNumbers(int number,string date);
    }
}
