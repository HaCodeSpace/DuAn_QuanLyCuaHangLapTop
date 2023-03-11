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
    public class QuanLyKhachHangService : IQuanLyKhachHangService
    {
        private IKhachHangRepository _ikhachHangRepository;
        private List<KhachHang> _lstKhachHang;
        private List<ViewHienThiKhachHang> _lstViewKH;
        public QuanLyKhachHangService()
        {
            _ikhachHangRepository = new KhachHangRepository();
            _lstKhachHang = new List<KhachHang>();
            _lstViewKH = new List<ViewHienThiKhachHang>();
            LayDanhSachKhachHang();
        }
        public List<KhachHang> LayDanhSachKhachHang()
        {
            return _lstKhachHang = _ikhachHangRepository.LayDanhSachKhachHang();
        }
        public List<ViewHienThiKhachHang> getViewKhachHang()
        {
            _lstViewKH = (from a in LayDanhSachKhachHang() select new ViewHienThiKhachHang { khachHang = a}).ToList();
            return _lstViewKH;
        }
        public bool ThemKH(KhachHang kh)
        {
            _ikhachHangRepository.ThemKH(kh);
            return true;
        }
        public bool SuaKH(KhachHang kh)
        {
            _ikhachHangRepository.SuaKH(kh);
            return true;
        }

    }
}
