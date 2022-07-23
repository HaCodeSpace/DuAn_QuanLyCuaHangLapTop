﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model
{
    public class BanPhim
    {
        public string MaSP { get; set; }
        public string HangSanXuat { get; set; }
        public int KieuKetNoi { get; set; }
        public string KieuBanPhim { get; set; }
        public string Led { get; set; }
        public string Layout { get; set; }
        //public string Keycaps { get; set; }
        public string KichThuoc { get; set; }
        public float TrongLuong { get; set; }
        public int MauSac { get; set; }

        public SanPham sanPham { get; set; }

        public ICollection<BanPhimSoLuongSwitch> banPhimSoLuongSwitches { get; set; }
        public IList<SanPhamMauSac> sanPhamMauSacs { get; set; }
    }
}
