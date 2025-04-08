using VeterinaryApp.WebApi.Model;

namespace VeterinaryApp.WebApi.Repository.Abstractions
{
    public interface IAppoinmentRepository
    {
        Task<IEnumerable<Appointment>> GetAll();
        Task Add(Appointment appointment);
        Task Update(Appointment appointment);
        Task Delete(int id);
        Task<Appointment> GetById(int id);
    }
}
