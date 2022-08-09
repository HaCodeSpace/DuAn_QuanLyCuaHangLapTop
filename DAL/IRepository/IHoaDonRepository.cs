using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Model;

namespace DAL.IRepository
{
    public interface IHoaDonRepository
    {
        IEnumerable<HoaDon> GetHoaDons();
        Boolean Add(HoaDon hoaDon);
        Boolean Edit(HoaDon hoaDon);

        Boolean Remove(HoaDon hoaDon);
    }
}
