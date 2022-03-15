using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;
namespace estudos_interface.Entities
{
    class InVoice
    {
        public double BasicPayment { get; set; }
        public double Tax { get; set; }

        public InVoice(double basicPayment, double tax)
        {
            BasicPayment = basicPayment;
            Tax = tax;
        }

        public double TotalPayment
        {
            get { return BasicPayment + Tax; }
        }

        public override string ToString()
        {
            return $"Basisc Payment: {BasicPayment.ToString("F2", CultureInfo.InvariantCulture)} " +
                    $"Tax: {Tax.ToString("F2", CultureInfo.InvariantCulture)}" +
                    $"Total payment: {TotalPayment.ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
