using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.IRepository.IRepositorySanPham;
using DAL.Model;
using DAL.DatabaseContext;

namespace DAL.Repository.RepositorySanPham
{
    public class SanPhamRepository : ISanPhamRepository
    {
        private DA1Context context;
        public SanPhamRepository()
        {
            this.context= new DA1Context();
        }

        public bool AddSP(SanPham san)
        {
            this.context.sanPhams.Add(san);
            this.context.SaveChanges();
            return true;
        }

        public bool DeleteSP(SanPham san)
        {
            var sanpham = this.context.sanPhams.Find(san.MaSP);
            if (sanpham != null)
            {
                this.context.sanPhams.Remove(sanpham);
                this.context.SaveChanges();
                return true;
            }
            else
                return false;
        }

        public bool Edit(SanPham san)
        {
            var sanpham = this.context.sanPhams.Find(san.MaSP);
            if (sanpham != null)
            {
                sanpham.TenSP = san.TenSP;
                sanpham.DonGiaBan = san.DonGiaBan;
                sanpham.DonGiaNhap = san.DonGiaNhap;
                sanpham.DongSP = san.DongSP;
                sanpham.GhiChu = san.GhiChu;
                this.context.sanPhams.Update(sanpham);
                this.context.SaveChanges();
                return true;
            }
            else
                return false;
        }

        public ICollection<SanPham> GetAll()
        {
            return this.context.sanPhams.ToList();
            //return new List<SanPham>();
        }

        public IEnumerable<SanPham> GetByValue(string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                return context.sanPhams.ToList();
            }
            else
            {
                var listsp = (from sp in context.sanPhams.ToList()
                              where sp.TenSP.Contains(value) || sp.MaSP == value
                              select sp);

                return listsp;
            }
            
        }
    }
}
