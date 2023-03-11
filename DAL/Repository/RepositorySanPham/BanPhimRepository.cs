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
    public class BanPhimRepository : IBanPhimRepository
    {
        private DA1Context context;

        public BanPhimRepository()
        {
            context = new DA1Context();
        }

        public bool Add(BanPhim banPhim)
        {
            context.banPhims.Add(banPhim);
            context.SaveChanges();
            return true;
        }

        public bool Edit(BanPhim banPhim)
        {
            var result = context.banPhims.Find(banPhim.MaSP);
            if (result != null)
            {
                result.HangSanXuat = banPhim.HangSanXuat;
                result.KieuKetNoi = banPhim.KieuKetNoi;
                result.KieuBanPhim = banPhim.KieuBanPhim;
                result.Led = banPhim.Led;
                result.Layout = banPhim.Layout;
                result.KichThuoc = banPhim.KichThuoc;
                result.TrongLuong = banPhim.TrongLuong;
                context.banPhims.Update(result);
                context.SaveChanges();
                return true;
            }
            else
                return false;
        }

        public bool Remove(BanPhim banPhim)
        {
            var result = context.banPhims.Find(banPhim.MaSP);
            if (result != null)
            {
                context.banPhims.Remove(result);
                context.SaveChanges();
                return true;
            }
            else
                return false;
        }
    }
}
