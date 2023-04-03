using System.Linq.Expressions;

namespace DataAccessLayer.Repositories.Abstractions
{
    public interface IRepository<T>
    {
        Task AddAsync(T entity);
        Task<T> UpdateAsync(T entity);
        Task DeleteAsync(T entity);
        Task<T> GetByIdAsync(int id);
        Task<int> CountAsync(Expression<Func<T, bool>> method);
        Task<bool> AnyAsync(Expression<Func<T, bool>> method);
        Task<T> GetAsync(Expression<Func<T, bool>> method, params Expression<Func<T, object>>[] includeProperties);
        Task<List<T>> GetAllAsync(Expression<Func<T, bool>> method = null, params Expression<Func<T, object>>[] includeProperties);
    }
}
