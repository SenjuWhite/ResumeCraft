using Microsoft.EntityFrameworkCore;
using ResumeCraft_API.DataAccess.Repositories.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ResumeCraft_API.DataAccess.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly ApplicationDbContext _db;
        private readonly DbSet<T> dbSet;
        public Repository(ApplicationDbContext db)
        {
            _db = db;
            dbSet = _db.Set<T>();
        }
        public async Task AddAsync(T entity)
        {

            await dbSet.AddAsync(entity);
        }
        public async Task<IEnumerable<T>> GetAllAsync()
        {
            IQueryable<T> query = dbSet;
            return await query.ToListAsync();
        }
        public async Task<IEnumerable<T>> GetValuesAsync(Expression<Func<T, bool>> filter)
        {
            IQueryable<T> query = dbSet;
            query = query.Where(filter);
            return await query.ToListAsync();
        }
        public async Task<T> GetValueAsync(Expression<Func<T, bool>> filter)
        {
            return await dbSet.FirstOrDefaultAsync(filter);
        }
        public async Task DeleteAsync(T entity)
        {
            dbSet.Remove(entity);
        }
        public async Task UpdateAsync(T entity)
        {
            dbSet.Update(entity);
        }
    }
}
