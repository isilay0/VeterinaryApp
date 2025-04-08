using System.Runtime.InteropServices;
using VeterinaryApp.WebApi.Business.Abstractions;
using VeterinaryApp.WebApi.Model;
using VeterinaryApp.WebApi.Repository.Abstractions;

namespace VeterinaryApp.WebApi.Business
{
    public class BreedService : IBreedService
    {
        private readonly IBreedRepository repository;
        private readonly ILogger<BreedService> logger;

        public BreedService(IBreedRepository repository, ILogger<BreedService> logger)
        {
            this.repository = repository;
            this.logger = logger;
        }

        public async Task Add(Breed breed)
        {
            await repository.Add(breed);
        }

        public async Task Delete(int id)
        {
            await repository.Delete(id);
        }

        public async Task<IEnumerable<Breed>> GetAll()
        {
            return await repository.GetAll();
        }

        public async Task<Breed> GetById(int id)
        {
            return await repository.GetById(id);
        }

        public async Task Update(Breed breed)
        {
            await repository.Update(breed);
        }
    }
}
