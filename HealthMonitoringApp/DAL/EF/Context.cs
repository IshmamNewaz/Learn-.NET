using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF
{
    public class Context: DbContext
    {
        public DbSet<Matric> Matrics { get; set; }
        public DbSet<HealthGoal> HealthGoals { get; set; }
    }
}
