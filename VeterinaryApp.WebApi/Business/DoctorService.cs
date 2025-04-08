using VeterinaryApp.WebApi.Business.Abstractions;
using VeterinaryApp.WebApi.Model;
using VeterinaryApp.WebApi.Repository.Abstractions;

namespace VeterinaryApp.WebApi.Business
{
    public class DoctorService : IDoctorService
    {
        private readonly IDoctorRepository repository;
        private readonly ILogger<DoctorService> logger;

        public DoctorService(IDoctorRepository repository, ILogger<DoctorService> logger)
        {
            this.repository = repository;
            this.logger = logger;
        }

        public async Task Add(Doctor doctor)
        {
            await repository.Add(doctor);
        }

        public async Task Delete(int id)
        {
            await repository.Delete(id);
        }

        public async Task<IEnumerable<Doctor>> GetAll()
        {
            return await repository.GetAll();
        }

        public async Task<Doctor> GetById(int id)
        {
            return await repository.GetById(id);
        }

        public async Task Update(Doctor doctor)
        {
            await repository.Update(doctor);
        }
    }
}
