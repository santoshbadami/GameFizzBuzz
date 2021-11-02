
namespace FizzBuzz.Web.BusinessService.FizzBuzz
{
    public class WizzOutput : FizzBuzzHandler
    {
        public override string Handle(int numberToHandle)
        {
            return "Wizz";
        }

        public override bool CanHandle(int numberToHandle)
        {
            return numberToHandle%FizzBuzzValue.Fizz == 0;
        }
    }
}
