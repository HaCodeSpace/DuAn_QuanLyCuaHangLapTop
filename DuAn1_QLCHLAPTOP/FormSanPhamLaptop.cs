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
    public partial class FormSanPhamLaptop : Form
    {
        public delegate void GetLaptop(string cpu, string ram, string card, string ocung, string pin, double trongluong, string manhinh, string dophangiai, string webcam, string hedieuhanh, string kichthuoc, string bluetooth);
        public event GetLaptop GetInfo;

        public FormSanPhamLaptop()
        {
            InitializeComponent();

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
            if (!check)
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
           
        }
    }
}
