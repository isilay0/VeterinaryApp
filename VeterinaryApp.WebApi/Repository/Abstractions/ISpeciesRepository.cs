using VeterinaryApp.WebApi.Model;

namespace VeterinaryApp.WebApi.Repository.Abstractions
{
    public interface ISpeciesRepository
    {
        Task<IEnumerable<Species>> GetAll();
        Task Add(Species species);
        Task Update(Species species);
        Task Delete(int id);
        Task<Species> GetById(int id);
    }
}
