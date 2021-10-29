namespace FizzBuzz.Web.XPagedList.Common
{
    public interface ITagBuilderFactory
    {
        ITagBuilder Create(string tagName);
    }
}