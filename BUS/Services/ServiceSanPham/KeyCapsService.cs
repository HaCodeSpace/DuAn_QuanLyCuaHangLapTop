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
    public class KeyCapsService : IKeycapsService
    {
        private IKeycapsRepository _service;

        public KeyCapsService()
        {
            _service = new KeycapsRepository();
        }

        //public bool ThemKeycaps(KeyCaps keyCaps)
        //{
        //    return _service.Add(keyCaps);
        //}

        //public int TimId(KeyCaps keyCaps)
        //{
        //    return _service.FindId(keyCaps);
        //}
    }
}
