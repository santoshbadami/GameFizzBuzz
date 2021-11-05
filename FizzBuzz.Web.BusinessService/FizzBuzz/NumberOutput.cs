using FizzBuzz.Web.BusinessService.Helpers;

namespace FizzBuzz.Web.BusinessService.FizzBuzz
{
    public class NumberOutput : FizzBuzzHandler
    {
        public override string Handle(int numberToHandle)
        {
            return numberToHandle.ToString();
        }

        public override bool CanHandle(int numberToHandle)
        {
            return numberToHandle % FizzBuzzConstants.Fizz != 0 &&
                numberToHandle % FizzBuzzConstants.Buzz != 0;
        }
    }
}
