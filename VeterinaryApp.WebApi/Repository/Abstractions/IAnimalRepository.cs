using VeterinaryApp.WebApi.Model;
namespace VeterinaryApp.WebApi.Repository.Abstractions

{
    public interface IAnimalRepository
    {
        Task<IEnumerable<Animal>> GetAll();
        Task Add(Animal animal);
        Task Update(Animal animal);
        Task Delete(int id);
        Task<Animal> GetById(int id);
        
    }
}
