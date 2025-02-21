using Microsoft.AspNetCore.Mvc;
using MvcMovie.Models;
namespace MvcMovie.Controllers
{
    public class BMIController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(double CanNang, double ChieuCao)
        {
            if (ChieuCao > 10)
            {
                ChieuCao /= 100;
            }
            if (CanNang <= 0 || CanNang <= 0)
            {
                ViewBag.Result = "Cân nặng và chiều cao phải lớn hơn 0.";
                return View();
            }

            double bmi = CanNang / (ChieuCao * ChieuCao);

            string category;
            if (bmi < 18.5) category = "Ban dang thieu can. Ban hay tap luyen va bo xung them dinh duong.";
            else if (bmi < 25) category = "Ban co chi so binh thuong.";
            else if (bmi < 30) category = "Ban dang thua can. Hay tap luyen de giam can.";
            else category = "Ban dang BEO PHI. Hay tap luyen de giam can.";

            // Gửi kết quả về View
            ViewBag.Result = $"📊 Kết quả BMI: {bmi:F2} - {category}";
            return View();
        }
    }
}