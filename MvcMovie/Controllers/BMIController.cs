using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
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