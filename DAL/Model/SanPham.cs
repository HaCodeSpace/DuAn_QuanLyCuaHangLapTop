using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model
{
    public class SanPham
    {
        public int MaSP { get; set; }
        public string TenSP { get; set; }
        public float DonGiaNhap { get; set; }
        public float DonGiaBan { get; set; }
        public Int32 DongSP { get; set; }
        public string GhiChu { get; set; }

        public virtual BanPhim banPhim { get; set; }

        public Laptop laptop { get; set; }

        public Chuot chuot { get; set; }
        public virtual ICollection<HoaDonChiTiet> hoaDonChiTiets { get; set; }
    }
}
