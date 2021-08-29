using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Want2Learn.ClassAndObjects
{
    public static class DateTimeExtensions
    {
        public static DateTime AddWeeks(this DateTime date, int value)
        {
            DateTime newDate = date.AddDays(7 * value);
            return newDate;
        }

        public static DateTime StartWeek(this DateTime date)
        {
            while (date.DayOfWeek != DayOfWeek.Monday)
            {
                date = date.AddDays(-1);
            }
            return date;
        }

        public static DateTime EndWeek(this DateTime date)
        {
            while (date.DayOfWeek != DayOfWeek.Sunday)
            {
                date = date.AddDays(1);
            }
            return date;
        }
    }
}
