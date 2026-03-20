using Microsoft.AspNetCore.Mvc;

namespace CarManagementMVCApplication.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
