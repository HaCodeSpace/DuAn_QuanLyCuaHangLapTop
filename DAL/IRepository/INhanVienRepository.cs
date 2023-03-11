using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Model;
namespace DAL.IRepository
{
    public interface INhanVienRepository
    {
        List<NhanVien> getlstNVfromDB();
        bool addNV(NhanVien nhanVien);
        bool updateNV(NhanVien nhanVien);
    }
}
