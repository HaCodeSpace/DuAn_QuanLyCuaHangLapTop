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

namespace Presentation
{
    public partial class FormSanPhamLaptop : Form
    {
        public delegate void GetLaptop(string cpu, string ram, string card, string ocung, string pin, double trongluong, string manhinh, string dophangiai, string webcam, string hedieuhanh, string kichthuoc, string bluetooth);
        public event GetLaptop GetInfo;
        private Laptop laptop;

        public FormSanPhamLaptop()
        {
            InitializeComponent();
  

        }
        public FormSanPhamLaptop(Laptop lap)
        {
            InitializeComponent();
            laptop = lap;
            
        }

        private void tbx_textchanged(object sender, EventArgs e)
        {
            string cpu = tb_cpu.Text.Trim();
            string ram = tb_ram.Text.Trim();
            string card = tbx_card.Text.Trim();
            string ocung = tbx_ocung.Text.Trim();
            string pin = tbx_pin.Text.Trim();
            double trongluong;
            var check = double.TryParse(tbx_trongluong.Text.Trim(), out trongluong);
            if (!check && !string.IsNullOrEmpty(tbx_trongluong.Text))
            {
                MessageBox.Show("Trọng lượng phải là số!");
                return;
            }
            string manhinh = tbx_manhinh.Text.Trim();
            string dophangiai = tbx_dophangiai.Text.Trim();
            string webcam = tbx_webcam.Text.Trim();
            string hedieuhanh = tbx_hedieuhanh.Text.Trim();
            string kichthuoc = tbx_kichthuoc.Text.Trim();
            string bluetooth = tbx_bluetooth.Text.Trim();
            if (GetInfo != null)
                GetInfo(cpu, ram, card, ocung, pin, trongluong, manhinh, dophangiai, webcam, hedieuhanh, kichthuoc, bluetooth);
        }

        private void FormSanPhamLaptop_Load(object sender, EventArgs e)
        {
            if (laptop !=null)
            {
                tb_cpu.Text = laptop.CPU;
                tb_ram.Text = laptop.RAM;
                tbx_card.Text = laptop.VGA_Card;
                tbx_ocung.Text=laptop.OCung;
                tbx_pin.Text=laptop.PIN;
                tbx_trongluong.Text=laptop.TrongLuong.ToString();
                tbx_manhinh.Text=laptop.ManHinh;
                tbx_dophangiai.Text=laptop.DoPhanGiai;
                tbx_webcam.Text=laptop.WebCam;
                tbx_hedieuhanh.Text=laptop.HeDieuHanh;
                tbx_bluetooth.Text=laptop.Bluetooth;
                tbx_kichthuoc.Text=laptop.KichThuoc;
            }
        }



        private void tb_cpu_Click(object sender, EventArgs e)
        {
            
        }
    }
}
