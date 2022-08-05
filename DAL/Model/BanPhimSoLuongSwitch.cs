using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model
{
    public class BanPhimSoLuongSwitch
    {

        public string MaSP { get; set; }
        public virtual BanPhim banPhim { get; set; }

        public string Switch { get; set; }
        public int SoLuong { get; set; }
    }
}
