using Microsoft.EntityFrameworkCore;
using VeterinaryApp.WebApi.Core.Exceptions;
using VeterinaryApp.WebApi.Model;
using VeterinaryApp.WebApi.Repository.Abstractions;

namespace VeterinaryApp.WebApi.Repository
{
    public class DoctorRepository : IDoctorRepository
    {
        private readonly AppDbContext context;
        private readonly ILogger<DoctorRepository> logger;

        public DoctorRepository(AppDbContext context, ILogger<DoctorRepository> logger)
        {
            this.context = context;
            this.logger = logger;
        }

        public async Task<Doctor> Add(Doctor doctor)
        {
            var newDoctor = context.Doctors.Add(doctor);
            await context.SaveChangesAsync();
            return newDoctor.Entity;
        }

        public async Task Delete(int id)
        {
            Doctor doctor = await context.Doctors.FindAsync(id) ?? throw new EntityNotFoundException("Silinmek İstenen Doktor Bulunamadı.");
            context.Doctors.Remove(doctor);
            await context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Doctor>> GetAll()
        {
            return await context.Doctors.ToListAsync();
        }

        public async Task<Doctor> GetById(int id)
        {
            return await context.Doctors.FindAsync(id) ?? throw new EntityNotFoundException("Aranan Doktor Bulunamadı.");
        }
        public async Task<Doctor?> GetByEmail(string email)
        {
            return await context.Doctors.FirstOrDefaultAsync(x => x.Email == email);
        }

        public async Task Update(Doctor doctor)
        {
            bool exists = await context.Doctors.AnyAsync(x => x.Id == doctor.Id);
            if (!exists)
            {
                throw new EntityNotFoundException("Aranan Doktor Bulunamadı.");
            }
            context.Doctors.Update(doctor);
            await context.SaveChangesAsync();
        }
    }
}
