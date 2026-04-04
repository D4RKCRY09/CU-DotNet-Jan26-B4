using Microsoft.AspNetCore.Mvc;
using TravelFrontend.Services;

namespace TravelFrontend.Controllers
{
    public class DestinationController : Controller
    {
        private readonly ITravelAPIService _service;
        public DestinationController(ITravelAPIService service) 
        {
            _service = service;
        }
        public async Task<IActionResult> Index()
        {
            var destinations = await _service.GetAllAsync();
            return View(destinations);
        }
    }
}
