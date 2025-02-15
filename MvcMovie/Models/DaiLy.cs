using System.ComponentModel.DataAnnotations;
namespace MvcMovie.Models;
public class DaiLy
{
    public string? MaDaiLy {get; set;}
    public string? TenDaiLy {get; set;}
    public string? DiaChi {get; set;}
    public string? NguoiDaiDien {get; set;}
    public int? DienThoai {get; set;}
    public string? MaHTPP {get; set;}
}
// ma, ten, dia chi, nguoi dai dien, phone, mahtpp