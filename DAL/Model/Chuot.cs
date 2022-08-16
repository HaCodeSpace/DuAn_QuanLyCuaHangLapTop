using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace DAL.Model
{
    public class Chuot
    {
        
        public int MaChuot { get; set; }

        [Required(ErrorMessage = "Yêu cầu kết nối")]
        public string KetNoi { get; set; }

        [Required(ErrorMessage = "Yêu cầu IPS")]
        public int IPS { get; set; }

        [Required(ErrorMessage = "Yêu cầu tần số phản hồi")]
        public string TanSoPhanHoi { get; set; }
        [Required(ErrorMessage = "Yêu cầu chất liệu vỏ")]

        public string ChetLieuVo { get; set; }
        [Required(ErrorMessage = "Yêu cầu trọng lượng")]
        [Range(minimum: 0.1, maximum: 5, ErrorMessage = "Trọng lượng không được bé hơn 0 hoặc lớn hơn 5 kg")]
        public double TrongLuong { get; set; }
        [Required(ErrorMessage = "Yêu cầu switch")]

        public string Switch { get; set; }
        [Required(ErrorMessage = "Yêu cầu Led")]

        public string Led { get; set; }
        [Required(ErrorMessage = "Yêu cầu Gia tốc")]

        public string GiaToc { get; set; }
        [Required(ErrorMessage = "Yêu cầu kích thước")]

        public string KichThuoc { get; set; }
        [Required(ErrorMessage = "Yêu cầu tuổi thọ")]

        public string TuoiTho { get; set; }

        public SanPham sanPham { get; set; }

    }
}
