using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Model;

namespace DAL.IRepository.IRepositorySanPham
{
    public interface ISanPhamRepository
    {
        ICollection<SanPham> GetAll();
        Boolean AddSP(SanPham san);
        Boolean Edit(SanPham san);
        Boolean DeleteSP(SanPham san);
    }
}
