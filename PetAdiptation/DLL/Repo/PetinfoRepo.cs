using DLL.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL.Repo
{
    public class PetinfoRepo : Repo
    {
        public void Create(Petinfo pets)
        {
            db.Petinfos.Add(pets);
            db.SaveChanges();

        }
        public List<Petinfo> Get()
        {
            return db.Petinfos.ToList();
        }
        public Petinfo Get(string id)
        {
            return db.Petinfos.FirstOrDefault(m => m.id == id);
        }
        public void Update(Petinfo mats)
        {
            var exobj = Get(mats.id);
            db.Entry(exobj).CurrentValues.SetValues(mats);
            db.SaveChanges();
        }
        public void Delete(string id)
        {
            var exobj = Get(id);
            db.Petinfos.Remove(exobj);
            db.SaveChanges();
        }

        public List<Petinfo> GetByUserId(string id)
        {
            return db.Petinfos.Where(m => m.id == id).ToList();
        }
        public List<Petinfo> GetMatricById(string id)
        {
            return db.Petinfos.Where(m => m.id == id).ToList();
        }
    }
}
