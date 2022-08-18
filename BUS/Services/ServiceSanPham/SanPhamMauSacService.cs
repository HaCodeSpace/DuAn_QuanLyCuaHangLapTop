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
    public class SanPhamMauSacService : ISanPhamMauSacService
    {
        private ISanPhamMauSacRepository _service;

        public SanPhamMauSacService()
        {
            _service = new SanPhamMauSacRepository();
        }

        //public bool ThemSPMS(SanPhamMauSac sanPhamMau)
        //{
        //    return _service.Add(sanPhamMau);
        //}
    }
}
