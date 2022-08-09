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
    public class HoaDonChiTietService : IHoaDonChiTietService
    {
        private IHoaDonChiTietRepository _service;

        public HoaDonChiTietService()
        {
            _service = new HoaDonChiTietRepository();
        }
        public bool ThemHDCT(HoaDonChiTiet hoaDonChiTiet)
        {
            return _service.Add(hoaDonChiTiet);
        }
    }
}
