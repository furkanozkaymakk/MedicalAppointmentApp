using DataAccessLayer.UnitOfWorks;
using EntityLayer.Entities;
using ServiceLayer.Services.Abstractions;

namespace ServiceLayer.Services.Concretes
{
    public class DoctorManager : IDoctorService
    {
        private readonly IUnitOfWork unitOfWork;

        public DoctorManager(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public Task TAddAsync(Doctor entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> TAnyAsync()
        {
            throw new NotImplementedException();
        }

        public Task<int> TCountAsync()
        {
            throw new NotImplementedException();
        }

        public async Task TDeleteAsync(Doctor entity)
        {
            await unitOfWork.GetRepository<Doctor>().DeleteAsync(entity);
        }

        public async Task<List<Doctor>> TGetAllAsync()
        {
            return await unitOfWork.GetRepository<Doctor>().GetAllAsync();
        }

        public Task<Doctor> TGetAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Doctor> TGetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Doctor> TUpdateAsync(Doctor entity)
        {
            throw new NotImplementedException();
        }
    }
}
