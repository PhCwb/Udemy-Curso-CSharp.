using System;


namespace Interfaces.Entities
{
    internal class CarRental
    {
        public DateTime Start { get; set; } //Inicio
        public DateTime End { get; set; } //Fim
        public Vehicle Vehicle { get; set; } //associado a class Vehicle
        public Invoice Invoice { get; set; } //associado class Invoice

        public CarRental(DateTime start, DateTime end, Vehicle vehicle)
        {
            Start = start;
            End = end;
            Vehicle = vehicle;
            //Invoice = null;
        }
    }
}
