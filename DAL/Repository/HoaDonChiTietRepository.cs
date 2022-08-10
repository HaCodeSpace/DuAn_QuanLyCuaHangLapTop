using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.IRepository;
using DAL.DatabaseContext;
using DAL.Model;

namespace DAL.Repository
{
    public class HoaDonChiTietRepository : IHoaDonChiTietRepository
    {
        private DA1Context context;

        public HoaDonChiTietRepository()
        {
            context = new DA1Context();
        }

        public bool Add(HoaDonChiTiet hoaDonChiTiet)
        {
            context.hoaDonChiTiets.Add(hoaDonChiTiet);
            if (context.SaveChanges() != 0)
                return true;
            else
                return false;
        }

        public IEnumerable<HoaDonChiTiet> TimHoadonchitiet(string value)
        {
            var result = context.hoaDonChiTiets.Where(p => p.MaHD.Equals(value)).ToList();
            return result;
        }
    }
}
