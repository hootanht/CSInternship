using Microsoft.AspNetCore.Mvc.RazorPages;

using TwitchStep02.Interfaces;
using TwitchStep02.Models;

namespace TwitchStep02.Pages
{
    public class CustomersModel : PageModel
    {
        private readonly ICustomerRepository _customerRepository;

        public CustomersModel(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public IEnumerable<Customer> Customers { get; set; }

        public void OnGet()
        {
            Customers = _customerRepository.GetAll();
        }
    }
}
