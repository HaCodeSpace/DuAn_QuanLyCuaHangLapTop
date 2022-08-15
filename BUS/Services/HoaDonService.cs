using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BUS.IServices;
using DAL.IRepository;
using DAL.Model;
using DAL.Repository;

namespace BUS.Services
{
    public class HoaDonService : IHoaDonService
    {
        private IHoaDonRepository _service;
        public HoaDonService()
        {
            _service = new HoaDonRepository();
        }
        public IEnumerable<HoaDon> LayDanhSachHD()
        {
            return _service.GetHoaDons();
        }

        public bool SuaHD(HoaDon hoaDon)
        {
            return _service.Edit(hoaDon);
        }

        public bool ThemHD(HoaDon hoaDon)
        {
          //  return _service.Add(hoaDon);
            return _service.Add(hoaDon);
        }

        public bool XoaHD(HoaDon hoaDon)
        {
            return _service.Remove(hoaDon);
        }
    }
}
