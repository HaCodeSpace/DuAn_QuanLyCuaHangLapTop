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
    public partial class FormSanPhamChuot : Form
    {
        public delegate void PushChuotToParent(string ketnoi, int ips, string tansophanhoi, string chatlieuvo, double trongluong, string swich, string led
            ,string giatoc, string kichthuoc, string tuoitho); 
        public event PushChuotToParent PushData;
        private Chuot chuot1;

        public FormSanPhamChuot()
        {
            InitializeComponent();
        }

        public FormSanPhamChuot(Chuot chuot)
        {
            InitializeComponent();
            chuot1 = chuot;
        }

        private void tb_trongluong_TextChanged(object sender, EventArgs e)
        {
            string ketnoi = tb_ketnoi.Text.Trim(); 
            int ips = 0;
            if (!string.IsNullOrEmpty(tb_ips.Text))
                ips = int.Parse(tb_ips.Text.Trim());
            string tansoph = tb_tansophanhoi.Text.Trim();
            string chatlieuvo = tb_chatlieuvo.Text.Trim();
            double trongluong;
            var check = double.TryParse(tb_trongluong.Text.Trim(), out trongluong);
            if (!check && !string.IsNullOrEmpty(tb_trongluong.Text))
                MessageBox.Show("Trong luong phai la so");
            string swit = tb_switch.Text.Trim();
            string led = tb_led.Text.Trim();
            string giatoc = tb_giatoc.Text.Trim();
            string kichthuoc = tb_kichthuoc.Text.Trim();
            string tuoitho = tb_tuoitho.Text.Trim();
            if (PushData != null)
                PushData(ketnoi, ips, tansoph, chatlieuvo, trongluong, swit, led, giatoc, kichthuoc, tuoitho);
        }

        private void FormSanPhamChuot_Load(object sender, EventArgs e)
        {
            if (chuot1 != null)
            {
                tb_ketnoi.Text = chuot1.KetNoi;
                tb_ips.Text = chuot1.IPS.ToString();
                tb_tansophanhoi.Text = chuot1.TanSoPhanHoi +"Hz";
                tb_chatlieuvo.Text = chuot1.ChetLieuVo;
                tb_trongluong.Text = chuot1.TrongLuong.ToString();
                tb_switch.Text = chuot1.Switch;
                tb_led.Text = chuot1.Led;
                tb_giatoc.Text = chuot1.GiaToc;
                tb_kichthuoc.Text = chuot1.KichThuoc;
                tb_tuoitho.Text = chuot1.TuoiTho;
          
            }
        }
    }
}
