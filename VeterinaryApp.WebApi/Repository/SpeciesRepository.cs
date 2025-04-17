using Microsoft.EntityFrameworkCore;
using VeterinaryApp.WebApi.Core.Exceptions;
using VeterinaryApp.WebApi.Model;
using VeterinaryApp.WebApi.Repository.Abstractions;

namespace VeterinaryApp.WebApi.Repository
{
    public class SpeciesRepository : ISpeciesRepository
    {
        private readonly AppDbContext context;
        private readonly ILogger<SpeciesRepository> logger;

        public SpeciesRepository(AppDbContext context, ILogger<SpeciesRepository> logger)
        {
            this.context = context;
            this.logger = logger;
        }

        public async Task Add(Species species)
        {
            context.Species.Add(species);
            await context.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            Species species = await context.Species.FindAsync(id) ?? throw new EntityNotFoundException("Silinmek İstenen Tür Bulunamadı.");
            context.Species.Remove(species);
            await context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Species>> GetAll()
        {
            return await context.Species.ToListAsync();
        }

        public async Task<Species> GetById(int id)
        {
            Species species = await context.Species.FindAsync(id) ?? throw new EntityNotFoundException("Aranan Tür Bulunamadı.");
            return species;
        }

        public async Task Update(Species species)
        {
            bool exists = await context.Species.AnyAsync(x => x.Id == species.Id);
            if (!exists)
            {
                throw new EntityNotFoundException("Aranan Tür Bulunamadı.");
            }
            context.Species.Add(species);
            await context.SaveChangesAsync();
        }
    }
}
