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

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void bt_dangnhap_Click(object sender, EventArgs e)
        {
            if (_IQLnv.getlstNVfromDB().Any(nv => nv.Email == tb_taikhoan.Text && nv.MatKhau == tb_matkhau.Text))
            {
                MessageBox.Show("Đăng nhập thành công");
                this.Hide();
                new FormBanHang().Show();
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại");
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void lb_quenmatkhau_Click(object sender, EventArgs e)
        {
            this.Hide();
            new QuenMK().Show();
        }
    }
}
