using VeterinaryApp.WebApi.Model;

namespace VeterinaryApp.WebApi.Business.Abstractions
{
    public interface ITreatmentService
    {
        Task<IEnumerable<Treatment>> GetAll();
        Task Add(Treatment treatment);
        Task Update(Treatment treatment);
        Task Delete(int id);
        Task<Treatment> GetById(int id);
    }
}
