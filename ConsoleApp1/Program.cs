using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp1
{
    class MainClass
    {
        static void Main()
        {
            MyDate date1 = new MyDate(2023, 1, 9, 12, 30);
            MyDate date2 = new MyDate(2023, 1, 10, 14, 45);
            Currency usd = new Currency("USD", 37.5m);
            Product product = new Product("Laptop", 1200, usd, 5, "HP", 2.5);
            Airplane flight = new Airplane("Kyiv", "Zhytomyr", date1, date2);

            Console.WriteLine("Product Information:");
            Console.WriteLine($"Name: {product.Name} {product.Producer}");
            Console.WriteLine($"Price: {product.Price} {product.Cost.GetName()}");
            Console.WriteLine($"Quantity: {product.Quantity}");
            Console.WriteLine($"Total Price in UAH: {product.TotalPriceInUAH} UAH");
            Console.WriteLine($"Total Weight: {product.TotalWeight} kg");

            Console.WriteLine("\nAirplane Information:");
            Console.WriteLine($"Departure City: {flight.StartCity}");
            Console.WriteLine($"Arrival City: {flight.FinishCity}");
            Console.WriteLine($"Departure Date: {flight.StartDate.Year}-{flight.StartDate.Month}-{flight.StartDate.Day} {flight.StartDate.Hours}:{flight.StartDate.Minutes}");
            Console.WriteLine($"Arrival Date: {flight.FinishDate.Year}-{flight.FinishDate.Month}-{flight.FinishDate.Day} {flight.FinishDate.Hours}:{flight.FinishDate.Minutes}");
            Console.WriteLine($"Total Travel Time: {flight.GetTotalTime()} minutes");
            Console.WriteLine($"Is Arriving Today: {flight.IsArrivingToday()}");
        }
    }
}
