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
    public class MauSacService : IMauSacService
    {
        private IMauSacRepository _service;

        public MauSacService()
        {
            _service = new MauSacRepository();
        }

        public bool ThemMau(MauSac mau)
        {
            return _service.Add(mau);
        }

        public int Timid(MauSac mau)
        {
            return _service.Findid(mau);
        }
    }
}
