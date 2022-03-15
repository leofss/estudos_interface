using estudos_interface.Entities;
using System;

namespace estudos_interface.Services
{
    class RentalService
    {
        public double  PricePerHour { get; private set; }

        public double PricePerDay { get; private set; }

        private BrazilTaxService _brazilTax = new BrazilTaxService();

        public RentalService(double pricePerHour, double pricePerDay)
        {
            PricePerHour = pricePerHour;
            PricePerDay = pricePerDay;
        }

        public void ProcessInvoice(CarRental carRental)
        {
            TimeSpan duration = carRental.Finish.Subtract(carRental.Start);

            double basicpayment = 0.0; 
            if(duration.TotalHours <= 12.0)
            {
                basicpayment = PricePerHour * Math.Ceiling(duration.TotalHours);

            }
            else
            {
                basicpayment = PricePerDay * Math.Ceiling(duration.TotalDays);
            }

            double tax = _brazilTax.Tax(basicpayment);

            carRental.inVoice = new InVoice(basicpayment, tax);
        }
    }
}
