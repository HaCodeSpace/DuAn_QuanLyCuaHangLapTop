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
using BUS.Services.ServiceSanPham;
using Presentation;

namespace Presentation
{
    public partial class FormSanPham : Form
    {
        //private DAL.IRepository.INhanVienRepository _repository;
        private BUS.IServices.IServiceSanPham.ISanPhamService _serviceSanPhamService;
        private IBanPhimService _banPhimService;
        private IMauSacService _mauSacService;
        private ISanPhamMauSacService _sanPhamMauSacService;
        private IKeycapsService _keycapsService;
        private IBanPhimKeycapsService _banPhimKeycapsService;
        public BanPhim ban;
        public BanPhimKeyCaps phimKeyCaps = new BanPhimKeyCaps();
        public MauSac mau = new MauSac();
        public SanPhamMauSac sanPhamMau = new SanPhamMauSac();
        public SanPham sanpham;
        public KeyCaps Capskey = new KeyCaps();


        public bool IsAdd { get; set; }

        public FormSanPham()
        {
            InitializeComponent();
            _serviceSanPhamService = new BUS.Services.ServiceSanPham.SanPhamService();
            _banPhimService = new BanPhimService();
            _mauSacService = new MauSacService();
            _sanPhamMauSacService = new SanPhamMauSacService();
            _keycapsService = new KeyCapsService();
            _banPhimKeycapsService = new BanPhimKeyCapsService();
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
                fspbp.GetBanPhimEvent += Fspbp_GetBanPhimEvent;
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

        private void Fspbp_GetBanPhimEvent(string hangsx, int kieukn, string kieubp, string led, string layout, string kichthuoc, float trongluong, string mausac, string keycaps)
        {
            ban = new BanPhim()
            {
                MaSP = "SP" + tb_masp.Text,
                HangSanXuat = hangsx,
                KieuKetNoi = kieukn,
                KieuBanPhim = kieubp,
                Led = led,
                Layout = layout,
                KichThuoc = kichthuoc,
                TrongLuong = trongluong,
            };
            mau.TenMau = mausac;
            Capskey.TenKeyCaps = keycaps;
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
        }

        private void FormSanPham_Load(object sender, EventArgs e)
        {
            btnclear.Click += (s, e) =>
            {
                tb_masp.Clear();
                tb_tensp.Clear();
                comboBox_dongsp.Text = String.Empty;
                tb_gianhap.Clear();
                tb_giaban.Clear();
                tb_mausac.Clear();
                tb_ghichu.Clear();
            };
        }

        private void bt_them_Click(object sender, EventArgs e)
        {
            try
            {
                IsAdd = true;
                MatchData();
                var result = _serviceSanPhamService.ThemSP(sanpham);
                var result2 = false;
                var result3 = true;
                var result4 = false;
                var result5 = false;
                var result6 = true;
                switch (comboBox_dongsp.SelectedIndex)
                {
                    case 0:
                        break;
                    case 1:
                        break;
                    case 2:
                        result2 = _banPhimService.ThemBP(ban);
                        mau.MaMau = "12xd31đss";
                        mau.TenMau = UpperCaseFirstLetter(mau.TenMau);
                        result3 = _mauSacService.ThemMau(mau);
                        sanPhamMau.Idmau = _mauSacService.Timid(mau);
                        sanPhamMau.Masp = sanpham.MaSP;
                        result4 = _sanPhamMauSacService.ThemSPMS(sanPhamMau);
                        result5 = _keycapsService.ThemKeycaps(Capskey);
                        phimKeyCaps.IdKeyCaps = _keycapsService.TimId(Capskey);
                        phimKeyCaps.MaSP = sanpham.MaSP;
                        result6 = _banPhimKeycapsService.ThemBPKCS(phimKeyCaps);
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        break;
                }
                if (result && result2 && result3 && result4 && result5 &&  result6)
                {
                    MessageBox.Show("Thêm thành công");
                    LoadFullList();
                }
                else
                    MessageBox.Show("Thêm thất bại");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
        }

        private string UpperCaseFirstLetter(string s)
        {
            return char.ToUpper(s[0]) + s.Substring(1);
        }

        private void MatchData()
        {
            sanpham = new SanPham()
            {
                MaSP = IsAdd ? "SP" + tb_masp.Text : tb_masp.Text,
                TenSP = tb_tensp.Text.Trim(),
                DonGiaNhap = float.Parse(tb_gianhap.Text.Trim()),
                DonGiaBan = float.Parse(tb_giaban.Text.Trim()),
                DongSP = comboBox_dongsp.SelectedIndex,
                GhiChu = tb_ghichu.Text
            };    
        }

        

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void bt_sua_Click(object sender, EventArgs e)
        {
            IsAdd = false;
            MatchData();
            var result = _serviceSanPhamService.SuaSP(sanpham);
            
            if (result)
            {
                MessageBox.Show("Sửa thành công");
                LoadFullList();
            }
            else
                MessageBox.Show("Sửa thất bại");
        }

        private void tb_timkiem_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _serviceSanPhamService.GetListByValue(tb_timkiem.Text.Trim());
        }
    }
}
