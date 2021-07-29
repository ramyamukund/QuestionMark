using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace QMproject.Helpers
{
    public static class DateHelper
    {
        public static string CalculateDateDifference(string date1, string date2)
        {
            try
            {
                //splits the date into 3 segments by delimiter
                var date1Segments = Regex.Split(date1, "/");
                var date2Segments = Regex.Split(date2, "/");

              
                // convert date segments array into an object

                var dateInput1 = new DateInput(date1Segments);
                var dateInput2 = new DateInput(date2Segments);

                var diffInDays = 0;

                //calculates the difference in days

                var years = Math.Abs(dateInput2.Year - dateInput1.Year);

                var months = Math.Abs(dateInput2.Month - dateInput1.Month);

                var days = Math.Abs(dateInput2.Day - dateInput1.Day);

                if (years > 0)
                {
                    diffInDays = calcDaysFromYears(years, dateInput1.Year);
                }
                if (months > 0)
                {
                    diffInDays = diffInDays + calcDaysFromMonths(months, dateInput1.Month);
                }
                if (days > 0)
                {
                    diffInDays = diffInDays + days;
                }

                return $"{diffInDays} days";
        }
            catch(Exception ex)
            {
                return string.Empty;
            }
            
        }

        private static int calcDaysFromMonths(int months, int m1)
        {
            var days = 0;
            var currentMonth = m1;
            var monthsWith31days = new List<int>() { 1, 3, 5, 7, 8, 10, 12 };
            var monthsWith30days = new List<int>() { 4, 6, 9, 11 };

            //check if the month contains 30 days , 31 or 28 days

            for (int i = 1; i <= months; i++)
            {
              
                if(currentMonth >  12)
                {
                    currentMonth = currentMonth - 12;
                }

                if(monthsWith31days.Contains(currentMonth))
                {
                    days += 31;
                }
                if (monthsWith30days.Contains(currentMonth))
                {
                    days += 30;
                }

                if(currentMonth == 2)
                {
                    days += 28;
                }

                currentMonth = currentMonth + i;
            }

            return days;

        }

        private static int calcDaysFromYears(int noOfYears, int year1)
        {
            var days = 0;
            var currentYear = year1;

            //check for leap year 

            for(int i = 1; i <= noOfYears; i++)
            {
                
                days += currentYear % 4 == 0 ? 366 : 365;
                currentYear = currentYear + i;

            }

            return days;
        }
    }
}
