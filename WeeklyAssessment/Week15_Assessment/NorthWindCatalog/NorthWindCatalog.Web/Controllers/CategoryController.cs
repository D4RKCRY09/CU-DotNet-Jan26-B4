using Microsoft.AspNetCore.Mvc;
using NorthWindCatalog.Services.DTOs;

namespace NorthWindCatalog.Web.Controllers
{
    public class CategoriesController : Controller
    {
        private readonly HttpClient _client;

        public CategoriesController(HttpClient client)
        {
            _client = client;
        }

        public async Task<IActionResult> Index()
        {
            var data = await _client.GetFromJsonAsync<List<CategoryDto>>("https://localhost:7086/api/categories");
            return View(data);
        }
    }

}
