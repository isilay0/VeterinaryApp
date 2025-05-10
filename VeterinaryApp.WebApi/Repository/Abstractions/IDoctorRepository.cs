using VeterinaryApp.WebApi.Model;

namespace VeterinaryApp.WebApi.Repository.Abstractions
{
    public interface IDoctorRepository
    {
        Task<IEnumerable<Doctor>> GetAll();
        Task<Doctor> Add(Doctor doctor);
        Task Update(Doctor doctor);
        Task Delete(int id);
        Task<Doctor> GetById(int id);
        Task<Doctor?> GetByEmail(string email);
    }
}
