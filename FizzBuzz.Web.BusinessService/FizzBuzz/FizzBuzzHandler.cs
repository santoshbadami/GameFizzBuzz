
namespace FizzBuzz.Web.BusinessService.FizzBuzz
{
    public abstract class FizzBuzzHandler : IFizzBuzzHandler
    {
        protected FizzBuzzHandler Successor;

        // abstract methods are used in their concrete implementations
        public abstract string Handle(int numberToHandle);
        public abstract bool CanHandle(int numberToHandle);

        public string FizzBuzzOutput(int numberToHandle)
        {
            return CanHandle(numberToHandle) ? Handle(numberToHandle) : Successor.FizzBuzzOutput(numberToHandle);
        }

        public FizzBuzzHandler SetSuccessor(FizzBuzzHandler successor)
        {
            if (Successor == null)
                Successor = successor;
            else
                Successor.SetSuccessor(successor);

            return this;
        }

        public class FizzBuzzValue
        {
            public static int Fizz { get { return 3; } }
            public static int Buzz { get { return 5; } }
            public static int FizzBuzz { get { return Fizz * Buzz; } }

        }
    }
}
