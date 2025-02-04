using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class MyDate
    {
        public int Year { get; set; }
        public int Month { get; set; }
        public int Day { get; set; }
        public int Hours { get; set; }
        public int Minutes { get; set; }

        public MyDate() { }

        public MyDate(int year, int month, int day, int hours, int minutes)
        {
            Year = year;
            Month = month;
            Day = day;
            Hours = hours;
            Minutes = minutes;
        }

        public MyDate(MyDate otherDate)
        {
            Year = otherDate.Year;
            Month = otherDate.Month;
            Day = otherDate.Day;
            Hours = otherDate.Hours;
            Minutes = otherDate.Minutes;
        }

        public DateTime GetDateTime()
        {
            return new DateTime(Year, Month, Day, Hours, Minutes, 0);
        }
    }

}

