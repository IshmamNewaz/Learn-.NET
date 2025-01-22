using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    internal interface IMatricRepo<CLASS, ID>
    {
        void Create(CLASS s);
        CLASS Get(ID id);
        List<CLASS> GetByUserId(string id);
        List<CLASS> Get();
        void Delete(ID id);
        void Update(CLASS s);
    }
}
