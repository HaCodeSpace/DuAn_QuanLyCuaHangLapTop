using BUS.IServices;
using BUS.ViewModels;
using DAL.IRepository;
using DAL.Model;
using DAL.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Services
{
    public class QLKhuyenMaiService : IQLKhuyenMaiService
    {
        private IKhuyenMaiRepository _ikhuyenMaiRepository;
        private List<KhuyenMai> _lstKhuyenMai;
        private List<ViewHienThiKhuyenMai> _lstViewKM;
        public QLKhuyenMaiService()
        {
            _ikhuyenMaiRepository = new KhuyenMaiRepository();
            _lstKhuyenMai = new List<KhuyenMai>();
            _lstViewKM = new List<ViewHienThiKhuyenMai>();
            LayDanhSachKhuyenMai();
        }
        public List<KhuyenMai> LayDanhSachKhuyenMai()
        {
            return _lstKhuyenMai = _ikhuyenMaiRepository.LayDanhSachKhuyenMai();
        }
        public List<ViewHienThiKhuyenMai> getViewKhuyenMai()
        {
            _lstViewKM = (from a in LayDanhSachKhuyenMai() select new ViewHienThiKhuyenMai{ khuyenMai = a }).ToList();
            return _lstViewKM;
        }
        public bool ThemKM(KhuyenMai km)
        {
            _ikhuyenMaiRepository.ThemKM(km);
            return true;
        }
        public bool SuaKM(KhuyenMai km)
        {
            _ikhuyenMaiRepository.SuaKM(km);
            return true;
        }

    }
}
