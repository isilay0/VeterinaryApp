using VeterinaryApp.WebApi.Business.Abstractions;
using VeterinaryApp.WebApi.Model;
using VeterinaryApp.WebApi.Repository.Abstractions;

namespace VeterinaryApp.WebApi.Business
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository repository;
        private readonly ILogger<ProductService> logger;

        public ProductService(ILogger<ProductService> logger, IProductRepository repository)
        {
            this.logger = logger;
            this.repository = repository;
        }

        public async Task Add(Product product)
        {
            await repository.Add(product);
        }

        public async Task Delete(int id)
        {
            await repository.Delete(id);
        }

        public async Task<IEnumerable<Product>> GetAll()
        {
            return await repository.GetAll();
        }

        public async Task<Product> GetById(int id)
        {
            return await repository.GetById(id);
        }

        public async Task Update(Product product)
        {
            await repository.Update(product);
        }
    }
}
