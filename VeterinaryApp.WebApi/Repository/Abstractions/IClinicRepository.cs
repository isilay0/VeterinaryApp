using VeterinaryApp.WebApi.Model;

namespace VeterinaryApp.WebApi.Repository.Abstractions
{
    public interface IClinicRepository
    {
        Task<IEnumerable<Clinic>> GetAll();
        Task Add(Clinic clinic);
        Task Update(Clinic clinic);
        Task Delete(int id);
        Task<Clinic> GetById(int id);
    }
}
