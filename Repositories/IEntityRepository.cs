using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectMainTestapi.Repositories
{
    public interface IEntityRepository<T> where T:class, new()
    {
        //list of all records
        //IEnumerable<>
        IQueryable<T> GetAllQueryable();
    }
}
