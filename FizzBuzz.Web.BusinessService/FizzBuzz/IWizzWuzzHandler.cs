namespace FizzBuzz.Web.BusinessService.FizzBuzz
{
    public interface IWizzWuzzHandler
    {
        string Handle(int numberToHandle);
        bool CanHandleNumber(int numberToHandle);
        bool CanHandleDate(string date);
        string WizzWuzzOutput(int numberToHandle, string date);
    }
}