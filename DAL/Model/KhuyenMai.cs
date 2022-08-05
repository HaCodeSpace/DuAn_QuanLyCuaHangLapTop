using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model
{
    public class KhuyenMai
    {
        public string MaKM { get; set; }
        public string TenKhuyenMai { get; set; }
      //  public DateTime NgayTao { get; set; }
        public double ChietKhau { get; set; }
        public DateTime NgayBatDau { get; set; }
        public DateTime NgayKetThuc { get; set; }
        public Boolean TrangThai { get; set; }
        public string Mota { get; set; }

        public virtual ICollection<HoaDon> hoaDons { get; set; }
    }
}
