using BUS.ViewModels;
using DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.IServices
{
    public interface IQuanLyKhachHangService
    {
        List<KhachHang> LayDanhSachKhachHang();
        List<ViewHienThiKhachHang> getViewKhachHang();
        bool ThemKH(KhachHang kh);
        bool SuaKH(KhachHang kh);
    }
}
