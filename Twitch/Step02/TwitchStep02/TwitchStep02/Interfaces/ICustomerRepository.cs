using TwitchStep02.Models;

namespace TwitchStep02.Interfaces
{
    public interface ICustomerRepository
    {
        IEnumerable<Customer> GetAll();
        Customer GetById(int id);
        void Add(Customer customer);
        void Update(Customer customer);
        void Delete(int id);
        void Delete(Customer customer);
        void Save();
    }
}
