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

        public Task TDeleteAsync(Doctor entity)
        {
            throw new NotImplementedException();
        }

        public Task<List<Doctor>> TGetAllAsync()
        {
            throw new NotImplementedException();
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
