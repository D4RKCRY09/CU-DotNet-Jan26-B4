using CentralizedPricingEngine.Models;
using CentralizedPricingEngine.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CentralizedPricingEngine.Controllers
{
    public class ProductsController : Controller
    {
        internal static List<Product> _products = new List<Product>();
        static int i = 0;
        private IPricingService _pricingService { get; set; }
        public ProductsController(IPricingService pricingService)
        {
            _pricingService = pricingService;
        }
        // GET: ProductsController
        public ActionResult Index()
        {
            return View(_products);
        }

        // GET: ProductsController/Details/5
        public ActionResult Details(int id)
        {
            return View(_products.FirstOrDefault(x => x.Id == id));
        }

        // GET: ProductsController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ProductsController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Product productToAdd)
        {
            productToAdd.Id = i++;
            _products.Add(productToAdd);
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ProductsController/Edit/5
        public ActionResult Edit(int id)
        {
            var product = _products.FirstOrDefault(x => x.Id == id);
            return View(product);
        }

        // POST: ProductsController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Product productToEdit)
        {
            foreach (var product in _products)
            {
                if (product.Id == id)
                {
                    product.Name = productToEdit.Name;
                    product.Price = productToEdit.Price;
                }
            }
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ProductsController/Delete/5
        public ActionResult Delete(int id)
        {
            return View(_products.FirstOrDefault(x => x.Id == id));
        }

        // POST: ProductsController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Product productToDelete)
        {
            _products.RemoveAll(x => x.Id == id);
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
