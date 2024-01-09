using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Currency
    {
        protected string Name;
        protected decimal ExRate;

        public Currency()
        {
        }

        public Currency(string name, decimal exRate)
        {
            Name = name;
            ExRate = exRate;
        }

        public Currency(Currency otherCurrency)
        {
            Name = otherCurrency.Name;
            ExRate = otherCurrency.ExRate;
        }

        public string GetName()
        {
            return Name;
        }

        public decimal GetExRate()
        {
            return ExRate;
        }



        public void SetName(string name)
        {
            Name = name;
        }

        public void SetExRate(decimal exRate)
        {
            ExRate = exRate;
        }
    }
}
