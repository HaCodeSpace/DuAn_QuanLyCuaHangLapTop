using DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BUS.IServices.IServiceSanPham;
using DAL.IRepository.IRepositorySanPham;
using DAL.Repository.RepositorySanPham;

namespace BUS.Services.ServiceSanPham
    
{
    public class SanPhamService : ISanPhamService
    {
        private DAL.IRepository.IRepositorySanPham.ISanPhamRepository _servie;
      
        public SanPhamService()
        {
            this._servie = new DAL.Repository.RepositorySanPham.SanPhamRepository();
        }

        public IEnumerable<SanPham> GetListByValue(string value)
        {
            return _servie.GetByValue(value);
        }

        public ICollection<SanPham> SanPhamList()
        {
            return this._servie.GetAll();
        }

        public bool SuaSP(SanPham san)
        {
            return _servie.Edit(san);
        }

        public bool ThemSP(SanPham san)
        {
            return this._servie.AddSP(san);
        }

        public bool XoaSP(SanPham san)
        {
            return this._servie.DeleteSP(san);
        }
    }
}
