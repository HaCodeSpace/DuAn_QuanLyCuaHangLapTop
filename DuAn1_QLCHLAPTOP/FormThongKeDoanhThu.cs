using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS.IServices;
using BUS.Services;
using DAL.Model;
using System.Net.Mail;
using System.Net;

namespace Presentation
{
    public partial class FormThongKeDoanhThu : Form
    {
        private IHoaDonService _hoaDonService;
        private IQuanLyKhachHangService _IQLKhachHangService;
        private List<ShowThongKe> showThongKes;
        private List<ShowThongKe> ListLoc;
        private IQLNhanVienService _IQLnv;
        private NhanVien _nv;

        public FormThongKeDoanhThu()
        {
            InitializeComponent();
            _hoaDonService = new HoaDonService();
            _IQLKhachHangService = new QuanLyKhachHangService();
            //dataGridView1.ColumnCount = 3;
            //dataGridView1.Columns[0].Name = "Tổng khách hàng";
            //dataGridView1.Columns[1].Name = "Tổng hóa đơn";
            //dataGridView1.Columns[2].Name = "Doanh thu";
    
        }

        public void LoadThongKe()
        {
            var viewtk = (from a in _hoaDonService.LayDanhSachHD()
                         join b in _IQLKhachHangService.LayDanhSachKhachHang() on a.MaKH equals b.MaKH
                         where a.TrangThai == true
                         select a).ToList();
            LoadDuLieuFilter(viewtk);
            if (viewtk != null)
            {
                showThongKes = viewtk
                .GroupBy(l => l.MaKH)
                .Select(cl => new ShowThongKe()
                {
                    MaKH = cl.First().MaKH,
                    NgayLapHD = cl.First().NgayLapHD,
                    tonghd = cl.Count(),
                    doanhthu = cl.Sum(c => c.TongTienHD).ToString()
                    
                }).ToList();
                ListLoc = showThongKes.ToList();
                dataGridView1.DataSource = showThongKes.ToList();
                dataGridView1.Columns["NgayLapHD"].Visible = false;
            }
            else
            {
                MessageBox.Show("Khong co doanh thu");
            }
        }

        private void LoadDuLieuFilter(IEnumerable<HoaDon> viewtk)
        {
            List<DateTime> Ldate = new List<DateTime>();
            foreach (var date in viewtk)
            {
                Ldate.Add(date.NgayLapHD);
            }
            foreach (var item in Ldate)
            {
                if (cbx_nam.Items.IndexOf("Năm "+ item.Year.ToString()) < 0)
                {
                    cbx_nam.Items.Add("Năm " + item.Year.ToString());
                }
                if (cbx_thang.Items.IndexOf("Tháng " + item.Month.ToString()) < 0)
                {
                    cbx_thang.Items.Add("Tháng " + item.Month.ToString());
                }
            }
        }

        private void sảnPhẩmToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

            FormThongKeSanPham ftksp = new FormThongKeSanPham()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true,
            };
            ftksp.FormBorderStyle = FormBorderStyle.None;
            ftksp.Show();
        }

        private void FormThongKeDoanhThu_Load(object sender, EventArgs e)
        {
            LoadThongKe();
        }

        private void cbx_nam_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!rdb_nam.Checked)
                rdb_nam.Checked = true;
 
            ListLoc = ListLoc.Where(p => p.NgayLapHD.Year == GetDate(cbx_nam.Text)).ToList();
            MessageBox.Show("loc");
            dataGridView1.DataSource = ListLoc;
            
        }

        private int GetDate(string selectedText)
        {
            string[] strarr = selectedText.Split(' ');
            return int.Parse(strarr[strarr.Length - 1]);
        }

        private void cbx_thang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!rdb_thang.Checked)
                rdb_thang.Checked = true;
      
            ListLoc = ListLoc.Where(p => p.NgayLapHD.Month == GetDate(cbx_thang.Text)).ToList();
            dataGridView1.DataSource = ListLoc;
        }

        private void rdb_tatca_CheckedChanged(object sender, EventArgs e)
        {
            if (rdb_tatca.Checked)
            {
                ListLoc = showThongKes.ToList();
                dataGridView1.DataSource = showThongKes.ToList();
            }

        }

        private void bt_guibaocao_Click(object sender, EventArgs e)
        {           
            string from, to, pass;
                from = "phongttph19348@fpt.edu.vn"; // mail gửi đi - pass 
                to = "nguyenvietha2ka2@gmail.com"; // mail gửi đến
                pass = "4ever1love";                 
                MailMessage mail = new MailMessage();
                mail.To.Add(to);
                mail.From = new MailAddress(from);
                mail.Subject = "Báo Cáo Doanh Thu";
                mail.Body = "Doanh thu: " + showThongKes;

                SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                smtp.EnableSsl = true;
                smtp.Port = 587;
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.Credentials = new NetworkCredential(from, pass);
                try
                {
                    smtp.Send(mail);
                    MessageBox.Show("Gửi Báo Cáo Doanh Thu Thành Công");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gửi Thất Bại");
                }         
        }
    }
}
