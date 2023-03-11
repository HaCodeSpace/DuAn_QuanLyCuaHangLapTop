using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.DatabaseContext;
using DAL.Model;
using DAL.IRepository;

namespace DAL.Repository
{
    public class NhanVienRepository:INhanVienRepository
    {
        private List<NhanVien> _lstNV;
        private DA1Context _DBContext;
        public NhanVienRepository()
        {
            _lstNV = new List<NhanVien>();
            _DBContext = new DA1Context();
        }
        public List<NhanVien> getlstNVfromDB()
        {
            _lstNV = _DBContext.nhanViens.ToList();
            return _lstNV;
        }
        public bool addNV(NhanVien nhanVien)
        {
            _DBContext.nhanViens.Add(nhanVien);
            _DBContext.SaveChanges();
            return true;
        }
        public bool updateNV(NhanVien nhanVien)
        {
            _DBContext.nhanViens.Update(nhanVien);
            _DBContext.SaveChanges();
            return true;
        }
    }
}
