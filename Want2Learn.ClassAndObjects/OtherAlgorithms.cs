using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Want2Learn.ClassAndObjects.Enums;

namespace Want2Learn.ClassAndObjects
{
   public class OtherAlgorithms
    {
        public int CountDayOff(DateTime start, DateTime end)
        {
            int count = 0;
            for (DateTime i = start; i <= end; i = i.AddDays(1))
            {
                if ((i.DayOfWeek == DayOfWeek.Saturday) || (i.DayOfWeek == DayOfWeek.Sunday))
                {
                    count++;
                }
            }
            return count;
        }

        public bool IsIncluded(DateTime start, DateTime end, DateTime date)
        {
            bool included = false;
            if ((date >= start) && (date <= end))
            {
                included = true;
            }
            return included;
        }

        public bool IsIntersect(DateTime startFirst, DateTime endFirst, DateTime startSecond, DateTime endSecond)
        {
            bool intersect = true;
            if ((startSecond > endFirst) || (endSecond < startFirst))
            {
                intersect = false;
            }
            return intersect;
        }

        public DateTime GetStartMonth(DateTime date)
        {
            DateTime newDate = new DateTime(date.Year, date.Month, 1);
            return newDate;
        }

        public DateTime GetEndMonth(DateTime date)
        {
            int countOfDays = DateTime.DaysInMonth(date.Year, date.Month);
            DateTime newDate = new DateTime(date.Year, date.Month, countOfDays);
            return newDate;
        }

        public Month GetMonth(DateTime date)
        {
            switch (date.Month)
            {
                case 1:
                    return Month.January;
                case 2:
                    return Month.February;
                case 3:
                    return Month.March;
                case 4:
                    return Month.April;
                case 5:
                    return Month.May;
                case 6:
                    return Month.June;
                case 7:
                    return Month.July;
                case 8:
                    return Month.August;
                case 9:
                    return Month.September;
                case 10:
                    return Month.October;
                case 11:
                    return Month.November;
                case 12:
                    return Month.December;
                default:
                    return Month.NaN;
            }
        }

        public Month GetMonth(int month)
        {
            switch (month)
            {
                case 1:
                    return Month.January;
                case 2:
                    return Month.February;
                case 3:
                    return Month.March;
                case 4:
                    return Month.April;
                case 5:
                    return Month.May;
                case 6:
                    return Month.June;
                case 7:
                    return Month.July;
                case 8:
                    return Month.August;
                case 9:
                    return Month.September;
                case 10:
                    return Month.October;
                case 11:
                    return Month.November;
                case 12:
                    return Month.December;
                default:
                    return Month.NaN;
            }
        }
    }
}
