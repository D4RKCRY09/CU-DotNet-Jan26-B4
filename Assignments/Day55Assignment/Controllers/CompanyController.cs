using Day55Assignment.Models;
using Microsoft.AspNetCore.Mvc;

namespace Day55Assignment.Controllers
{
    public class CompanyController : Controller
    {
        private static List<Employees> emp = new List<Employees>()
        {
            new Employees(1,"Aaroh","Backend",40000),
            new Employees(2,"Mayank","Frontend",50000),
            new Employees(3,"Hritik","Devops",60000),
            new Employees(4,"Sahil","Testing",35000)
        };
        public IActionResult Index()
        {
            ViewBag.Announcement = "Welcome to the Employee DB";
            ViewBag.Employees = emp;
            ViewData["ServerStatus"] = true;
            return View();
        }
    }
}
