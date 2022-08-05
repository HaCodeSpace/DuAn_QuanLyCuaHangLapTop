using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Model;

namespace BUS.IServices.IServiceSanPham
{
    public interface ISanPhamMauSacService
    {
        Boolean ThemSPMS(SanPhamMauSac sanPhamMau);
    }
}
