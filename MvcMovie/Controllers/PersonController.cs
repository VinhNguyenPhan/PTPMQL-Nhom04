using Microsoft.AspNetCore.Mvc;
using MvcMovie.Models;
using System.Text.Encodings.Web;
namespace MvcMovie.Controllers
{
    public class PersonController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index( Person ps)
        {
            string strOutput = "Xin chao " + ps.FullName + " co ID la: " + ps.PersonId + " den tu " + ps.Address;
            ViewBag.infoPerson = strOutput;
            return View();
        }
        public IActionResult Welcome()
        {
            return View();
        }
    }
}