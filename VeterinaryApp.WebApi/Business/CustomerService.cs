using VeterinaryApp.WebApi.Business.Abstractions;
using VeterinaryApp.WebApi.Model;
using VeterinaryApp.WebApi.Repository.Abstractions;

namespace VeterinaryApp.WebApi.Business
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository repository;
        private readonly ILogger<CustomerService> logger;

        public CustomerService(ICustomerRepository repository, ILogger<CustomerService> logger)
        {
            this.repository = repository;
            this.logger = logger;
        }

        public async Task Add(Customer customer)
        {
            await repository.Add(customer);
        }

        public async Task Delete(int id)
        {
            await repository.Delete(id);
        }

        public async Task<IEnumerable<Customer>> GetAll()
        {
            return await repository.GetAll();
        }

        public async Task<Customer> GetById(int id)
        {
            return await repository.GetById(id);
        }

        public async Task Update(Customer customer)
        {
            await repository.Update(customer);
        }
    }
}
