using BUS.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BUS.Services;
using System.Net.Mail;
using DAL.Model;

namespace Presentation.Utilities
{
    public class Validations
    {
        private IQLNhanVienService _IQLnv;
        public Validations()
        {
            _IQLnv = new QLNhanVienService();
        }
        public bool NhanVienValidate(string ma, string ten, string vaitro, string email, string date, string sdt,string mk)
        {
            if (ma.Length == 0 || ten.Length == 0 || vaitro.Length == 0 || email.Length == 0 || date.Length == 0 || sdt.Length == 0||mk.Length==0)
            {
                MessageBox.Show("Không được bỏ trống trường nào");
                return false;
            }
            foreach (var item in _IQLnv.getlstNVfromDB().ToList())
            {
                if (item.MaNV == ma)
                {
                    MessageBox.Show("Mã nhân viên trùng, mời nhập lại");
                    return false;
                }
                if (item.Email == email)
                {
                    MessageBox.Show("Email đã tồn tại trong hệ thống");
                    return false;
                }
                if (item.SoDienThoai == sdt)
                {
                    MessageBox.Show("Số điện thoại đã tồn tại trong hệ thống");
                    return false;
                }
            }
            if (ma.StartsWith("NV") == false)
            {
                MessageBox.Show("Mã nhân viên phải bắt đầu bằng NV(VD: NV00)");
                return false;
            }
            if (ten.Any(char.IsNumber) == true)
            {
                MessageBox.Show("Tên nhân viên không được chứa số");
                return false;
            }
            if (vaitro.Length == 0)
            {
                MessageBox.Show("Mời bạn chọn vai trò của nhân viên");
                return false;
            }
            try
            {
                MailAddress m = new MailAddress(email);
            }
            catch (Exception)
            {
                MessageBox.Show("Không đúng định dạng email (VD: nguyenvietha2ka2@gmail.com)");
                return false;
            }
            if (mk.Length > 8)
            {
                MessageBox.Show("Mật khẩu ít hơn 9 ký tự");
                return false;
            }
            try
            {
                Convert.ToDateTime(date);
            }
            catch (Exception)
            {
                MessageBox.Show("Ngày sinh nhập không hợp lệ");
                return false;
            }
            if (sdt.Any(char.IsLetter) == true || sdt.Length != 10)
            {
                MessageBox.Show("Số điện thoại không được chứa chữ và độ dài là 10 ký tự");
                return false;
            }
            return true;
        }
        public bool NhanVienValidate2(string ten, string vaitro, string email, string date, string sdt,string mk)
        {
            if (ten.Length == 0 || vaitro.Length == 0 || email.Length == 0 || date.Length == 0 || sdt.Length == 0||mk.Length==0)
            {
                MessageBox.Show("Không được bỏ trống trường nào");
                return false;
            }
            foreach (var item in _IQLnv.getlstNVfromDB().ToList())
            {
                if (item.SoDienThoai == sdt)
                {
                    MessageBox.Show("Số điện thoại đã tồn tại trong hệ thống");
                    return false;
                }
            }
            if (ten.Any(char.IsNumber) == true)
            {
                MessageBox.Show("Tên nhân viên không được chứa số");
                return false;
            }
            if (vaitro.Length == 0)
            {
                MessageBox.Show("Mời bạn chọn vai trò của nhân viên");
                return false;
            }
            try
            {
                MailAddress m = new MailAddress(email);
            }
            catch (Exception)
            {
                MessageBox.Show("Không đúng định dạng email (VD: nguyenvietha2ka2@gmail.com)");
                return false;
            }
            if (mk.Length > 8)
            {
                MessageBox.Show("Mật khẩu ít hơn 9 ký tự");
                return false;
            }
            try
            {
                Convert.ToDateTime(date);
            }
            catch (Exception)
            {
                MessageBox.Show("Ngày sinh nhập không hợp lệ");
                return false;
            }
            if (sdt.Any(char.IsLetter) == true || sdt.Length != 10)
            {
                MessageBox.Show("Số điện thoại không được chứa chữ và độ dài là 10 ký tự");
                return false;
            }
            return true;
        }
        public bool DoiMatKhau(string mkc,string mkm,string mkxn)
        {
            foreach (var item in _IQLnv.getlstNVfromDB().Where(nv => nv.MaNV == Properties.Settings.Default.manv))
            {
                if (item.MatKhau != mkc)
                {
                    MessageBox.Show("Mật khẩu cũ sai, mời bạn nhập lại");
                    return false;
                }
                if (item.MatKhau == mkm)
                {
                    MessageBox.Show("Mật khẩu mới trùng mật khẩu cũ");
                    return false;
                }
                if (mkm.Length < 8)
                {
                    MessageBox.Show("Mật khẩu mới không được ít hơn 8 ký tự");
                    return false;
                }
                if (mkm != mkxn)
                {
                    MessageBox.Show("Mật khẩu mới và xác nhận mật khẩu không trùng");
                    return false;
                }
            }
            return true;
        }
    }
}
