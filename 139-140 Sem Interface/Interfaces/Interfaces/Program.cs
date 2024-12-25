using System;
using System.Globalization;
using Interfaces.Entities;
using Interfaces.Services;


namespace Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter rental data");
            Console.Write("Car model: ");
            string model = Console.ReadLine();
            Console.Write("Pickup (dd/MM/yyyy hh:ss): ");
            DateTime start = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
            Console.Write("Return (dd/MM/yyyy hh:ss): ");
            DateTime end = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

            Console.Write("Enter price per hour: ");
            double priceHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Enter price per day: ");
            double priceDay = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            CarRental carRental = new CarRental(start, end, new Vehicle(model));
            
            RentalService rentalService = new RentalService(priceHour, priceDay);

            rentalService.ProcessInvoice(carRental);
            Console.WriteLine("INVOICE:");
            Console.WriteLine(carRental.Invoice);
      

        }
    }
}