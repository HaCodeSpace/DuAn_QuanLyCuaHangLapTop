using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model
{
    public class Laptop
    {
        public int MaLaptop { get; set; }
        public string CPU { get; set; }
        public string RAM { get; set; }
        public string VGA_Card { get; set; }
        public string OCung { get; set; }
        public string PIN { get; set; }
        public double TrongLuong { get; set; }
        public string ManHinh { get; set; }
        public string DoPhanGiai { get; set; }
        public string WebCam { get; set; }
        public string HeDieuHanh { get; set; }
        public string KichThuoc { get; set; }
        public string Bluetooth { get; set; }
        public SanPham sanPham { get; set; }
    }
}
