using Microsoft.AspNetCore.Mvc;
using NorthWindCatalog.Services.DTOs;

namespace NorthWindCatalog.Web.Controllers
{
    public class ProductsController : Controller
    {
        private readonly HttpClient _client;
        public ProductsController(HttpClient client)
        {
            _client = client;
        }

        public async Task<IActionResult> ByCategory(int id)
        {
            var products = await _client.GetFromJsonAsync<List<ProductDto>>
                ($"https://localhost:7086/api/products/by-category/{id}");

            return View(products);
        }

    }
}
