

namespace ExercicioLoja.Entities
{
    internal class ImportedProduct : Product
    {
        public double CustomsFee { get; set; }

        public ImportedProduct() { }

        public ImportedProduct(string name, double price, double customsFee) : base(name, price)
        {
            CustomsFee = customsFee;
        }

        public double TotalPrice()
        {
            return CustomsFee + Price;
        }

        public override string PriceTag() //importados
        {
            return $"{Name} {TotalPrice().ToString("C")} (Customs fee: {CustomsFee.ToString("C")})";
        }



    }
}
