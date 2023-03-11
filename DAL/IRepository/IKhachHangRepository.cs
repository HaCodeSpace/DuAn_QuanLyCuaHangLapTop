using DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.IRepository
{
    public interface IKhachHangRepository
    {
        List<KhachHang> LayDanhSachKhachHang();
        bool ThemKH(KhachHang kh);
        bool SuaKH(KhachHang kh);
    }
}
