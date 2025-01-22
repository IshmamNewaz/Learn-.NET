using DAL.EF;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{
    public class MatricRepo: Repo, IMatricRepo<Matric, string>
    {
        public void Create(Matric mats)
        {
            db.Matrics.Add(mats);
            db.SaveChanges();

        }
        public List<Matric> Get()
        {
            return db.Matrics.ToList();
        }
        public Matric Get(string id)
        {
            return db.Matrics.FirstOrDefault(m => m.MatricsId == id);
        }
        public void Update(Matric mats)
        {
            var exobj = Get(mats.MatricsId);
            db.Entry(exobj).CurrentValues.SetValues(mats);
            db.SaveChanges();
        }
        public void Delete(string id)
        {
            var exobj = Get(id);
            db.Matrics.Remove(exobj);
            db.SaveChanges();
        }

        public List<Matric> GetByUserId(string userId)
        {
            return db.Matrics.Where(m => m.UserId == userId).ToList();
        }
        public List<Matric> GetMatricById(string MatricId)
        {
            return db.Matrics.Where(m => m.MatricsId == MatricId).ToList();
        }
    }
}
