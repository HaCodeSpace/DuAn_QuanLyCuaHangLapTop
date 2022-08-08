using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model
{
    public class HoaDon
    {
        public string MaHD { get; set; }
        public DateTime NgayLapHD { get; set; }
        public int? HinhThucThanhToan { get; set; }
        public string? HinhThucGiaoHang { get; set; }
        public float? TienKhachDua { get; set; }
        public float? TienTraLai { get; set; }
        public float? TongTienHD { get; set; }
        //public string NguoiLapHD { get; set; }
        //public string? TenKH { get; set; }
        public Boolean TrangThai { get; set; }
        public string? GhiChu { get; set; }

        public string MaNV { get; set; }
        public virtual NhanVien NhanVien { get; set; }

        public string? MaKH { get; set; }
        public virtual KhachHang khachHang { get; set; }

        public string? MaKM { get; set; }
        public virtual KhuyenMai khuyenMai { get; set; }

        public  virtual ICollection<HoaDonChiTiet> hoadonchitiets { get; set; }
    }
}
