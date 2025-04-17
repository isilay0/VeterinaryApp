using VeterinaryApp.WebApi.Model;

namespace VeterinaryApp.WebApi.Business.Abstractions
{
    public interface IClinicService
    {
        Task<IEnumerable<Clinic>> GetAll();
        Task Add(Clinic clinic);
        Task Update(Clinic clinic);
        Task Delete(int id);
        Task<Clinic> GetById(int id);
    }
}
