using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL.Model;
using BUS.IServices;
using BUS.Services;
using BUS.IServices.IServiceSanPham;
using BUS.Services.ServiceSanPham;

namespace Presentation
{
    public partial class FormHoaDon : Form
    {
        private IHoaDonService _hoaDonService;
        private IQLNhanVienService _nhanVienService;
        private IQuanLyKhachHangService _khachHangService;
        private IHoaDonChiTietService _hoaDonChiTietService;
        private ISanPhamService _sanPhamService;

        // list
        private List<ViewHoaDon> hoaDons;
        private List<ViewHoaDon> ListLocHoaDon;
        private bool isFilltering = false;
        public FormHoaDon()
        {
            InitializeComponent();
            // initialize service
            _hoaDonService = new HoaDonService();
            _nhanVienService = new QLNhanVienService();
            _khachHangService = new QuanLyKhachHangService();
            _hoaDonChiTietService = new HoaDonChiTietService();
            _sanPhamService = new SanPhamService();

            hoaDons = new List<ViewHoaDon>();
            ListLocHoaDon = new List<ViewHoaDon>();

        }

        private void FormHoaDon_Load(object sender, EventArgs e)
        {
            LoadDanhSachHoaDon();
        }

        private void Testload()
        {
            var result = from l in _hoaDonService.LayDanhSachHD() select new {l.MaHD, l.MaNV };
            dtghoadon.DataSource = result.ToList();
        }

        private void LoadDanhSachHoaDon()
        {
            var result = from l in _hoaDonService.LayDanhSachHD() 
                         join n in _nhanVienService.getlstNVfromDB()
                         on l.MaNV equals n.MaNV
                         join h in _khachHangService.LayDanhSachKhachHang()
                         on l.MaKH equals h.MaKH
                         select new ViewHoaDon()
                         {
                             MaHD = l.MaHD,
                             NgayLapHD = l.NgayLapHD,
                             HinhThucThanhToan = l.HinhThucThanhToan == 0 ? "Banking"  : "Tiền Mặt",
                             HinhThucGiaoHang = l.HinhThucGiaoHang,
                             TienKhachDua = l.TienKhachDua,
                             TienTraLai = l.TienTraLai,
                             TongTienHD = l.TongTienHD,
                             TrangThai = l.TrangThai ? "Đã thanh toán" : "Chờ thanh toán",
                             GhiChu = l.GhiChu,
                             NguoiLap = n.TenNV,
                             KhachHang = h.TenKH,
                             SoDienThoai = h.SDT,
                             MaKM = l.MaKM
                         };
            hoaDons = result.ToList();
            dtghoadon.DataSource = hoaDons;
            
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            
            if (e.KeyCode == Keys.Enter)
            {
                if (string.IsNullOrEmpty(textBox1.Text))
                    isFilltering = false;
                else
                    isFilltering = true;
                if (isFilltering)
                    ListLocHoaDon = ListLocHoaDon.Where(p => p.MaHD.Contains(textBox1.Text)).ToList();
                else
                {
                    ListLocHoaDon = hoaDons.Where(p => p.MaHD.Contains(textBox1.Text)).ToList();
                    isFilltering = true;
                }
                dtghoadon.DataSource = ListLocHoaDon;
            }
        }

        private void cbx_LocTrangthai_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbx_LocTrangthai.Text == "None")
                isFilltering = false;
            else if (isFilltering)
                ListLocHoaDon = ListLocHoaDon.Where(p => p.TrangThai == cbx_LocTrangthai.Text).ToList();
            else
            {
                ListLocHoaDon = hoaDons.Where(p => p.TrangThai == cbx_LocTrangthai.Text).ToList();
                isFilltering = true;
            }
            dtghoadon.DataSource = ListLocHoaDon;
        }

        private void cbx_locthanhtoan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbx_locthanhtoan.Text == "None")
                isFilltering = false;
            else if (isFilltering)
                ListLocHoaDon = ListLocHoaDon.Where(p => p.TrangThai == cbx_locthanhtoan.Text).ToList();
            else
            {
                ListLocHoaDon = hoaDons.Where(p => p.TrangThai == cbx_locthanhtoan.Text).ToList();
                isFilltering = true;
            }
            dtghoadon.DataSource = ListLocHoaDon;
        }

        private void cbx_locgiaohang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbx_locgiaohang.Text == "None")
                isFilltering = false;
            else if (isFilltering)
                ListLocHoaDon = ListLocHoaDon.Where(p => p.TrangThai == cbx_locgiaohang.Text).ToList();
            else
            {
                ListLocHoaDon = hoaDons.Where(p => p.TrangThai == cbx_locgiaohang.Text).ToList();
                isFilltering = true;
            }
            dtghoadon.DataSource = ListLocHoaDon;
        }

        private void dtghoadon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var mahd = dtghoadon.CurrentRow.Cells["MaHD"].Value.ToString();
            var result = from l in _hoaDonChiTietService.TaiHoaDonChiTiet(mahd)
                         join s in _sanPhamService.SanPhamList()
                         on l.MaSP equals s.MaSP
                         select new ViewHoaDonChiTiet()
                         {
                             MaHD = l.MaHD,
                             TenSP = s.TenSP,
                             GiaSP = s.DonGiaBan,
                             SoLuongMua = l.SoLuongMua
                         };
            dtghoadonct.DataSource = result.ToList();
        }
    }

    public class ViewHoaDon
    {
        public string MaHD { get; set; }
        public DateTime NgayLapHD { get; set; }
        public string? HinhThucThanhToan { get; set; }
        public string? HinhThucGiaoHang { get; set; }
        public float? TienKhachDua { get; set; }
        public float? TienTraLai { get; set; }
        public float? TongTienHD { get; set; }
        public string TrangThai { get; set; }
        public string? GhiChu { get; set; }
        public string NguoiLap { get; set; }
        public string? KhachHang { get; set; }

        public string SoDienThoai { get; set; }
        public string? MaKM { get; set; }

    }

    public class ViewHoaDonChiTiet
    {
        public string MaHD { get; set; }
        public string TenSP { get; set; }
        public float GiaSP { get; set; }
        public int SoLuongMua { get; set; }
    }
}
