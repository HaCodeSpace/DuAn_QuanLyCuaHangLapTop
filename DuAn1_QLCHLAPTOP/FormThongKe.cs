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
    public partial class FormThongKe : Form
    {
        public FormThongKe()
        {
            InitializeComponent();
        }

        private void doanhThuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            FormThongKeDoanhThu ftkdt = new FormThongKeDoanhThu()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true,
            };
            this.panel2.Controls.Add(ftkdt);
            ftkdt.FormBorderStyle = FormBorderStyle.None;
            ftkdt.Show();
        }

        private void sảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            FormThongKeSanPham ftksp = new FormThongKeSanPham()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true,
            };
            this.panel2.Controls.Add(ftksp);
            ftksp.FormBorderStyle = FormBorderStyle.None;
            ftksp.Show();
        }
    }
}
