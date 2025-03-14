using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MvcMovie.Models;


namespace MvcMovie.Models
{
    [Table("HeThongPhanPhois")]
    public class HeThongPhanPhoi
    {
        [Key]
        public string MaHTPP { get; set; }
        public string TenHTPP { get; set; }
        public List<DaiLy> Daily { get; set; }
        public HeThongPhanPhoi()
        {
            Daily = new List<DaiLy>();
        }
    }
}