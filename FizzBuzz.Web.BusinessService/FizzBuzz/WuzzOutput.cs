
using System;

namespace FizzBuzz.Web.BusinessService.FizzBuzz
{
    public class WuzzOutput : WizzWuzzHandler
    {
        public override string Handle(int numberToHandle)
        {
            return "Wuzz";
        }

        public override bool CanHandleNumber(int numberToHandle)
        {
            return numberToHandle%WizzWuzzValue.Wuzz == 0;
        }

        public override bool CanHandleDate(string date)
        {
            return Convert.ToDateTime(date).DayOfWeek.ToString() == "Wednesday";
        }
    }
}
