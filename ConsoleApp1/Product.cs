using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public Currency Cost { get; set; }
        public int Quantity { get; set; }
        public string Producer { get; set; }
        public double Weight { get; set; }

        public Product() { }

        public Product(string name, decimal price, Currency cost, int quantity, string producer, double weight)
        {
            Name = name;
            Price = price;
            Cost = new Currency(cost);
            Quantity = quantity;
            Producer = producer;
            Weight = weight;
        }

        public Product(Product otherProduct) : this(otherProduct.Name, otherProduct.Price, otherProduct.Cost, otherProduct.Quantity, otherProduct.Producer, otherProduct.Weight) { }

        public decimal PriceInUAH => Price * Cost.GetExRate();
        public decimal TotalPriceInUAH => Price * Quantity * Cost.GetExRate();
        public double TotalWeight => Weight * Quantity;
    }
}