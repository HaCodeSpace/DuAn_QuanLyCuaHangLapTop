using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Presentation;
using DAL.Model;
using BUS.IServices.IServiceSanPham;
using BUS.Services.ServiceSanPham;

namespace Presentation
{
    public partial class FormSanPhamBanPhim : Form
    {
        public delegate void GetBanPhim(string hangsx, int kieukn, string kieubp, string led, string layout, string kichthuoc, float trongluong, string mausac, string keycaps);
        public event GetBanPhim GetBanPhimEvent;

        public FormSanPhamBanPhim()
        {
            InitializeComponent();
            
        }

        private void _view_MatchBanPhim(object? sender, EventArgs e)
        {
            
        }

        private void comboBox_ketnoi_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtbox_textchanged(object sender, EventArgs e)
        {
            string hangsx = tb_hangsx.Text.Trim();
            int kieukn = 0;
            if (!string.IsNullOrEmpty(tb_ketnoi.Text.Trim()))
            {
                kieukn = int.Parse(tb_ketnoi.Text.Trim());
            }
            String kieubp = tb_kieubp.Text.Trim();
            String led = tb_led.Text.Trim();
            String layout = tb_layout.Text.Trim();
            string kichthuoc = tb_kichthuoc.Text.Trim();
            float trongluong = 0;
            if (!string.IsNullOrEmpty(tb_trongluong.Text.Trim()))
            {
                trongluong = float.Parse(tb_trongluong.Text.Trim());
            }
            string mausac = tb_mausac.Text.Trim();
            string keycaps = tb_keycaps.Text.Trim();

            if (GetBanPhimEvent != null)
                GetBanPhimEvent(hangsx, kieukn, kieubp, led, layout, kichthuoc, trongluong, mausac, keycaps);
        }
    }
}
