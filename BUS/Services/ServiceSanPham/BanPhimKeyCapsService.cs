using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BUS.IServices.IServiceSanPham;
using DAL.IRepository.IRepositorySanPham;
using DAL.Model;
using DAL.Repository.RepositorySanPham;

namespace BUS.Services.ServiceSanPham
{
    public class BanPhimKeyCapsService : IBanPhimKeycapsService
    {
        private IBanPhimKeyCapsRepository _service;

        public BanPhimKeyCapsService()
        {
            _service = new BanPhimKeyCapsRepository();
        }

        //public bool ThemBPKCS(BanPhimKeyCaps banPhimKeyCaps)
        //{
        //    return _service.Add(banPhimKeyCaps);
        //}
    }
}
