using FizzBuzz.Web.BusinessService.Helpers;

namespace FizzBuzz.Web.BusinessService.FizzBuzz
{
    public class BuzzOutput : FizzBuzzHandler
    {
        public override string Handle(int numberToHandle)
        {
            return "Buzz";
        }

        public override bool CanHandle(int numberToHandle)
        {
            return numberToHandle % FizzBuzzConstants.Buzz == 0;
        }
    }
}
