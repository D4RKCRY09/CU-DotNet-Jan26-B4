using Microsoft.AspNetCore.Mvc;
using Day56Assignment.Models;

namespace Day56Assignment.Controllers
{
    public class LoanController : Controller
    {
        private static List<Loan> _loans = new List<Loan>()
        {
            new Loan
            {
                Id=1,BorrowerName = "Sahil" , LenderName = "Aaroh" , Amount = 50000, IsSettled = true
            },
            new Loan
            {
                Id=2,BorrowerName = "Sahil" , LenderName = "Tushar" , Amount = 100000, IsSettled = false
            }
        };
        public IActionResult Index()
        {
            return View(_loans);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View(new Loan());
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var loanToEdit = _loans.Where(x => x.Id == id).FirstOrDefault();
            return View(loanToEdit);
        }
        [HttpPost]
        public IActionResult Edit(Loan loan)
        {
            foreach(var l in _loans)
            {
                if(loan.Id == l.Id)
                {
                    l.BorrowerName = loan.BorrowerName;
                    l.LenderName = loan.LenderName;
                    l.Amount = loan.Amount;
                    l.IsSettled = loan.IsSettled;
                    return RedirectToAction("Index");
                }
            }
            return NotFound();
        }

        [HttpPost]
        public IActionResult Add(Loan loan)
        {
            int id = _loans.Select(x => x.Id).Last();
            _loans.Add(
                new Loan
                {
                    Id = id+1,
                    BorrowerName = loan.BorrowerName,
                    LenderName = loan.LenderName,
                    Amount = loan.Amount,
                    IsSettled = loan.IsSettled
                }
                );
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var loanToDelete = _loans.Where(x => x.Id == id).FirstOrDefault();
            return View(loanToDelete);
        }

        [HttpPost]
        public IActionResult Delete(Loan loan)
        {

            var loanToDelete = _loans.Where(x => x.Id == loan.Id).FirstOrDefault();
            if(loanToDelete !=null)
            {
                _loans.Remove(loanToDelete);
                return RedirectToAction("Index");
            }
            return NotFound();
        }



    }
}
