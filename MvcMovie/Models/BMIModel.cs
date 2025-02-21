using System.ComponentModel.DataAnnotations;
namespace MvcMovie.Models
{
public class TinhBMI
{
        public double CanNang { get; set; }
        public double ChieuCao { get; set; }
        public double BMI => (CanNang > 0) ? CanNang / (ChieuCao * ChieuCao) : 0;

        public string KetQua
        {
            get
            {
                if (BMI < 18.5) return "Ban dang thieu can. Ban hay tap luyen va bo xung them dinh duong.";
                if (BMI < 24.9) return "Ban co chi so binh thuong.";
                if (BMI < 29.9) return "Ban dang thua can. Hay tap luyen de giam can.";
                return "Ban dang BEO PHI. Hay tap luyen de giam can.";
            }
        }
    }
}
