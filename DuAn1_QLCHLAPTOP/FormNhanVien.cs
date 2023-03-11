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
using Presentation.Utilities;


namespace Presentation
{
    public partial class FormNhanVien : Form
    {
        private NhanVien _nv;
        private IQLNhanVienService _IQLnv;
        private Validations _validate;
        public FormNhanVien()
        {
            InitializeComponent();
            _nv = new NhanVien();
            _IQLnv = new QLNhanVienService();
            _validate = new Validations();
            Loading();
            comboBox_vaitro.SelectedIndex = 0;
        }

        public void Loading()
        {
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
                dataGridView1.Rows.Add(item.MaNV, item.TenNV, item.Vaitro == true ? "Quản Lý" : "Nhân Viên", item.Email, item.MatKhau, item.DiaChi, item.SoDienThoai, item.NgaySinh.ToString("MM/dd/yyyy"), item.GioiTinh, item.TrangThai == true ? "Đang Làm" : "Nghỉ Việc");
            }
        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == _IQLnv.getlstNVfromDB().Count || e.RowIndex == -1) return;
            DataGridViewRow dataGridViewRow = dataGridView1.Rows[e.RowIndex];
            tb_manv.Text = dataGridViewRow.Cells[0].Value.ToString();
            tb_tennv.Text = dataGridViewRow.Cells[1].Value.ToString();
            comboBox_vaitro.Text = dataGridViewRow.Cells[2].Value.ToString();
            tb_email.Text = dataGridViewRow.Cells[3].Value.ToString();
            tb_matkhau.Text = dataGridViewRow.Cells[4].Value.ToString();
            tb_diachi.Text = dataGridViewRow.Cells[5].Value.ToString();
            tb_dienthoai.Text = dataGridViewRow.Cells[6].Value.ToString();
            tb_ngaysinh.Text = dataGridViewRow.Cells[7].Value.ToString();
            rdb_nam.Checked = dataGridViewRow.Cells[8].Value.ToString() == "Nam";
            rdb_nu.Checked = dataGridViewRow.Cells[8].Value.ToString() == "Nữ";
            rdb_danglam.Checked = dataGridViewRow.Cells[9].Value.ToString() == "Đang Làm";
            rdb_nghiviec.Checked = dataGridViewRow.Cells[9].Value.ToString() == "Nghỉ Việc";
            tb_manv.Enabled = false;

        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            comboBox1.ResetText();
            comboBox2.ResetText();
            dataGridView1.Rows.Clear();
            var tim = _IQLnv.getlstNVfromDB().Where(e => e.TenNV.ToLower().Contains(textBox1.Text.ToLower()));
            foreach (var item in tim)
            {
                dataGridView1.Rows.Add(item.MaNV, item.TenNV, item.Vaitro == true ? "Quản Lý" : "Nhân Viên", item.Email, item.MatKhau, item.DiaChi, item.SoDienThoai, item.NgaySinh.ToString("MM/dd/yyyy"), item.GioiTinh, item.TrangThai == true ? "Đang Làm" : "Nghỉ Việc");
            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            textBox1.Clear();
            comboBox2.ResetText();
            if (comboBox1.Text == "Quản Lý")
            {
                var tim = from a in _IQLnv.getlstNVfromDB()
                          where a.Vaitro == true
                          select a;
                foreach (var item in tim)
                {
                    dataGridView1.Rows.Add(item.MaNV, item.TenNV, item.Vaitro == true ? "Quản Lý" : "Nhân Viên", item.Email, item.MatKhau, item.DiaChi, item.SoDienThoai, item.NgaySinh.ToString("MM/dd/yyyy"), item.GioiTinh, item.TrangThai == true ? "Đang Làm" : "Nghỉ Việc");

                }
            }
            if (comboBox1.Text == "Nhân Viên")
            {
                var tim = from a in _IQLnv.getlstNVfromDB()
                          where a.Vaitro == false
                          select a;
                foreach (var item in tim)
                {
                    dataGridView1.Rows.Add(item.MaNV, item.TenNV, item.Vaitro == true ? "Quản Lý" : "Nhân Viên", item.Email, item.MatKhau, item.DiaChi, item.SoDienThoai, item.NgaySinh.ToString("MM/dd/yyyy"), item.GioiTinh, item.TrangThai == true ? "Đang Làm" : "Nghỉ Việc");
                }
            }
        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            textBox1.Clear();
            comboBox1.ResetText();
            if (comboBox2.Text == "Đang Làm")
            {
                var tim = from a in _IQLnv.getlstNVfromDB()
                          where a.TrangThai == true
                          select a;
                foreach (var item in tim)
                {
                    dataGridView1.Rows.Add(item.MaNV, item.TenNV, item.Email, item.MatKhau, item.DiaChi, item.SoDienThoai, item.NgaySinh.ToString("MM/dd/yyyy"), item.GioiTinh, item.TrangThai == true ? "Đang Làm" : "Nghỉ Việc");
                }
            }
            if (comboBox2.Text == "Nghỉ Việc")
            {
                var tim = from a in _IQLnv.getlstNVfromDB()
                          where a.TrangThai == false
                          select a;
                foreach (var item in tim)
                {
                    dataGridView1.Rows.Add(item.MaNV, item.TenNV, item.Email, item.MatKhau, item.DiaChi, item.SoDienThoai, item.NgaySinh.ToString("MM/dd/yyyy"), item.GioiTinh, item.TrangThai == true ? "Đang Làm" : "Nghỉ Việc");
                }
            }
        }



        private void bt_them_Click_1(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn Thêm không", "", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (!_validate.NhanVienValidate(tb_manv.Text, tb_tennv.Text, comboBox_vaitro.Text, tb_email.Text, tb_ngaysinh.Text, tb_dienthoai.Text, tb_matkhau.Text))
                {
                    return;
                }
                _nv.MaNV = tb_manv.Text;
                _nv.TenNV = tb_tennv.Text;
                _nv.DiaChi = tb_diachi.Text;
                _nv.Email = tb_email.Text;
                _nv.MatKhau = tb_matkhau.Text;
                _nv.TrangThai = true ? rdb_danglam.Checked : rdb_nghiviec.Checked;
                _nv.NgaySinh = Convert.ToDateTime(tb_ngaysinh.Text);
                _nv.SoDienThoai = tb_dienthoai.Text;
                if (comboBox_vaitro.Text == "Quản Lý")
                {
                    _nv.Vaitro = true;
                }
                if (comboBox_vaitro.Text == "Nhân Viên")
                {
                    _nv.Vaitro = false;
                }
                if (rdb_nam.Checked)
                {
                    _nv.GioiTinh = "Nam";
                }
                if (rdb_nu.Checked)
                {
                    _nv.GioiTinh = "Nữ";
                }
                _IQLnv.addNV(_nv);
                MessageBox.Show("Thêm nhân viên thành công");
                Loading();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tb_manv.Enabled = true;
            tb_manv.Clear();
            tb_tennv.Clear();
            tb_email.Clear();
            tb_matkhau.Clear();
            tb_diachi.Clear();
            tb_email.Clear();
            tb_ngaysinh.Clear();
            tb_dienthoai.Clear();
        }

        private void bt_sua_Click_1(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn Sửa không", "", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (!_validate.NhanVienValidate2(tb_manv.Text,tb_tennv.Text, comboBox_vaitro.Text, tb_email.Text, tb_ngaysinh.Text, tb_dienthoai.Text, tb_matkhau.Text))
                {
                    return;
                }
                foreach (var item in _IQLnv.getlstNVfromDB().Where(nv => nv.MaNV == tb_manv.Text))
                {
                    item.TenNV = tb_tennv.Text;
                    item.Email = tb_email.Text;
                    item.DiaChi = tb_diachi.Text;
                    item.SoDienThoai = tb_dienthoai.Text;
                    item.MatKhau = tb_matkhau.Text;
                    if (rdb_nam.Checked)
                        item.GioiTinh = "Nam";
                    if (rdb_nu.Checked)
                        item.GioiTinh = "Nữ";
                    item.TrangThai = true ? rdb_danglam.Checked : rdb_nghiviec.Checked;
                    item.NgaySinh = Convert.ToDateTime(tb_ngaysinh.Text);
                    if (comboBox_vaitro.Text == "Quản Lý")
                    {
                        item.Vaitro = true;
                    }
                    if (comboBox_vaitro.Text == "Nhân Viên")
                    {
                        item.Vaitro = false;
                    }
                    _IQLnv.updateNV(item);
                    MessageBox.Show("Sửa thành công nhân viên");
                    Loading();
                }
            }
        }
    }
}
