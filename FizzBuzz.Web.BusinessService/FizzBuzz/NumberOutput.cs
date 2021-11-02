
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
            return numberToHandle%FizzBuzzValue.Fizz != 0 && 
                numberToHandle%FizzBuzzValue.Buzz!=0;
        }
    }
}
