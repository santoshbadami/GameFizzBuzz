using FizzBuzz.Web.BusinessService.Helpers;
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
            return numberToHandle % WizzWuzzConstants.Wuzz == 0;
        }

        public override bool CanHandleDate(string day)
        {
            return DateTime.Now.DayOfWeek.ToString() == day;
        }
    }
}
