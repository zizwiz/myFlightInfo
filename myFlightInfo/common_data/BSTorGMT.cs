using System;

namespace myFlightInfo.common_data
{
    class CheckDate
    {
        public static DateTime LastSundayOfMonth(string month, string year)
        {
            int myyear = Convert.ToInt32(year);
            int mymonth = Convert.ToInt32(month);
            var myDayOfWeek = DayOfWeek.Sunday;

            DateTime date = new DateTime(myyear, mymonth, DateTime.DaysInMonth(myyear, mymonth), System.Globalization.CultureInfo.CurrentCulture.Calendar);

            int daysOffset = date.DayOfWeek - myDayOfWeek;
            if (daysOffset < 0) daysOffset += 7; // if the code is negative, we need to normalize them

           return DateTime.Parse(date.AddDays(-daysOffset).ToLongDateString());
        }
    }
}
