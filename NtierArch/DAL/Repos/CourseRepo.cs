using DAL.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    public class CourseRepo:Repo
    {
        public void Create(Course s)
        {
            Db.Courses.Add(s);
            Db.SaveChanges();

        }
        public List<Course> Get()
        {
            return Db.Courses.ToList();
        }
        public Course Get(int id)
        {
            return Db.Courses.Find(id);
        }
        public void Update(Course s)
        {
            var exobj = Get(s.Id);
            Db.Entry(exobj).CurrentValues.SetValues(s);
            Db.SaveChanges();
        }
        public void Delete(int id)
        {
            var exobj = Get(id);
            Db.Courses.Remove(exobj);
            Db.SaveChanges();
        }
    }
}
