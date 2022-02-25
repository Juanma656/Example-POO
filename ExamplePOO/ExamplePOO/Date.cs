using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamplePOO
{
    public class Date
    {
        private int _year;
        private int _month;
        private int _day;

        public Date(int year, int month, int day)
        {
            //this.year = year; Esta obsoleto se usa el _year
            _year = year;
            _month = checkMonth(month);
            _day = checkDay(year,month,day);

        }

        private int checkDay(int year, int month, int day)
        {
            if (month == 2 && day == 29 && IsLeapYear(year))

                return year;

            int[] daysPerMonth = {0,31,28,31,30,31,30,31,31,30,31,30,31 };
            if (day >= 1 && day <= daysPerMonth[month])

                return day;

            throw new dayException("Invalid day");
        }

        private bool IsLeapYear(int year)
        {
           return year % 400 == 0 || year % 4 == 0 && year % 100 != 0;
        }

        private int checkMonth(int month)
        {
            if (month <= 12 && month > 0)

                return month;

            throw new MonthException($"Invalid month{_month}");
        }

        public override string ToString()
        {
            return $"{_year}/{_month:00}/{_day:00}";
        }
    }
}
