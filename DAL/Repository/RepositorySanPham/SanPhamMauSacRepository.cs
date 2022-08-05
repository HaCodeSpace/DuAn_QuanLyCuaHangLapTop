using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.IRepository.IRepositorySanPham;
using DAL.DatabaseContext;
using DAL.Model;

namespace DAL.Repository.RepositorySanPham
{
    public class SanPhamMauSacRepository : ISanPhamMauSacRepository
    {
        private DA1Context context;

        public SanPhamMauSacRepository()
        {
            context = new DA1Context();
        }

        public bool Add(SanPhamMauSac sanPhamMau)
        {
            context.sanPhamMauSacs.Add(sanPhamMau);
            context.SaveChanges();
            return true;
        }
    }
}
