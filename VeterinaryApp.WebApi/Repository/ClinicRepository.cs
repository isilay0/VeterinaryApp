using Microsoft.EntityFrameworkCore;
using VeterinaryApp.WebApi.Core.Exceptions;
using VeterinaryApp.WebApi.Model;
using VeterinaryApp.WebApi.Repository.Abstractions;

namespace VeterinaryApp.WebApi.Repository
{
    public class ClinicRepository : IClinicRepository
    {
        private readonly AppDbContext context;
        private readonly ILogger<ClinicRepository> logger;

        public ClinicRepository(AppDbContext context, ILogger<ClinicRepository> logger)
        {
            this.context = context;
            this.logger = logger;
        }

        public async Task Add(Clinic clinic)
        {
            context.Clinics.Add(clinic);
            await context.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            Clinic clinic = await context.Clinics.FindAsync(id) ?? throw new EntityNotFoundException("Silinmek İstenen Klinik Bulunamadı.");
            context.Clinics.Remove(clinic);
            await context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Clinic>> GetAll()
        {
            return await context.Clinics.ToListAsync();
        }

        public async Task<Clinic> GetById(int id)
        {
            return await context.Clinics.FindAsync(id) ?? throw new EntityNotFoundException("Aranan Klinik Bulunamadı.");
        }

        public async Task Update(Clinic clinic)
        {
            bool exists = await context.Clinics.AnyAsync(x => x.Id == clinic.Id);
            if (!exists)
            {
                throw new EntityNotFoundException("Aranan Klinik Bulunamadı.");
            }
            context.Clinics.Update(clinic);
            await context.SaveChangesAsync();
        }
    }
}
