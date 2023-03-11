using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BUS.IServices.IServiceSanPham;
using DAL.Model;
using DAL.IRepository.IRepositorySanPham;
using DAL.Repository.RepositorySanPham;

namespace BUS.Services.ServiceSanPham
{
    public class BanPhimService : IBanPhimService
    {
        private IBanPhimRepository _service;

        public BanPhimService()
        {
            _service = new BanPhimRepository();
        }

        public bool SuaBP(BanPhim banPhim)
        {
            return _service.Edit(banPhim);
        }

        public bool ThemBP(BanPhim banPhim)
        {
            return _service.Add(banPhim);
        }

        public bool XoaBP(BanPhim banPhim)
        {
            return _service.Remove(banPhim);
        }
    }
}
