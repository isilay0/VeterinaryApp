using VeterinaryApp.WebApi.Model;

namespace VeterinaryApp.WebApi.Business.Abstractions
{
    public interface IAnimalService
    {
        Task<IEnumerable<Animal>> GetAll();
        Task Add(Animal animal);
        Task Update(Animal animal);
        Task Delete(int id);
        Task<Animal> GetById(int id);
    }
}
