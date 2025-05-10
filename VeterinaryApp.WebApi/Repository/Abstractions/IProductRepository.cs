using VeterinaryApp.WebApi.Model;

namespace VeterinaryApp.WebApi.Repository.Abstractions
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> GetAll();
        Task Add(Product product);
        Task Update(Product product);
        Task Delete(int id);
        Task<Product> GetById(int id);
        Task<Product> SearchName (string name);
    }
}
