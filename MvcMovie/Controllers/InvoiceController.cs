using Microsoft.AspNetCore.Mvc;
using MvcMovie.Models;

namespace MvcMovie.Controllers
{
    public class InvoiceController : Controller
    {
        public IActionResult Index(double quantity = 0, double unitPrice = 0)
        {
            var model = new InvoiceModel
            {
                Quantity = quantity,
                UnitPrice = unitPrice
            };

            ViewBag.Total = model.Index().ToString("N0") + " VND"; 
            return View();
        }
    }
}