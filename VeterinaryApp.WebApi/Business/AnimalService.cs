using VeterinaryApp.WebApi.Business.Abstractions;
using VeterinaryApp.WebApi.Model;
using VeterinaryApp.WebApi.Repository.Abstractions;

namespace VeterinaryApp.WebApi.Business
{
    public class AnimalService : IAnimalService
    {
        private readonly IAnimalRepository repository;
        private readonly ILogger<AnimalService> logger;

        public AnimalService(IAnimalRepository repository, ILogger<AnimalService> logger)
        {
            this.repository = repository;
            this.logger = logger;
        }

        public async Task Add(Animal animal)
        {
            await repository.Add(animal);
        }

        public async Task Delete(int id)
        {
            await repository.Delete(id);
        }

        public async Task<IEnumerable<Animal>> GetAll()
        {
            return await repository.GetAll();
        }

        public async Task<Animal> GetById(int id)
        {
            return await repository.GetById(id);
        }

        public async Task Update(Animal animal)
        {
            await repository.Update(animal);
        }
    }
}
