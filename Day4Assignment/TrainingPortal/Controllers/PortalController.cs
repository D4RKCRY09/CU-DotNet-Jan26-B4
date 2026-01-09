using Microsoft.AspNetCore.Mvc;

namespace TrainingPortal.Controllers
{
    public class PortalController : Controller
    {
        public IActionResult Courses()
        {
            return View();
        }
        public IActionResult Contacts()
        {
            return View();
        }
    }
}
