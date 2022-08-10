using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Model;

namespace DAL.IRepository
{
    public interface IHoaDonChiTietRepository
    {
        Boolean Add(HoaDonChiTiet hoaDonChiTiet);

        IEnumerable<HoaDonChiTiet> TimHoadonchitiet(string value);
    }
}
