using DataAccessLayer.Repositories.Abstractions;

namespace DataAccessLayer.UnitOfWorks
{
    public interface IUnitOfWork : IAsyncDisposable
    {
        IRepository<T> GetRepository<T>() where T : class;
        Task<int> SaveAsync(); //-->Async save etme
        int Save(); //-->Async olmayan durumlarda save etme.
    }
}
