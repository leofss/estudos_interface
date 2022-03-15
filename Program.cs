using System;
using System.Globalization;
using estudos_interface.Entities;

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

            CarRental carRental = new CarRental(start, finsh, new Vehicle(model));

        }
    }
}
