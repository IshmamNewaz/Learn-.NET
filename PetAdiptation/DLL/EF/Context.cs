using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL.EF
{
    public class Context: DbContext
    {
        public DbSet<Petinfo> Petinfos { get; set; }
    }
}
