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
using Presentation.Utilities;

namespace Presentation
{
    public partial class DoiMatKhau : Form
    {
        private IQLNhanVienService _IQLnv;
        private Validations _validate;
        public DoiMatKhau()
        {
            InitializeComponent();
            _IQLnv = new QLNhanVienService();
            _validate = new Validations();
        }
        private void bt_thaydoi_Click(object sender, EventArgs e)
        {
            if (_validate.DoiMatKhau(tb_matkhauhientai.Text, tb_matkhaumoi.Text, tb_xacnhan.Text))
            {
                if (cb_xacnhan.Checked)
                {
                    foreach (var item in _IQLnv.getlstNVfromDB().Where(nv => nv.MaNV == Properties.Settings.Default.manv))
                    {
                        item.MatKhau = tb_matkhaumoi.Text;
                        _IQLnv.updateNV(item);
                        MessageBox.Show("Đổi mật khẩu thành công");
                    }
                }
                if (!cb_xacnhan.Checked)
                {
                    MessageBox.Show("Bạn cần phải tích xác nhận đổi mật khẩu");
                }
            }
        }
    }
}
