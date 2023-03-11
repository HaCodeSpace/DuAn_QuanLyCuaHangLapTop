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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation
{
    public partial class FormKhuyenMai : Form
    {
        DA1Context _context = new DA1Context();
        public double vou;
        private DAL.Model.KhuyenMai _khuyenMai;
        private IQLKhuyenMaiService _iQLKhuyenMaiService;
        private ViewHienThiKhuyenMai _viewHienThiKM;
        public FormKhuyenMai()
        {
            InitializeComponent();
            _khuyenMai = new DAL.Model.KhuyenMai();
            _iQLKhuyenMaiService = new QLKhuyenMaiService();
            _viewHienThiKM = new ViewHienThiKhuyenMai();
            rdb_apdung.Checked = true;           
            ShowThongTinKM();
        }
        public void ShowThongTinKM()
        {
            dataGridView1.Rows.Clear();           
            foreach (var item in _iQLKhuyenMaiService.LayDanhSachKhuyenMai())
            {
                dataGridView1.Rows.Add(item.MaKM, item.TenKhuyenMai, item.ChietKhau, item.TrangThai == true ? "Áp Dụng" : "Không Áp Dụng", item.NgayBatDau, item.NgayKetThuc, item.Mota);
            }           
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dt = dataGridView1.Rows[e.RowIndex];
            tb_makhuyenmai.Text = dt.Cells[0].Value.ToString();
            tb_chuongtrinhkhuyenmai.Text = dt.Cells[1].Value.ToString();
            tb_voucher.Text = dt.Cells[2].Value.ToString();
            rdb_apdung.Checked = (dt.Cells[3].Value.ToString() == "Áp Dụng" ? true : false);
            rdb_khongapdung.Checked = (dt.Cells[3].Value.ToString() == "Không Áp Dụng" ? true : false);
            dateTimePicker1.Value = Convert.ToDateTime(dt.Cells[4].Value);
            dateTimePicker2.Value = Convert.ToDateTime(dt.Cells[5].Value);
            tb_mota.Text = dt.Cells[6].Value.ToString();      
            tb_makhuyenmai.Enabled = false;
        }
        public bool ValiDateThem()
        {
            if (tb_makhuyenmai.Text == "" || tb_chuongtrinhkhuyenmai.Text == "" || tb_voucher.Text == "" || tb_mota.Text == "")
            {
                MessageBox.Show("Không được để trống thông tin");
                return false;
            }
            foreach (var item in _iQLKhuyenMaiService.LayDanhSachKhuyenMai().Where(p => p.MaKM == tb_makhuyenmai.Text))
            {
                MessageBox.Show("Mã khuyến mại đã tồn tại");
                return false;
            }
            if (tb_makhuyenmai.Text.StartsWith("KM") == false)
            {
                MessageBox.Show("Mã khuyến mại phải bắt đầu bằng KM, Ví Dụ: KM01");
                return false;
            }           
            bool check = Double.TryParse(tb_voucher.Text, out vou);
            if (check == false)
            {
                MessageBox.Show("Voucher không được là chữ");
                return false;
            }           
            return true;
        }
        public bool ValiDateSua()
        {
            if (tb_makhuyenmai.Text == "" || tb_chuongtrinhkhuyenmai.Text == "" || tb_voucher.Text == "" || tb_mota.Text == "")
            {
                MessageBox.Show("Không được để trống thông tin");
                return false;
            }                     
            bool check = Double.TryParse(tb_voucher.Text, out vou);
            if (check == false)
            {
                MessageBox.Show("Voucher không được là chữ hoặc kí tự đặc biệt");
                return false;
            }
            return true;
        }

        private void bt_them_Click_1(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn thêm không", "Thêm", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    if (ValiDateThem())
                    {
                        _khuyenMai.MaKM = tb_makhuyenmai.Text;
                        _khuyenMai.TenKhuyenMai = tb_chuongtrinhkhuyenmai.Text;
                        _khuyenMai.ChietKhau = Convert.ToDouble(tb_voucher.Text);
                        _khuyenMai.TrangThai = true ? rdb_apdung.Checked : rdb_khongapdung.Checked;
                        _khuyenMai.NgayBatDau = Convert.ToDateTime(dateTimePicker1.Value);
                        _khuyenMai.NgayKetThuc = Convert.ToDateTime(dateTimePicker2.Value);
                        _khuyenMai.Mota = tb_mota.Text;
                        _iQLKhuyenMaiService.ThemKM(_khuyenMai);
                        MessageBox.Show("Thêm thành công");
                        tb_makhuyenmai.Clear();
                        tb_chuongtrinhkhuyenmai.Clear();
                        tb_mota.Clear();
                        tb_voucher.Clear();
                        ShowThongTinKM();
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Thêm thất bại");
                }
            }
        }

        private void bt_sua_Click_1(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn Sửa không", "Sửa", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    if (ValiDateSua())
                    {
                        foreach (var item in _iQLKhuyenMaiService.LayDanhSachKhuyenMai().Where(kh => kh.MaKM == tb_makhuyenmai.Text))
                        {
                            item.TenKhuyenMai = tb_chuongtrinhkhuyenmai.Text;
                            item.ChietKhau = Convert.ToDouble(tb_voucher.Text);
                            item.TrangThai = true ? rdb_apdung.Checked : rdb_khongapdung.Checked;
                            item.NgayBatDau = Convert.ToDateTime(dateTimePicker1.Value);
                            item.NgayKetThuc = Convert.ToDateTime(dateTimePicker2.Value);
                            item.Mota = tb_mota.Text;
                            _iQLKhuyenMaiService.SuaKM(item);
                        }
                        MessageBox.Show("Sửa Thành Công");
                        tb_makhuyenmai.Clear();
                        tb_chuongtrinhkhuyenmai.Clear();
                        tb_mota.Clear();
                        tb_voucher.Clear();
                        ShowThongTinKM();
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Sửa Thất Bại");
                }
            }
        }

        private void bt_reset_Click_1(object sender, EventArgs e)
        {
            tb_makhuyenmai.Enabled = true;
            tb_makhuyenmai.Clear();
            tb_chuongtrinhkhuyenmai.Clear();
            tb_voucher.Clear();
            tb_mota.Clear();
        }
    }
}
