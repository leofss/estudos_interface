using System;
using System.Globalization;
using estudos_interface.Entities;
using estudos_interface.Services;

namespace estudos_interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com os dados do aluguel");
            Console.WriteLine("Modelo do carro: ");
            string model = Console.ReadLine();
            Console.WriteLine("Retirada (dd/MM/yyyy hh:ss: ");
            DateTime start = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
            Console.WriteLine("Retornar (dd/MM/yyyy hh:ss: ");
            DateTime finsh = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
            Console.WriteLine("Price por hora: ");
            double hour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Price per dia: ");
            double day = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            RentalService rentalService = new RentalService(hour, day, new BrazilTaxService());
            CarRental carRental = new CarRental(start, finsh, new Vehicle(model));

            rentalService.ProcessInvoice(carRental);

            Console.WriteLine($"invoice {carRental.inVoice}" );

        }
    }
}
