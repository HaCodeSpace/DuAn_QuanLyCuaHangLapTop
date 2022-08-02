using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Model;

namespace DAL.IRepository.IRepositorySanPham
{
    public interface IBanPhimRepository
    {
        Boolean Add(BanPhim banPhim);
        Boolean Edit(BanPhim banPhim);
        Boolean Remove(BanPhim banPhim);
    }
}
