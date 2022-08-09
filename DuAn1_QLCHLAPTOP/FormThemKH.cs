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
using BUS.IServices;
using BUS.Services;

namespace Presentation
{
    public partial class FormThemKH : Form
    {
        public delegate void AddKH(bool issuccess);
        public event AddKH ThemKH;

        private IQuanLyKhachHangService _service;

        public FormThemKH()
        {
            InitializeComponent();
            _service = new QuanLyKhachHangService();
        }

        private void FormThemKH_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ma = textBox1.Text;
            string ten = textBox2.Text;
            string sdt = textBox3.Text;

            var kh = new KhachHang()
            {
                MaKH = ma,
                TenKH = ten,
                SDT = sdt
            };

            var result = _service.ThemKH(kh);
            if (result)
            {
                MessageBox.Show("Thành công");
            }
            else
                MessageBox.Show("Thất bại");

            if (ThemKH != null)
                ThemKH(result);
            this.Dispose();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
        }
    }
}
