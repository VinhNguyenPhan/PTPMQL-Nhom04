using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MvcMovie.Models;

namespace MvcMovie.Models
{
    [Table("DaiLys")]
    public class DaiLy
    {
        [Key]
        public string MaDaiLy { get; set; }
        public string TenDaiLy { get; set; }
        public string DiaChi { get; set; }
        public string NguoiDaiDien { get; set; }
        public string DienThoai { get; set; }
        public string MaHTPP { get; set; }
        public HeThongPhanPhoi HeThongPhanPhoi{ get; set; }
        public DaiLy(string maDaiLy, string tenDaiLy, string diaChi, string nguoiDaiDien, string dienThoai, string maHTPP)
        {
            MaDaiLy = maDaiLy;
            TenDaiLy = tenDaiLy;
            DiaChi = diaChi;
            NguoiDaiDien = nguoiDaiDien;
            DienThoai = dienThoai;
            MaHTPP = maHTPP;

        }
    }
}