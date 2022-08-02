using BUS.IServices;
using BUS.Services;
using BUS.ViewModels;
using DAL.DatabaseContext;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;


namespace Presentation
{
    public partial class FormKhachHang : Form
    {
        DA1Context _context = new DA1Context();
        public double sdt;
        public double ten;
        public int makh;
        private DAL.Model.KhachHang _khachHang;
        private IQuanLyKhachHangService _iQuanLyKhachHangService;
        private ViewHienThiKhachHang _viewHienTHiKH;
        public FormKhachHang()
        {
            InitializeComponent();
            _khachHang = new DAL.Model.KhachHang();
            _iQuanLyKhachHangService = new QuanLyKhachHangService();
            _viewHienTHiKH = new ViewHienThiKhachHang();
            rdb_hd.Checked = true;
            rdb_nam.Checked = true;
            ShowThongTin();

        }
        public void ShowThongTin()
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Add("Mã Khách Hàng", "Mã Khách Hàng");
            foreach (var item in _iQuanLyKhachHangService.LayDanhSachKhachHang())
            {
                dataGridView1.Rows.Add(item.TenKH, item.SDT, item.DiaChi, item.GioiTinh, item.TrangThai == true ? "Hoạt Động" : "Không Hoạt Động", item.MaKH);
            }
            dataGridView1.Columns[5].Visible = false;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dt = dataGridView1.Rows[e.RowIndex];           
            tb_tenkh.Text = dt.Cells[0].Value.ToString();
            tb_dienthoai.Text = dt.Cells[1].Value.ToString();
            tb_diachi.Text = dt.Cells[2].Value.ToString();
            rdb_nam.Checked = (dt.Cells[3].Value.ToString() == "Nam" ? true : false);
            rdb_nu.Checked = (dt.Cells[3].Value.ToString() == "Nữ" ? true : false);
            rdb_hd.Checked = (dt.Cells[4].Value.ToString() == "Hoạt Động" ? true : false);
            rdb_khd.Checked = (dt.Cells[4].Value.ToString() == "Không Hoạt Động" ? true : false);
            var data = _context.khachHangs.FirstOrDefault(p => p.MaKH == dt.Cells[5].Value.ToString());
            tb_makh.Text = data.MaKH;
            tb_email.Text = data.Email;
        }
        
        public bool validateThem()
        {
            if (tb_tenkh.Text == "" || tb_makh.Text == "" || tb_diachi.Text == "" || tb_email.Text == "" || tb_dienthoai.Text == "")
            {
                MessageBox.Show("Không được để trống thông tin");
                return false;
            }
            foreach (var item in _iQuanLyKhachHangService.LayDanhSachKhachHang().Where(p => p.MaKH == tb_makh.Text))
            {
                MessageBox.Show("Mã khách hàng đã tồn tại");
                return false;
            }
            if (tb_makh.Text.StartsWith("KH") == false)
            {
                MessageBox.Show("Mã khách hàng phải bắt đầu bằng KH, Ví Dụ: KH01");
                return false;
            }
            bool check1 = Double.TryParse(tb_tenkh.Text, out ten);
            if (check1 == true)
            {
                MessageBox.Show("Tên khách hàng không được là số");
                return false;
            }
            bool check = Double.TryParse(tb_dienthoai.Text, out sdt);
            if (check == false)
            {
                MessageBox.Show("Số điện thoại không được là chữ");
                return false;
            }
            if (tb_dienthoai.Text.Length != 10)
            {
                MessageBox.Show("Số điện thoại phải có 10 số");
                return false;
            }
            try
            {
                MailAddress m = new MailAddress(tb_email.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Mail không đúng định dạng, Ví Dụ: abc@gmail.com");
                return false;
            }
            return true;
        }
        public bool validateSua()
        {
            if (tb_tenkh.Text == "" || tb_makh.Text == "" || tb_diachi.Text == "" || tb_email.Text == "" || tb_dienthoai.Text == "")
            {
                MessageBox.Show("Không được để trống thông tin");
                return false;
            }         
            if (tb_makh.Text.StartsWith("KH") == false)
            {
                MessageBox.Show("Mã khách hàng phải bắt đầu bằng KH, Ví Dụ: KH01");
                return false;
            }
            bool check1 = Double.TryParse(tb_tenkh.Text, out ten);
            if (check1 == true)
            {
                MessageBox.Show("Tên khách hàng không được là số");
                return false;
            }
            bool check = Double.TryParse(tb_dienthoai.Text, out sdt);
            if (check == false)
            {
                MessageBox.Show("Số điện thoại không được là chữ");
                return false;
            }
            if (tb_dienthoai.Text.Length != 10)
            {
                MessageBox.Show("Số điện thoại phải có 10 số");
                return false;
            }
            try
            {
                MailAddress m = new MailAddress(tb_email.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Mail không đúng định dạng, Ví Dụ: abc@gmail.com");
                return false;
            }
            return true;
        }
        private void bt_them_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn thêm không", "Thêm", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    if (validateThem())
                    {
                        _khachHang.MaKH = tb_makh.Text;
                        _khachHang.TenKH = tb_tenkh.Text;
                        _khachHang.DiaChi = tb_diachi.Text;
                        _khachHang.SDT = tb_dienthoai.Text;
                        _khachHang.GioiTinh = rdb_nam.Checked == true ? "Nam" : "Nữ";
                        _khachHang.TrangThai = true ? rdb_hd.Checked : rdb_khd.Checked;
                        _khachHang.Email = tb_email.Text;
                        _iQuanLyKhachHangService.ThemKH(_khachHang);
                        MessageBox.Show("Thêm thành công");
                        tb_makh.Clear();
                        tb_tenkh.Clear();
                        tb_diachi.Clear();
                        tb_dienthoai.Clear();
                        tb_email.Clear();
                        ShowThongTin();
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Thêm thất bại");
                }
            }
        }

        private void bt_sua_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn Sửa không", "Sửa", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    if (validateSua())
                    {
                        foreach (var item in _iQuanLyKhachHangService.LayDanhSachKhachHang().Where(kh => kh.MaKH == tb_makh.Text))
                        {
                            item.DiaChi = tb_diachi.Text;
                            item.SDT = tb_dienthoai.Text;
                            item.GioiTinh = rdb_nam.Checked == true ? "Nam" : "Nữ";
                            item.TenKH = tb_tenkh.Text;
                            item.TrangThai = true ? rdb_hd.Checked : rdb_khd.Checked;
                            item.Email = tb_email.Text;
                            _iQuanLyKhachHangService.SuaKH(item);
                        }
                        MessageBox.Show("Sửa Thành Công");
                        tb_makh.Clear();
                        tb_tenkh.Clear();
                        tb_diachi.Clear();
                        tb_dienthoai.Clear();
                        tb_email.Clear();
                        ShowThongTin();
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Sửa Thất Bại");
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            comboBox1.ResetText();
            comboBox2.ResetText();
            var gt = comboBox1.Text != null ? comboBox1.Text : String.Empty;
            var tt = comboBox2.Text == "Hoạt Động" ? true : false;
            var tim = _iQuanLyKhachHangService.LayDanhSachKhachHang().Where(e => e.TenKH.ToLower().Contains(textBox1.Text.ToLower()));
            dataGridView1.Rows.Clear();
            foreach (var item in tim)
            {
                dataGridView1.Rows.Add(item.TenKH, item.SDT, item.DiaChi, item.GioiTinh, item.TrangThai == true ? "Hoạt Động" : "Không Hoạt Động");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Clear();
            comboBox2.ResetText();
            dataGridView1.Rows.Clear();
            var tim = _iQuanLyKhachHangService.LayDanhSachKhachHang().Where(p => p.GioiTinh.Contains(comboBox1.Text));
            dataGridView1.Rows.Clear();
            foreach (var item in tim)
            {
                dataGridView1.Rows.Add(item.TenKH, item.SDT, item.DiaChi, item.GioiTinh, item.TrangThai == true ? "Hoạt Động" : "Không Hoạt Động");
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Clear();
            comboBox1.ResetText();
            dataGridView1.Rows.Clear();
            if (comboBox2.Text == "Hoạt Động")
            {
                var tim = _iQuanLyKhachHangService.LayDanhSachKhachHang().Where(e => e.TrangThai == true);
                foreach (var item in tim)
                {
                    dataGridView1.Rows.Add(item.TenKH, item.SDT, item.DiaChi, item.GioiTinh, item.TrangThai == true ? "Hoạt Động" : "Không Hoạt Động");
                }
            }
            if (comboBox2.Text == "Không Hoạt Động")
            {
                var tim = _iQuanLyKhachHangService.LayDanhSachKhachHang().Where(e => e.TrangThai == false);
                foreach (var item in tim)
                {
                    dataGridView1.Rows.Add(item.TenKH, item.SDT, item.DiaChi, item.GioiTinh, item.TrangThai == true ? "Hoạt Động" : "Không Hoạt Động");
                }
            }


        }
    }
}
