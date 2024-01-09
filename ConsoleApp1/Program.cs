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
            Console.WriteLine($"Name: {product.GetName()} {product.GetProducer()}");
            Console.WriteLine($"Price: {product.GetPrice()} {product.GetCost().GetName()}");
            Console.WriteLine($"Quantity: {product.GetQuantity()}");
            Console.WriteLine($"Total Price in UAH: {product.GetTotalPriceInUAH()} UAH");
            Console.WriteLine($"Total Weight: {product.GetTotalWeight()} kg");
            Console.WriteLine("\nAirplane Information:");
            Console.WriteLine($"Departure City: {flight.GetStartCity()}");
            Console.WriteLine($"Arrival City: {flight.GetFinishCity()}");
            Console.WriteLine($"Departure Date: {flight.GetStartDate().GetYear()}-{flight.GetStartDate().GetMonth()}-{flight.GetStartDate().GetDay()} {flight.GetStartDate().GetHours()}:{flight.GetStartDate().GetMinutes()}");
            Console.WriteLine($"Arrival Date: {flight.GetFinishDate().GetYear()}-{flight.GetFinishDate().GetMonth()}-{flight.GetFinishDate().GetDay()} {flight.GetFinishDate().GetHours()}:{flight.GetFinishDate().GetMinutes()}");
            Console.WriteLine($"Total Travel Time: {flight.GetTotalTime()} minutes");
            Console.WriteLine($"Is Arriving Today: {flight.IsArrivingToday()}");

        }
    }



}
