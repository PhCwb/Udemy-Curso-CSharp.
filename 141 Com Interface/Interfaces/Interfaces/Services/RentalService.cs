using System;
using Interfaces.Entities;

namespace Interfaces.Services
{
    internal class RentalService //Serviço de aluguel.
    {
        public double PricePerHour { get; private set; }
        public double PricePerDay { get; private set; }

        private ITaxService _taxService;

        public RentalService(double pricePerHour, double pricePerDay, ITaxService taxService)
        {
            PricePerHour = pricePerHour;
            PricePerDay = pricePerDay;
            _taxService = taxService;
        }

        //Calculo do pagamento basico
        public void ProcessInvoice(CarRental carRental) //Processo de Fatura (Class Invoice).
        {
            //Ira tirar a diferença entre o horario de entrega e horario que foi alugado o carro.
            TimeSpan duracao = carRental.End.Subtract(carRental.Start);// Duração da locação.

            double basiPayment = 0.0;
            if (duracao.TotalHours <= 12.0)
            {
                basiPayment = PricePerHour * Math.Ceiling(duracao.TotalHours); //Para arredondar pra cima > Math.Ceiling
            }
            else
            {
                basiPayment = PricePerDay * Math.Ceiling(duracao.TotalDays);
            }

            //imposto ele ta calculando o imposto baseado no PagamentoBasico
            double tax = _taxService.Tax(basiPayment);

            //Associando o calculo com CarRental para processar o Invoice
            carRental.Invoice = new Invoice(basiPayment, tax);

        }
    }
}
