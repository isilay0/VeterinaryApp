using VeterinaryApp.WebApi.Model;

namespace VeterinaryApp.WebApi.Business.Abstractions
{
    public interface IProductService
    {
        Task<IEnumerable<Product>> GetAll();
        Task Add(Product product);
        Task Update(Product product);
        Task Delete(int id);
        Task<Product> GetById(int id);
        Task<Product> SearchName (string name);
    }
}
