using FizzBuzz.Web.XPagedList.Common;


namespace FizzBuzz.Web.XPagedList
{
    internal sealed class TagBuilderFactory : ITagBuilderFactory
    {
        public ITagBuilder Create(string tagName)
        {
            return new TagBuilder(tagName);
        }
    }
}
