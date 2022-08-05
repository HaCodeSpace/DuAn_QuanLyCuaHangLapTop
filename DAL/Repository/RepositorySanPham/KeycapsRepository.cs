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
    public class KeycapsRepository : IKeycapsRepository
    {
        private DA1Context context;

        public KeycapsRepository()
        {
            context = new DA1Context();
        }

        public bool Add(KeyCaps keyCaps)
        {
            var result = context.keyCaps.Where(p => p.TenKeyCaps == keyCaps.TenKeyCaps).FirstOrDefault();
            if (result == null)
            {
                context.keyCaps.Add(keyCaps);
                context.SaveChanges();
            }
            
            return true;
        }

        public int FindId(KeyCaps keyCaps)
        {
            var result = context.keyCaps.Where(p => p.TenKeyCaps == keyCaps.TenKeyCaps).FirstOrDefault();
            return result.Id;
        }
    }
}
