using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model
{
    public class NhanVien
    {
        public string MaNV { get; set; }
        public string TenNV { get; set; }
        public string GioiTinh { get; set; }
        public bool TrangThai { get; set; }
        //public string TaiKhoan { get; set; }
        public string MatKhau { get; set; } 
        public string SoDienThoai { get; set; }
        public DateTime NgaySinh { get; set; }
        public string DiaChi { get; set; }
        public string Email { get; set; }

        public string? MaQuanLi { get; set; }

        public virtual NhanVien QuanLi { get; set; }

        public virtual ICollection<NhanVien> nhanViens { get; set; }
        public virtual ICollection<HoaDon> hoaDons { get; set; }
    }
}
