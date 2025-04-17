using VeterinaryApp.WebApi.Model;

namespace VeterinaryApp.WebApi.Business.Abstractions
{
    public interface IDoctorService
    {
        Task<IEnumerable<Doctor>> GetAll();
        Task Add(Doctor doctor);
        Task Update(Doctor doctor);
        Task Delete(int id);
        Task<Doctor> GetById(int id);
    }
}
