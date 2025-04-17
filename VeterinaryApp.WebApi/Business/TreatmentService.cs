using VeterinaryApp.WebApi.Business.Abstractions;
using VeterinaryApp.WebApi.Model;
using VeterinaryApp.WebApi.Repository.Abstractions;

namespace VeterinaryApp.WebApi.Business
{
    public class TreatmentService : ITreatmentService
    {
        private readonly ITreatmentRepository repository;
        private readonly ILogger<TreatmentService> logger;

        public TreatmentService(ITreatmentRepository repository, ILogger<TreatmentService> logger)
        {
            this.repository = repository;
            this.logger = logger;
        }

        public async Task Add(Treatment treatment)
        {
            await repository.Add(treatment);
        }

        public async Task Delete(int id)
        {
            await repository.Delete(id);
        }

        public async Task<IEnumerable<Treatment>> GetAll()
        {
            return await repository.GetAll();
        }

        public async Task<Treatment> GetById(int id)
        {
            return await repository.GetById(id);
        }

        public async Task Update(Treatment treatment)
        {
            await repository.Update(treatment);
        }
    }
}
