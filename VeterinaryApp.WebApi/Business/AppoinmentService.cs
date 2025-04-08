using VeterinaryApp.WebApi.Business.Abstractions;
using VeterinaryApp.WebApi.Model;
using VeterinaryApp.WebApi.Repository.Abstractions;

namespace VeterinaryApp.WebApi.Business
{
    public class AppoinmentService : IAppoinmentService
    {
        private readonly IAppoinmentRepository repository;
        private readonly ILogger<AppoinmentService> logger;

        public AppoinmentService(IAppoinmentRepository repository, ILogger<AppoinmentService> logger)
        {
            this.repository = repository;
            this.logger = logger;
        }

        public async Task Add(Appointment appointment)
        {
            await repository.Add(appointment);
        }

        public async Task Delete(int id)
        {
            await repository.Delete(id);
        }

        public async Task<IEnumerable<Appointment>> GetAll()
        {
            return await repository.GetAll();
        }

        public async Task<Appointment> GetById(int id)
        {
            return await repository.GetById(id);
        }

        public async Task Update(Appointment appointment)
        {
            await repository.Update(appointment);
        }
    }
}
