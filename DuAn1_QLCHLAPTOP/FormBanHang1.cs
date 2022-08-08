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

        private CultureInfo _cultureConverter;
        public List<sanphamMua> Listsanphammua = new List<sanphamMua>();

        public FormBanHang1()
        {
            InitializeComponent();
            // initailize service
            _hoaDonService = new HoaDonService();
            _sanPhamService = new SanPhamService();
            _hoaDonChiTietService = new HoaDonChiTietService();

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
                MaNV = "NV1"
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
                             SoLuong = 1
                         };

            dataGridView_danhsachsp.DataSource = ListSP.ToList();
            ShowHoadonOnHoaDoncho();
            AddDataBinding();
        }

        private void dataGridView_danhsachsp_Click(object sender, EventArgs e)
        {

            var sanpham = new sanphamMua()
            {
                MaSP = dataGridView_danhsachsp.CurrentRow.Cells["MaSP"].Value.ToString(),
                TenSP = dataGridView_danhsachsp.CurrentRow.Cells["TenSP"].Value.ToString(),
                GiaSP = float.Parse(dataGridView_danhsachsp.CurrentRow.Cells["GiaSP"].Value.ToString()),
                SoLuong = int.Parse(dataGridView_danhsachsp.CurrentRow.Cells["SoLuong"].Value.ToString())
            };
            var result = Listsanphammua.Any(m => m.MaSP == sanpham.MaSP);
            
            if (result && Listsanphammua.Count > 0) 
            {
                var sp = Listsanphammua.Find(p => p.MaSP.Equals(sanpham.MaSP));
                var a = Listsanphammua.IndexOf(sp);
                //MessageBox.Show(a.ToString());
                //Listsanphammua.Insert(Listsanphammua.IndexOf(sanpham), sanpham);
                Listsanphammua[a].SoLuong += 1;
            }
            else
            {
                Listsanphammua.Add(sanpham);
            }
            AddSPToListMua();
            total += sanpham.SoLuong * sanpham.GiaSP;
            
            tb_tongtien.Text = total.ToString("c", _cultureConverter);
        }

        private void AddSPToListMua()
        {
            dataGridView_giohang.DataSource = Listsanphammua.ToList();
        }

        private void bt_xoatatca_Click(object sender, EventArgs e)
        {
            Listsanphammua = new List<sanphamMua>();
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
                MaKH = tb_makh.Text
            };
            var EditHD = _hoaDonService.SuaHD(hd);
            var EditHDCT = FillHDCT();

            if (EditHD && EditHDCT)
                MessageBox.Show("Thanh toán thành công");
            else
                MessageBox.Show("Thanh toán chưa thành công");

        }

        private bool FillHDCT()
        {
            bool[] successArr = new bool[Listsanphammua.Count];
            for (int i = 0; i < Listsanphammua.Count; i++)
            {
               
                var hdct = new HoaDonChiTiet()
                {
                    MaHD = label_mahoadon1.Text,
                    MaSP = Listsanphammua[i].MaSP,
                    SoLuongMua = Listsanphammua[i].SoLuong
                };
                successArr.Append(_hoaDonChiTietService.ThemHDCT(hdct));

            }

            foreach (var item in successArr)
            {
                if (!item)
                    return false;
            }
            return true;
        }
    }

    public class sanphamMua
    {
        public string MaSP { get; set; }
        public string TenSP { get; set; }
        public float GiaSP { get; set; }
        public int SoLuong { get; set; }
    }
}
