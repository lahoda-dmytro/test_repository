using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class MyDate
    {
        protected int Year;
        protected int Month;
        protected int Day;
        protected int Hours;
        protected int Minutes;

        public MyDate()
        {
        }

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



        public int GetYear()
        {
            return Year;
        }
        public int GetMonth()
        {
            return Month;
        }
        public int GetDay()
        {
            return Day;
        }
        public int GetHours()
        {
            return Hours;
        }
        public int GetMinutes()
        {
            return Minutes;
        }


        public void SetYear(int year)
        {
            Year = year;
        }




        public void SetMonth(int month)
        {
            Month = month;
        }

        public void SetDay(int day)
        {
            Day = day;
        }


        public void SetHours(int hours)
        {
            Hours = hours;
        }

        public void SetMinutes(int minutes)
        {
            Minutes = minutes;
        }


    }
}
