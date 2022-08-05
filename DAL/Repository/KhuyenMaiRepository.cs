using DAL.IRepository;
using DAL.IRepository.IRepositorySanPham;
using DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public class KhuyenMaiRepository : IKhuyenMaiRepository
    {
        private DatabaseContext.DA1Context _DA1context;
        private List<KhuyenMai> _lstKhuyenMai;
        public KhuyenMaiRepository()
        {
            _lstKhuyenMai = new List<KhuyenMai>();
            _DA1context = new DatabaseContext.DA1Context();
            LayDanhSachKhuyenMai();
        }
        public List<KhuyenMai> LayDanhSachKhuyenMai()
        {
            _lstKhuyenMai = _DA1context.khuyenMais.ToList();
            return _lstKhuyenMai;
        }
        public bool ThemKM(KhuyenMai km)
        {
            _DA1context.khuyenMais.Add(km);
            _DA1context.SaveChanges();
            return true;
        }
        public bool SuaKM(KhuyenMai km)
        {
            _DA1context.khuyenMais.Update(km);
            _DA1context.SaveChanges();
            return true;
        }
    }
}
