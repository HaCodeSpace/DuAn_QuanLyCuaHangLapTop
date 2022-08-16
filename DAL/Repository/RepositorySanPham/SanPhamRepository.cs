using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.IRepository.IRepositorySanPham;
using DAL.Model;
using DAL.DatabaseContext;
using Microsoft.EntityFrameworkCore;

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
            var check = context.sanPhams.Any(p => p.TenSP.ToUpper().Trim() == san.TenSP.ToUpper().Trim());
            if (check)
                throw new Exception("San pham nay da ton tai");
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
            var existingSanPham = new SanPham();
            var existingChild = Type.Missing;
            if (san.laptop !=null)
            {
                existingSanPham = context.sanPhams
               .Where(p => p.TenSP == san.TenSP)
               .Include(p => p.laptop)
               .SingleOrDefault();
                san.laptop.MaLaptop = existingSanPham.MaSP;
                existingChild=existingSanPham.laptop;
            }
            else
            {
                existingSanPham = context.sanPhams
                .Where(p => p.TenSP == san.TenSP)
                .Include(p => p.banPhim)
                .SingleOrDefault();
                san.banPhim.MaSP=existingSanPham.MaSP;
                existingChild=existingSanPham.banPhim;
            }



            if (existingSanPham != null)
            {
                // update Sanpham
                san.MaSP = existingSanPham.MaSP;
                context.Entry(existingSanPham).CurrentValues.SetValues(san);

                //update child
                if(san.laptop!=null)
                    context.Entry(existingChild).CurrentValues.SetValues(san.laptop);
                else
                    context.Entry(existingChild).CurrentValues.SetValues(san.banPhim);
                context.SaveChanges();
                return true;
            }
            else
                return false;
        }



        public ICollection<SanPham> GetAll()
        {

            var result = context.sanPhams
                .Include(s => s.laptop)
                .Include(s => s.banPhim)
                .ToList();
            return result;
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
                              where sp.TenSP.Contains(value)
                              select sp);

                return listsp;
            }

        }
    }

}
