using VeterinaryApp.WebApi.Model;

namespace VeterinaryApp.WebApi.Repository.Abstractions
{
    public interface ITreatmentRepository
    {
        Task<IEnumerable<Treatment>> GetAll();
        Task Add(Treatment treatment);
        Task Update(Treatment treatment);
        Task Delete(int id);
        Task<Treatment> GetById(int id);
    }
}
