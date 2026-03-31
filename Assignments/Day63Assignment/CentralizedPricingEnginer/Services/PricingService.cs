using CentralizedPricingEngine.Models;
using System.Globalization;

namespace CentralizedPricingEngine.Services
{
    public class PricingService : IPricingService
    {
        public decimal DiscountedPrice(string? code, decimal price)
        {

            if(code == null) return price;

            if (code.ToUpper() == "WINTER25") price -= price * 0.15M;
            else if (code.ToUpper() == "FREESHIP") price -= 5;

            return price;
        }
    }
}
