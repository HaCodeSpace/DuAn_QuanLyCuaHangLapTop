using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model
{
    public class BanPhimKeyCaps
    {
        public int IdKeyCaps { get; set; }
        public virtual KeyCaps keyCaps { get; set; }

        public string MaSP { get; set; }
        public virtual BanPhim banPhim { get; set; }
    }
}
