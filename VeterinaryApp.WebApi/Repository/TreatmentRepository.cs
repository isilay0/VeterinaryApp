using Microsoft.EntityFrameworkCore;
using VeterinaryApp.WebApi.Core.Exceptions;
using VeterinaryApp.WebApi.Model;
using VeterinaryApp.WebApi.Repository.Abstractions;

namespace VeterinaryApp.WebApi.Repository
{
    public class TreatmentRepository : ITreatmentRepository
    {
        private readonly AppDbContext context;
        private readonly ILogger<TreatmentRepository> logger;

        public TreatmentRepository(AppDbContext context, ILogger<TreatmentRepository> logger)
        {
            this.context = context;
            this.logger = logger;
        }

        public async Task Add(Treatment treatment)
        {
            context.Treatments.Add(treatment);
            await context.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            Treatment treatment = await context.Treatments.FindAsync(id) ?? throw new EntityNotFoundException("Silinmek İstenen Tedavi Bulunamadı.");
            context.Treatments.Remove(treatment);
            context.SaveChanges();
        }

        public async Task<IEnumerable<Treatment>> GetAll()
        {
            return await context.Treatments.ToListAsync();
        }

        public async Task<Treatment> GetById(int id)
        {
            return await context.Treatments.FindAsync(id) ?? throw new EntityNotFoundException("Aranan Tedavi Bulunamadı.");
        }

        public async Task Update(Treatment treatment)
        {
            bool exists = await context.Treatments.AnyAsync(x => x.Id == treatment.Id);
            if (exists)
            {
                throw new EntityNotFoundException("Aranan Tedavi Bulunamadı.");
            }
                context.Treatments.Update(treatment);
                await context.SaveChangesAsync();
        }
    }
}
