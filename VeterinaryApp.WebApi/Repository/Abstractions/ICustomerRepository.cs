using VeterinaryApp.WebApi.Model;

namespace VeterinaryApp.WebApi.Repository.Abstractions
{
    public interface ICustomerRepository
    {
        Task<IEnumerable<Customer>> GetAll();
        Task Add(Customer customer);
        Task Update(Customer customer);
        Task Delete(int id);
        Task<Customer> GetById(int id);
        

    }
}
