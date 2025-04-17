using VeterinaryApp.WebApi.Business.Abstractions;
using VeterinaryApp.WebApi.Model;
using VeterinaryApp.WebApi.Repository.Abstractions;

namespace VeterinaryApp.WebApi.Business
{
    public class SpeciesService : ISpeciesService
    {
        private readonly ISpeciesRepository repository;
        private readonly ILogger<SpeciesService> logger;

        public SpeciesService(ISpeciesRepository repository, ILogger<SpeciesService> logger)
        {
            this.repository = repository;
            this.logger = logger;
        }

        public async Task Add(Species species)
        {
            await repository.Add(species);
        }

        public async Task Delete(int id)
        {
            await repository.Delete(id);
        }

        public async Task<IEnumerable<Species>> GetAll()
        {
            return await repository.GetAll();
        }

        public async Task<Species> GetById(int id)
        {
            return await repository.GetById(id);
        }

        public async Task Update(Species species)
        {
            await repository.Update(species);
        }
    }
}
