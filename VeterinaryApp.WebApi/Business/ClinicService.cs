using VeterinaryApp.WebApi.Business.Abstractions;
using VeterinaryApp.WebApi.Model;
using VeterinaryApp.WebApi.Repository.Abstractions;

namespace VeterinaryApp.WebApi.Business
{
    public class ClinicService : IClinicService
    {
        private readonly IClinicRepository repository;
        private readonly ILogger<ClinicService> logger;

        public ClinicService(IClinicRepository repository, ILogger<ClinicService> logger)
        {
            this.repository = repository;
            this.logger = logger;
        }

        public async Task Add(Clinic clinic)
        {
            await repository.Add(clinic);
        }

        public async Task Delete(int id)
        {
            await repository.Delete(id);
        }

        public async Task<IEnumerable<Clinic>> GetAll()
        {
            return await repository.GetAll();
        }

        public async Task<Clinic> GetById(int id)
        {
            return await repository.GetById(id);
        }

        public async Task Update(Clinic clinic)
        {
            await repository.Update(clinic);
        }
    }
}
