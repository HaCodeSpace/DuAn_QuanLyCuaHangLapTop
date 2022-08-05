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
    public class BanPhimKeyCapsRepository : IBanPhimKeyCapsRepository
    {
        private DA1Context context;

        public BanPhimKeyCapsRepository()
        {
            context = new DA1Context();
        }
        public bool Add(BanPhimKeyCaps banPhimKeyCaps)
        {
            context.banPhimKeyCaps.Add(banPhimKeyCaps);
            if (context.SaveChanges() > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
