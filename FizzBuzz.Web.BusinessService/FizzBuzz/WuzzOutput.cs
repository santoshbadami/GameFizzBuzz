
namespace FizzBuzz.Web.BusinessService.FizzBuzz
{
    public class WuzzOutput : FizzBuzzHandler
    {
        public override string Handle(int numberToHandle)
        {
            return "Wuzz";
        }

        public override bool CanHandle(int numberToHandle)
        {
            return numberToHandle%FizzBuzzValue.Buzz == 0;
        }
    }
}
