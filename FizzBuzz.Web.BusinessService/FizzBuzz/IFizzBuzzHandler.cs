namespace FizzBuzz.Web.BusinessService.FizzBuzz
{
    public interface IFizzBuzzHandler
    {
        string Handle(int numberToHandle);
        bool CanHandle(int numberToHandle);
        string FizzBuzzOutput(int numberToHandle);
    }
}