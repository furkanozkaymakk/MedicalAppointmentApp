using DataAccessLayer.Context;
using DataAccessLayer.Repositories.Abstractions;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace DataAccessLayer.Repositories.Concretes
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly AddDbContext dbContext;

        public Repository(AddDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        private DbSet<T> Table { get => dbContext.Set<T>(); }

        public async Task AddAsync(T entity)
        {
            await Table.AddAsync(entity);
        }


        public async Task DeleteAsync(T entity)
        {
            await Task.Run(() => Table.Remove(entity));
        }


        public async Task<T> UpdateAsync(T entity)
        {
            await Task.Run(() => Table.Update(entity));
            return entity;
        }


        public async Task<T> GetByIdAsync(int id)
        {
            return await Table.FindAsync(id);
        }


        public async Task<int> CountAsync(Expression<Func<T, bool>> method)
        {
            return await Table.CountAsync(method);
        }

        public async Task<bool> AnyAsync(Expression<Func<T, bool>> method)
        {
            return await Table.AnyAsync(method);
        }


        public async Task<T> GetAsync(Expression<Func<T, bool>> method, params Expression<Func<T, object>>[] includeProperties)
        {
            IQueryable<T> query = Table;
            query = query.Where(method);
            if (includeProperties.Any())
            {
                foreach (var item in includeProperties)
                {
                    query = query.Include(item);
                }
            }
            return await query.SingleAsync();
        }


        public async Task<List<T>> GetAllAsync(Expression<Func<T, bool>> method = null, params Expression<Func<T, object>>[] includeProperties)
        {
            IQueryable<T> query = Table;
            if (method != null)
            {
                query = query.Where(method);
            }
            if (includeProperties.Any())
            {
                foreach (var item in includeProperties)
                {
                    query = query.Include(item);
                }
            }
            return await query.ToListAsync();
        }


    }
}

