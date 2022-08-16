using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;
using BUS.IServices;
using BUS.Services;
using DAL.Model;

namespace Presentation
{
    public partial class QuenMK : Form
    {
        private IQLNhanVienService _IQLnv;
        private NhanVien _nv;
        public QuenMK()
        {
            InitializeComponent();
            _IQLnv = new QLNhanVienService();
            _nv = new NhanVien();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new DangNhap().Show();
        }

        private void bt_xacnhan_Click(object sender, EventArgs e)
        {
            if (_IQLnv.getlstNVfromDB().Any(nv => nv.Email == tb_email.Text && nv.SoDienThoai ==tb_sdt.Text))
            {              
                string from, to, pass;
                from = "hanvph19236@fpt.edu.vn";
                to = tb_email.Text;
                pass = "ha244466666";
                foreach (var item in _IQLnv.getlstNVfromDB().Where(nv=>nv.Email==tb_email.Text))
                {
                    _nv.MatKhau = item.MatKhau;
                }
                MailMessage mail = new MailMessage();
                mail.To.Add(to);
                mail.From = new MailAddress(from);
                mail.Subject = "Cửa hàng laptop và phụ kiện";
                mail.Body = "Mật khẩu của bạn là: "+_nv.MatKhau;

                SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                smtp.EnableSsl = true;
                smtp.Port = 587;
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.Credentials = new NetworkCredential(from, pass);
                try
                {
                    smtp.Send(mail);
                    MessageBox.Show("Mật khẩu của bạn đã được gửi về mail, mời kiểm tra");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Bạn nhập sai thông tin rồi");
            }
        }
    }
}
