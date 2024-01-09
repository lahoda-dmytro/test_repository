using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Airplane
    {
        protected string StartCity;
        protected string FinishCity;
        protected MyDate StartDate;
        protected MyDate FinishDate;

        public Airplane()
        {
            StartDate = new MyDate();
            FinishDate = new MyDate();
        }

        public Airplane(string startCity, string finishCity, MyDate startDate, MyDate finishDate)
        {
            StartCity = startCity;
            FinishCity = finishCity;
            StartDate = new MyDate(startDate);
            FinishDate = new MyDate(finishDate);
        }

        public Airplane(Airplane otherAirplane)
        {
            StartCity = otherAirplane.StartCity;
            FinishCity = otherAirplane.FinishCity;
            StartDate = new MyDate(otherAirplane.StartDate);
            FinishDate = new MyDate(otherAirplane.FinishDate);
        }



        public void SetStartCity(string startCity)
        {
            this.StartCity = startCity;
        }


        public void SetFinishCity(string finishCity)
        {
            this.FinishCity = finishCity;
        }
        public void SetStartDate(MyDate startDate)
        {
            this.StartDate = startDate;
        }
        public void SetFinishDate(MyDate finishDate)
        {
            this.FinishDate = finishDate;
        }




        public string GetStartCity()
        {
            return this.StartCity;

        }

        public string GetFinishCity()
        {
            return this.FinishCity;
        }

        public MyDate GetStartDate()
        {
            return this.StartDate;
        }
        public MyDate GetFinishDate()
        {
            return this.FinishDate;


        }


        public int GetTotalTime()
        {
            TimeSpan duration = FinishDate.GetDateTime().Subtract(StartDate.GetDateTime());
            return (int)duration.TotalMinutes;
        }

        public bool IsArrivingToday()
        {
            bool isSameDay = StartDate.GetDay() == FinishDate.GetDay();
            bool isSameMonth = StartDate.GetMonth() == FinishDate.GetMonth();
            bool isSameYear = StartDate.GetYear() == FinishDate.GetYear();

            return isSameDay && isSameMonth && isSameYear;
        }
    }

}
