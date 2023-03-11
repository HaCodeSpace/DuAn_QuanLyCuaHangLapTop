using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Model;

namespace BUS.IServices
{
    public interface IHoaDonService
    {
        IEnumerable<HoaDon> LayDanhSachHD();
        Boolean ThemHD(HoaDon hoaDon);
        Boolean SuaHD(HoaDon hoaDon);
        Boolean XoaHD(HoaDon hoaDon);
    }
}
