using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DAL.Model
{
    public class SanPham
    {
        [Display(Name = "Ma san pham")]
        public int MaSP { get; set; }
        [Required(ErrorMessage = "Yeu cau ten san pham")]
        [StringLength(maximumLength: 100, MinimumLength = 3, ErrorMessage = "Ten san pham khong duoc it hon 3 ki tu")]
        [Display(Name = "Ten san pham")]
        public string TenSP { get; set; }

        [Required(ErrorMessage = "Yeu cau gia nhap san pham")]
        [Display(Name ="Don gia nhap")]
        [Range(minimum: 0, maximum: int.MaxValue, ErrorMessage = "Gia nhap khong duoc be hon 0")]
        public float DonGiaNhap { get; set; }
        [Display(Name ="Don gia ban")]
        [Required(ErrorMessage = "Yeu cau gia ban san pham")]
        [Range(minimum: 0, maximum: int.MaxValue, ErrorMessage ="Gia ban khong duoc nho hon gia nhap")]

        public float DonGiaBan { get; set; }
        [Range(0,int.MaxValue, ErrorMessage = "Yeu cau dong san pham")]

        public Int32 DongSP { get; set; }

        public string GhiChu { get; set; }

        public virtual BanPhim banPhim { get; set; }

        public Laptop laptop { get; set; }

        public Chuot chuot { get; set; }
        public virtual ICollection<HoaDonChiTiet> hoaDonChiTiets { get; set; }
    }
}
