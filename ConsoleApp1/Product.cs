using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Product
    {
        protected string Name;
        protected decimal Price;
        protected Currency Cost;
        protected int Quantity;
        protected string Producer;
        protected double Weight;

        public Product()
        {
        }

        public Product(string name, decimal price, Currency cost, int quantity, string producer, double weight)
        {
            Name = name;
            Price = price;
            Cost = new Currency(cost);
            Quantity = quantity;
            Producer = producer;
            Weight = weight;
        }

        public Product(Product otherProduct) : this(otherProduct.Name, otherProduct.Price, otherProduct.Cost, otherProduct.Quantity, otherProduct.Producer, otherProduct.Weight)
        {
        }



        public string GetName()
        {
            return Name;
        }

        public decimal GetPrice()
        {
            return Price;
        }

        public Currency GetCost()
        {
            return Cost;
        }

        public int GetQuantity()
        {
            return Quantity;
        }

        public string GetProducer()
        {
            return Producer;
        }

        public double GetWeight()
        {
            return Weight;
        }



        public void SetName(string name)
        {
            Name = name;
        }

        public void SetPrice(decimal price)
        {
            Price = price;
        }

        public void SetCost(Currency cost)
        {
            Cost = new Currency(cost);
        }


        public void SetQuantity(int quantity)
        {
            Quantity = quantity;
        }

        public void SetProducer(string producer)
        {
            Producer = producer;
        }

        public void SetWeight(double weight)
        {
            Weight = weight;
        }



        public decimal GetPriceInUAH()
        {
            return Price * Cost.GetExRate();
        }

        public decimal GetTotalPriceInUAH()
        {
            return Price * Quantity * Cost.GetExRate();
        }

        public double GetTotalWeight()
        {
            return Weight * Quantity;
        }
    }

}
