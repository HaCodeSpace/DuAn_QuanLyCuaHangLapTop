using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Model;

namespace Presentation
{
    public class SanPhamView
    {
        public int MaSP { get; set; }
        public string TenSP { get; set; }
        public float DonGiaNhap { get; set; }
        public float DonGiaBan { get; set; }
        public string DongSP { get; set; }
        public string GhiChu { get; set; }
        public int SoLuongTon { get; set; }

        public Laptop laptop { get; set; }
        public BanPhim banPhim { get; set; }
        public Chuot chuot { get; set; }
    }
}
