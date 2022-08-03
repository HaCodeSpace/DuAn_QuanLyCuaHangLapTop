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
    public class QLNhanVienService:IQLNhanVienService
    {
        private INhanVienRepository _IQLnv;
        private List<NhanVien> _lstNV;
        public QLNhanVienService()
        {
            _IQLnv = new NhanVienRepository();
            _lstNV = new List<NhanVien>();
            getlstNVfromDB();
        }
        public List<NhanVien> getlstNVfromDB()
        {
            return _lstNV = _IQLnv.getlstNVfromDB();
        }
        public bool addNV(NhanVien nhanVien)
        {
            _IQLnv.addNV(nhanVien);
            return true;
        }
    }
}
