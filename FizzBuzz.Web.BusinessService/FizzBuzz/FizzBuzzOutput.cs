
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
            return numberToHandle%FizzBuzzValue.FizzBuzz == 0;
        }
    }
}
