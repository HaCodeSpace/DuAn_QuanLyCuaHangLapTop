using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS.IServices;
using BUS.Services;

namespace Presentation
{
    public partial class FormThongKeDoanhThu : Form
    {
        private IHoaDonService _hoaDonService;
        private IQuanLyKhachHangService _IQLKhachHangService;
        private List<ShowThongKe> showThongKes; 
        public FormThongKeDoanhThu()
        {
            InitializeComponent();
            _hoaDonService = new HoaDonService();
            _IQLKhachHangService = new QuanLyKhachHangService();
            dataGridView1.ColumnCount = 3;
            dataGridView1.Columns[0].Name = "Tổng khách hàng";
            dataGridView1.Columns[1].Name = "Tổng hóa đơn";
            dataGridView1.Columns[2].Name = "Doanh thu";
            
            var viewtk = from a in _hoaDonService.LayDanhSachHD()
                         join b in _IQLKhachHangService.LayDanhSachKhachHang() on a.MaKH equals b.MaKH
                         where a.TrangThai == true
                         select new { tongkhach = b.MaKH, tonghd = a.MaHD, doanhthu = a.TongTienHD};
            showThongKes = new List<ShowThongKe>()
            {

            };
            foreach (var item in viewtk)
            {
                dataGridView1.Rows.Add(item.tongkhach, item.tonghd, item.doanhthu);
            }
        }

        private void sảnPhẩmToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

            FormThongKeSanPham ftksp = new FormThongKeSanPham()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true,
            };
            ftksp.FormBorderStyle = FormBorderStyle.None;
            ftksp.Show();
        }
    }
}
