using System;
using System.Globalization;

namespace FizzBuzz.Web.BusinessService
{
    public abstract class FizzBuzzCategorizer
    {
        public FizzBuzzCategorizer RegisterNext(FizzBuzzCategorizer next)
        {
            Next = next;
            return Next;
        }

        protected FizzBuzzCategorizer Next { get; private set; }

        public abstract string IsSatisfiedBy(int number);
    }
    public class FizzBuzzCatagorizer : FizzBuzzCategorizer
    {
        public override string IsSatisfiedBy(int number)
        {
            if (number % 15 == 0)
                return "FizzBuzz";
            return Next.IsSatisfiedBy(number);
        }
    }
    public class WuzzCatagorizer : FizzBuzzCategorizer
    {
        public override string IsSatisfiedBy(int number)
        {
            if (number % 5 == 0 && DateTime.Now.DayOfWeek.ToString() == "Wednesday")
                return "Wuzz";
            return Next.IsSatisfiedBy(number);
        }
    }
    public class WizzCatagorizer : FizzBuzzCategorizer
    {
        public override string IsSatisfiedBy(int number)
        {
            if (number % 3 == 0 && DateTime.Now.DayOfWeek.ToString() == "Wednesday")
                return "Wizz";
            return Next.IsSatisfiedBy(number);
        }
    }
    public class BuzzCatagorizer : FizzBuzzCategorizer
    {
        public override string IsSatisfiedBy(int number)
        {
            if (number % 5 == 0)
                return "Buzz";
            return Next.IsSatisfiedBy(number);
        }
    }
    public class FizzCatagorizer : FizzBuzzCategorizer
    {
        public override string IsSatisfiedBy(int number)
        {
            if (number % 3 == 0)
                return "Fizz";
            return Next.IsSatisfiedBy(number);
        }
    }
    public class PlainNumberCatagorizer : FizzBuzzCategorizer
    {
        public override string IsSatisfiedBy(int number)
        {
            return number.ToString(CultureInfo.InvariantCulture);
        }
    }
    public class CatagorizerChain
    {
        private CatagorizerChain()
        {
            Head = new FizzBuzzCatagorizer();
            Head.RegisterNext(new WuzzCatagorizer())
                .RegisterNext(new WizzCatagorizer())
                .RegisterNext(new BuzzCatagorizer())
                .RegisterNext(new FizzCatagorizer())
                .RegisterNext(new PlainNumberCatagorizer());
        }
        private FizzBuzzCategorizer Head { get; set; }

        public static string Calculate(int number)
        {
            return _instance.Head.IsSatisfiedBy(number);
        }

        private static readonly CatagorizerChain _instance = new CatagorizerChain();
    }
}
