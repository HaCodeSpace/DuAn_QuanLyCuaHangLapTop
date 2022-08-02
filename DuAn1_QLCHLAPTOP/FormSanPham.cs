using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL.Model;
using BUS.IServices.IServiceSanPham;

namespace Presentation
{
    public partial class FormSanPham : Form
    {
        //private DAL.IRepository.INhanVienRepository _repository;
        private BUS.IServices.IServiceSanPham.ISanPhamService _serviceSanPhamService;
        private IBanPhimService _banPhimService;

        public bool IsAdd { get; set; }

        public FormSanPham()
        {
            InitializeComponent();
            _serviceSanPhamService = new BUS.Services.ServiceSanPham.SanPhamService();
            LoadFullList();
            AddBindings();
        }

        private void comboBox_dongsp_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_dongsp.Text == "PC")
            {
                panel2.Controls.Clear();
                FormSanPhamPC fsppc = new FormSanPhamPC()
                {
                    Dock = DockStyle.Fill,
                    TopLevel = false,
                    TopMost = true,
                };
                this.panel2.Controls.Add(fsppc);
                fsppc.FormBorderStyle = FormBorderStyle.None;
                fsppc.Show();
            }
            if (comboBox_dongsp.Text == "Laptop")
            {
                panel2.Controls.Clear();
                FormSanPhamLaptop fspl = new FormSanPhamLaptop()
                {
                    Dock = DockStyle.Fill,
                    TopLevel = false,
                    TopMost = true,
                };
                this.panel2.Controls.Add(fspl) ;
                fspl.FormBorderStyle = FormBorderStyle.None;
                fspl.Show();
            }
            if (comboBox_dongsp.Text == "Bàn Phím")
            {
                panel2.Controls.Clear();
                FormSanPhamBanPhim fspbp = new FormSanPhamBanPhim()
                {
                    Dock = DockStyle.Fill,
                    TopLevel = false,
                    TopMost = true,
                };
                this.panel2.Controls.Add(fspbp);
                fspbp.FormBorderStyle = FormBorderStyle.None;
                fspbp.Show();
            }
            if (comboBox_dongsp.Text == "Chuột")
            {
                panel2.Controls.Clear();
                FormSanPhamChuot fspc = new FormSanPhamChuot()
                {
                    Dock = DockStyle.Fill,
                    TopLevel = false,
                    TopMost = true,
                };
                this.panel2.Controls.Add(fspc);
                fspc.FormBorderStyle = FormBorderStyle.None;
                fspc.Show();
            }
            if (comboBox_dongsp.Text == "Tai Nghe")
            {
                panel2.Controls.Clear();
                FormSanPhamTaiNghe fsptn = new FormSanPhamTaiNghe()
                {
                    Dock = DockStyle.Fill,
                    TopLevel = false,
                    TopMost = true,
                };
                this.panel2.Controls.Add(fsptn);
                fsptn.FormBorderStyle = FormBorderStyle.None;
                fsptn.Show();
            }
            if (comboBox_dongsp.Text == "Màn Hình")
            {
                panel2.Controls.Clear();
                FormSanPhamManHinh fspmh = new FormSanPhamManHinh()
                {
                    Dock = DockStyle.Fill,
                    TopLevel = false,
                    TopMost = true,
                };
                this.panel2.Controls.Add(fspmh);
                fspmh.FormBorderStyle = FormBorderStyle.None;
                fspmh.Show();
            }
            
        }

        private void AddBindings()
        {
            tb_masp.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "MaSP"));
            tb_tensp.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "TenSP"));
            tb_gianhap.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "DonGiaNhap"));
            tb_giaban.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "DonGiaBan"));
            tb_ghichu.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "GhiChu"));
        }

        private void LoadFullList()
        {
            var fulllist = from c in _serviceSanPhamService.SanPhamList() select new { c.MaSP, c.TenSP, c.DongSP, c.DonGiaNhap, c.DonGiaBan, c.GhiChu };
            dataGridView1.DataSource = fulllist.ToList();
            dataGridView1.Columns[0].HeaderText = "Mã sản phẩm";
            dataGridView1.Columns[1].HeaderText = "Tên sản phẩm";
            dataGridView1.Columns[2].HeaderText = "Dòng sản phẩm";
            dataGridView1.Columns[3].HeaderText = "Đơn giá nhập";
            dataGridView1.Columns[4].HeaderText = "Đơn giá bán";
            dataGridView1.Columns[5].HeaderText = "Ghi chú";

            dataGridView1.DataSource = _serviceSanPhamService.SanPhamList();
        }

        private void FormSanPham_Load(object sender, EventArgs e)
        {
        
        }

        private void bt_them_Click(object sender, EventArgs e)
        {
            IsAdd = true;
            var result =  _serviceSanPhamService.ThemSP(MatchData());
            var result2 = true;
            switch (comboBox_dongsp.SelectedIndex)
            {
                case 0:
                    break;
                case 1:
                    break;
                case 2:
                    result2 = _banPhimService.ThemBP(MatchBanPhim());
                    break;
                case 3:
                    break;
                case 4:
                    break;
                case 5:
                    break;
            }
            if (result)
            {
                MessageBox.Show("Thêm thành công");
                LoadFullList();
            }
            else
                MessageBox.Show("Thêm thất bại");
        }

        private BanPhim MatchBanPhim()
        {
            var banphim = new BanPhim();
            banphim.MaSP = tb_masp.Text;
            
            return banphim;
        }

        private SanPham MatchData()
        {
            SanPham currentSP = new SanPham();
            currentSP.MaSP = IsAdd ? "SP" + tb_masp.Text : tb_masp.Text;
            currentSP.TenSP = tb_tensp.Text;
            currentSP.DongSP = comboBox_dongsp.SelectedIndex;
            currentSP.DonGiaBan = float.Parse(tb_giaban.Text);
            currentSP.DonGiaNhap = float.Parse(tb_gianhap.Text);
            currentSP.GhiChu = tb_ghichu.Text;

            return currentSP;
        }

        

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void bt_sua_Click(object sender, EventArgs e)
        {
            IsAdd = false;
            var result = _serviceSanPhamService.SuaSP(MatchData());
            
            if (result)
            {
                MessageBox.Show("Sửa thành công");
                LoadFullList();
            }
            else
                MessageBox.Show("Sửa thất bại");
        }
    }
}
