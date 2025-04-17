using VeterinaryApp.WebApi.Model;

namespace VeterinaryApp.WebApi.Business.Abstractions
{
    public interface IAppoinmentService
    {
        Task<IEnumerable<Appointment>> GetAll();
        Task Add(Appointment appointment);
        Task Update(Appointment appointment);
        Task Delete(int id);
        Task<Appointment> GetById(int id);
    }
}
