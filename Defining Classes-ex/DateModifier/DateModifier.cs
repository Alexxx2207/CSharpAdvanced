using System;
using System.Collections.Generic;
using System.Text;

namespace DateModifierN
{
    public class DateModifier
    {
        private DateTime start;
        private DateTime end;

        public DateTime Start { get; set; }
        public DateTime End { get; set; }

        public static double Calc(DateTime date1, DateTime date2)
        {
            return Math.Abs((date2.Date - date1.Date).TotalDays);
        }
    }
}
