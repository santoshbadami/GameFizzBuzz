using FizzBuzz.Web.BusinessService.Helpers;

namespace FizzBuzz.Web.BusinessService.FizzBuzz
{
    public class FizzBuzzOutput : FizzBuzzHandler
    {
        public override string Handle(int numberToHandle)
        {
            return "FizzBuzz";
        }

        public override bool CanHandle(int numberToHandle)
        {
            return numberToHandle % FizzBuzzConstants.FizzBuzz == 0;
        }
    }
}
