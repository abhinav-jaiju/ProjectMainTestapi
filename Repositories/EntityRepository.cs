using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProjectMainTestapi.Models;

namespace ProjectMainTestapi.Repositories
{
    public class EntityRepository<T> : IEntityRepository<T> where T : class, new()
    {
        //declare dbcontext
        private CustomerDbContext _context;
        private DbSet<T> _dbSet;
        public EntityRepository(CustomerDbContext dbContext)
        {
            _context = dbContext;
            _dbSet = _context.Set<T>();
        }
        public IQueryable<T> GetAllQueryable()
        {
            return _dbSet;
        }
    }
}
