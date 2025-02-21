using System.ComponentModel.DataAnnotations;

namespace BMICalculatorMVC.Models
{
    public class BMIModel
    {
        [Required(ErrorMessage = "Vui lòng nhập cân nặng.")]
        [Range(1, 500, ErrorMessage = "Cân nặng phải nằm trong khoảng 1 - 500 kg.")]
        public double Weight { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập chiều cao.")]
        [Range(0.5, 2.5, ErrorMessage = "Chiều cao phải nằm trong khoảng 0.5 - 2.5 mét.")]
        public double Height { get; set; }

        public double BMI => Weight / (Height * Height);
        public string Category
        {
            get
            {
                if (BMI < 18.5) return "Gầy";
                if (BMI < 24.9) return "Bình thường";
                if (BMI < 29.9) return "Thừa cân";
                return "Béo phì";
            }
        }
    }
}