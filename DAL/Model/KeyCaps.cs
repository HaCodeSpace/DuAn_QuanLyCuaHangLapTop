using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model
{
    public class KeyCaps
    {
        public int Id { get; set; }
        public string TenKeyCaps { get; set; }

        public virtual ICollection<BanPhimKeyCaps> banPhimKeyCaps { get; set; }
    }
}
