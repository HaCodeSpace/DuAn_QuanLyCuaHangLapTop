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
    public partial class FormThongKeSanPham : Form
    {
        public FormThongKeSanPham()
        {
            InitializeComponent();
        }
     
        private void doanhThuToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FormThongKeDoanhThu ftkdt = new FormThongKeDoanhThu()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true,
            };

            ftkdt.FormBorderStyle = FormBorderStyle.None;
            ftkdt.Show();
        }

        private void rdb_thang_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
