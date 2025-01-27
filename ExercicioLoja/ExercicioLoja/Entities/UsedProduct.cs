using System;

namespace ExercicioLoja.Entities
{
    internal class UsedProduct : Product
    {
        public DateTime ManufactureDate { get; set; }

        public UsedProduct() { }
        public UsedProduct(string name, double price, DateTime manufactureDate) : base (name, price)
        {
            ManufactureDate = manufactureDate;
        }

        public override string PriceTag() //usados
        {
            return $"{Name} (used) {Price.ToString("C")} (Manufacture date: {ManufactureDate.ToString("dd/MM/yyyy")}";
        }
    }
}
