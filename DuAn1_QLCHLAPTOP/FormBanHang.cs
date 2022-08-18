using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation
{
    public partial class FormBanHang : Form
    {
        public FormBanHang()
        {
            InitializeComponent();
            // ẩn viền button
            bt_nhanvien.TabStop = false;
            bt_nhanvien.FlatStyle = FlatStyle.Flat;
            bt_nhanvien.FlatAppearance.BorderSize = 0;
            bt_banhang.TabStop = false;
            bt_banhang.FlatStyle = FlatStyle.Flat;
            bt_banhang.FlatAppearance.BorderSize = 0;
            bt_sanpham.TabStop = false;
            bt_sanpham.FlatStyle = FlatStyle.Flat;
            bt_sanpham.FlatAppearance.BorderSize = 0;
            bt_hoadon.TabStop = false;
            bt_hoadon.FlatStyle = FlatStyle.Flat;
            bt_hoadon.FlatAppearance.BorderSize = 0;
            bt_khuyenmai.TabStop = false;
            bt_khuyenmai.FlatStyle = FlatStyle.Flat;
            bt_khuyenmai.FlatAppearance.BorderSize = 0;
            bt_khachhang.TabStop = false;
            bt_khachhang.FlatStyle = FlatStyle.Flat;
            bt_khachhang.FlatAppearance.BorderSize = 0;
            bt_thongke.TabStop = false;
            bt_thongke.FlatStyle = FlatStyle.Flat;
            bt_thongke.FlatAppearance.BorderSize = 0;
            bt_doimatkhau.TabStop = false;
            bt_doimatkhau.FlatStyle = FlatStyle.Flat;
            bt_doimatkhau.FlatAppearance.BorderSize = 0;
            bt_dangxuat.TabStop = false;
            bt_dangxuat.FlatStyle = FlatStyle.Flat;
            bt_dangxuat.FlatAppearance.BorderSize = 0;

            if (Properties.Settings.Default.maql == false)
                bt_nhanvien.Visible = false;
            //Mở form Bán Hàng 1
            panel3.Controls.Clear();
            FormBanHang1 fbh = new FormBanHang1()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true,
            };
            this.panel3.Controls.Add(fbh);
            fbh.FormBorderStyle = FormBorderStyle.None;
            fbh.Show();
        }
        private void bt_nhanvien_Click_1(object sender, EventArgs e)
        {
            bt_banhang.BackColor = Color.Snow;    // Xóa màu backcolor
            bt_banhang.UseVisualStyleBackColor = true;
            bt_hoadon.BackColor = Color.Snow;    // Xóa màu backcolor
            bt_hoadon.UseVisualStyleBackColor = true;
            bt_khuyenmai.BackColor = Color.Snow;    // Xóa màu backcolor
            bt_khuyenmai.UseVisualStyleBackColor = true;
            bt_sanpham.BackColor = Color.Snow;    // Xóa màu backcolor
            bt_sanpham.UseVisualStyleBackColor = true;
            bt_khachhang.BackColor = Color.Snow;    // Xóa màu backcolor
            bt_khachhang.UseVisualStyleBackColor = true;
            bt_thongke.BackColor = Color.Snow;    // Xóa màu backcolor
            bt_thongke.UseVisualStyleBackColor = true;
            bt_doimatkhau.BackColor = Color.Snow;    // Xóa màu backcolor
            bt_doimatkhau.UseVisualStyleBackColor = true;
            bt_dangxuat.BackColor = Color.Snow;    // Xóa màu backcolor
            bt_dangxuat.UseVisualStyleBackColor = true;
            bt_nhanvien.BackColor = Color.Gray;
            panel3.Controls.Clear();
            FormNhanVien fnv = new FormNhanVien()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true,
            };
            this.panel3.Controls.Add(fnv);
            fnv.FormBorderStyle = FormBorderStyle.None;
            fnv.Show();
        }

        private void bt_hoadon_Click(object sender, EventArgs e)
        {
            bt_banhang.BackColor = Color.Snow;    // Xóa màu backcolor
            bt_banhang.UseVisualStyleBackColor = true;
            bt_sanpham.BackColor = Color.Snow;    // Xóa màu backcolor
            bt_sanpham.UseVisualStyleBackColor = true;
            bt_khuyenmai.BackColor = Color.Snow;    // Xóa màu backcolor
            bt_khuyenmai.UseVisualStyleBackColor = true;
            bt_nhanvien.BackColor = Color.Snow;    // Xóa màu backcolor
            bt_nhanvien.UseVisualStyleBackColor = true;
            bt_khachhang.BackColor = Color.Snow;    // Xóa màu backcolor
            bt_khachhang.UseVisualStyleBackColor = true;
            bt_thongke.BackColor = Color.Snow;    // Xóa màu backcolor
            bt_thongke.UseVisualStyleBackColor = true;
            bt_doimatkhau.BackColor = Color.Snow;    // Xóa màu backcolor
            bt_doimatkhau.UseVisualStyleBackColor = true;
            bt_dangxuat.BackColor = Color.Snow;    // Xóa màu backcolor
            bt_dangxuat.UseVisualStyleBackColor = true;
            bt_hoadon.BackColor = Color.Gray;
            panel3.Controls.Clear();
            FormHoaDon fhd = new FormHoaDon()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true,
            };
            this.panel3.Controls.Add(fhd);
            fhd.FormBorderStyle = FormBorderStyle.None;
            fhd.Show();
        }

        private void bt_khachhang_Click(object sender, EventArgs e)
        {
            bt_banhang.BackColor = Color.Snow;    // Xóa màu backcolor
            bt_banhang.UseVisualStyleBackColor = true;
            bt_sanpham.BackColor = Color.Snow;    // Xóa màu backcolor
            bt_sanpham.UseVisualStyleBackColor = true;
            bt_khuyenmai.BackColor = Color.Snow;    // Xóa màu backcolor
            bt_khuyenmai.UseVisualStyleBackColor = true;
            bt_nhanvien.BackColor = Color.Snow;    // Xóa màu backcolor
            bt_nhanvien.UseVisualStyleBackColor = true;
            bt_hoadon.BackColor = Color.Snow;    // Xóa màu backcolor
            bt_hoadon.UseVisualStyleBackColor = true;
            bt_thongke.BackColor = Color.Snow;    // Xóa màu backcolor
            bt_thongke.UseVisualStyleBackColor = true;
            bt_doimatkhau.BackColor = Color.Snow;    // Xóa màu backcolor
            bt_doimatkhau.UseVisualStyleBackColor = true;
            bt_dangxuat.BackColor = Color.Snow;    // Xóa màu backcolor
            bt_dangxuat.UseVisualStyleBackColor = true;
            bt_khachhang.BackColor = Color.Gray;
            panel3.Controls.Clear();
            FormKhachHang fkh = new FormKhachHang()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true,
            };
            this.panel3.Controls.Add(fkh);
            fkh.FormBorderStyle = FormBorderStyle.None;
            fkh.Show();
        }

        private void bt_thongke_Click(object sender, EventArgs e)
        {
            bt_banhang.BackColor = Color.Snow;    // Xóa màu backcolor
            bt_banhang.UseVisualStyleBackColor = true;
            bt_sanpham.BackColor = Color.Snow;    // Xóa màu backcolor
            bt_sanpham.UseVisualStyleBackColor = true;
            bt_khuyenmai.BackColor = Color.Snow;    // Xóa màu backcolor
            bt_khuyenmai.UseVisualStyleBackColor = true;
            bt_nhanvien.BackColor = Color.Snow;    // Xóa màu backcolor
            bt_nhanvien.UseVisualStyleBackColor = true;
            bt_khachhang.BackColor = Color.Snow;    // Xóa màu backcolor
            bt_khachhang.UseVisualStyleBackColor = true;
            bt_hoadon.BackColor = Color.Snow;    // Xóa màu backcolor
            bt_hoadon.UseVisualStyleBackColor = true;
            bt_doimatkhau.BackColor = Color.Snow;    // Xóa màu backcolor
            bt_doimatkhau.UseVisualStyleBackColor = true;
            bt_dangxuat.BackColor = Color.Snow;    // Xóa màu backcolor
            bt_dangxuat.UseVisualStyleBackColor = true;
            bt_thongke.BackColor = Color.Gray;
            panel3.Controls.Clear();
            FormThongKe ftk = new FormThongKe()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true,
            };
            this.panel3.Controls.Add(ftk);
            ftk.FormBorderStyle = FormBorderStyle.None;
            ftk.Show();
        }

        private void bt_khuyenmai_Click(object sender, EventArgs e)
        {
            bt_banhang.BackColor = Color.Snow;    // Xóa màu backcolor
            bt_banhang.UseVisualStyleBackColor = true;
            bt_hoadon.BackColor = Color.Snow;    // Xóa màu backcolor
            bt_hoadon.UseVisualStyleBackColor = true;
            bt_sanpham.BackColor = Color.Snow;    // Xóa màu backcolor
            bt_sanpham.UseVisualStyleBackColor = true;
            bt_nhanvien.BackColor = Color.Snow;    // Xóa màu backcolor
            bt_nhanvien.UseVisualStyleBackColor = true;
            bt_khachhang.BackColor = Color.Snow;    // Xóa màu backcolor
            bt_khachhang.UseVisualStyleBackColor = true;
            bt_thongke.BackColor = Color.Snow;    // Xóa màu backcolor
            bt_thongke.UseVisualStyleBackColor = true;
            bt_doimatkhau.BackColor = Color.Snow;    // Xóa màu backcolor
            bt_doimatkhau.UseVisualStyleBackColor = true;
            bt_dangxuat.BackColor = Color.Snow;    // Xóa màu backcolor
            bt_dangxuat.UseVisualStyleBackColor = true;
            bt_khuyenmai.BackColor = Color.Gray;
            panel3.Controls.Clear();
            FormKhuyenMai fkm = new FormKhuyenMai()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true,
            };
            this.panel3.Controls.Add(fkm);
            fkm.FormBorderStyle = FormBorderStyle.None;
            fkm.Show();
        }

        private void bt_sanpham_Click(object sender, EventArgs e)
        {
            bt_banhang.BackColor = Color.Snow;    // Xóa màu backcolor
            bt_banhang.UseVisualStyleBackColor = true;
            bt_hoadon.BackColor = Color.Snow;    // Xóa màu backcolor
            bt_hoadon.UseVisualStyleBackColor = true;
            bt_khuyenmai.BackColor = Color.Snow;    // Xóa màu backcolor
            bt_khuyenmai.UseVisualStyleBackColor = true;
            bt_nhanvien.BackColor = Color.Snow;    // Xóa màu backcolor
            bt_nhanvien.UseVisualStyleBackColor = true;
            bt_khachhang.BackColor = Color.Snow;    // Xóa màu backcolor
            bt_khachhang.UseVisualStyleBackColor = true;
            bt_thongke.BackColor = Color.Snow;    // Xóa màu backcolor
            bt_thongke.UseVisualStyleBackColor = true;
            bt_doimatkhau.BackColor = Color.Snow;    // Xóa màu backcolor
            bt_doimatkhau.UseVisualStyleBackColor = true;
            bt_dangxuat.BackColor = Color.Snow;    // Xóa màu backcolor
            bt_dangxuat.UseVisualStyleBackColor = true;
            bt_sanpham.BackColor = Color.Gray;
            panel3.Controls.Clear();
            FormSanPham fsp = new FormSanPham()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true,
            };
            this.panel3.Controls.Add(fsp);
            fsp.FormBorderStyle = FormBorderStyle.None;
            fsp.Show();
        }

        private void bt_banhang_Click(object sender, EventArgs e)
        {
            bt_sanpham.BackColor = Color.Snow;    // Xóa màu backcolor
            bt_sanpham.UseVisualStyleBackColor = true;
            bt_hoadon.BackColor = Color.Snow;    // Xóa màu backcolor
            bt_hoadon.UseVisualStyleBackColor = true;
            bt_khuyenmai.BackColor = Color.Snow;    // Xóa màu backcolor
            bt_khuyenmai.UseVisualStyleBackColor = true;
            bt_nhanvien.BackColor = Color.Snow;    // Xóa màu backcolor
            bt_nhanvien.UseVisualStyleBackColor = true;
            bt_khachhang.BackColor = Color.Snow;    // Xóa màu backcolor
            bt_khachhang.UseVisualStyleBackColor = true;
            bt_thongke.BackColor = Color.Snow;    // Xóa màu backcolor
            bt_thongke.UseVisualStyleBackColor = true;
            bt_doimatkhau.BackColor = Color.Snow;    // Xóa màu backcolor
            bt_doimatkhau.UseVisualStyleBackColor = true;
            bt_dangxuat.BackColor = Color.Snow;    // Xóa màu backcolor
            bt_dangxuat.UseVisualStyleBackColor = true;
            bt_banhang.BackColor = Color.Gray;
            panel3.Controls.Clear();
            FormBanHang1 fbh = new FormBanHang1()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true,
            };
            this.panel3.Controls.Add(fbh);
            fbh.FormBorderStyle = FormBorderStyle.None;
            fbh.Show();
        }

        private void bt_dangxuat_Click(object sender, EventArgs e)
        {
            bt_banhang.BackColor = Color.Snow;    // Xóa màu backcolor
            bt_banhang.UseVisualStyleBackColor = true;
            bt_sanpham.BackColor = Color.Snow;    // Xóa màu backcolor
            bt_sanpham.UseVisualStyleBackColor = true;
            bt_khuyenmai.BackColor = Color.Snow;    // Xóa màu backcolor
            bt_khuyenmai.UseVisualStyleBackColor = true;
            bt_nhanvien.BackColor = Color.Snow;    // Xóa màu backcolor
            bt_nhanvien.UseVisualStyleBackColor = true;
            bt_khachhang.BackColor = Color.Snow;    // Xóa màu backcolor
            bt_khachhang.UseVisualStyleBackColor = true;
            bt_thongke.BackColor = Color.Snow;    // Xóa màu backcolor
            bt_thongke.UseVisualStyleBackColor = true;
            bt_doimatkhau.BackColor = Color.Snow;    // Xóa màu backcolor
            bt_doimatkhau.UseVisualStyleBackColor = true;
            bt_hoadon.BackColor = Color.Snow;    // Xóa màu backcolor
            bt_hoadon.UseVisualStyleBackColor = true;
            bt_dangxuat.BackColor = Color.Gray;
            new DangNhap().Show();
            this.Hide();
        }
        private void bt_doimatkhau_Click(object sender, EventArgs e)
        {
            bt_banhang.BackColor = Color.Snow;    // Xóa màu backcolor
            bt_banhang.UseVisualStyleBackColor = true;
            bt_sanpham.BackColor = Color.Snow;    // Xóa màu backcolor
            bt_sanpham.UseVisualStyleBackColor = true;
            bt_khuyenmai.BackColor = Color.Snow;    // Xóa màu backcolor
            bt_khuyenmai.UseVisualStyleBackColor = true;
            bt_nhanvien.BackColor = Color.Snow;    // Xóa màu backcolor
            bt_nhanvien.UseVisualStyleBackColor = true;
            bt_khachhang.BackColor = Color.Snow;    // Xóa màu backcolor
            bt_khachhang.UseVisualStyleBackColor = true;
            bt_thongke.BackColor = Color.Snow;    // Xóa màu backcolor
            bt_thongke.UseVisualStyleBackColor = true;
            bt_hoadon.BackColor = Color.Snow;    // Xóa màu backcolor
            bt_hoadon.UseVisualStyleBackColor = true;
            bt_dangxuat.BackColor = Color.Snow;    // Xóa màu backcolor
            bt_dangxuat.UseVisualStyleBackColor = true;
            bt_doimatkhau.BackColor = Color.Gray;
            panel3.Controls.Clear();
            DoiMatKhau dmk = new DoiMatKhau()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true,
            };
            this.panel3.Controls.Add(dmk);
            dmk.FormBorderStyle = FormBorderStyle.None;
            dmk.Show();
        }
    }
}
