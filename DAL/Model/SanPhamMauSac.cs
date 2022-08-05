using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model
{
    public class SanPhamMauSac
    {
        public int Idmau { get; set; }
        public virtual MauSac mausac { get; set; }

        public string Masp { get; set; }
        public virtual BanPhim banphim { get; set; }
    }
}
