using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model
{
    public class BanPhim
    {
      
        public int MaSP { get; set; }
        public string HangSanXuat { get; set; }
        public int KieuKetNoi { get; set; }
        public string KieuBanPhim { get; set; }
        public string Led { get; set; }
        public string Layout { get; set; }
        //public string Keycaps { get; set; }
        public string KichThuoc { get; set; }
        public double TrongLuong { get; set; }

        public virtual SanPham sanPham { get; set; }

        public virtual ICollection<BanPhimSoLuongSwitch> banPhimSoLuongSwitches { get; set; }
        public virtual ICollection<SanPhamMauSac> sanPhamMauSacs { get; set; }
        public virtual ICollection<BanPhimKeyCaps> banPhimKeyCaps { get; set; }
    

    }
}
