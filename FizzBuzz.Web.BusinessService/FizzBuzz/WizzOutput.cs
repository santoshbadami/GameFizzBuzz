
using System;

namespace FizzBuzz.Web.BusinessService.FizzBuzz
{
    public class WizzOutput : WizzWuzzHandler
    {
        public override string Handle(int numberToHandle)
        {
            return "Wizz";
        }

        public override bool CanHandleNumber(int numberToHandle)
        {
            return numberToHandle % WizzWuzzValue.Wizz == 0;
        }
        public override bool CanHandleDate(string date)
        {
            return Convert.ToDateTime(date).DayOfWeek.ToString() == "Wednesday";
        }
    }
}
