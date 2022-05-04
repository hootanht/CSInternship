using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using TwitchStep02.Interfaces;
using TwitchStep02.Models;

namespace TwitchStep02.Pages
{
    public class AddCustomerModel : PageModel
    {
        // ICustomerRepository _customerRepository = new CustomerRepository();
        private readonly ICustomerRepository _customerRepository;

        [BindProperty]
        public Customer Customer { get; set; }

        public AddCustomerModel(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _customerRepository.Add(Customer);
            _customerRepository.Save();

            return RedirectToPage("/Index");
        }
    }
}
