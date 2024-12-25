using System;
using System.Collections.Generic;
using System.Globalization;

namespace Interfaces.Entities
{
    internal class Invoice//fatura a pagar
    {
        public double BasicPayment { get; set; } //Pagamento 
        public double Tax { get; set; } //Taxa

        public Invoice(double basicPayment, double tax)
        {
            BasicPayment = basicPayment;
            Tax = tax;
        }

        public double TotalPayment
        {
            get
            {
                return BasicPayment + Tax;
            }
        }

        public override string ToString()
        {
            return 
              $"Basic payment: {BasicPayment.ToString("F2", CultureInfo.InvariantCulture)}\n"
            + $"Tax: {Tax.ToString("F2", CultureInfo.InvariantCulture)}\n"
            + $"Total payment: {TotalPayment.ToString("F2",CultureInfo.InvariantCulture)}\n";
        }

    }
}