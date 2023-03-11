using DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.IServices
{
    public interface IQLNhanVienService
    {
        List<NhanVien> getlstNVfromDB();
        bool addNV(NhanVien nhanVien);
        bool updateNV(NhanVien nhanVien);
    }
}
