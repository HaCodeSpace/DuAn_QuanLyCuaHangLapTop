using BUS.ViewModels;
using DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.IServices
{
    public interface IQLKhuyenMaiService
    {
        List<KhuyenMai> LayDanhSachKhuyenMai();
        List<ViewHienThiKhuyenMai> getViewKhuyenMai();
        bool ThemKM(KhuyenMai km);
        bool SuaKM(KhuyenMai km);
    }
}
