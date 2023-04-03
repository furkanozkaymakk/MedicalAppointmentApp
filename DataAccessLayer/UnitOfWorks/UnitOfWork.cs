using DataAccessLayer.Context;
using DataAccessLayer.Repositories.Abstractions;
using DataAccessLayer.Repositories.Concretes;

namespace DataAccessLayer.UnitOfWorks
{
    internal class UnitOfWork : IUnitOfWork
    {
        private readonly AddDbContext dbContext;

        public UnitOfWork(AddDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async ValueTask DisposeAsync()
        {
            await dbContext.DisposeAsync();
        }
        public int Save()
        {
            return dbContext.SaveChanges();
        }
        public async Task<int> SaveAsync()
        {
            return await dbContext.SaveChangesAsync();
        }

        public IRepository<T> GetRepository<T>() where T : class
        {
            return new Repository<T>(dbContext); //Repositroy'e gidip işlemleri buradaki <T>'ye göre gerçekleştirmesini isteyeceğiz. Artık tam anlamıyla repomuz unitOf' a bağlanmış oldu.
        }
    }
}
