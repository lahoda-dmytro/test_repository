using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Airplane
    {
        private readonly string startCity;
        private readonly string finishCity;
        private readonly MyDate startDate;
        private readonly MyDate finishDate;

        public Airplane(string startCity, string finishCity, MyDate startDate, MyDate finishDate)
        {
            if (string.IsNullOrWhiteSpace(startCity))
                throw new ArgumentException("Start city cannot be empty.");

            if (string.IsNullOrWhiteSpace(finishCity))
                throw new ArgumentException("Finish city cannot be empty.");

            if (startDate == null || finishDate == null)
                throw new ArgumentNullException("StartDate and FinishDate cannot be null.");

            if (startDate.GetDateTime() > finishDate.GetDateTime())
                throw new ArgumentException("Finish date cannot be earlier than start date.");

            this.startCity = startCity;
            this.finishCity = finishCity;
            this.startDate = new MyDate(startDate);
            this.finishDate = new MyDate(finishDate);
        }

        public string StartCity => startCity;
        public string FinishCity => finishCity;
        public MyDate StartDate => startDate;
        public MyDate FinishDate => finishDate;

        public int GetTotalTime()
        {
            TimeSpan duration = finishDate.GetDateTime().Subtract(startDate.GetDateTime());
            return (int)duration.TotalMinutes;
        }

        public bool IsArrivingToday()
        {
            return startDate.Year == finishDate.Year &&
                   startDate.Month == finishDate.Month &&
                   startDate.Day == finishDate.Day;
        }
    }

}
