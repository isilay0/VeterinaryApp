using VeterinaryApp.WebApi.Model;

namespace VeterinaryApp.WebApi.Business.Abstractions
{
    public interface ICustomerService
    {
        Task<IEnumerable<Customer>> GetAll();
        Task Add(Customer customer);
        Task Update(Customer customer);
        Task Delete(int id);
        Task<Customer> GetById(int id);
    }
}
