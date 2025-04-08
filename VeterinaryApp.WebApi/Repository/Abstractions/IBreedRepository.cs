using VeterinaryApp.WebApi.Model;

namespace VeterinaryApp.WebApi.Repository.Abstractions
{
    public interface IBreedRepository
    {
        Task<IEnumerable<Breed>> GetAll();
        Task Add(Breed breed);
        Task Update(Breed breed);
        Task Delete(int id);
        Task<Breed> GetById(int id);
    }
}
