
namespace FizzBuzz.Web.BusinessService.FizzBuzz
{
    public class FizzOutput : FizzBuzzHandler
    {
        public override string Handle(int numberToHandle)
        {
            return "Fizz";
        }

        public override bool CanHandle(int numberToHandle)
        {
            return numberToHandle%FizzBuzzValue.Fizz == 0;
        }
    }
}
