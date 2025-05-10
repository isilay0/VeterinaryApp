using Microsoft.EntityFrameworkCore;
using VeterinaryApp.WebApi.Core.Exceptions;
using VeterinaryApp.WebApi.Model;
using VeterinaryApp.WebApi.Repository.Abstractions;

namespace VeterinaryApp.WebApi.Repository
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly AppDbContext context;
        private readonly ILogger<CustomerRepository> logger;

        public CustomerRepository(AppDbContext context, ILogger<CustomerRepository> logger)
        {
            this.context = context;
            this.logger = logger;
        }
        public async Task Add(Customer customer)
        {
            bool exists = await context.Customers.AnyAsync(x => x.PhoneNumber == customer.PhoneNumber);
            if (exists)
            {
                throw new EntityAlreadyExistsException("Telefon Numarası Zaten Kayıtlı.");
            }

            context.Customers.Add(customer);
            await context.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            Customer customer = await context.Customers.FindAsync(id) ?? throw new EntityNotFoundException("Silinmek İstenen Müşteri Bulanamadı.");
            context.Customers.Remove(customer);
            await context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Customer>> GetAll()
        {
            return await context.Customers.ToListAsync();
        }

        public async Task<Customer> GetById(int id)
        {
            return await context.Customers.FindAsync(id) ?? throw new EntityNotFoundException("Aranan Müşteri Bulunamadı.");
        }

        public async Task<Customer[]> SearchFullName(string fullName)
        {
            return await context.Customers.Where(u => EF.Functions.Like(u.Name + u.Surname, $"%{fullName}%", " ")).ToArrayAsync();
        }

        public async Task<Customer> SearchTckn(string tckn)
        {
            return await context.Customers.FirstOrDefaultAsync(u => u.Tckn!.StartsWith(tckn)) ?? throw new EntityNotFoundException("Girilen TCKN'ye ait müşteri bulunamadı.");
        }

        public async Task Update(Customer customer)
        {
            bool exists = await context.Customers.AnyAsync(x => x.Id == customer.Id);
            if (!exists)
            {
                throw new EntityNotFoundException("Aranan Müşteri Bulunamadı.");
            }
            context.Customers.Update(customer);
            await context.SaveChangesAsync();
        }
    }
}
