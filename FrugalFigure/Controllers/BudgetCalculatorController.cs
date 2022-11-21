using Microsoft.AspNetCore.Mvc;

namespace FrugalFigure.Controllers
{
    public class BudgetCalculatorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
