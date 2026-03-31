using CentralizedPricingEngine.Models;

namespace CentralizedPricingEngine.Services
{
    public interface IPricingService
    {
        public decimal DiscountedPrice(string? code, decimal total);
    }
}
