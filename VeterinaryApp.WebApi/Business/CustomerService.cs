using VeterinaryApp.WebApi.Business.Abstractions;
using VeterinaryApp.WebApi.Model;
using VeterinaryApp.WebApi.Repository.Abstractions;

namespace VeterinaryApp.WebApi.Business
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository repository;
        private readonly IAnimalRepository animalRepository;
        private readonly ILogger<CustomerService> logger;

        public CustomerService(ICustomerRepository repository, ILogger<CustomerService> logger, IAnimalRepository animalRepository)
        {
            this.repository = repository;
            this.logger = logger;
            this.animalRepository = animalRepository;
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
            Customer customer = await repository.GetById(id);
            customer.Animals = await animalRepository.GetByCustomerId(customer.Id);
            return customer;
        }

        public async Task<Customer[]> SearchFullName(string fullName)
        {
            return await repository.SearchFullName(fullName);
        }

        public async Task<Customer> SearchTckn(string tckn)
        {
            Customer customer = await repository.SearchTckn(tckn);
            customer.Animals = await animalRepository.GetByCustomerId(customer.Id);
            return customer;
        }

        public async Task Update(Customer customer)
        {
            await repository.Update(customer);
        }

    }
}
