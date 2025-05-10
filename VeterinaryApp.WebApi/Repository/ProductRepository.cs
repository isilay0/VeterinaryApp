using Microsoft.EntityFrameworkCore;
using VeterinaryApp.WebApi.Core.Exceptions;
using VeterinaryApp.WebApi.Model;
using VeterinaryApp.WebApi.Repository.Abstractions;

namespace VeterinaryApp.WebApi.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly AppDbContext context;
        private readonly ILogger<ProductRepository> logger;

        public ProductRepository(AppDbContext context, ILogger<ProductRepository> logger)
        {
            this.context = context;
            this.logger = logger;
        }

        public async Task Add(Product product)
        {
            context.Products.Add(product);
            await context.SaveChangesAsync();   
        }

        public async Task Delete(int id)
        {
            Product product = await context.Products.FindAsync(id) ?? throw new EntityNotFoundException("Silinmek İstenen Ürün Bulunamadı.");
            context.Products.Remove(product);
            await context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Product>> GetAll()
        {
            return await context.Products.ToListAsync();
        }

        public async Task<Product> GetById(int id)
        {
            return await context.Products.FindAsync(id) ?? throw new EntityNotFoundException("Aranan Ürün Bulunamadı.");
        }

        public async Task<Product> SearchName(string name)
        {
            return await context.Products.FirstOrDefaultAsync(x => x.Name!.StartsWith(name)) ?? throw new EntityNotFoundException("Girilen İsimde bir hayvan bulunamadı"); 
        }

        public async Task Update(Product product)
        {
            bool exists = await context.Customers.AnyAsync(x => x.Id == product.Id);
            if(!exists)
            {
                throw new EntityNotFoundException("Aranan Ürün Bulunamadı");
            }
            context.Products.Update(product);
            await context.SaveChangesAsync();
        }
    }
}
