using CoreLayer.Entities;
using DataAccessLayer.Repositories.Abstractions;

namespace DataAccessLayer.UnitOfWorks
{
    public interface IUnitOfWork : IAsyncDisposable
    {
        IRepository<T> GetRepository<T>() where T : class,IEntityBase,new();
        Task<int> SaveAsync(); //-->Async save etme
        int Save(); //-->Async olmayan durumlarda save etme.
    }
}
