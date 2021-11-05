using FizzBuzz.Web.BusinessService.Helpers;
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
            return numberToHandle % WizzWuzzConstants.Wizz == 0;
        }
        public override bool CanHandleDate(string day)
        {
            return DateTime.Now.DayOfWeek.ToString() == day;
        }
    }
}
