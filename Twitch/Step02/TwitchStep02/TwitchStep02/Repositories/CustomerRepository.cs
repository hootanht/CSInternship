using TwitchStep02.Data.Context;
using TwitchStep02.Interfaces;
using TwitchStep02.Models;

namespace TwitchStep02.Repositories
{
    /// <summary>
    /// This class is responsible for handling the data access for the TwitchUser model.
    /// </summary>
    public class CustomerRepository : ICustomerRepository
    {
        // This is the context that we will be using to access the database.
        private readonly Twitch02DBContext _context;

        // This is the constructor for the class. It will take in a context.
        public CustomerRepository(Twitch02DBContext context)
        {
            _context = context;
        }

        /// <summary>
        /// This method will add a new customer to the database.
        /// </summary>
        /// <param name="customer"> The customer to be added to the database. </param>
        public void Add(Customer customer)
        {
            _context.Add(customer);
        }

        /// <summary>
        /// This method will remove a customer from the database.
        /// </summary>
        /// <param name="id"> The id of the customer to be removed. </param>
        public void Delete(int id)
        {
            _context.Remove(GetById(id));
        }

        /// <summary>
        /// This method will remove a customer from the database.
        /// </summary>
        /// <param name="customer"> The customer to be removed. </param>
        public void Delete(Customer customer)
        {
            _context.Remove(customer);
        }

        /// <summary>
        /// This method will return all of the customers in the database.
        /// </summary>
        /// <returns> A list of all of the customers in the database. </returns>
        public IEnumerable<Customer>? GetAll()
        {
            return _context.Customers;
        }

        /// <summary>
        /// This method will return a customer from the database by their id.
        /// </summary>
        /// <param name="id"> The id of the customer to be returned. </param>
        /// <returns> The customer with the given id. </returns>
        public Customer? GetById(int id)
        {
            return _context.Find<Customer>(id);
        }

        /// <summary>
        /// This method will save the changes to the database.
        /// </summary>
        public void Save()
        {
            _context.SaveChanges();
        }

        /// <summary>
        /// This method will update a customer in the database.
        /// </summary>
        /// <param name="customer"> The customer to be updated. </param>
        public void Update(Customer customer)
        {
            _context.Update(customer);
        }
    }
}
