using Microsoft.EntityFrameworkCore;
using VeterinaryApp.WebApi.Business.Abstractions;
using VeterinaryApp.WebApi.Core.Exceptions;
using VeterinaryApp.WebApi.Model;
using VeterinaryApp.WebApi.Repository.Abstractions;

namespace VeterinaryApp.WebApi.Repository
{
    public class AppoinmentRepository : IAppoinmentRepository
    {
        private readonly AppDbContext context;
        private readonly ILogger<AppoinmentRepository> logger;

        public AppoinmentRepository(AppDbContext context, ILogger<AppoinmentRepository> logger)
        {
            this.context = context;
            this.logger = logger;
        }

        public async Task Add(Appointment appointment)
        {
            context.Appointments.Add(appointment);
            await context.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            Appointment appointment = await context.Appointments.FindAsync(id) ?? throw new EntityNotFoundException("Silinmek İstenen Randevu Bulunamadı.");
            context.Appointments.Remove(appointment);
            await context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Appointment>> GetAll()
        {
            return await context.Appointments.ToListAsync();
        }

        public async Task<Appointment> GetById(int id)
        {
            return await context.Appointments.FindAsync(id) ?? throw new EntityNotFoundException("Aranan Randevu Bulunamadı.");
        }

        public async Task Update(Appointment appointment)
        {
            bool exists = await context.Appointments.AnyAsync(x => x.Id == appointment.Id);
            if (!exists)
            {
                throw new EntityNotFoundException("Aranan Randevu Bulunamadı.");
            }
            context.Appointments.Update(appointment);
            await context.SaveChangesAsync();
        }
    }
}
