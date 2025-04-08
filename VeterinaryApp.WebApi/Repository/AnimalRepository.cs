using Microsoft.EntityFrameworkCore;
using VeterinaryApp.WebApi.Core.Exceptions;
using VeterinaryApp.WebApi.Model;
using VeterinaryApp.WebApi.Repository.Abstractions;

namespace VeterinaryApp.WebApi.Repository
{
    public class AnimalRepository : IAnimalRepository
    {
        private readonly AppDbContext context;
        private readonly ILogger<AnimalRepository> logger;

        public AnimalRepository(AppDbContext context, ILogger<AnimalRepository> logger)
        {
            this.context = context;
            this.logger = logger;
        }

        public async Task Add(Animal animal)
        {
            context.Animals.Add(animal);
            await context.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            Animal animal = await context.Animals.FindAsync(id) ?? throw new EntityNotFoundException("Silinmek İstenen Hayvan Bulunamadı.");
            context.Animals.Remove(animal);
            await context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Animal>> GetAll()
        {
            return await context.Animals.ToListAsync();

        }

        public async Task<Animal> GetById(int id)
        {
            Animal an = await context.Animals.FindAsync(id) ?? throw new EntityNotFoundException("Aranan Hayvan Bulunamadı.");
            return an;
        }

        public async Task Update(Animal animal)
        {
            bool exists = await context.Animals.AnyAsync(x => x.Id == animal.Id);
            if (!exists)
            {
                throw new EntityNotFoundException("Aranan Hayvan Bulunamadı.");
            }
            context.Animals.Update(animal);
            await context.SaveChangesAsync();
        }


    }
}
