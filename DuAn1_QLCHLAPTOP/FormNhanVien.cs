using BUS.IServices;
using DAL.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS.Services;

namespace Presentation
{
    public partial class FormNhanVien : Form
    {
        private NhanVien _nv;
        private IQLNhanVienService _IQLnv;
        public FormNhanVien()
        {
            InitializeComponent();
            _nv = new NhanVien();
            _IQLnv = new QLNhanVienService();
            dataGridView1.Rows.Clear();
            dataGridView1.ColumnCount = 10;
            dataGridView1.Columns[0].Name = "Mã nhân viên";
            dataGridView1.Columns[1].Name = "Tên nhân viên";
            dataGridView1.Columns[2].Name = "Vai trò";
            dataGridView1.Columns[3].Name = "Email";
            dataGridView1.Columns[4].Name = "Mật khẩu";
            dataGridView1.Columns[5].Name = "Địa chỉ";
            dataGridView1.Columns[6].Name = "Điện thoại";
            dataGridView1.Columns[7].Name = "Ngày sinh";
            dataGridView1.Columns[8].Name = "Giới tính";
            dataGridView1.Columns[9].Name = "Trạng thái";
            foreach (var item in _IQLnv.getlstNVfromDB())
            {
                dataGridView1.Rows.Add(item.MaNV, item.TenNV, item.MaQuanLi == "" ? "Nhân viên" : "Quản lý", item.Email, item.MatKhau, item.DiaChi,item.SoDienThoai,item.NgaySinh,item.TrangThai);
            }
        }

        private void bt_them_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn Thêm không", "", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                _nv.MaNV = tb_manv.Text;
                _nv.TenNV = tb_tennv.Text;
                _nv.DiaChi = tb_diachi.Text;
                _nv.Email = tb_email.Text;
                _nv.MatKhau = tb_matkhau.Text;
                _nv.TrangThai = true ? rdb_danglam.Checked:rdb_nghiviec.Checked;
                _nv.NgaySinh = Convert.ToDateTime(tb_ngaysinh.Text);
                _nv.SoDienThoai = tb_dienthoai.Text;
                _IQLnv.addNV(_nv);
                MessageBox.Show("Thêm nhân viên thành công");
            }
        }
    }
}
