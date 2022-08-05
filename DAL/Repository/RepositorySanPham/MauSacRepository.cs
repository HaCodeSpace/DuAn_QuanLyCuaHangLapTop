using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.IRepository.IRepositorySanPham;
using DAL.Model;
using DAL.DatabaseContext;


namespace DAL.Repository.RepositorySanPham
{
    public class MauSacRepository
    {
        private DA1Context context;

        public MauSacRepository()
        {
            context = new DA1Context();
        }

        public bool Add(MauSac mau)
        {
            var result = context.mauSacs.Where(p => p.MaMau == mau.MaMau).FirstOrDefault();
            if (result != null)
            {
                return false;
            }
            else
            {
                context.mauSacs.Add(mau);
                context.SaveChanges();
                return true;

            }
        }

        public int Findid(MauSac mau)
        {
            var result = context.mauSacs.Where(p => p.TenMau == mau.TenMau).FirstOrDefault();
            return result.Id;
        }
    }
}
