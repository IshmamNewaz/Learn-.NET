using DAL.EF;
using DAL.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DAL.Interfaces.IStudentRepo;

namespace DAL
{
    public class DataAccess
    {
        public static IRepo<Student, int> StudentDataAccess()
        {
            return new StudentRepo();
        }
    }
}
