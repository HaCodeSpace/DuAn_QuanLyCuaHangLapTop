using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DAL.Model
{
    public class BanPhim
    {
      
        public int MaSP { get; set; }
        [Required(ErrorMessage ="Hãng sản xuất là gì?")]
        public string HangSanXuat { get; set; }
        [Required(ErrorMessage = "Kiều kết nối là gì?")]
        public int KieuKetNoi { get; set; }
        [Required(ErrorMessage = "Kiều bàn phím là gì?")]

        public string KieuBanPhim { get; set; }
        [Required(ErrorMessage = "Đèn led là gì?")]

        public string Led { get; set; }
        [Required(ErrorMessage = "Layout như thế nào?")]

        public string Layout { get; set; }

        [Required(ErrorMessage = "Kich thước có nice không là gì?")]

        public string KichThuoc { get; set; }
        [Required(ErrorMessage = "Trong lượng bao nhiêu??")]
        [Range(0, int.MaxValue, ErrorMessage ="Trọng lượng không được bé hơn không")]
    
        public double TrongLuong { get; set; }

        public virtual SanPham sanPham { get; set; }

        //public virtual ICollection<BanPhimSoLuongSwitch> banPhimSoLuongSwitches { get; set; }
        //public virtual ICollection<SanPhamMauSac> sanPhamMauSacs { get; set; }
        //public virtual ICollection<BanPhimKeyCaps> banPhimKeyCaps { get; set; }
    

    }
}
