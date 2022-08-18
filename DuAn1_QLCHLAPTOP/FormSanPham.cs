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
        private FormSanPhamLaptop sp = new FormSanPhamLaptop();
        private Form activeForm;
        public BanPhim ban;
        public Laptop lap;
        public Chuot chuot;
        //public BanPhimKeyCaps phimKeyCaps = new BanPhimKeyCaps();
        public MauSac mau = new MauSac();
        //public SanPhamMauSac sanPhamMau = new SanPhamMauSac();
        public SanPham sanpham;
        //public KeyCaps Capskey = new KeyCaps();
        public IEnumerable<SanPhamView> ListSP;
        public IEnumerable<SanPhamView> ListSauKhisuLyDuLieu;
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
            ListSP = new List<SanPhamView>();
            ListSauKhisuLyDuLieu = new List<SanPhamView>();
            LoadFullList();
            AddBindings();
        }

        private void comboBox_dongsp_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (activeForm != null)
            {
                activeForm.Dispose();
                activeForm.Close();
            }

            if (comboBox_dongsp.Text == "Laptop")
            {
                panel2.Controls.Clear();
                FormSanPhamLaptop fspl = new FormSanPhamLaptop(lap)
                {
                    Dock = DockStyle.Fill,
                    TopLevel = false,
                    TopMost = true,
                };
                activeForm = fspl;
                this.panel2.Controls.Add(fspl);
                fspl.FormBorderStyle = FormBorderStyle.None;
                fspl.GetInfo += Fspl_GetInfo;

                fspl.Show();
            }
            if (comboBox_dongsp.Text == "Bàn Phím")
            {
                panel2.Controls.Clear();

                FormSanPhamBanPhim fspbp = new FormSanPhamBanPhim(ban)
                {
                    Dock = DockStyle.Fill,
                    TopLevel = false,
                    TopMost = true,

                };
                activeForm = fspbp;
                this.panel2.Controls.Add(fspbp);
                fspbp.FormBorderStyle = FormBorderStyle.None;
                fspbp.GetBanPhimEvent += Fspbp_GetBanPhimEvent;

                fspbp.Show();
            }
            if (comboBox_dongsp.Text == "Chuột")
            {
                panel2.Controls.Clear();
                FormSanPhamChuot fspc = new FormSanPhamChuot(chuot)
                {
                    Dock = DockStyle.Fill,
                    TopLevel = false,
                    TopMost = true,
                };
                activeForm = fspc;
                this.panel2.Controls.Add(fspc);
                fspc.FormBorderStyle = FormBorderStyle.None;
                fspc.PushData += Fspc_PushData;
                fspc.Show();
            }
        }

        private void Fspc_PushData(string ketnoi, int ips, string tansophanhoi, string chatlieuvo, double trongluong, string swich, string led, string giatoc, string kichthuoc, string tuoitho)
        {
            try
            {
                sanpham = new SanPham()
                {
                    TenSP = tb_tensp.Text.Trim(),
                    DongSP = comboBox_dongsp.SelectedIndex,
                    DonGiaNhap = float.TryParse(tb_gianhap.Text.Trim(), out _) ? float.Parse(tb_gianhap.Text.Trim()) : throw new Exception("Khong duoc nhap chu cai"),
                    DonGiaBan = float.TryParse(tb_giaban.Text.Trim(), out _) ? float.Parse(tb_giaban.Text.Trim()) : throw new Exception("Khong duoc nhap chu cai"),
                    GhiChu = tb_ghichu.Text.Trim(),
                    soluong = string.IsNullOrEmpty(tb_soluong.Text) ? 0 : int.Parse(tb_soluong.Text.Trim()),
                    chuot = new Chuot()
                    {
                        KetNoi = ketnoi,
                        IPS = ips,
                        TanSoPhanHoi = tansophanhoi,
                        ChetLieuVo = chatlieuvo,
                        TrongLuong = trongluong,
                        Switch = swich,
                        Led = led,
                        GiaToc = giatoc,
                        KichThuoc = kichthuoc,
                        TuoiTho = tuoitho
                    }
                };
            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);
            }

            
        }

        private void Fspl_GetInfo(string cpu, string ram, string card, string ocung, string pin, double trongluong, string manhinh, string dophangiai, string webcam, string hedieuhanh, string kichthuoc, string bluetooth)
        {
            try
            {
                sanpham = new SanPham()
                {
                    TenSP = tb_tensp.Text.Trim(),
                    DongSP = comboBox_dongsp.SelectedIndex,
                    DonGiaNhap = float.TryParse(tb_gianhap.Text.Trim(), out _) ? float.Parse(tb_gianhap.Text.Trim()) : throw new Exception("Khong duoc nhap chu cai"),
                    DonGiaBan = float.TryParse(tb_giaban.Text.Trim(), out _) ? float.Parse(tb_giaban.Text.Trim()) : throw new Exception("Khong duoc nhap chu cai"),
                    soluong = string.IsNullOrEmpty(tb_soluong.Text) ? 0 : int.Parse(tb_soluong.Text.Trim()),
                    GhiChu = tb_ghichu.Text.Trim(),
                    laptop = new Laptop()
                    {

                        CPU = cpu,
                        RAM = ram,
                        VGA_Card = card,
                        OCung = ocung,
                        PIN = pin,
                        TrongLuong = trongluong,
                        ManHinh = manhinh,
                        DoPhanGiai = dophangiai,
                        WebCam = webcam,
                        HeDieuHanh = hedieuhanh,
                        KichThuoc = kichthuoc,
                        Bluetooth = bluetooth
                    }
                };
            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);
            }
            
        }

        private void Fspbp_GetBanPhimEvent(string hangsx, int kieukn, string kieubp, string led, string layout, string kichthuoc, float trongluong, string mausac, string keycaps)
        {
            try
            {
                sanpham = new SanPham()
                {
                    TenSP = tb_tensp.Text.Trim(),
                    DongSP = comboBox_dongsp.SelectedIndex,
                    DonGiaNhap = float.TryParse(tb_gianhap.Text.Trim(), out _) ? float.Parse(tb_gianhap.Text.Trim()) : throw new Exception("Khong duoc nhap chu cai"),
                    DonGiaBan = float.TryParse(tb_giaban.Text.Trim(), out _) ? float.Parse(tb_giaban.Text.Trim()) : throw new Exception("Khong duoc nhap chu cai"),
                    soluong = string.IsNullOrEmpty(tb_soluong.Text) ? 0 : int.Parse(tb_soluong.Text.Trim()),
                    GhiChu = tb_ghichu.Text.Trim(),
                    banPhim = new BanPhim()
                    {
                        HangSanXuat = hangsx,
                        KieuKetNoi = kieukn,
                        KieuBanPhim = kieubp,
                        Led = led,
                        Layout = layout,
                        KichThuoc = kichthuoc,
                        TrongLuong = trongluong,
                    }
                };
            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);
            }

            

        }

        private void AddBindings()
        {
            tb_tensp.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "TenSP"));
            tb_gianhap.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "DonGiaNhap"));
            tb_giaban.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "DonGiaBan"));
            tb_ghichu.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "GhiChu"));
            tb_soluong.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "SoLuongTon"));
        }

        private void LoadFullList()
        {
            ListSP = from c in _serviceSanPhamService.SanPhamList() select new SanPhamView { MaSP = c.MaSP, TenSP = c.TenSP, DonGiaNhap = c.DonGiaNhap, DonGiaBan = c.DonGiaBan, DongSP = comboBox_dongsp.Items[c.DongSP].ToString(), GhiChu = c.GhiChu, laptop = c.laptop, banPhim = c.banPhim, chuot = c.chuot, SoLuongTon = c.soluong };
            ListSauKhisuLyDuLieu = ListSP;
            dataGridView1.DataSource = ListSauKhisuLyDuLieu.ToList();
            dataGridView1.Columns[dataGridView1.ColumnCount - 1].Visible = false;
            dataGridView1.Columns[dataGridView1.ColumnCount - 2].Visible = false;

            //dataGridView1.Columns[1].HeaderText = "Tên sản phẩm";
            //dataGridView1.Columns[2].HeaderText = "Dòng sản phẩm";
            //dataGridView1.Columns[3].HeaderText = "Đơn giá nhập";
            //dataGridView1.Columns[4].HeaderText = "Đơn giá bán";
            //dataGridView1.Columns[5].HeaderText = "Ghi chú";


        }

        //private string ReturnDongSP(int i)
        //{
        //    for (int i = 0; i < comboBox_dongsp.Items.Count; i++)
        //    {
        //        comboBox_dongsp.Items[i].ToString()
        //    }

        //}

        private void FormSanPham_Load(object sender, EventArgs e)
        {

        }

        private void bt_them_Click(object sender, EventArgs e)
        {
            try
            {
                MappingData();
                new Utilities.DataAnnotationValidation().CheckValidation(sanpham);
                var result = _serviceSanPhamService.ThemSP(sanpham);

                switch (comboBox_dongsp.SelectedIndex)
                {
                    case 0:
                        break;
                    case 1:
                        break;
                    case 2:
                        //result2 = _banPhimService.ThemBP(ban);
                        //mau.MaMau = "12xd31đss";
                        //mau.TenMau = UpperCaseFirstLetter(mau.TenMau);
                        //result3 = _mauSacService.ThemMau(mau);
                        //sanPhamMau.Idmau = _mauSacService.Timid(mau);
                        //sanPhamMau.Masp = sanpham.MaSP;
                        //result4 = _sanPhamMauSacService.ThemSPMS(sanPhamMau);
                        //result5 = _keycapsService.ThemKeycaps(Capskey);
                        //phimKeyCaps.IdKeyCaps = _keycapsService.TimId(Capskey);
                        //phimKeyCaps.MaSP = sanpham.MaSP;
                        //result6 = _banPhimKeycapsService.ThemBPKCS(phimKeyCaps);
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
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private string UpperCaseFirstLetter(string s)
        {
            return char.ToUpper(s[0]) + s.Substring(1);
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void bt_sua_Click(object sender, EventArgs e)
        {
            MappingData();
            var result = _serviceSanPhamService.SuaSP(sanpham);
            if (result)
            {
                MessageBox.Show("Sửa thành công");
                LoadFullList();
                RemoveBindings();
                AddBindings();
            }
            else
                MessageBox.Show("Sửa thất bại");
        }

        private void RemoveBindings()
        {
            tb_tensp.DataBindings.Clear();
            tb_gianhap.DataBindings.Clear();
            tb_giaban.DataBindings.Clear();
            tb_ghichu.DataBindings.Clear();
            tb_soluong.DataBindings.Clear();
        }

        private void MappingData()
        {
            if (sanpham != null)
            {
                sanpham.TenSP=tb_tensp.Text.Trim();
                sanpham.DonGiaNhap=string.IsNullOrEmpty(tb_gianhap.Text) ? -1 : int.Parse(tb_gianhap.Text.Trim());
                sanpham.DonGiaBan=string.IsNullOrEmpty(tb_giaban.Text) ? -1 : int.Parse(tb_giaban.Text.Trim());
                sanpham.DongSP = comboBox_dongsp.SelectedIndex;
                sanpham.soluong = int.TryParse(tb_soluong.Text.Trim(), out _) ? int.Parse(tb_soluong.Text.Trim()) : throw new Exception("so luong khong duoc co chu");
                sanpham.GhiChu=tb_ghichu.Text.Trim();
            }
            else
            {
                sanpham = new SanPham()
                {
                    TenSP=tb_tensp.Text.Trim(),
                    DonGiaNhap = string.IsNullOrEmpty(tb_gianhap.Text) ? -1 : int.Parse(tb_gianhap.Text.Trim()),
                    DonGiaBan= string.IsNullOrEmpty(tb_giaban.Text) ? -1 : int.Parse(tb_giaban.Text.Trim()),
                    DongSP = comboBox_dongsp.SelectedIndex,
                    soluong = int.TryParse(tb_soluong.Text.Trim(), out _) ? int.Parse(tb_soluong.Text.Trim()) : throw new Exception("so luong khong duoc co chu"),
                    GhiChu=tb_ghichu.Text.Trim()
                };
            }
            
        }

        private void tb_timkiem_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox_mau_SelectedIndexChanged(object sender, EventArgs e)
        {
            int a = 0; int b = 0; int c = 0;
            string[] str = comboBox_gia.Text.Split(' ');
            if (comboBox_gia.SelectedIndex == 4)
            {
                c = 2000000;
                ListSauKhisuLyDuLieu = ListSauKhisuLyDuLieu.Where(p => p.DonGiaBan >= c);

            }
            else if (comboBox_gia.SelectedIndex >= 0)
            {
                a = int.Parse(SplitBack(str[0]));
                b = int.Parse(SplitBack(str[str.Length - 1]));
                ListSauKhisuLyDuLieu = ListSauKhisuLyDuLieu.Where(p => p.DonGiaBan >= a && p.DonGiaBan <= b);

            }

            dataGridView1.DataSource = ListSauKhisuLyDuLieu.ToList();
        }

        private string SplitBack(string v)
        {
            string[] split = v.Split('.');
            string newstr = string.Empty;
            for (int i = 0; i < split.Length; i++)
            {
                newstr += split[i];
            }

            return newstr;
        }

        private void comboBox_dongspTTSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListSauKhisuLyDuLieu = ListSauKhisuLyDuLieu.Where(p => p.DongSP.Equals(comboBox_dongspTTSP.Text));
            dataGridView1.DataSource = ListSauKhisuLyDuLieu.ToList();
        }

        public void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            var index = comboBox_dongsp.Items.IndexOf(dataGridView1.CurrentRow.Cells["DongSP"].Value);
            var modelchild = ListSP
                .Where(p => p.MaSP == Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString()))
                .SingleOrDefault();
            if (activeForm != null) activeForm.Close();
            comboBox_dongsp.SelectedIndex = -1;
            if (modelchild != null)
            {
                switch (index)
                {
                    case 0:
                        lap = modelchild.laptop;
                        break;
                    case 1:
                        ban = modelchild.banPhim;
                        break;
                    case 2:
                        chuot = modelchild.chuot;
                        break;

                }
                comboBox_dongsp.SelectedItem = dataGridView1.CurrentRow.Cells["DongSP"].Value;
                //MessageBox.Show(sanpham.laptop.CPU);

            }
        }

        private void btnclear_Click_1(object sender, EventArgs e)
        {
            if (activeForm != null)
            {
                activeForm.Dispose();
                activeForm.Close();
            }

            comboBox_dongsp.SelectedIndex = -1;
            tb_gianhap.Clear();
            tb_giaban.Clear();
            tb_soluong.Clear();
            tb_ghichu.Clear();
            tb_tensp.Clear();
        }
    }
}
