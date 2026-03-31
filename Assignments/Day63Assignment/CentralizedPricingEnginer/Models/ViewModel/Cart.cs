using System.ComponentModel.DataAnnotations;

namespace CentralizedPricingEngine.Models.ViewModel
{
    public class Cart
    {
        public decimal TotalPrice { get; set; }
        public string? PromoCode { get; set; }
        public decimal FinalPrice {  get; set; }
    }
}
