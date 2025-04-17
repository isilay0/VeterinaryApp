using VeterinaryApp.WebApi.Model;

namespace VeterinaryApp.WebApi.Business.Abstractions
{
    public interface IBreedService
    {
        Task<IEnumerable<Breed>> GetAll();
        Task Add(Breed breed);
        Task Update(Breed breed);
        Task Delete(int id);
        Task<Breed> GetById(int id);
    }
}
