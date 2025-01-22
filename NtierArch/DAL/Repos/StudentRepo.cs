using DAL.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static DAL.Interfaces.IStudentRepo;

namespace DAL.Repos
{
    internal class StudentRepo : Repo, IRepo<Student, int>
    {
        public void Add(Student s)
        {
            Db.Students.Add(s);
            Db.SaveChanges();
        }
        public List<Student> Get()
        {
            return Db.Students.ToList();
        }
        public Student Get(int id)
        {
            return Db.Students.Find(id);
        }
        public void Update(Student s)
        {
            var exobj = Get(s.Id);
            Db.Entry(exobj).CurrentValues.SetValues(s);
            Db.SaveChanges();
        }
        public void Delete(int id)
        {
            var exobj = Get(id);
            Db.Students.Remove(exobj);
            Db.SaveChanges();
        }
    }
}
