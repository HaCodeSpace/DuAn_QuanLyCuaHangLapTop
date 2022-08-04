using DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.IRepository
{
    public interface IKhuyenMaiRepository
    {
        List<KhuyenMai> LayDanhSachKhuyenMai();
        bool ThemKM(KhuyenMai km);
        bool SuaKM(KhuyenMai km);
    }
}
