using Microsoft.EntityFrameworkCore;
using VeterinaryApp.WebApi.Core.Exceptions;
using VeterinaryApp.WebApi.Model;
using VeterinaryApp.WebApi.Repository.Abstractions;

namespace VeterinaryApp.WebApi.Repository
{
    public class BreedRepository : IBreedRepository
    {
        private readonly AppDbContext context;
        private readonly ILogger<BreedRepository> logger;

        public BreedRepository(AppDbContext context, ILogger<BreedRepository> logger)
        {
            this.context = context;
            this.logger = logger;
        }

        public async Task Add(Breed breed)
        {
            context.Breeds.Add(breed);
            await context.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            Breed breed = await context.Breeds.FindAsync(id) ?? throw new EntityNotFoundException("Silinmek İstenen Cins Bulunamadı.");
            context.Breeds.Remove(breed);
            await context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Breed>> GetAll()
        {
            return await context.Breeds.ToListAsync();
        }

        public List<Breed> GetBreedBySpeciesId(int speciesId)
        {
            return context.Breeds
            .Where(b => b.SpeciesId == speciesId)
            .ToList();
        }

        public async Task<Breed> GetById(int id)
        {
            return await context.Breeds.FindAsync(id) ?? throw new EntityNotFoundException("Aranan Cins Bulunamadı.");
        }

        public async Task Update(Breed breed)
        {
            bool exists = await context.Breeds.AnyAsync(x => x.Id == breed.Id);
            if (!exists)
            {
                throw new EntityNotFoundException("Aranan Cins Bulunamadı.");
            }
            context.Breeds.Update(breed);
            await context.SaveChangesAsync();
        }
    }
}
