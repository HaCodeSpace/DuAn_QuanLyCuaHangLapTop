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
using DAL.Model;

namespace Presentation
{
    public partial class AddKhachHang : Form
    {
        private IQuanLyKhachHangService _service;
        public List<KHview> ListKhachHang;

        public delegate void GetInfo(string makh, string tenkh);
        public event GetInfo FillInfomation;
        public AddKhachHang()
        {
            InitializeComponent();
            _service = new QuanLyKhachHangService();
            ListKhachHang = new List<KHview>();
        }

        private void AddKhachHang_Load(object sender, EventArgs e)
        {
            LoadKhachHangList();
        }

        private void LoadKhachHangList()
        {
            var list = from l in _service.LayDanhSachKhachHang()
                            select new KHview()
                            {
                                makh = l.MaKH,
                                tenKH = l.TenKH,
                                sodienthoai = l.SDT
                            };
            ListKhachHang = list.ToList();
            dtgListview.DataSource = ListKhachHang.ToList();
        }

        private void dtgListview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var result = ListKhachHang.Where(p => p.makh == tb_timkiem.Text).FirstOrDefault();

            dtgListview.DataSource = result;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormThemKH themKH = new FormThemKH();
            themKH.ThemKH += ThemKH_ThemKH;
            themKH.ShowDialog();
        }

        private void ThemKH_ThemKH(bool issuccess)
        {
            if (issuccess)
                LoadKhachHangList();
        }

        private void dtgListview_DoubleClick(object sender, EventArgs e)
        {
            string ma = dtgListview.CurrentRow.Cells["makh"].Value.ToString();
            string ten = dtgListview.CurrentRow.Cells["tenkh"].Value.ToString();

            if (FillInfomation != null)
                FillInfomation(ma, ten);

            this.Dispose();
            this.Close();
        }
    }

    public class KHview
    {
        public string makh { get; set; }
        public string tenKH { get; set; }
        public string sodienthoai { get; set; }
    }
}
