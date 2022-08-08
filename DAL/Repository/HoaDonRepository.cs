using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.IRepository;
using DAL.Model;
using DAL.DatabaseContext;

namespace DAL.Repository
{
    public class HoaDonRepository : IHoaDonRepository
    {
        private DA1Context context;
        public HoaDonRepository()
        {
            context = new DA1Context();
        }
        public bool Add(HoaDon hoaDon)
        {
            context.hoaDons.Add(hoaDon);
            if (context.SaveChanges() != 0)
                return true;
            else
                return false;
        }

        public bool Edit(HoaDon hoaDon)
        {
            var result = context.hoaDons.Find(hoaDon.MaHD);
            if (result != null)
            {
                result.TongTienHD = hoaDon.TongTienHD;
                result.TienKhachDua = hoaDon.TienKhachDua;
                result.TienTraLai = hoaDon.TienTraLai;
                result.HinhThucThanhToan = hoaDon.HinhThucThanhToan;
                result.HinhThucGiaoHang = hoaDon.HinhThucGiaoHang;
                result.GhiChu = hoaDon.GhiChu;
                result.MaKM = hoaDon.MaKM;
                result.TrangThai = hoaDon.TrangThai;
                result.MaKH = hoaDon.MaKH;
                context.hoaDons.Update(result);
                if (context.SaveChanges() != 0)
                    return true;
                else
                    return false;
            }
            else
            {
                return false;
            }
        }

        public IEnumerable<HoaDon> GetHoaDons()
        {
            return context.hoaDons.ToList();
        }

        public bool Remove(HoaDon hoaDon)
        {
            var result = context.hoaDons.Find(hoaDon.MaHD);
            if (result != null)
            {
                context.hoaDons.Remove(result);
                if (context.SaveChanges() != 0)
                    return true;
                else
                    return false;
            }
            else
                return false;
        }
    }
}
