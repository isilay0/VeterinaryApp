using VeterinaryApp.WebApi.Model;

namespace VeterinaryApp.WebApi.Business.Abstractions
{
    public interface ISpeciesService
    {
        Task<IEnumerable<Species>> GetAll();
        Task Add(Species species);
        Task Update(Species species);
        Task Delete(int id);
        Task<Species> GetById(int id);
    }
}
