using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DAL.Model
{
    public class Laptop
    {
        public int MaLaptop { get; set; }
        [Required(ErrorMessage = "Dung Corei hay AMD gi co phai Chip M khong khong thi ngheo roi")]
        [StringLength(50, MinimumLength = 2,ErrorMessage = "Ten CPU khong duoc it hon 2 ki tu, neu la" +
            "chip M thi duoc vd: M1")]
        public string CPU { get; set; } 
        [Required(ErrorMessage = "Ram không toa đời không lể")]
        public string RAM { get; set; }
        [Required(ErrorMessage = "Máy tính này có card đồ hoạ 1080 TI trở lên không không thì nghèo quá rồi")]
        public string VGA_Card { get; set; }
        [Required(ErrorMessage = "Dùng ổ cứng SSD đúng không không thì chắc máy chạy không giòn đâu")]
        public string OCung { get; set; }
        [Required(ErrorMessage = "Pin bao nhieu co toa nhu pin xe dien vinfast khong")]
        public string PIN { get; set; }
        [Required(ErrorMessage = "Trong luong bao nhieu co lam ban luong lu vao moi sang cap sach di lam")]
        [Range(0, int.MaxValue, ErrorMessage = "Trong luong khong duoc be hon 0")]
        public double TrongLuong { get; set; }
        [Required(ErrorMessage = "Yeu cau co man hinh khong thi xin vinh biet cu")]
        public string ManHinh { get; set; }
        [Required(ErrorMessage = "Do phan giai la bao nhieu? co giai phong ban khoi tuong lai phia truoc toan" +
            "la mu mit hay khong?")]
        public string DoPhanGiai { get; set; }
        [Required(ErrorMessage ="Web cam cua hang nao no co trong giong cai khay dung thuc an cua hang nao do " +
            "chu")]
        public string WebCam { get; set; }
        [Required(ErrorMessage ="Dung he dieu hanh gi ")]
        public string HeDieuHanh { get; set; }
        [Required(ErrorMessage ="Kich thuoc dai rong no nhu the nao")]
        public string KichThuoc { get; set; }
        [Required(ErrorMessage ="Bluetooth may cham 0")]
        public string Bluetooth { get; set; }
        public SanPham sanPham { get; set; }
    }
}
