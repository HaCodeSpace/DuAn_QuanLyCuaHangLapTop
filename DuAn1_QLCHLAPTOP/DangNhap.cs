using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Presentation.Utilities;
using BUS.IServices;
using BUS.Services;

namespace Presentation
{
    public partial class DangNhap : Form
    {
        private IQLNhanVienService _IQLnv;
        public DangNhap()
        {
            InitializeComponent();
            _IQLnv = new QLNhanVienService();
        }

        private void bt_dangnhap_Click(object sender, EventArgs e)
        {
            if (_IQLnv.getlstNVfromDB().Any(nv => nv.Email == tb_taikhoan.Text && nv.MatKhau == tb_matkhau.Text))
            {
                if (cb_luutaikhoan.Checked == true)
                {
                    string email = tb_taikhoan.Text;
                    string pwd = tb_matkhau.Text;
                    Properties.Settings.Default.email = email;
                    Properties.Settings.Default.password=pwd;
                    Properties.Settings.Default.Save();
                }
                if(cb_luutaikhoan.Checked==false)
                    Properties.Settings.Default.Reset();
                MessageBox.Show("Đăng nhập thành công");
                foreach (var item in _IQLnv.getlstNVfromDB())
                {
                    if (item.Email == tb_taikhoan.Text)
                    {
                        Properties.Settings.Default.manv = item.MaNV;
                    }
                }
                this.Hide();
                new FormBanHang().Show();
            }
            else
            {
                Properties.Settings.Default.Reset();
                MessageBox.Show("Đăng nhập thất bại");
            }
        }

        private void lb_quenmatkhau_Click(object sender, EventArgs e)
        {
            this.Hide();
            new QuenMK().Show();
        }

        private void bt_thoat_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void cb_luutaikhoan_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void DangNhap_Load(object sender, EventArgs e)
        {
            tb_taikhoan.Text = Properties.Settings.Default.email;
            tb_matkhau.Text=Properties.Settings.Default.password;
            if (Properties.Settings.Default.email != "")
                cb_luutaikhoan.Checked = true;
        }
    }
}
