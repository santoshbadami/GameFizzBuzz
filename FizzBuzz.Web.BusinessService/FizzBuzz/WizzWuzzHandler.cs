namespace FizzBuzz.Web.BusinessService.FizzBuzz
{
    public abstract class WizzWuzzHandler : IWizzWuzzHandler
    {
        protected WizzWuzzHandler Successor;

        // abstract methods are used in their concrete implementations
        public abstract string Handle(int numberToHandle);
        public abstract bool CanHandleNumber(int numberToHandle);
        public abstract bool CanHandleDate(string date);

        public string WizzWuzzOutput(int numberToHandle, string date)
        {
            return (CanHandleDate(date) && CanHandleNumber(numberToHandle)) ? Handle(numberToHandle) :
                (Successor != null ? Successor.WizzWuzzOutput(numberToHandle, date) : string.Empty);
        }

        public WizzWuzzHandler SetSuccessor(WizzWuzzHandler successor)
        {
            if (Successor == null)
            {
                Successor = successor;
            }
            else
                Successor.SetSuccessor(successor);

            return this;
        }
    }
}
