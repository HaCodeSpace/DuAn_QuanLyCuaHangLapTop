using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Globalization;
using System.Threading;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS.IServices;
using BUS.Services;
using BUS.IServices.IServiceSanPham;
using BUS.Services.ServiceSanPham;
using DAL.Model;

namespace Presentation
{
    public partial class FormBanHang1 : Form
    {
        // fields
        public float total = 0;
        public float tienkhachdua = 0;
        private IHoaDonService _hoaDonService;
        private ISanPhamService _sanPhamService;
        private IHoaDonChiTietService _hoaDonChiTietService;
        private IQLKhuyenMaiService _khuyenMaiService;
        public readonly List<SanPham> LsanPhamSauThanhtoan = new List<SanPham>();
        private CultureInfo _cultureConverter;
        public List<sanphamMua> Giohang = new List<sanphamMua>();
        public List<sanphamMua> ListSanpham = new List<sanphamMua>();
        public List<KhuyenMai> listkhuyenmai = new List<KhuyenMai>();
        private string makm;

        public FormBanHang1()
        {
            InitializeComponent();
            // initailize service
            _hoaDonService = new HoaDonService();
            _sanPhamService = new SanPhamService();
            _hoaDonChiTietService = new HoaDonChiTietService();
            _khuyenMaiService = new QLKhuyenMaiService();
            _cultureConverter = new CultureInfo("vi-VN");
            
        }

        private void RemoveDatabindings()
        {
            label_mahoadon1.DataBindings.Clear();
        }

        private void AddDataBinding()
        {

            label_mahoadon1.DataBindings.Add(new Binding("Text", dataGridView_hoadoncho.DataSource, "MaHD"));
        }

        private void bt_taohoadon_Click(object sender, EventArgs e)
        {
            var hoadon = CreateHoadon();
            var resultAccess = _hoaDonService.ThemHD(hoadon);
            if (resultAccess)
            {
                MessageBox.Show("Thành công");
                ShowHoadonOnHoaDoncho();
                RemoveDatabindings(); AddDataBinding();
            }
            else
                MessageBox.Show("Thất bại");
        }

        private void ShowHoadonOnHoaDoncho()
        {
            var result = from l in _hoaDonService.LayDanhSachHD()
                         where l.TrangThai == false
                         select new
                         {
                             MaHD = l.MaHD,
                             NgayLap = l.NgayLapHD,
                             TrangThai = "Chờ Thanh toán"
                         };
            dataGridView_hoadoncho.DataSource = result.ToList();
        }

        private HoaDon CreateHoadon()
        {
            var a = _hoaDonService.LayDanhSachHD().Count();
            var hoadon = new HoaDon()
            {
                MaHD = "HD" + a,
                NgayLapHD = DateTime.Now,
                TrangThai = false,
                MaNV = "NV1",
                MaKH = "KH0"
            };
            return hoadon;
        }

        private void FormBanHang1_Load(object sender, EventArgs e)
        {
            var ListSP = from s in _sanPhamService.SanPhamList()
                         select new sanphamMua()
                         {
                             MaSP = s.MaSP,
                             TenSP = s.TenSP,
                             GiaSP = s.DonGiaBan,
                             GiaNhap = s.DonGiaNhap,
                             Dongsp = s.DongSP,
                             SoLuong = s.soluong,
                             ghichu = s.GhiChu
                         };
            ListSanpham = ListSP.ToList();
            dataGridView_danhsachsp.DataSource = ListSP.ToList();
            dataGridView_danhsachsp.Columns["GiaNhap"].Visible = false;
            dataGridView_danhsachsp.Columns["Dongsp"].Visible = false;
            ShowHoadonOnHoaDoncho();
            LoadGiamGia();
            RemoveDatabindings();
            AddDataBinding();
        }

        private void LoadGiamGia()
        {
            var resutl = from l in _khuyenMaiService.LayDanhSachKhuyenMai()
                         where l.NgayKetThuc > DateTime.Now
                         select l;
            listkhuyenmai = resutl.ToList();
            foreach (var item in resutl)
            {
                comboBox_giamgia.Items.Add(item.TenKhuyenMai);
            }
        }

        private void dataGridView_danhsachsp_Click(object sender, EventArgs e)
        {
            var num = int.Parse(dataGridView_danhsachsp.CurrentRow.Cells["SoLuong"].Value.ToString());
            if (num == 0)
            {
                MessageBox.Show("San pham nay da het hang");
                return;
            }
            var sanpham = new sanphamMua()
            {
                MaSP = int.Parse(dataGridView_danhsachsp.CurrentRow.Cells["MaSP"].Value.ToString()),
                TenSP = dataGridView_danhsachsp.CurrentRow.Cells["TenSP"].Value.ToString(),
                GiaSP = float.Parse(dataGridView_danhsachsp.CurrentRow.Cells["GiaSP"].Value.ToString()),
                SoLuong = 1
            };
            
            var result = Giohang.Any(m => m.MaSP == sanpham.MaSP);
            
            if (result && Giohang.Count > 0) 
            {
                var sp = Giohang.Find(p => p.MaSP.Equals(sanpham.MaSP));
                var a = Giohang.IndexOf(sp);
                //MessageBox.Show(a.ToString());
                //Listsanphammua.Insert(Listsanphammua.IndexOf(sanpham), sanpham);
                Giohang[a].SoLuong += 1;
            }
            else
            {
                Giohang.Add(sanpham);
            }
            var sanp = ListSanpham.Find(p => p.MaSP.Equals(sanpham.MaSP));
            var index = ListSanpham.IndexOf(sanp);
            ListSanpham[index].SoLuong -= 1;
            var sanpUpdate = new SanPham()
            {
                TenSP = ListSanpham[index].TenSP,
                DonGiaBan = ListSanpham[index].GiaSP,
                DonGiaNhap = ListSanpham[index].GiaNhap,
                DongSP = ListSanpham[index].Dongsp,
                soluong = ListSanpham[index].SoLuong,
                GhiChu = ListSanpham[index].ghichu
            };
            LsanPhamSauThanhtoan.Add(sanpUpdate);
            AddSPToListMua();

            total += sanpham.SoLuong * sanpham.GiaSP;

            comboBox_giamgia_SelectedIndexChanged(this, new EventArgs());

            tb_tongtien.Text = total.ToString("c", _cultureConverter);
        }

        private void AddSPToListMua()
        {
            dataGridView_giohang.DataSource = Giohang.ToList();
            dataGridView_danhsachsp.DataSource = ListSanpham.ToList();
            dataGridView_giohang.Columns["GiaNhap"].Visible = false;
            dataGridView_giohang.Columns["Dongsp"].Visible = false;
            dataGridView_giohang.Columns["ghichu"].Visible = false;
            dataGridView_giohang.Columns["MaSP"].Visible = false;
        }

        private void bt_xoatatca_Click(object sender, EventArgs e)
        {
            Giohang = new List<sanphamMua>();
            AddSPToListMua();
        }

        private void bt_xoasp_Click(object sender, EventArgs e)
        {

        }

        private void tb_tienkhachdua_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void tb_tienkhachdua_Leave(object sender, EventArgs e)
        {
            
            if (float.TryParse(tb_tienkhachdua.Text, out tienkhachdua))
            {
                tb_tienkhachdua.Text = tienkhachdua.ToString("c", _cultureConverter);
                tb_tienkhachtra.Text = (tienkhachdua - total).ToString("c", _cultureConverter);
            }
            else
            {
                tb_tienkhachdua.Text = String.Empty;
            }
        }

        private void bt_chon_Click(object sender, EventArgs e)
        {
            AddKhachHang akh = new AddKhachHang();
            akh.FillInfomation += Akh_FillInfomation;
            akh.ShowDialog();
        }

        private void Akh_FillInfomation(string makh, string tenkh)
        {
            tb_makh.Text = makh;
            tb_tenkh.Text = tenkh;
        }

        private void bt_huyhoadon_Click(object sender, EventArgs e)
        {
            var message = MessageBox.Show("Bạn có chắc muốn xoá hoá đơn này", "Warning!", MessageBoxButtons.YesNo);
            if (message == DialogResult.Yes)
            {
                var hd = new HoaDon()
                {
                    MaHD = label_mahoadon1.Text
                };
                if (_hoaDonService.XoaHD(hd))
                {
                    MessageBox.Show("Xoá thành công!");
                    ShowHoadonOnHoaDoncho();
                    RemoveDatabindings(); AddDataBinding();
                }
                else
                    MessageBox.Show("Thất bại");
                
            }
        }

        private void bt_thanhtoan_Click(object sender, EventArgs e)
        {
            
                if (label_mahoadon1.Text == "..........")
                {
                    //throw new Exception("Vui long tao hoa don");
                }

                var hd = new HoaDon()
                {
                    MaHD = label_mahoadon1.Text,
                    NgayLapHD = Convert.ToDateTime(dataGridView_hoadoncho.CurrentRow.Cells[1].Value),
                    HinhThucThanhToan = comboBox_hinhthuctt.SelectedText == "Tiền Mặt" ? 0 : 1,
                    HinhThucGiaoHang =  comboBox_hinhthucgiaohang.Text,
                    TienKhachDua = tienkhachdua,
                    TienTraLai = tienkhachdua - total,
                    TongTienHD = total,
                    TrangThai = true,
                    GhiChu = tb_ghichu.Text,
                    MaNV = "NV1",
                    MaKH = string.IsNullOrEmpty(tb_makh.Text) ? "KH0" : tb_makh.Text.Trim(),
                    MaKM = String.IsNullOrEmpty(comboBox_giamgia.Text) ? null : makm,
                };
                var EditHD = _hoaDonService.SuaHD(hd);
                var EditHDCT = FillHDCT();
                var EditSoLuong = UpdateSoLuong();

                if (EditHD && EditHDCT && EditSoLuong)
                {

                    MessageBox.Show("Thanh toán thành công");
                    reset();

                }
                else
                    MessageBox.Show("Thanh toán chưa thành công");
            
            

        }

        private void reset()
        {
            FormBanHang1_Load(this, new EventArgs());
            Giohang = new List<sanphamMua>();
            dataGridView_giohang.DataSource = Giohang.ToList();
            bt_lammoi_Click(this, new EventArgs());
        }



        private bool UpdateSoLuong()
        {

            foreach (var sp in LsanPhamSauThanhtoan)
            {
                var result = _sanPhamService.SuaSP(sp);
                if (!result) return result;
            }
            return true;
        }

        private bool FillHDCT()
        {
            List<bool> successArr = new List<bool>();
            for (int i = 0; i < Giohang.Count; i++)
            {
               
                var hdct = new HoaDonChiTiet()
                {
                    MaHD = label_mahoadon1.Text,
                    MaSP = Giohang[i].MaSP,
                    SoLuongMua = Giohang[i].SoLuong
                };
                successArr.Add(_hoaDonChiTietService.ThemHDCT(hdct));

            }

            foreach (var item in successArr)
            {
                if (!item)
                    return false;
            }
            return true;
        }

        private void tb_timkiem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                var result = from l in _sanPhamService.SanPhamList()
                             where l.TenSP.Contains(tb_timkiem.Text)
                             select new sanphamMua()
                             {
                                 MaSP = l.MaSP,
                                 TenSP = l.TenSP,
                                 GiaSP = l.DonGiaBan,
                                 GiaNhap = l.DonGiaNhap,
                                 Dongsp = l.DongSP,
                                 SoLuong = l.soluong,
                                 ghichu = l.GhiChu
                             };
                dataGridView_danhsachsp.DataSource = result.ToList();
            }
        }

        private void comboBox_danhmuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            var result = from l in _sanPhamService.SanPhamList()
                         where l.DongSP.Equals(comboBox_danhmuc.SelectedIndex)
                         select new sanphamMua()
                         {
                             MaSP = l.MaSP,
                             TenSP = l.TenSP,
                             GiaSP = l.DonGiaBan,
                             GiaNhap = l.DonGiaNhap,
                             Dongsp = l.DongSP,
                             SoLuong = l.soluong,
                             ghichu = l.GhiChu
                         };
            dataGridView_danhsachsp.DataSource = result.ToList();
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void bt_lammoi_Click(object sender, EventArgs e)
        {
            if (Giohang == null)
                total = 0;
            tb_makh.Clear();
            tb_tenkh.Clear();
            tb_tongtien.Clear();
            comboBox_giamgia.SelectedIndex = -1;
            tb_tienkhachdua.Clear();
            tb_tienkhachtra.Clear();
            comboBox_hinhthuctt.SelectedIndex = -1;
            comboBox_hinhthucgiaohang.SelectedIndex = -1;
            tb_ghichu.Clear();
        }

        private void comboBox_giamgia_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (total == 0)
            {
                comboBox_giamgia.SelectedIndex = -1;
                return;
            }
            if(comboBox_giamgia.SelectedIndex != -1)
            {
                var kmapdung = listkhuyenmai[comboBox_giamgia.SelectedIndex];
                makm = kmapdung.MaKM;
                total *= (float)kmapdung.ChietKhau / 100;
                tb_tongtien.Text = total.ToString("c", _cultureConverter);
            }
            
        }
    }

    public class sanphamMua
    {
        public int MaSP { get; set; }
        public string TenSP { get; set; }
        public float GiaNhap { get; set; }
        public float GiaSP { get; set; }
        public int SoLuong { get; set; }
        public int Dongsp { get; set; }
        public string ghichu { get; set; }

    }
}
