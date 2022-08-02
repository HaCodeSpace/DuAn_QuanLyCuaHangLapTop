using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.IServices.IServiceSanPham
{
    public interface ISanPhamService
    {
        ICollection<DAL.Model.SanPham> SanPhamList();
        Boolean ThemSP(DAL.Model.SanPham san);
        Boolean SuaSP(DAL.Model.SanPham san);
        Boolean XoaSP(DAL.Model.SanPham san);
    }
}
