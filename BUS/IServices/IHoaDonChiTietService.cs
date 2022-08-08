using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Model;

namespace BUS.IServices
{
    public interface IHoaDonChiTietService
    {
        Boolean ThemHDCT(HoaDonChiTiet hoaDonChiTiet);
    }
}
