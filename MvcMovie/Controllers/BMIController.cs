using Microsoft.AspNetCore.Mvc;
using BMICalculatorMVC.Models;

namespace BMICalculatorMVC.Controllers
{
    public class BMIController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(BMIModel model)
        {
            if (ModelState.IsValid)
            {
                return View("Result", model);
            }
            return View();
        }
    }
}