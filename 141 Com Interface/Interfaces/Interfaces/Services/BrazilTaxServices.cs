

namespace Interfaces.Services
{
    internal class BrazilTaxServices : ITaxService
    {
        public double Tax(double amount)
        {
            if (amount <= 100.0)
            {
                return amount * 0.2;//Taxa de 20% 
            }
            else
            {
                return amount * 0.15;//Taxa de 15%
            }
        }
    }
}
