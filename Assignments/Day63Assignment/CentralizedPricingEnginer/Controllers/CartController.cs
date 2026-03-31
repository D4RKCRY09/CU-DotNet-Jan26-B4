using Microsoft.AspNetCore.Mvc;
using CentralizedPricingEngine.Models.ViewModel;
using CentralizedPricingEngine.Services;

namespace CentralizedPricingEngine.Controllers
{
    public class CartController : Controller
    {
        private IPricingService _priceService {  get; set; }
        public CartController(IPricingService pricingService)
        { 
            _priceService = pricingService;

        }
        public IActionResult Total()
        {
            Cart cart = new Cart();
            cart.TotalPrice = ProductsController._products.Sum(x => x.Price);
            return View(cart);
        }

        [HttpPost]
        public IActionResult Total(Cart localcart)
        {
            localcart.FinalPrice = _priceService.DiscountedPrice(localcart.PromoCode, localcart.TotalPrice);
            return RedirectToAction("Checkout",localcart);
        }

        public IActionResult Checkout(Cart localcart)
        {
            return View(localcart);
        }
    }
}
