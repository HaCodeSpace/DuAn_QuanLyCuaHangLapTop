using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Model;

namespace BUS.IServices.IServiceSanPham
{
    public interface IBanPhimService
    {
        Boolean ThemBP(BanPhim banPhim);
        Boolean SuaBP(BanPhim banPhim);
        Boolean XoaBP(BanPhim banPhim);
    }
}
