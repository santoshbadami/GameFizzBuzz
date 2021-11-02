#region Namespaces
using FizzBuzz.Web.BusinessService;
using FizzBuzz.Web.Models;
using System.Collections.Generic;
#endregion

namespace FizzBuzz.Web.ApplicationService
{
    public class FizzBuzzApplicationService : IFizzBuzzApplicationService
    {
        private readonly IFizzBuzzBusinessService _fizzBuzzBusinessService;

        public FizzBuzzApplicationService(IFizzBuzzBusinessService fizzBuzzBusinessService)
        {
            _fizzBuzzBusinessService = fizzBuzzBusinessService;
        }

        public List<FizzBuzzModel> GetNumbers(int number,string date)
        {
            return _fizzBuzzBusinessService.GetNumbers(number,date);
        }
    }
}
